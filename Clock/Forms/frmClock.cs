using System.Text.Json;
using Clock.Models;
using Clock.Helpers;
using Clock.Services;

namespace Clock
{
    public partial class frmClock : Form
    {
        private readonly WindowDragHelper _dragHelper;
        private readonly IFontService _fontService;
        private readonly SettingsService _settingsService;

        private bool settingsOpen = false;
        public frmClock(IFontService fontService)
        {
            InitializeComponent();
            _dragHelper = new WindowDragHelper(this);
            _fontService = fontService;
            _settingsService = new SettingsService(_fontService);
            _fontService.FontChanged += FontService_FontChanged;
            _fontService.LoadFonts();
            Location = _settingsService.LoadSettings(Location);

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

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            _settingsService.SaveSettings(Location);
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
            lblDigitalTime.ForeColor = _fontService.FontColor;
            lblDate.ForeColor = _fontService.FontColor;
        }
    }
}
