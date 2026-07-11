using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Clock
{
    public partial class frmSettings : Form
    {
        private readonly frmClock clockForm;

        public frmSettings(frmClock clockForm)
        {
            InitializeComponent();

            lblTypographyExampleSentence.TextAlign = ContentAlignment.MiddleCenter;
            lblTypographyExampleChars.TextAlign = ContentAlignment.MiddleCenter;

            lblTypographyExampleSentence.AutoSize = false;
            lblTypographyExampleChars.AutoSize = false;

            this.clockForm = clockForm;
            txtActiveFont.Text = this.clockForm.FontName;
            //txtActivePath.Text = this.clockForm.FontPath;
            txtActivePath.Text = ShortenPath(clockForm.FontPath, 64);
            FontFamily font = clockForm.selectedFont ?? FontFamily.GenericSansSerif;

            ApplyPreviewFont(lblTypographyExampleSentence, font);
            ApplyPreviewFont(lblTypographyExampleChars, font);
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            using(OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "TrueType Fonts (*.ttf)|*.ttf";
                openFileDialog.Title = "Select a font file";

                if (!string.IsNullOrEmpty(clockForm.FontFolder))
                {
                    openFileDialog.InitialDirectory = clockForm.FontFolder;
                }

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    clockForm.LoadFont(openFileDialog.FileName);

                    txtActiveFont.Text = clockForm.FontName;
                    txtActivePath.Text = ShortenPath(clockForm.FontPath, 64);
                    txtExampleFont.Text = ShortenPath(clockForm.FontPath, 64);

                    ApplyPreviewFont(lblTypographyExampleSentence, clockForm.selectedFont ?? FontFamily.GenericSansSerif);
                    ApplyPreviewFont(lblTypographyExampleChars, clockForm.selectedFont ?? FontFamily.GenericSansSerif);
                }
            }
        }

        private void OpenFontFolder(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = clockForm.FontFolder,
                UseShellExecute = true
            });
        }

        private string ShortenPath(string path, int maxLength)
        {
            if (path.Length <= maxLength) return path;
            return "..." + path.Substring(path.Length - maxLength);
        }

        private void ApplyPreviewFont(Control control, FontFamily fontFamily)
        {
            float size = 48f;
            Font testFont;

            while (size > 1)
            {
                testFont = new Font(fontFamily, size, control.Font.Style);

                Size textSize = TextRenderer.MeasureText(control.Text, testFont);

                if (textSize.Width <= control.Width && textSize.Height <= control.Height)
                {
                    control.Font = testFont;
                    return;
                }

                testFont.Dispose();
                size--;
            }

            control.Font = new Font(fontFamily, 1f, control.Font.Style);
        }
    }
}
