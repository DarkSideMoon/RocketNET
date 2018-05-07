using System;
using System.Collections.Generic;
using System.Text;

namespace RocketNET.Model.Configuration
{
    /// <summary>
    /// Configuration for logger
    /// </summary>
    public class ConfigureLogging
    {
        public string LogType { get; set; }

        public string LogNotification { get; set; }

        public string LogParameter { get; set; }

        public string LogLevel { get; set; }
    }
}
