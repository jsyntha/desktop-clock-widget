using System;
using System.Collections.Generic;
using System.Text;

namespace Clock.Services
{
    public interface IFontService
    {
        FontFamily? SelectedFont { get; }
        string FontName { get; }
        string FontPath { get; }
        string FontFolder { get; }
        Font? TimeFont { get; }
        Font? DateFont { get; }
        Color FontColor { get; }
        event EventHandler? FontChanged;

        void LoadFonts();
        void SelectFont(string path);
        void ApplyFontColour(Color color);
        public void Dispose();
    }
}
