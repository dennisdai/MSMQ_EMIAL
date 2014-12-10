using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using log4net;
using MSMQ.Email;

namespace MSMQ.WinTest
{
    public partial class FrmMain : Form
    {
        static string InstallUtilPath = string.Empty;
        static string FrameworkPath = string.Empty;
        static string LastVersion = string.Empty;
        static string[] paths = null;

        List<QueueProcessor> list = new List<QueueProcessor>();

        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
           
            

            string Frwk64 = "Framework64";
            string Frwk32 = "Framework";

            DirectoryInfo info = new DirectoryInfo(Environment.SystemDirectory + @"..\..\Microsoft.NET");
            if (Environment.Is64BitOperatingSystem)
            {
                FrameworkPath = info.FullName + @"\" + Frwk64;
            }
            else
            {
                FrameworkPath = info.FullName + @"\" + Frwk32;
            }

            DirectoryInfo[] dirInfo = new DirectoryInfo(FrameworkPath).GetDirectories("v?.?.*");
            if (dirInfo != null && dirInfo.Length > 0)
                LastVersion = dirInfo[dirInfo.Length - 1].Name;


            StringBuilder sb = new StringBuilder();
            foreach (DirectoryInfo infos in dirInfo)
            {
                string NetVersion = infos.Name.Substring(1);
                sb.Append(".Net Framework : " + NetVersion + "\r\n");
            }

            lblFramework.Text = sb.ToString();

            paths = new string [] { 
                                 @".\private$\SCS_EMAIL_LIST",
                                 @".\private$\SRS_EMAIL_LIST"
                             };

           

           
        }

       

        private void btnSelect64_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.InitialDirectory = System.AppDomain.CurrentDomain.BaseDirectory;
            open.Filter = "Executable File (*.exe) | *.exe; | All files(*.*) | *.*";
            open.Title = "Open File";
            open.ValidateNames = true;
            open.CheckFileExists = true;
            open.CheckPathExists = true;

            if (open.ShowDialog() == DialogResult.OK)
            {
                if (open.CheckPathExists == false)
                    MessageBox.Show("The path is invalid!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else if (open.CheckFileExists == false)
                    MessageBox.Show("The file does not existed, please choose a correct File!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else if (open.ValidateNames == false)
                    MessageBox.Show("The file name is invalid!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    txtPath64.Text = open.FileName;
                }
            }
        }

        private void btnInstall_Click(object sender, EventArgs e)
        {
            string path = txtPath64.Text;
            string ext = Path.GetExtension(path);

            if (string.IsNullOrEmpty(path))
            {
                MessageBox.Show("Please enter exe file path!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (!File.Exists(path))
            {
                MessageBox.Show("The file is not exist, please choose a correct file!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (ext.ToLower() != ".exe")
            {
                MessageBox.Show("Please choose a exe file!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {

                System.Diagnostics.Process pr = new System.Diagnostics.Process();
                pr.StartInfo.CreateNoWindow = true;

                pr.StartInfo.FileName = FrameworkPath + @"\" + LastVersion + @"\InstallUtil.exe";

                pr.StartInfo.Arguments = "\"" + txtPath64.Text + "\"";
                pr.StartInfo.UseShellExecute = false;
                pr.StartInfo.RedirectStandardOutput = true;
                pr.StartInfo.RedirectStandardError = true;

                pr.Start();
                System.IO.StreamReader srMsg = pr.StandardOutput;
                System.IO.StreamReader srError = pr.StandardError;

                string RcvStr = srMsg.ReadToEnd();
                string RcvErr = string.Empty;
                if (srError != null)
                {
                    RcvErr = srError.ReadToEnd();
                }

                MessageBox.Show(RcvStr + "\r\n" + RcvErr);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUnInstall_Click(object sender, EventArgs e)
        {
            string path = txtPath64.Text;
            string ext = Path.GetExtension(path);

            if (string.IsNullOrEmpty(path))
            {
                MessageBox.Show("Please enter exe file path!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (!File.Exists(path))
            {
                MessageBox.Show("The file is not exist, please choose a correct file!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else if (ext.ToLower() != ".exe")
            {
                MessageBox.Show("Please choose a exe file!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {

                System.Diagnostics.Process pr = new System.Diagnostics.Process();
                pr.StartInfo.CreateNoWindow = true;

                pr.StartInfo.FileName = FrameworkPath + @"\" + LastVersion + @"\InstallUtil.exe";

                pr.StartInfo.Arguments = "\"" + txtPath64.Text + "\"" + " /u";
                pr.StartInfo.UseShellExecute = false;
                pr.StartInfo.RedirectStandardOutput = true;
                pr.StartInfo.RedirectStandardError = true;

                pr.Start();
                System.IO.StreamReader srMsg = pr.StandardOutput;
                System.IO.StreamReader srError = pr.StandardError;

                string RcvStr = srMsg.ReadToEnd();
                string RcvErr = string.Empty;
                if (srError != null)
                {
                    RcvErr = srError.ReadToEnd();
                }

                MessageBox.Show(RcvStr + "\r\n" + RcvErr);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


       

        
        private void btnStart_Click(object sender, EventArgs e)
        {
            list.Clear();
            foreach (var item in paths)
            {
                var model = new QueueProcessor(item);
                model.Start();
                list.Add(model);
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            foreach (var item in list)
            {
                item.Stop();
            }
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            foreach (var item in list)
            {
                item.Pause();
            }
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            foreach (var item in list)
            {
                item.Continue();
            }
        }

        private void btnSendEmail_Click(object sender, EventArgs e)
        {
            QueueService svc = new QueueService();
            foreach (var item in paths)
            {
                for (int i = 0; i < 10; i++)
                {
                    var message = new EmailEntity();
                    message.EmailTo.Add("carldai@bcsint.com");
                    message.EmailCc.Add("dc0106@126.com");
                    message.FriendlyName = "BcsWebReporter";
                    message.From = "BcsWebReporter@bcsint.com";
                    message.Message = "Hello, This is a test!";
                    message.IsBccAll = true;
                    message.SMTP = new SMTPEntity
                    {
                        EnableSSL = false,
                        Password = "bcswebreporter",
                        Port = 25,
                        SMTP = "smtp.1and1.com",
                        UserName = "BcsWebReporter@bcsint.com"
                    };
                    message.Subject = item + " Just a test " + i.ToString();

                    svc.QueueMessage(item, message);
                }
            }

            MessageBox.Show("Init finished!");
        }

        private void btnTestMonitor_Click(object sender, EventArgs e)
        {
            ILog log = LogManager.GetLogger("logger");
            log.Info("Loading");
        }

        private void btnStartService_Click(object sender, EventArgs e)
        {
            ServiceController[] sc = ServiceController.GetServices();

            var info = sc.Where(x => x.ServiceName == txtSvcName.Text).FirstOrDefault();
            if (info == null)
            {
                MessageBox.Show("Service is not be found.");
            }
            else
            {
                if (info.Status != ServiceControllerStatus.Running)
                {
                    info.Start();
                }

                MessageBox.Show("Service started.");
            }
        }

        private void btnStopService_Click(object sender, EventArgs e)
        {
            ServiceController[] sc = ServiceController.GetServices();

            var info = sc.Where(x => x.ServiceName == txtSvcName.Text).FirstOrDefault();
            if (info == null)
            {
                MessageBox.Show("Service is not be found.");
            }
            else
            {
                if (info.Status != ServiceControllerStatus.Stopped)
                {
                    info.Stop();
                }

                MessageBox.Show("Service stopped.");
            }
        }
    }

    public class Product
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public void Validate1()
        {
            if (string.IsNullOrEmpty(this.Name))
            {
                throw new Exception("please enter a name for the product");
            }
            if (string.IsNullOrEmpty(this.Description))
            {
                throw new Exception("product description is required");
            }
        }

        public void Validate2()
        {

            this.Require(x => x.Name, "please enter a name for the product");
            this.Require(x => x.Description, "product description is required");
            
        }

        public void Require(Func<Product, string> func, string message)
        {            
            if (string.IsNullOrEmpty(func(this)))
            {
                throw new Exception(message);
            }
        }
    }
}
