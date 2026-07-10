using System.Configuration;
using System.Drawing.Text;
using System.Text.Json;

namespace Clock
{
    public partial class frmClock : Form
    {
        private bool isDragging = false;
        private Point mouseDownPosition;
        private Point formPosition;

        private PrivateFontCollection fonts = new();
        private Font timeFont;
        private Font dateFont;
        public string FontName { get; private set; } = "";
        public string FontPath { get; private set; } = "";

        private readonly Dictionary<string, FontFamily> fontsStored = new();
        private string settingsFilePath = Path.Combine(Application.StartupPath, "clockSettings.json");

        private bool settingsOpen = false;
        public frmClock()
        {
            InitializeComponent();
            SetupFonts();
            LoadSettings();
        }

        private void SetupFonts()
        {
            string fontsFolder = Path.Combine(Application.StartupPath, "Fonts");
            FontPath = fontsFolder;

            if (!Directory.Exists(fontsFolder))
            {
                MessageBox.Show("The Fonts folder was not found.");
                return;
            }

            string[] fontsFoundList = Directory.GetFiles(fontsFolder, "*.ttf");

            if (fontsFoundList.Length == 0)
            {
                MessageBox.Show("No fonts found in the Fonts folder.");
                return;
            }

            try
            {
                foreach (string fontPath in fontsFoundList)
                {
                    int oldFontCount = fonts.Families.Length;
                    fonts.AddFontFile(fontPath);

                    if (fonts.Families.Length <= oldFontCount)
                    {
                        continue;
                    }

                    FontFamily loadedFont = fonts.Families[fonts.Families.Length - 1];
                    string fontName = Path.GetFileNameWithoutExtension(fontPath);

                    if (!fontsStored.ContainsKey(fontName))
                    {
                        fontsStored.Add(fontName, loadedFont);
                        FontName = fontName;
                    }
                }

                if (fontsStored.Count == 0)
                {
                    MessageBox.Show("No fonts could be loaded.");
                    return;
                }

                FontFamily selectedFont = fontsStored.Values.First();

                timeFont = new Font(selectedFont, 84, FontStyle.Regular);
                dateFont = new Font(selectedFont, 32, FontStyle.Regular);

                lblDigitalTime.Font = timeFont;
                lblDate.Font = dateFont;

                lblDate.Text = DateTime.Now.ToString("dd/MM/yy");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;

            lblDigitalTime.Text = now.ToString("HH:mm");
            lblDate.Text = now.ToString("dd/MM/yy");
        }

        private void pnlClock_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;

            isDragging = true;

            mouseDownPosition = Cursor.Position;
            formPosition = Location;
        }

        private void pnlClock_MouseMove(object sender, MouseEventArgs e)
        {
            if (!isDragging)
                return;

            Point difference = Cursor.Position - (Size)mouseDownPosition;
            Location = formPosition + (Size)difference;
        }

        private void pnlClock_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            notifyIcon1.Visible = false;
            Application.Exit();
        }

        private void LoadSettings()
        {
            if (!File.Exists(settingsFilePath)) return;

            string json = File.ReadAllText(settingsFilePath);

            ClockSettings? settings = JsonSerializer.Deserialize<ClockSettings>(json);

            if (settings == null)
                return;

            Location = new Point(settings.X, settings.Y);
        }

        private void SaveSettings()
        {
            ClockSettings settings = new ClockSettings
            {
                X = Location.X,
                Y = Location.Y
            };

            string json = JsonSerializer.Serialize(settings);
            File.WriteAllText(settingsFilePath, json);
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            SaveSettings();
            notifyIcon1?.Visible = false;
            base.OnFormClosing(e);
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(settingsOpen)
            {
                return;
            } settingsOpen = true;

            try
            {
                using (frmSettings settingsForm = new frmSettings())
                {
                    settingsForm.ShowDialog(this);
                }
            }
            finally
            {
                settingsOpen = false;
            }
        }
    }
}
