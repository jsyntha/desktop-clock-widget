using System;
using System.Collections.Generic;
using System.Text;

namespace Clock.Helpers
{
    public static class AppPathHelper
    {
        private static readonly string _appDataRoot = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "DesktopClockWidget");
        public static readonly string userFontFolder;
        public static readonly string bundledFontFolder;

        static AppPathHelper()
        {
            userFontFolder = Path.Combine(_appDataRoot, "Fonts");
            bundledFontFolder = Path.Combine(Application.StartupPath, "Fonts");
        }
    }
}
