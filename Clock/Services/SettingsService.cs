using Clock.Helpers;
using Clock.Models;
using System.Text.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Clock.Services
{
    public class SettingsService : ISettingsService
    {
        private readonly string settingsFilePath;
        private readonly IFontService _fontService;
        public SettingsService(IFontService fontService)
        {
            _fontService = fontService;
            settingsFilePath = Path.Combine(AppPaths.AppDataFolder, "clockSettings.json");
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
