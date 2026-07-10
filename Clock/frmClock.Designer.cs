namespace Clock
{
    partial class frmClock
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClock));
            timer1 = new System.Windows.Forms.Timer(components);
            lblDigitalTime = new Label();
            lblDate = new Label();
            pnlClock = new Panel();
            notifyIcon1 = new NotifyIcon(components);
            contextMenuStrip1 = new ContextMenuStrip(components);
            exitToolStripMenuItem = new ToolStripMenuItem();
            settingsToolStripMenuItem = new ToolStripMenuItem();
            pnlClock.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // lblDigitalTime
            // 
            lblDigitalTime.BackColor = Color.Transparent;
            lblDigitalTime.Font = new Font("Segoe UI", 84F);
            lblDigitalTime.ForeColor = Color.FromArgb(255, 192, 255);
            lblDigitalTime.Location = new Point(0, 27);
            lblDigitalTime.Name = "lblDigitalTime";
            lblDigitalTime.Size = new Size(500, 135);
            lblDigitalTime.TabIndex = 0;
            lblDigitalTime.Text = "00:00";
            lblDigitalTime.TextAlign = ContentAlignment.TopCenter;
            lblDigitalTime.UseCompatibleTextRendering = true;
            lblDigitalTime.MouseDown += pnlClock_MouseDown;
            lblDigitalTime.MouseMove += pnlClock_MouseMove;
            lblDigitalTime.MouseUp += pnlClock_MouseUp;
            // 
            // lblDate
            // 
            lblDate.BackColor = Color.Transparent;
            lblDate.Font = new Font("Segoe UI", 32F);
            lblDate.ForeColor = Color.FromArgb(255, 192, 255);
            lblDate.Location = new Point(0, 180);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(500, 80);
            lblDate.TabIndex = 1;
            lblDate.Text = "DDMMYY";
            lblDate.TextAlign = ContentAlignment.TopCenter;
            lblDate.UseCompatibleTextRendering = true;
            lblDate.MouseDown += pnlClock_MouseDown;
            lblDate.MouseMove += pnlClock_MouseMove;
            lblDate.MouseUp += pnlClock_MouseUp;
            // 
            // pnlClock
            // 
            pnlClock.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlClock.Controls.Add(lblDate);
            pnlClock.Controls.Add(lblDigitalTime);
            pnlClock.Location = new Point(50, 25);
            pnlClock.Name = "pnlClock";
            pnlClock.Size = new Size(500, 350);
            pnlClock.TabIndex = 2;
            pnlClock.MouseDown += pnlClock_MouseDown;
            pnlClock.MouseMove += pnlClock_MouseMove;
            pnlClock.MouseUp += pnlClock_MouseUp;
            // 
            // notifyIcon1
            // 
            notifyIcon1.ContextMenuStrip = contextMenuStrip1;
            notifyIcon1.Icon = (Icon)resources.GetObject("notifyIcon1.Icon");
            notifyIcon1.Text = "Clock";
            notifyIcon1.Visible = true;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { settingsToolStripMenuItem, exitToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(181, 70);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(180, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // settingsToolStripMenuItem
            // 
            settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            settingsToolStripMenuItem.Size = new Size(180, 22);
            settingsToolStripMenuItem.Text = "Settings";
            settingsToolStripMenuItem.Click += settingsToolStripMenuItem_Click;
            // 
            // frmClock
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(584, 361);
            Controls.Add(pnlClock);
            FormBorderStyle = FormBorderStyle.None;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmClock";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.Manual;
            Text = "Clock";
            TransparencyKey = Color.White;
            pnlClock.ResumeLayout(false);
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private Label lblDigitalTime;
        private Label lblDate;
        private Panel pnlClock;
        private NotifyIcon notifyIcon1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem settingsToolStripMenuItem;
    }
}
