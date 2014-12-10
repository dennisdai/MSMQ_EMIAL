namespace MSMQ.WinTest
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnStart = new System.Windows.Forms.Button();
            this.btnSendEmail = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblFramework = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnSelect64 = new System.Windows.Forms.Button();
            this.txtPath64 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnUnInstall = new System.Windows.Forms.Button();
            this.btnInstall = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnContinue = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnStartService = new System.Windows.Forms.Button();
            this.btnStopService = new System.Windows.Forms.Button();
            this.txtSvcName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(337, 193);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(171, 23);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "Start Send";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnSendEmail
            // 
            this.btnSendEmail.Location = new System.Drawing.Point(337, 263);
            this.btnSendEmail.Name = "btnSendEmail";
            this.btnSendEmail.Size = new System.Drawing.Size(358, 23);
            this.btnSendEmail.TabIndex = 1;
            this.btnSendEmail.Text = "Init Email";
            this.btnSendEmail.UseVisualStyleBackColor = true;
            this.btnSendEmail.Click += new System.EventHandler(this.btnSendEmail_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblFramework);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(313, 276);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "64 bit .Net Framework Version List ";
            // 
            // lblFramework
            // 
            this.lblFramework.AutoSize = true;
            this.lblFramework.Location = new System.Drawing.Point(55, 20);
            this.lblFramework.Name = "lblFramework";
            this.lblFramework.Size = new System.Drawing.Size(0, 13);
            this.lblFramework.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtSvcName);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.btnStopService);
            this.groupBox4.Controls.Add(this.btnStartService);
            this.groupBox4.Controls.Add(this.btnSelect64);
            this.groupBox4.Controls.Add(this.txtPath64);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.btnUnInstall);
            this.groupBox4.Controls.Add(this.btnInstall);
            this.groupBox4.Location = new System.Drawing.Point(337, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(358, 168);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Install Windows Service";
            // 
            // btnSelect64
            // 
            this.btnSelect64.Location = new System.Drawing.Point(248, 64);
            this.btnSelect64.Name = "btnSelect64";
            this.btnSelect64.Size = new System.Drawing.Size(100, 23);
            this.btnSelect64.TabIndex = 17;
            this.btnSelect64.Text = "Select EXE File";
            this.btnSelect64.UseVisualStyleBackColor = true;
            this.btnSelect64.Click += new System.EventHandler(this.btnSelect64_Click);
            // 
            // txtPath64
            // 
            this.txtPath64.Location = new System.Drawing.Point(87, 27);
            this.txtPath64.Name = "txtPath64";
            this.txtPath64.Size = new System.Drawing.Size(262, 20);
            this.txtPath64.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "EXE File Path :";
            // 
            // btnUnInstall
            // 
            this.btnUnInstall.Location = new System.Drawing.Point(128, 64);
            this.btnUnInstall.Name = "btnUnInstall";
            this.btnUnInstall.Size = new System.Drawing.Size(100, 23);
            this.btnUnInstall.TabIndex = 14;
            this.btnUnInstall.Text = "UnInstall Service";
            this.btnUnInstall.UseVisualStyleBackColor = true;
            this.btnUnInstall.Click += new System.EventHandler(this.btnUnInstall_Click);
            // 
            // btnInstall
            // 
            this.btnInstall.Location = new System.Drawing.Point(10, 64);
            this.btnInstall.Name = "btnInstall";
            this.btnInstall.Size = new System.Drawing.Size(93, 23);
            this.btnInstall.TabIndex = 13;
            this.btnInstall.Text = "Install Service";
            this.btnInstall.UseVisualStyleBackColor = true;
            this.btnInstall.Click += new System.EventHandler(this.btnInstall_Click);
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(337, 227);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(171, 23);
            this.btnPause.TabIndex = 11;
            this.btnPause.Text = "Pause Send";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnContinue
            // 
            this.btnContinue.Location = new System.Drawing.Point(524, 227);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(171, 23);
            this.btnContinue.TabIndex = 12;
            this.btnContinue.Text = "Continue Send";
            this.btnContinue.UseVisualStyleBackColor = true;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(524, 193);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(171, 23);
            this.btnStop.TabIndex = 13;
            this.btnStop.Text = "Stop Send";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnStartService
            // 
            this.btnStartService.Location = new System.Drawing.Point(256, 135);
            this.btnStartService.Name = "btnStartService";
            this.btnStartService.Size = new System.Drawing.Size(93, 23);
            this.btnStartService.TabIndex = 18;
            this.btnStartService.Text = "Start Service";
            this.btnStartService.UseVisualStyleBackColor = true;
            this.btnStartService.Click += new System.EventHandler(this.btnStartService_Click);
            // 
            // btnStopService
            // 
            this.btnStopService.Location = new System.Drawing.Point(128, 135);
            this.btnStopService.Name = "btnStopService";
            this.btnStopService.Size = new System.Drawing.Size(100, 23);
            this.btnStopService.TabIndex = 19;
            this.btnStopService.Text = "Stop Service";
            this.btnStopService.UseVisualStyleBackColor = true;
            this.btnStopService.Click += new System.EventHandler(this.btnStopService_Click);
            // 
            // txtSvcName
            // 
            this.txtSvcName.Location = new System.Drawing.Point(90, 102);
            this.txtSvcName.Name = "txtSvcName";
            this.txtSvcName.Size = new System.Drawing.Size(262, 20);
            this.txtSvcName.TabIndex = 21;
            this.txtSvcName.Text = "EmailQueueProcessor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Service Name :";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 300);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnContinue);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnSendEmail);
            this.Controls.Add(this.btnStart);
            this.Name = "FrmMain";
            this.Text = "Test Queue Email";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnSendEmail;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblFramework;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnSelect64;
        private System.Windows.Forms.TextBox txtPath64;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnUnInstall;
        private System.Windows.Forms.Button btnInstall;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnStopService;
        private System.Windows.Forms.Button btnStartService;
        private System.Windows.Forms.TextBox txtSvcName;
        private System.Windows.Forms.Label label1;
    }
}

