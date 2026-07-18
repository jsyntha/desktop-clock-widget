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
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            //FontService fontService = new();
            var services = new ServiceCollection();
            services.AddSingleton<IFontService, FontService>();
            services.AddSingleton<ISettingsService, SettingsService>();

            services.AddTransient<frmClock>();
            services.AddTransient<frmSettings>();

            var serviceProvider = services.BuildServiceProvider();
            //Application.Run(new frmClock(fontService));
            Application.Run(serviceProvider.GetRequiredService<frmClock>());
        }
    }
}