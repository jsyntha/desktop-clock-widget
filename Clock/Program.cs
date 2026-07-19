using Clock.Helpers;
using Clock.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Clock
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>

        private static Mutex? mutexName;

        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            mutexName = new Mutex(true, "DesktopClockWidgetMutex", out bool createdNew);
            if (!createdNew) { MessageBox.Show("Another instance of the program is already running."); return; }
            ApplicationConfiguration.Initialize();
            var services = new ServiceCollection();
            services.AddSingleton<IFontService, FontService>();
            services.AddSingleton<ISettingsService, SettingsService>();

            services.AddTransient<frmClock>();
            services.AddTransient<frmSettings>();

            var serviceProvider = services.BuildServiceProvider();
            Application.Run(serviceProvider.GetRequiredService<frmClock>());
        }
    }
}