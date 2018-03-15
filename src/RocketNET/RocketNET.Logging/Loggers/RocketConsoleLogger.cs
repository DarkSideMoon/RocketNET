using System;
using System.Collections.Generic;
using System.Text;
using RocketNET.Logging.Enums;
using RocketNET.Logging.Interfaces;

namespace RocketNET.Logging.Loggers
{
    public class RocketConsoleLogger : ILog, ILogAsync
    {
        public LogLevel LogLevel { get; set; }
        public LogType LogType { get; set; }
        public LogParameter LogParameter { get; set; }
        public LogNotification LogNotification { get; set; }

        #region ILog implementation
        public bool Log(string message)
        {
            throw new NotImplementedException();
        }

        public bool Log(string message, Exception exception)
        {
            throw new NotImplementedException();
        }

        public bool Log(string message, Exception exception, LogLevel logLevel)
        {
            throw new NotImplementedException();
        }

        public bool Log(string message,
            Exception exception,
            LogLevel logLevel,
            LogNotification logNotification)
        {
            throw new NotImplementedException();
        }

        public bool Log(string message,
            Exception exception,
            LogLevel logLevel,
            LogNotification logNotification,
            LogParameter logParameter)
        {
            throw new NotImplementedException();
        }
        #endregion

        #region ILogAsync implementation
        public bool LogAsync(string message)
        {
            throw new NotImplementedException();
        }

        public bool LogAsync(string message, Exception exception)
        {
            throw new NotImplementedException();
        }

        public bool LogAsync(string message, Exception exception, LogLevel logLevel)
        {
            throw new NotImplementedException();
        }

        public bool LogAsync(string message, 
            Exception exception, 
            LogLevel logLevel, 
            LogNotification logNotification)
        {
            throw new NotImplementedException();
        }

        public bool LogAsync(string message, 
            Exception exception, 
            LogLevel logLevel, 
            LogNotification logNotification,
            LogParameter logParameter)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
