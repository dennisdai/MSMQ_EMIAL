using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using log4net;
using MSMQ.Email;

[assembly: log4net.Config.XmlConfigurator(Watch = true)]
namespace MSMQ.Processor
{
    public partial class EmailQueueProcessor : ServiceBase
    {
        List<QueueProcessor> list = new List<QueueProcessor>();
        ILog logger = null;
        public EmailQueueProcessor()
        {
            InitializeComponent();

            InitService();
        }

        private void InitService()
        {
            base.AutoLog = true;
            base.CanShutdown = true;
            base.CanStop = true;
            base.CanPauseAndContinue = true;
            base.ServiceName = "EmailQueueProcessor";  //这个名字很重要，设置不一致会产生 1083 错误哦！

            logger = LogManager.GetLogger("logger");
        }

        protected override void OnStart(string[] args)
        {
            string paths = System.Configuration.ConfigurationManager.AppSettings["paths"];
            var arr = paths.Split('|');
            foreach (var item in arr)
            {
                var qp = new QueueProcessor(item);
                qp.Start();

                list.Add(qp);
            }


        }

        protected override void OnStop()
        {
            foreach (var item in list)
            {
                if (item != null)
                {
                    item.Stop();
                }
            }
        }

        protected override void OnContinue()
        {
            foreach (var item in list)
            {
                if (item != null)
                {
                    item.Continue();
                }
            }
        }

        protected override void OnPause()
        {
            foreach (var item in list)
            {
                if (item != null)
                {
                    item.Pause();
                }
            }           
        }
    }
}
