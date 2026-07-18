using System;
using System.Collections.Generic;
using System.Text;

namespace Clock.Helpers
{
    public static class AppPaths
    {
        public static readonly string UserFontFolder =
            Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                "DesktopClockWidget",
                "Fonts");

        public static readonly string BundledFontFolder =
            Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory,
                "Fonts");

        public static readonly string AppDataFolder =
            Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
                "DesktopClockWidget");
    }
}
