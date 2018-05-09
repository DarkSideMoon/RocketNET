using System;

namespace RocketNET.PostgreInitializer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, there is RokectNET Postgre data base Initializer!");

            Initializer initializer = new Initializer("", "", "Server=localhost;Port=5432;User Id=postgres;Password=12345678;");
            initializer.SetupEnvironment();

            Console.ReadKey(true);
        }
    }
}
