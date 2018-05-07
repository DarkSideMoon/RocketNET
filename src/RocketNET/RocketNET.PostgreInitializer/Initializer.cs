using System;
using System.Collections.Generic;
using System.Text;
using RocketNET.InitializerModel;

namespace RocketNET.PostgreInitializer
{
    /// <summary>
    /// Class like a builder 
    /// Step by step initialize database environment for working with postgre data base
    /// </summary>
    public class Initializer : IInitializer
    {
        /// <summary>
        /// Path to folder where database setup
        /// </summary>
        private readonly string _mainInstallPath;

        /// <summary>
        /// Path to scripts folder
        /// </summary>
        private readonly string _sqlScriptsPath;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="mainInstallPath">Path to folder where database environment will be setup</param>
        /// <param name="sqlScriptsPath">Path to folder of database scripts destinations</param>
        public Initializer(string mainInstallPath, string sqlScriptsPath)
        {
            _mainInstallPath = mainInstallPath;
            _sqlScriptsPath = sqlScriptsPath;
        }

        /// <summary>
        /// Main method to Setup all database environment
        /// </summary>
        public void SetupEnvironment()
        {
            try
            {
                CreateDatabase();

                CreateTables();

                CreatePackages();

                CreateViews();
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(e);
                Console.ResetColor();

                throw;
            }
        }

        public void CreateDatabase()
        {
            throw new NotImplementedException();
        }

        public void CreateTables()
        {
            throw new NotImplementedException();
        }

        public void CreatePackages()
        {
            throw new NotImplementedException();
        }

        public void CreateViews()
        {
            throw new NotImplementedException();
        }
    }
}
