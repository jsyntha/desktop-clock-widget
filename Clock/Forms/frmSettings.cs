using Clock.Services;
using System.Diagnostics;

namespace Clock
{
    public partial class frmSettings : Form
    {
        private readonly FontService _fontService;
        private Color _previewFontColor;
        private Color _previousFontColor;

        public frmSettings(FontService fontService)
        {
            InitializeComponent();
            _fontService = fontService;
            _previousFontColor = _fontService.FontColor;
            _previewFontColor = _previousFontColor;

            lblTypographyExampleSentence.TextAlign = ContentAlignment.MiddleCenter;
            lblTypographyExampleChars.TextAlign = ContentAlignment.MiddleCenter;

            lblTypographyExampleSentence.AutoSize = false;
            lblTypographyExampleChars.AutoSize = false;

            txtActiveFont.Text = _fontService.FontName;
            txtActivePath.Text = ShortenPath(_fontService.FontPath, 64);
            FontFamily? font = _fontService.SelectedFont;

            ApplyPreviewFont(lblTypographyExampleSentence, font, _fontService.FontColor);
            ApplyPreviewFont(lblTypographyExampleChars, font, _fontService.FontColor);
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "TrueType Fonts (*.ttf)|*.ttf";
                openFileDialog.Title = "Select a font file";

                if (!string.IsNullOrEmpty(_fontService.FontFolder))
                {
                    openFileDialog.InitialDirectory = _fontService.FontFolder;
                }

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    _fontService.SelectFont(openFileDialog.FileName);

                    txtActiveFont.Text = _fontService.FontName;
                    txtActivePath.Text = ShortenPath(_fontService.FontPath, 64);
                    txtExampleFont.Text = ShortenPath(_fontService.FontPath, 64);

                    ApplyPreviewFont(lblTypographyExampleSentence, _fontService.SelectedFont ?? FontFamily.GenericSansSerif, _fontService.FontColor);
                    ApplyPreviewFont(lblTypographyExampleChars, _fontService.SelectedFont ?? FontFamily.GenericSansSerif, _fontService.FontColor);
                }
            }
        }

        private void OpenFontFolder(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = _fontService.FontFolder,
                UseShellExecute = true
            });
        }

        private string ShortenPath(string path, int maxLength)
        {
            if (path.Length <= maxLength) return path;
            return "..." + path.Substring(path.Length - maxLength);
        }

        private void ApplyPreviewFont(Control control, FontFamily? fontFamily, Color fontColor)
        {
            FontFamily previewFontFamily = fontFamily ?? SystemFonts.DefaultFont.FontFamily;
            float size = 48f;
            Font testFont;

            control.ForeColor = fontColor;

            while (size > 1)
            {
                testFont = new Font(previewFontFamily, size, control.Font.Style);

                Size textSize = TextRenderer.MeasureText(control.Text, testFont);

                if (textSize.Width <= control.Width && textSize.Height <= control.Height)
                {
                    control.Font = testFont;
                    return;
                }

                testFont.Dispose();
                size--;
            }

            control.Font = new Font(previewFontFamily, 1f, control.Font.Style);
        }

        private void btnChangeFontColour_Click(object sender, EventArgs e)
        {
            using ColorDialog dialog = new();
            dialog.Color = _previewFontColor;
            dialog.AnyColor = true;
            dialog.FullOpen = true;

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                _previewFontColor = dialog.Color;
                ApplyPreviewFont(lblTypographyExampleSentence, _fontService.SelectedFont ?? FontFamily.GenericSansSerif, _previewFontColor);
                ApplyPreviewFont(lblTypographyExampleChars, _fontService.SelectedFont ?? FontFamily.GenericSansSerif, _previewFontColor);
            }
        }

        private void btnApplySettings_Click(object sender, EventArgs e)
        {
            _fontService.ApplyFontColour(_previewFontColor);
            _previousFontColor = _previewFontColor;
        }

        private void btnCancelSettings_Click(object sender, EventArgs e)
        {
            if(_previewFontColor == _previousFontColor)
            {
                MessageBox.Show("No changes to cancel.");
                return;
            }
            _previewFontColor = _previousFontColor;
            ApplyPreviewFont(lblTypographyExampleSentence, _fontService.SelectedFont ?? FontFamily.GenericSansSerif, _previewFontColor);
            ApplyPreviewFont(lblTypographyExampleChars, _fontService.SelectedFont ?? FontFamily.GenericSansSerif, _previewFontColor);
        }
    }
}
