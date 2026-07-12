namespace Clock
{
    partial class frmSettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSettings));
            pnlSettings = new Panel();
            lblTypographyExampleChars = new Label();
            lblTypographyExampleSentence = new Label();
            lblTypographyPreview = new Label();
            txtTypographyPreview = new TextBox();
            grpSettingsFooter = new GroupBox();
            picFolderIcon = new PictureBox();
            btnOpenFontFolder = new Button();
            grpUpdateFont = new GroupBox();
            lblSupportedFormats = new Label();
            txtExampleFont = new TextBox();
            btnBrowse = new Button();
            lblNewFont = new Label();
            grpCurrentConfiguration = new GroupBox();
            lblActiveFont = new Label();
            txtActiveFont = new TextBox();
            txtActivePath = new TextBox();
            lblActivePath = new Label();
            pnlSettings.SuspendLayout();
            grpSettingsFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picFolderIcon).BeginInit();
            grpUpdateFont.SuspendLayout();
            grpCurrentConfiguration.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSettings
            // 
            pnlSettings.Controls.Add(lblTypographyExampleChars);
            pnlSettings.Controls.Add(lblTypographyExampleSentence);
            pnlSettings.Controls.Add(lblTypographyPreview);
            pnlSettings.Controls.Add(txtTypographyPreview);
            pnlSettings.Controls.Add(grpSettingsFooter);
            pnlSettings.Controls.Add(grpUpdateFont);
            pnlSettings.Controls.Add(grpCurrentConfiguration);
            pnlSettings.Location = new Point(12, 12);
            pnlSettings.Name = "pnlSettings";
            pnlSettings.Size = new Size(560, 350);
            pnlSettings.TabIndex = 0;
            // 
            // lblTypographyExampleChars
            // 
            lblTypographyExampleChars.AutoSize = true;
            lblTypographyExampleChars.BackColor = Color.White;
            lblTypographyExampleChars.Location = new Point(188, 276);
            lblTypographyExampleChars.Name = "lblTypographyExampleChars";
            lblTypographyExampleChars.Size = new Size(193, 15);
            lblTypographyExampleChars.TabIndex = 16;
            lblTypographyExampleChars.Text = "AaBbCcDdEeFfGgHhIiJj 1234567890";
            // 
            // lblTypographyExampleSentence
            // 
            lblTypographyExampleSentence.AutoSize = true;
            lblTypographyExampleSentence.BackColor = Color.White;
            lblTypographyExampleSentence.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTypographyExampleSentence.Location = new Point(71, 236);
            lblTypographyExampleSentence.Name = "lblTypographyExampleSentence";
            lblTypographyExampleSentence.Size = new Size(434, 30);
            lblTypographyExampleSentence.TabIndex = 15;
            lblTypographyExampleSentence.Text = "The quick brown fox jumps over the lazy dog.";
            // 
            // lblTypographyPreview
            // 
            lblTypographyPreview.AutoSize = true;
            lblTypographyPreview.BackColor = Color.White;
            lblTypographyPreview.Location = new Point(225, 206);
            lblTypographyPreview.Name = "lblTypographyPreview";
            lblTypographyPreview.Size = new Size(114, 15);
            lblTypographyPreview.TabIndex = 14;
            lblTypographyPreview.Text = "Typography Preview";
            // 
            // txtTypographyPreview
            // 
            txtTypographyPreview.BackColor = Color.White;
            txtTypographyPreview.Enabled = false;
            txtTypographyPreview.Location = new Point(3, 191);
            txtTypographyPreview.Multiline = true;
            txtTypographyPreview.Name = "txtTypographyPreview";
            txtTypographyPreview.Size = new Size(550, 120);
            txtTypographyPreview.TabIndex = 13;
            // 
            // grpSettingsFooter
            // 
            grpSettingsFooter.Controls.Add(picFolderIcon);
            grpSettingsFooter.Controls.Add(btnOpenFontFolder);
            grpSettingsFooter.Location = new Point(0, 310);
            grpSettingsFooter.Name = "grpSettingsFooter";
            grpSettingsFooter.Size = new Size(560, 40);
            grpSettingsFooter.TabIndex = 12;
            grpSettingsFooter.TabStop = false;
            // 
            // picFolderIcon
            // 
            picFolderIcon.BackgroundImageLayout = ImageLayout.Zoom;
            picFolderIcon.Image = (Image)resources.GetObject("picFolderIcon.Image");
            picFolderIcon.InitialImage = (Image)resources.GetObject("picFolderIcon.InitialImage");
            picFolderIcon.Location = new Point(6, 10);
            picFolderIcon.Name = "picFolderIcon";
            picFolderIcon.Size = new Size(24, 24);
            picFolderIcon.SizeMode = PictureBoxSizeMode.Zoom;
            picFolderIcon.TabIndex = 14;
            picFolderIcon.TabStop = false;
            // 
            // btnOpenFontFolder
            // 
            btnOpenFontFolder.FlatAppearance.BorderSize = 0;
            btnOpenFontFolder.FlatStyle = FlatStyle.Flat;
            btnOpenFontFolder.Location = new Point(31, 11);
            btnOpenFontFolder.Name = "btnOpenFontFolder";
            btnOpenFontFolder.Size = new Size(110, 23);
            btnOpenFontFolder.TabIndex = 11;
            btnOpenFontFolder.Text = "Open Font Folder";
            btnOpenFontFolder.TextAlign = ContentAlignment.MiddleLeft;
            btnOpenFontFolder.UseVisualStyleBackColor = true;
            btnOpenFontFolder.Click += OpenFontFolder;
            // 
            // grpUpdateFont
            // 
            grpUpdateFont.Controls.Add(lblSupportedFormats);
            grpUpdateFont.Controls.Add(txtExampleFont);
            grpUpdateFont.Controls.Add(btnBrowse);
            grpUpdateFont.Controls.Add(lblNewFont);
            grpUpdateFont.Location = new Point(0, 105);
            grpUpdateFont.Name = "grpUpdateFont";
            grpUpdateFont.Size = new Size(550, 80);
            grpUpdateFont.TabIndex = 9;
            grpUpdateFont.TabStop = false;
            grpUpdateFont.Text = "Update Font";
            // 
            // lblSupportedFormats
            // 
            lblSupportedFormats.AutoSize = true;
            lblSupportedFormats.ForeColor = Color.DimGray;
            lblSupportedFormats.Location = new Point(112, 54);
            lblSupportedFormats.Name = "lblSupportedFormats";
            lblSupportedFormats.Size = new Size(127, 15);
            lblSupportedFormats.TabIndex = 10;
            lblSupportedFormats.Text = "Supported formats: .ttf";
            // 
            // txtExampleFont
            // 
            txtExampleFont.BackColor = Color.White;
            txtExampleFont.Enabled = false;
            txtExampleFont.Location = new Point(112, 28);
            txtExampleFont.Name = "txtExampleFont";
            txtExampleFont.PlaceholderText = "C:\\Example\\Path\\example_font.ttf";
            txtExampleFont.ReadOnly = true;
            txtExampleFont.ScrollBars = ScrollBars.Horizontal;
            txtExampleFont.Size = new Size(355, 23);
            txtExampleFont.TabIndex = 4;
            // 
            // btnBrowse
            // 
            btnBrowse.Location = new Point(472, 28);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(60, 23);
            btnBrowse.TabIndex = 1;
            btnBrowse.Text = "Browse";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // lblNewFont
            // 
            lblNewFont.AutoSize = true;
            lblNewFont.Location = new Point(47, 31);
            lblNewFont.Name = "lblNewFont";
            lblNewFont.Size = new Size(59, 15);
            lblNewFont.TabIndex = 4;
            lblNewFont.Text = "New font:";
            // 
            // grpCurrentConfiguration
            // 
            grpCurrentConfiguration.Controls.Add(lblActiveFont);
            grpCurrentConfiguration.Controls.Add(txtActiveFont);
            grpCurrentConfiguration.Controls.Add(txtActivePath);
            grpCurrentConfiguration.Controls.Add(lblActivePath);
            grpCurrentConfiguration.Location = new Point(0, 3);
            grpCurrentConfiguration.Name = "grpCurrentConfiguration";
            grpCurrentConfiguration.Size = new Size(550, 80);
            grpCurrentConfiguration.TabIndex = 8;
            grpCurrentConfiguration.TabStop = false;
            grpCurrentConfiguration.Text = "Current Configuration";
            // 
            // lblActiveFont
            // 
            lblActiveFont.AutoSize = true;
            lblActiveFont.Location = new Point(31, 25);
            lblActiveFont.Name = "lblActiveFont";
            lblActiveFont.Size = new Size(75, 15);
            lblActiveFont.TabIndex = 1;
            lblActiveFont.Text = "Current font:";
            // 
            // txtActiveFont
            // 
            txtActiveFont.BackColor = Color.White;
            txtActiveFont.Enabled = false;
            txtActiveFont.Location = new Point(112, 22);
            txtActiveFont.Name = "txtActiveFont";
            txtActiveFont.PlaceholderText = "Example Font";
            txtActiveFont.ReadOnly = true;
            txtActiveFont.ScrollBars = ScrollBars.Horizontal;
            txtActiveFont.Size = new Size(420, 23);
            txtActiveFont.TabIndex = 0;
            // 
            // txtActivePath
            // 
            txtActivePath.BackColor = Color.White;
            txtActivePath.Enabled = false;
            txtActivePath.Location = new Point(112, 51);
            txtActivePath.Multiline = true;
            txtActivePath.Name = "txtActivePath";
            txtActivePath.PlaceholderText = "C:\\Example\\Path\\example_font.ttf";
            txtActivePath.ReadOnly = true;
            txtActivePath.ScrollBars = ScrollBars.Horizontal;
            txtActivePath.Size = new Size(420, 23);
            txtActivePath.TabIndex = 2;
            // 
            // lblActivePath
            // 
            lblActivePath.AutoSize = true;
            lblActivePath.Location = new Point(31, 54);
            lblActivePath.Name = "lblActivePath";
            lblActivePath.Size = new Size(77, 15);
            lblActivePath.TabIndex = 3;
            lblActivePath.Text = "Current path:";
            // 
            // frmSettings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(584, 361);
            Controls.Add(pnlSettings);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmSettings";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Font Settings";
            pnlSettings.ResumeLayout(false);
            pnlSettings.PerformLayout();
            grpSettingsFooter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picFolderIcon).EndInit();
            grpUpdateFont.ResumeLayout(false);
            grpUpdateFont.PerformLayout();
            grpCurrentConfiguration.ResumeLayout(false);
            grpCurrentConfiguration.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlSettings;
        private Label lblActivePath;
        private TextBox txtActivePath;
        private Label lblActiveFont;
        private TextBox txtActiveFont;
        private Button btnBrowse;
        private Label lblNewFont;
        private GroupBox grpUpdateFont;
        private GroupBox grpCurrentConfiguration;
        private Button btnOpenFontFolder;
        private Label lblSupportedFormats;
        private TextBox txtExampleFont;
        private GroupBox grpSettingsFooter;
        private PictureBox picFolderIcon;
        private Label lblTypographyExampleSentence;
        private Label lblTypographyPreview;
        private TextBox txtTypographyPreview;
        private Label lblTypographyExampleChars;
    }
}