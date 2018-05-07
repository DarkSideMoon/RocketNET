using System;
using System.Collections.Generic;
using System.Text;

namespace RocketNET.Model.Configuration
{
    /// <summary>
    /// Model of configuration file
    /// </summary>
    public class Configure
    {
        /// <summary>
        /// Number of processes that will accept connections for the listeners
        /// Default: 10
        /// </summary>
        public int AcceptorNumbers { get; set; }

        /// <summary>
        /// Port of service working
        /// Default: 8080
        /// </summary>
        public int Port { get; set; }

        /// <summary>
        /// Configuration for logging
        /// </summary>
        public ConfigureLogging ConfigureLogging { get; set; }

        /// <summary>
        /// Actual version of file
        /// Default: DateTime.Now
        /// </summary>
        public DateTime ActualVersion { get; set; }

        /// <summary>
        /// Version of configuration file
        /// Default: 1
        /// </summary>
        public int Version { get; set; }
    }
}
