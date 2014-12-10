/* My Log Implementation */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using log4net.Core;

namespace Log4Ext
{
    /// <summary>
    /// Implementation of IMyLog wrapper interface.
    /// </summary>
    public class MyLogImpl : LogImpl, IMyLog
    {
        /// <summary>
        /// The fully qualified name of this declaring type not the type of any subclass.
        /// </summary>
        private readonly static Type ThisDeclaringType = typeof(MyLogImpl);
        /// <summary>
        /// Construct a new wrapper for the specified logger.
        /// </summary>
        /// <param name="logger">The logger to wrap.</param>
        public MyLogImpl(ILogger logger) : base(logger) { }
        ///<summary>
        ///Log a message object with the log4net.Core.Level.Debug level.
        ///</summary>
        ///param name="UserName">User Name</param>
        ///param name="OperateType">Operation Type\: ("Add", "Update","Delete")</param>
        ///param name="SystemType">System Type \: Normal or Test</param>
        ///param name="Browser">Browser \: IE or Firefox Or Chrome etc.</param>
        ///param name="Message">Message is Which operation and operation description</param>           
        public void Debug(string UserName, string LogType, string SystemType, string Browser, object Message)
        {
            Debug(UserName, LogType, SystemType, Browser, Message, null);
        }

        ///<summary>
        ///Log a message object with the log4net.Core.Level.Debug level.
        ///</summary>
        ///<param name="UserName">User Name</param>
        ///<param name="OperateType">Operation Type\: ("Add", "Update","Delete")</param>
        ///<param name="SystemType">System Type \: Normal or Test</param>
        ///<param name="Browser">Browser \: IE or Firefox Or Chrome etc.</param>
        ///<param name="Message">Message is Which operation andoperation description</param>
        ///<param name="Ex">Exception object</param>                      
        public void Debug(string UserName, string LogType, string SystemType, string Browser, object Message, Exception Ex)
        {

            if (this.IsDebugEnabled)
            {
                if (Ex == null)
                    Ex = new Exception("No Exception Found.");

                LoggingEvent loggingEvent = new LoggingEvent(ThisDeclaringType, Logger.Repository, Logger.Name, Level.Debug, Message, Ex);
                loggingEvent.Properties["UserName"] = UserName;
                loggingEvent.Properties["OperateType"] = LogType;
                loggingEvent.Properties["SystemType"] = SystemType;
                loggingEvent.Properties["Browser"] = Browser;
                Logger.Log(loggingEvent);
            }
        }

        ///<summary>
        ///Logs a message object with the log4net.Core.Level.Info level.
        ///</summary>
        ///<param name="UserName">User Name</param>
        ///<param name="OperateType">Operation Type\: ("Add", "Update", "Delete")</param>
        ///<param name="SystemType">System Type \: Normal or Test</param>
        ///<param name="Browser">Browser \: IE or Firefox Or Chrome  etc.</param>
        ///<param name="Message">Message is Which operation and operation description</param>           
        public void Info(string UserName, string LogType, string SystemType, string Browser, object Message)
        {
            Info(UserName, LogType, SystemType, Browser, Message, null);
        }

        ///<summary>
        ///Logs a message object with the log4net.Core.Level.Info level.
        ///</summary>
        ///<param name="UserName">User Name</param>
        ///<param name="OperateType">Operation Type\: ("Add", "Update", "Delete")</param>
        ///<param name="SystemType">System Type \: Normal or Test</param>
        ///<param name="Browser">Browser \: IE or Firefox Or Chrome etc.</param>
        ///<param name="Message">Message is Which operation and operation description</param>
        ///<param name="Ex">Exception object</param>            
        public void Info(string UserName, string LogType, string SystemType, string Browser, object Message, Exception Ex)
        {
            if (this.IsInfoEnabled)
            {
                if (Ex == null)
                    Ex = new Exception("No Exception Found.");
                LoggingEvent loggingEvent = new LoggingEvent(ThisDeclaringType, Logger.Repository, Logger.Name, Level.Info, Message, Ex);
                loggingEvent.Properties["UserName"] = UserName;
                loggingEvent.Properties["SystemType"] = SystemType;
                loggingEvent.Properties["OperateType"] = LogType;
                loggingEvent.Properties["Browser"] = Browser;
                Logger.Log(loggingEvent);
            }
        }
        ///<summary>
        ///Log a message object with the log4net.Core.Level.Warn level.
        ///</summary>
        ///<param name="UserName">User Name</param>
        ///<param name="OperateType">Operation Type\: ("Add", "Update","Delete")</param>
        ///<param name="SystemType">System Type \: Normal or Test</param>
        ///<param name="Browser">Browser \: IE or Firefox Or Chrome etc.</param>
        ///<param name="Message">Message is Which operation and operation description</param>            
        public void Warn(string UserName, string LogType, string SystemType, string Browser, object Message)
        {
            Warn(UserName, LogType, SystemType, Browser, Message, null);
        }
        ///<summary>
        ///Log a message object with the log4net.Core.Level.Warn level.
        ///</summary>
        ///<param name="UserName">User Name</param>
        ///<param name="OperateType">Operation Type\: ("Add", "Update", "Delete")</param>
        ///<param name="SystemType">System Type \: Normal or Test</param>
        ///<param name="Browser">Browser \: IE or Firefox Or Chrome etc.</param>
        ///<param name="Message">Message is Which operation and operation description</param>
        ///<param name="Ex">Exception object</param>                      
        public void Warn(string UserName, string LogType, string SystemType, string Browser, object Message, Exception Ex)
        {
            if (this.IsWarnEnabled)
            {
                if (Ex == null)
                    Ex = new Exception("No Exception Found.");
                LoggingEvent loggingEvent = new LoggingEvent(ThisDeclaringType, Logger.Repository, Logger.Name, Level.Warn, Message, Ex);
                loggingEvent.Properties["UserName"] = UserName;
                loggingEvent.Properties["SystemType"] = SystemType;
                loggingEvent.Properties["OperateType"] = LogType;
                loggingEvent.Properties["Browser"] = Browser;
                Logger.Log(loggingEvent);
            }
        }
        ///<summary>
        ///Logs a message object with the log4net.Core.Level.Error level.
        ///</summary>
        ///<param name="UserName">User Name</param>
        ///<param name="OperateType">Operation Type\: ("Add", "Update", "Delete")</param>
        ///<param name="SystemType">System Type \: Normal or Test</param>
        ///<param name="Browser">Browser \: IE or Firefox Or Chrome etc.</param>
        ///<param name="Message">Message is Which operation and operation description</param>          
        public void Error(string UserName, string LogType, string SystemType, string Browser, object Message)
        {
            Error(UserName, LogType, SystemType, Browser, Message, null);
        }
        ///<summary>
        ///Logs a message object with the log4net.Core.Level.Error level.
        ///</summary>
        ///<param name="UserName">User Name</param>
        ///<param name="OperateType">Operation Type\: ("Add", "Update", "Delete")</param>
        ///<param name="SystemType">System Type \: Normal or Test</param>
        ///<param name="Browser">Browser \: IE or Firefox Or Chrome etc.</param>
        ///<param name="Message">Message is Which operation and operation description</param>
        ///<param name="Ex">Exception object</param>                  
        public void Error(string UserName, string LogType, string SystemType, string Browser, object Message, Exception Ex)
        {
            if (this.IsErrorEnabled)
            {

                if (Ex == null)
                    Ex = new Exception("No Exception Found.");
                LoggingEvent loggingEvent = new LoggingEvent(ThisDeclaringType, Logger.Repository, Logger.Name, Level.Error, Message, Ex);
                loggingEvent.Properties["UserName"] = UserName;
                loggingEvent.Properties["OperateType"] = LogType;
                loggingEvent.Properties["SystemType"] = SystemType;
                loggingEvent.Properties["Browser"] = Browser;
                Logger.Log(loggingEvent);
            }
        }

        ///<summary>        
        ///Log a message object with the log4net.Core.Level.Fatal level.
        ///</summary>
        ///<param name="UserName">User Name</param>
        ///<param name="OperateType">Operation Type\: ("Add", "Update", "Delete")</param>
        ///<param name="SystemType">System Type \: Normal or Test</param>
        ///<param name="Browser">Browser \: IE or Firefox Or Chrome etc.</param>
        ///<param name="Message">Message is Which operation and operation description</param>           
        public void Fatal(string UserName, string LogType, string SystemType, string Browser, object Message)
        {
            Fatal(UserName, LogType, SystemType, Browser, Message, null);
        }

        ///<summary>
        ///Log a message object with the log4net.Core.Level.Fatal level.
        ///</summary>
        ///<param name="UserName">User Name</param>
        ///<param name="OperateType">Operation Type\: ("Add", "Update", "Delete")</param>
        ///<param name="SystemType">System Type \: Normal or Test</param>
        ///<param name="Browser">Browser \: IE or Firefox Or Chrome etc.</param>
        ///<param name="Message">Message is Which operation and operation description</param>
        ///<param name="Ex">Exception object</param>                     
        public void Fatal(string UserName, string LogType, string SystemType, string Browser, object Message, Exception Ex)
        {
            if (this.IsFatalEnabled)
            {
                if (Ex == null)
                    Ex = new Exception("No Exception Found.");
                LoggingEvent loggingEvent = new LoggingEvent(ThisDeclaringType, Logger.Repository, Logger.Name, Level.Fatal, Message, Ex);
                loggingEvent.Properties["UserName"] = UserName;
                loggingEvent.Properties["SystemType"] = SystemType;
                loggingEvent.Properties["OperateType"] = LogType;
                loggingEvent.Properties["Browser"] = Browser;
                Logger.Log(loggingEvent);
            }
        }
    }

}
