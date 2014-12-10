using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Messaging;
using System.IO;
using System.Xml.Serialization;
using System.Threading;
using log4net;

[assembly: log4net.Config.XmlConfigurator(Watch = true)]  
namespace MSMQ.Email
{
    public class QueueProcessor : IDisposable
    {
        /*    注意事项：
        *    1. 发送和接受消息的电脑都要安装MSMQ。
        *    2. 在工作组模式下不能访问public队列。
        *    3. 访问本地队列和远程队列，path字符串格式不太一样。
        *    4. public队列存在于消息网络中所有主机的消息队列中。
        *    5. private队列则只存在于创建队列的那台主机上。
        */
        private MessageQueue queue = null;           
        ManualResetEvent reset = null;
        ILog logger = null;
        private string _path = string.Empty;

        public QueueProcessor(string QueuePath)
        {
            //访问本地电脑上的消息队列时Path的格式可以有如下几种：
            //MessageQueue mq = new MessageQueue();
            //mq.Path = @".\Private$\test";
            //mq.Path = @"sf00902395d34\Private$\test";  //sf00902395d34是主机名
            //mq.Path = @"FormatName:DIRECT=OS:sf00902395d34\Private$\test";
            //mq.Path = @"FormatName:DIRECT=OS:localhost\Private$\test";

            //访问远程电脑上的消息队列时Path的格式
            //mq.Path = @"FormatName:DIRECT=OS:server\Private$\test";            

            reset = new ManualResetEvent(true);
            logger = LogManager.GetLogger("logger");

            _path = QueuePath;

            //判断指定的消息队列是否存在
            if (MessageQueue.Exists(QueuePath))
            {
                queue = new MessageQueue(QueuePath);
                logger.Info(string.Format("Init : {0} successfully!", QueuePath));
            }
            else
            {
                //不存在，创建
                queue = MessageQueue.Create(QueuePath);                
                //赋予权限
                queue.SetPermissions("Everyone", MessageQueueAccessRights.FullControl, AccessControlEntryType.Set);

                logger.Info(string.Format("Create message queue : {0} successfully!", QueuePath));
            }
        }

        public void Start()
        {
            try
            {
                queue.Formatter = new BinaryMessageFormatter();
                queue.MessageReadPropertyFilter.SetAll();
                queue.ReceiveCompleted += queue_ReceiveCompleted;
                queue.BeginReceive();

                logger.Info(string.Format("{0} : Start receive message!", _path));
            }
            catch (Exception ex)
            {                
                logger.Error("Error", ex);
                Stop();
            }
        }

        void queue_ReceiveCompleted(object sender, ReceiveCompletedEventArgs e)
        {
            var mq = sender as MessageQueue;
            if (mq != null)
            {
                reset.WaitOne();

                EmailEntity entity = null;
                try
                {
                    var msg = mq.EndReceive(e.AsyncResult);
                    entity = msg.Body as EmailEntity;
                    if (entity != null)
                    {
                        var svc = new EmailService();
                        svc.SendMessage(entity);
                        string strXml = Serializer(entity);
                        logger.Info("Send Message \r\n" + strXml);
                    }
                    else
                    {
                        logger.InfoFormat("{0} : Email is null.", _path);                        
                    }
                }
                catch (Exception ex)
                {
                    string strXml = Serializer(entity);                    
                    logger.Error(strXml, ex);
                }
                finally
                {
                    if (mq != null)
                    {
                        //继续接收下一条信息
                        mq.BeginReceive();
                    }
                }
            }
        }

        private string Serializer(EmailEntity entity)
        {
            string strXml = string.Empty;
            using (MemoryStream ms = new MemoryStream())
            {
                
                XmlSerializer xs = new XmlSerializer(typeof(EmailEntity));
                xs.Serialize(ms, entity);
                strXml = Encoding.UTF8.GetString(ms.ToArray());                
            }

            return strXml;
        }

        public void Stop()
        {
            reset.Close();
            reset.Dispose();

            if (queue != null)
            {
                try
                {
                    logger.InfoFormat("{0} : Stop receive message!", _path);
                    queue.Close();
                    queue.Dispose();
                    queue = null;
                }
                catch (Exception ex)
                {
                    logger.Error("Error", ex);
                }
            }
        }

        public void Pause()
        {
            reset.Reset();
            logger.InfoFormat("{0} : Pause receive message!", _path);
        }

        public void Continue()
        {
            reset.Set();
            logger.InfoFormat("{0} : Continue receive message!", _path);
        }


        public void Dispose()
        {
            Stop();            
        }
    }
}
