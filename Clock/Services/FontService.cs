using Microsoft.VisualBasic;
using System.Drawing.Text;

namespace Clock.Services
{
    public class FontService
    {
        private PrivateFontCollection _fonts = new();
        private readonly Dictionary<string, FontFamily> _fontsStored = new();
        private Font? _timeFont;
        private Font? _dateFont;
        private Color _fontColor = Color.Black;
        //private Color _previousFontColor;

        public FontFamily? SelectedFont { get; private set; }
        public string FontName { get; private set; } = "";
        public string FontPath { get; private set; } = "";
        public string FontFolder { get; private set; } = "";
        public Font? TimeFont => _timeFont;
        public Font? DateFont => _dateFont;
        public Color FontColor => _fontColor;
        //public Color PreviouisFontColor => _previousFontColor;
        public event EventHandler? FontChanged;

        public void LoadFonts()
        {
            FontFolder = Path.Combine(Application.StartupPath, "Fonts");
            if (!Directory.Exists(FontFolder))
            {
                UseFallbackFont();
                return;
            }

            string[] fontsFoundList = Directory.GetFiles(FontFolder, "*.ttf");
            if (fontsFoundList.Length <= 0)
            {
                UseFallbackFont();
                return;
            }

            try
            {
                foreach (string fontPath in fontsFoundList)
                {
                    int oldFontCount = _fonts.Families.Length;
                    _fonts.AddFontFile(fontPath);

                    if (_fonts.Families.Length <= oldFontCount)
                    {
                        continue;
                    }

                    FontFamily loadedFont = _fonts.Families[_fonts.Families.Length - 1];
                    string fontName = Path.GetFileNameWithoutExtension(fontPath);

                    if (!_fontsStored.ContainsKey(fontName))
                    {
                        _fontsStored.Add(fontName, loadedFont);

                        if (string.IsNullOrEmpty(FontPath))
                        {
                            FontPath = fontPath;
                        }
                    }
                }

                if (_fontsStored.Count == 0)
                {
                    UseFallbackFont();
                    return;
                }

                var firstFont = _fontsStored.First();
                ApplySelectedFont(firstFont.Value, firstFont.Key, FontPath);
                FontChanged?.Invoke(this, EventArgs.Empty);
            }
            catch
            {
                UseFallbackFont();
            }
        }

        public void SelectFont(string path)
        {
            string fontName = Path.GetFileNameWithoutExtension(path);

            if (!_fontsStored.TryGetValue(fontName, out FontFamily? font))
            {
                _fonts.AddFontFile(path);

                font = _fonts.Families.Last();

                _fontsStored.Add(fontName, font);
            }

            ApplySelectedFont(font, fontName, path);
            FontChanged?.Invoke(this, EventArgs.Empty);
        }

        public void ApplyFontColour(Color color)
        {
            _fontColor = color;
            FontChanged?.Invoke(this, EventArgs.Empty);
        }

        private void ApplySelectedFont(FontFamily fontFamily, string fontName, string fontPath)
        {
            _timeFont?.Dispose();
            _dateFont?.Dispose();

            SelectedFont = fontFamily;
            FontName = fontName;
            FontPath = fontPath;

            _timeFont = new Font(fontFamily, 84, FontStyle.Regular);
            _dateFont = new Font(fontFamily, 32, FontStyle.Regular);
        }

        private void UseFallbackFont()
        {
            ApplySelectedFont(SystemFonts.DefaultFont.FontFamily, SystemFonts.DefaultFont.FontFamily.Name, string.Empty);
            FontChanged?.Invoke(this, EventArgs.Empty);
        }

        public void Dispose()
        {
            _timeFont?.Dispose();
            _dateFont?.Dispose();
            _fonts.Dispose();
        }
    }
}