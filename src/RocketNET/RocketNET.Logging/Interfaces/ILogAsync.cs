using System;
using System.Collections.Generic;
using System.Text;
using RocketNET.Logging.Enums;

namespace RocketNET.Logging.Interfaces
{
    /// <summary>
    /// Interface of asynchronous logging
    /// </summary>
    public interface ILogAsync
    {
        LogLevel LogLevel { get; set; }

        LogType LogType { get; set; }

        LogParameter LogParameter { get; set; }

        LogNotification LogNotification { get; set; }

        bool LogAsync(string message);

        bool LogAsync(string message, Exception exception);

        bool LogAsync(string message, Exception exception, LogLevel logLevel);

        bool LogAsync(string message,
            Exception exception,
            LogLevel logLevel,
            LogNotification logNotification);

        bool LogAsync(string message,
            Exception exception,
            LogLevel logLevel,
            LogNotification logNotification,
            LogParameter logParameter);
    }
}
