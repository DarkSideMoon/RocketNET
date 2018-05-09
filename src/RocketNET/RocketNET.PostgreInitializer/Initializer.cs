using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;
using Npgsql;
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
        /// Connection string
        /// </summary>
        private readonly string _connectionString;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="mainInstallPath">Path to folder where database environment will be setup</param>
        /// <param name="sqlScriptsPath">Path to folder of database scripts destinations</param>
        /// <param name="connectionString">Connection string to database</param>
        public Initializer(
            string mainInstallPath, 
            string sqlScriptsPath,
            string connectionString)
        {
            _mainInstallPath = mainInstallPath;
            _sqlScriptsPath = sqlScriptsPath;
            _connectionString = connectionString;
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
            string sqlScript = GetResourseScript("CreateDatabase");

            try
            {
                using (NpgsqlConnection сonnection = new NpgsqlConnection(_connectionString))
                {
                    using (NpgsqlCommand command = new NpgsqlCommand(sqlScript))
                    {
                        сonnection.Open();
                        command.ExecuteNonQuery();
                        сonnection.Close();
                    }
                }
                // TODO: If everything OK need logging 
            }
            catch (Exception e)
            {
                // TODO: Need logging 
                throw e;
            }
        }

        public void CreateTables()
        {
            throw new NotImplementedException();
        }

        public void CreateSequences()
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

        
        /// <summary>
        /// Get resourse sql script to work 
        /// </summary>
        /// <param name="scriptName"></param>
        /// <returns></returns>
        private string GetResourseScript(string scriptName)
        {
            string resourse = String.Empty;
            var assembly = Assembly.GetExecutingAssembly();

            try
            {
                using (Stream stream = assembly.GetManifestResourceStream($"{scriptName}.sql"))
                {
                    using (StreamReader reader = new StreamReader(stream))
                    {
                        resourse = reader.ReadToEnd();
                    }
                }
            }
            catch (Exception e)
            {
                throw e;
            }

            return resourse;
        }
    }
}
