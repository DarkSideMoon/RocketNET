using System;
using System.Collections.Generic;
using System.Text;

namespace RocketNET.Logging.Enums
{
    public enum LogType
    {
        Default,
        Console,
        DataBase,
        File,
        Json,

        /// <summary>
        /// Multiply way of logging
        /// </summary>
        Combine
    }
}
