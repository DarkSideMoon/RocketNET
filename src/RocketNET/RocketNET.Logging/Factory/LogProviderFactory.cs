using System;
using System.Collections.Generic;
using System.Text;
using RocketNET.Logging.Enums;
using RocketNET.Logging.Interfaces;

namespace RocketNET.Logging.Factory
{
    /// <summary>
    /// Factory of logger providers
    /// </summary>
    public static class LogProviderFactory
    {
        public static ILog GetLogProviderFactory(string name)
        {
            throw new NotImplementedException();
        }

        public static ILogAsync GetLogProviderFactoryAsync(string name)
        {
            throw new NotImplementedException();
        }

        public static ILog GetLogProviderFactory(LogType logType)
        {
            throw new NotImplementedException();
        }

        public static ILogAsync GetLogProviderFactoryAsync(LogType logType)
        {
            throw new NotImplementedException();
        }
    }
}
