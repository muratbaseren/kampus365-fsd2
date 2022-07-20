using Microsoft.Extensions.Configuration;

namespace WinformsApp1
{
    internal static class Program
    {
        public static IConfiguration Configuration;

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            var builder = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            Configuration = builder.Build();

            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}