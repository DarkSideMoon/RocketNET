using System;
using System.Collections.Generic;
using System.Text;
using RocketNET.Logging.Enums;

namespace RocketNET.Logging.Interfaces
{
    /// <summary>
    /// Different type of logging
    /// 
    /// You can customize logging process
    /// You can create logger 
    /// </summary>
    public interface ILog
    {
        LogLevel LogLevel { get; set; }

        LogType LogType { get; set; }

        LogParameter LogParameter { get; set; }

        LogNotification LogNotification { get; set; }

        bool Log(string message);

        bool Log(string message, Exception exception);

        bool Log(string message, Exception exception, LogLevel logLevel);

        bool Log(string message,
            Exception exception,
            LogLevel logLevel,
            LogNotification logNotification);

        bool Log(string message,
            Exception exception,
            LogLevel logLevel,
            LogNotification logNotification,
            LogParameter logParameter);
    }
}
