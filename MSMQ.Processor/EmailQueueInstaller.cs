using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Install;
using System.Linq;
using System.Threading.Tasks;

namespace MSMQ.Processor
{
    [RunInstaller(true)]
    public partial class EmailQueueInstaller : System.Configuration.Install.Installer
    {
        public EmailQueueInstaller()
        {
            InitializeComponent();
        }
    }
}
