using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSMQ.Email
{
    [Serializable]
    public class EmailEntity
    {       
        public EmailEntity()
        {
            if (EmailTo == null)
                EmailTo = new List<string>();

            if (EmailCc == null)
                EmailCc = new List<string>();

            if (EmailBcc == null)
                EmailBcc = new List<string>();

            if (AttachementPaths == null)
                AttachementPaths = new List<string>();            
        }

        /// <summary>
        /// <para>The subject of email</para>
        /// <para>邮件主题</para>
        /// </summary>
        public string Subject { get; set; }
        /// <summary>
        /// <para>Where is from which email</para>
        /// <para>发送者邮箱</para>
        /// </summary>
        public string From { get; set; }
        /// <summary>
        /// <para>Display friendly name for From.</para>
        /// <para>发件者的友好显示，不以发送者邮箱显示</para>
        /// </summary>
        public string FriendlyName { get; set; }
        /// <summary>
        /// <para>To list</para>
        /// <para>发送给谁的邮箱地址集合</para>
        /// </summary>
        public List<string> EmailTo { get; private set; }
        /// <summary>
        /// <para>Cc list</para>
        /// <para>抄送给谁的邮箱地址集合</para>
        /// </summary>
        public List<string> EmailCc { get; private set; }
        /// <summary>
        /// <para>Bcc list </para>
        /// <para>密送给谁的邮箱地址集合</para>
        /// </summary>
        public List<string> EmailBcc { get; private set; }
        /// <summary>
        /// <para>attached files paths</para>
        /// <para>附件在电脑中的地址集合</para>
        /// </summary>
        public List<string> AttachementPaths { get; private set; }
        /// <summary>
        /// <para>message body</para>
        /// <para>发送的主体信息</para>
        /// </summary>
        public string Message { get; set; }
        /// <summary>
        /// <para>if true sending email by bcc (including EmailTo, EmailCc), if false just for EmailBcc</para>
        /// <para>True 对所有地址进行密送，包括发送地址，抄送地址。False 只对EmailBcc密送</para>
        /// </summary>
        public bool IsBccAll { get; set; }
        /// <summary>
        /// <para>SMTP information</para>
        /// <para>邮箱发送服务器信息</para>
        /// </summary>
        public SMTPEntity SMTP { get; set; }
    }
}
