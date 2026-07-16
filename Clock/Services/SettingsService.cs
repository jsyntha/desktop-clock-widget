using Clock.Helpers;
using Clock.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace Clock.Services
{
    public class SettingsService
    {
        private readonly string settingsFilePath;
        private readonly FontService _fontService;
        public SettingsService(FontService fontService)
        {
            _fontService = fontService;
            settingsFilePath = Path.Combine(AppPaths.UserFontFolder, "clockSettings.json");
        }

        public Point LoadSettings(Point location)
        {
            if (!File.Exists(settingsFilePath)) return Point.Empty;

            string json = File.ReadAllText(settingsFilePath);

            ClockSettings? settings = JsonSerializer.Deserialize<ClockSettings>(json);

            if (settings == null)
                return Point.Empty;

            if (settings.FontColorArgb.HasValue)
            {
                _fontService.ApplyFontColour(Color.FromArgb(settings.FontColorArgb.Value));
            }

            return new Point(settings.X, settings.Y);
        }

        public void SaveSettings(Point location)
        {
            Directory.CreateDirectory(AppPaths.UserFontFolder);

            ClockSettings settings = new ClockSettings
            {
                X = location.X,
                Y = location.Y,
                FontColorArgb = _fontService.FontColor.ToArgb()
            };

            string json = JsonSerializer.Serialize(settings);
            File.WriteAllText(settingsFilePath, json);
        }
    }
}
