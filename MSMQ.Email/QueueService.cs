using System;
using System.Collections.Generic;
using System.Linq;
using System.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace MSMQ.Email
{
    public class QueueService
    {       
        /// <summary>
        /// sending email message to MSMQ
        /// </summary>
        /// <param name="QueuePath">Queue path</param>
        /// <param name="message">Email Message</param>
        public void QueueMessage(string QueuePath, EmailEntity message)
        {
            Message msg = new Message();
            msg.Body = message;
            msg.Recoverable = true;
            msg.Formatter = new BinaryMessageFormatter();
            //msg.Formatter = new XmlMessageFormatter();

            if (!MessageQueue.Exists(QueuePath))
            {
                using (MessageQueue queue = MessageQueue.Create(QueuePath))
                {
                    queue.SetPermissions("Everyone", MessageQueueAccessRights.FullControl, AccessControlEntryType.Set);
                    queue.Send(msg);
                }
            }
            else
            {
                using (MessageQueue queue = new MessageQueue(QueuePath))
                {
                    queue.Formatter = new BinaryMessageFormatter();
                    queue.Send(msg);
                }
            }
        }      
    }
}
