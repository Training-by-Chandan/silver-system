namespace WinFormApp.Db
{
    internal static class Program
    {
        public static frmLogin loginForm = new frmLogin();

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(loginForm);
        }
    }
}