using System;

namespace RocketNET.InitializerModel
{
    public interface IInitializer
    {
        void SetupEnvironment();

        void CreateDatabase();

        void CreateTables();

        void CreatePackages();

        void CreateViews();
    }
}
