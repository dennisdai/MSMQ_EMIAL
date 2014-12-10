/* My Log Interface */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using log4net;

namespace Log4Ext
{
    /// <summary>
    /// The ILog interface is use by application to log messages into the log4net framework.
    /// </summary>
    public interface IMyLog : ILog
    {
        /* <summary>
           Log a message object with the log4net.Core.Level.Debug level.
           </summary>
           <param name="UserName">User Name</param>
           <param name="OperateType">Operation Type\: ("Add", "Update",
                                     "Delete")</param>
           <param name="SystemType">System Type \: Normal or Test</param>
           <param name="Browser">Browser \: IE or Firefox Or Chrome
                                 etc.</param>
           <param name="Message">Message is Which operation and
                                 operation description</param>            */
        void Debug(string UserName, string OperateType, string SystemType, string Source, object Message);
        /* <summary>
           Log a message object with the log4net.Core.Level.Debug level.
           </summary>
           <param name="UserName">User Name</param>
           <param name="OperateType">Operation Type\: ("Add", "Update",
                                     "Delete")</param>
           <param name="SystemType">System Type \: Normal or Test</param>
           <param name="Browser">Browser \: IE or Firefox Or Chrome
                                 etc.</param>
           <param name="Message">Message is Which operation and
                                 operation description</param>
           <param name="Ex">Exception object</param>                      */
        void Debug(string UserName, string OperateType, string SystemType, string Source, object Message, Exception Ex);
        /* <summary>
           Logs a message object with the log4net.Core.Level.Info level.
           </summary>
           <param name="UserName">User Name</param>
           <param name="OperateType">Operation Type\: ("Add", "Update",
                                     "Delete")</param>
           <param name="SystemType">System Type \: Normal or Test</param>
           <param name="Browser">Browser \: IE or Firefox Or Chrome
                                 etc.</param>
           <param name="Message">Message is Which operation and
                                 operation description</param>            */
        void Info(string UserName, string OperateType, string SystemType, string Source, object Message);
        /* <summary>
           Logs a message object with the log4net.Core.Level.Info level.
           </summary>
           <param name="UserName">User Name</param>
           <param name="OperateType">Operation Type\: ("Add", "Update",
                                     "Delete")</param>
           <param name="SystemType">System Type \: Normal or Test</param>
           <param name="Browser">Browser \: IE or Firefox Or Chrome
                                 etc.</param>
           <param name="Message">Message is Which operation and
                                 operation description</param>
           <param name="Ex">Exception object</param>                      */
        void Info(string UserName, string OperateType, string SystemType, string Source, object Message, Exception Ex);
        /* <summary>
           Log a message object with the log4net.Core.Level.Warn level.
           </summary>
           <param name="UserName">User Name</param>
           <param name="OperateType">Operation Type\: ("Add", "Update",
                                     "Delete")</param>
           <param name="SystemType">System Type \: Normal or Test</param>
           <param name="Browser">Browser \: IE or Firefox Or Chrome
                                 etc.</param>
           <param name="Message">Message is Which operation and
                                 operation description</param>            */
        void Warn(string UserName, string OperateType, string SystemType, string Source, object Message);
        /* <summary>
           Log a message object with the log4net.Core.Level.Warn level.
           </summary>
           <param name="UserName">User Name</param>
           <param name="OperateType">Operation Type\: ("Add", "Update",
                                     "Delete")</param>
           <param name="SystemType">System Type \: Normal or Test</param>
           <param name="Browser">Browser \: IE or Firefox Or Chrome
                                 etc.</param>
           <param name="Message">Message is Which operation and
                                 operation description</param>
           <param name="Ex">Exception object</param>                      */
        void Warn(string UserName, string OperateType, string SystemType, string Source, object Message, Exception Ex);
        /* <summary>
           Logs a message object with the log4net.Core.Level.Error
           level.
           </summary>
           <param name="UserName">User Name</param>
           <param name="OperateType">Operation Type\: ("Add", "Update",
                                     "Delete")</param>
           <param name="SystemType">System Type \: Normal or Test</param>
           <param name="Browser">Browser \: IE or Firefox Or Chrome
                                 etc.</param>
           <param name="Message">Message is Which operation and
                                 operation description</param>            */
        void Error(string UserName, string OperateType, string SystemType, string Source, object Message);
        /* <summary>
           Logs a message object with the log4net.Core.Level.Error
           level.
           </summary>
           <param name="UserName">User Name</param>
           <param name="OperateType">Operation Type\: ("Add", "Update",
                                     "Delete")</param>
           <param name="SystemType">System Type \: Normal or Test</param>
           <param name="Browser">Browser \: IE or Firefox Or Chrome
                                 etc.</param>
           <param name="Message">Message is Which operation and
                                 operation description</param>
           <param name="Ex">Exception object</param>                      */
        void Error(string UserName, string OperateType, string SystemType, string Source, object Message, Exception Ex);
        /* <summary>
           Log a message object with the log4net.Core.Level.Fatal level.
           </summary>
           <param name="UserName">User Name</param>
           <param name="OperateType">Operation Type\: ("Add", "Update",
                                     "Delete")</param>
           <param name="SystemType">System Type \: Normal or Test</param>
           <param name="Browser">Browser \: IE or Firefox Or Chrome
                                 etc.</param>
           <param name="Message">Message is Which operation and
                                 operation description</param>            */
        void Fatal(string UserName, string OperateType, string SystemType, string Source, object Message);
        /* <summary>
           Log a message object with the log4net.Core.Level.Fatal level.
           </summary>
           <param name="UserName">User Name</param>
           <param name="OperateType">Operation Type\: ("Add", "Update",
                                     "Delete")</param>
           <param name="SystemType">System Type \: Normal or Test</param>
           <param name="Browser">Browser \: IE or Firefox Or Chrome
                                 etc.</param>
           <param name="Message">Message is Which operation and
                                 operation description</param>
           <param name="Ex">Exception object</param>                      */
        void Fatal(string UserName, string OperateType, string SystemType, string Source, object Message, Exception Ex);
    }   
}
