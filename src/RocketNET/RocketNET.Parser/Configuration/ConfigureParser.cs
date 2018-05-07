using System;
using System.Collections.Generic;
using System.Text;
using RocketNET.Model.Configuration;

namespace RocketNET.Parser.Configuration
{
    /// <summary>
    /// Class for RocketNET global configuration parser
    /// </summary>
    public class ConfigureParser
    {
        /// <summary>
        /// Parse configuration from JSON file
        /// </summary>
        /// <returns></returns>
        public Configure Parse()
        {
            return new Configure();
        }
    }
}
