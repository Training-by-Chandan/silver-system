using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.Extensions.Configuration;

namespace WinFormApp.Db
{
    internal static class Program
    {
        public static frmLogin loginForm = new frmLogin();
        public static bool DeveloperOption = false;
        public static string connectionString = "";

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main(string[] args)
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            #region DevMode

            for (int i = 0; i < args.Length; i = i + 2)
            {
                //Console.WriteLine(args[i]);
                if (args[i] == "-dev" && args[i + 1] == "enabled")
                {
                    DeveloperOption = true;
                }
            }
            if (DeveloperOption)
            {
                Console.WriteLine("Developer option enabled");
            }

            #endregion DevMode

            #region Get The Configuration

            var configuration = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json");
            var config = configuration.Build();
            connectionString = config.GetConnectionString("DefaultConnection");

            #endregion Get The Configuration

#if DEBUG
            Application.Run(loginForm);
#else
            Application.Run(new frmMain());
#endif
        }
    }
}