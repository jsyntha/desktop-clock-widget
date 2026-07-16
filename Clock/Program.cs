using Clock.Helpers;
using Clock.Services;

namespace Clock
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            FontService fontService = new();
            Application.Run(new frmClock(fontService));
        }
    }
}