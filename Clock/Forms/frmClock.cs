using System.Text.Json;
using Clock.Models;
using Clock.Helpers;
using Clock.Services;

namespace Clock
{
    public partial class frmClock : Form
    {
        private readonly WindowDragHelper _dragHelper;
        private readonly FontService _fontService;

        private string settingsFilePath = Path.Combine(Application.StartupPath, "clockSettings.json");

        private bool settingsOpen = false;
        public frmClock(FontService fontService)
        {
            InitializeComponent();

            _fontService = fontService;
            _dragHelper = new WindowDragHelper(this);

            _fontService.FontChanged += FontService_FontChanged;
            _fontService.LoadFonts();

            LoadSettings();

            lblDigitalTime.Font = _fontService.TimeFont;
            lblDate.Font = _fontService.DateFont;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;

            lblDigitalTime.Text = now.ToString("HH:mm");
            lblDate.Text = now.ToString("dd/MM/yy");
        }

        private void pnlClock_MouseDown(object sender, MouseEventArgs e)
        {
            _dragHelper.StartDrag(e);
        }

        private void pnlClock_MouseMove(object sender, MouseEventArgs e)
        {
            _dragHelper.MoveDrag();
        }

        private void pnlClock_MouseUp(object sender, MouseEventArgs e)
        {
            _dragHelper.EndDrag(e);
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
            _fontService.FontChanged -= FontService_FontChanged;
            _fontService.Dispose();
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
                using (frmSettings settingsForm = new frmSettings(_fontService))
                {
                    settingsForm.ShowDialog(this);
                }
            }
            finally
            {
                settingsOpen = false;
            }
        }

        private void FontService_FontChanged(object? sender, EventArgs e)
        {
            lblDigitalTime.Font = _fontService.TimeFont;
            lblDate.Font = _fontService.DateFont;
        }
    }
}
