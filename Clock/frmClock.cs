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

        private string settingsFilePath = Path.Combine(Application.StartupPath, "clockSettings.json");

        public frmClock()
        {
            InitializeComponent();
            SetupFonts();
            LoadSettings();
        }

        private void SetupFonts()
        {
            fonts.AddFontFile(
                Path.Combine(
                    Application.StartupPath,
                    "Fonts",
                    "Minecraftia-Regular.ttf"
                )
            );

            timeFont = new Font(fonts.Families[0], 84, FontStyle.Regular);
            dateFont = new Font(fonts.Families[0], 32, FontStyle.Regular);

            lblDigitalTime.Font = timeFont;
            lblDate.Font = dateFont;

            lblDate.Text = DateTime.Now.ToString("dd/MM/yy");
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
    }
}
