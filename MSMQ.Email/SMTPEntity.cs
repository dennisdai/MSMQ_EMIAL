using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSMQ.Email
{
    [Serializable]
    public class SMTPEntity
    {
        public SMTPEntity()
        {
            if (this.Port == 0) {
                Port = 25;
            }
        }

        /// <summary>
        /// <para>User name</para>
        /// <para>登录账号</para>
        /// </summary>
        public string UserName { get; set; }
        /// <summary>
        /// <para>Password</para>
        /// <para>登录密码</para>
        /// </summary>
        public string Password { get; set; }
        /// <summary>
        /// <para>SMTP address</para>
        /// <para>发送邮件的服务器</para>
        /// </summary>
        public string SMTP { get; set; }
        /// <summary>
        /// <para>port</para>
        /// <para>端口： 一般是25</para>
        /// </summary>
        public int Port { get; set; }

        /// <summary>
        /// <para>enable ssl</para>
        /// <para>是否开启SSL</para>
        /// </summary>
        public bool EnableSSL { get; set; }
    }
}
