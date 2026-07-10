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
            pnlSettings = new Panel();
            lblActivePath = new Label();
            txtActivePath = new TextBox();
            lblActiveFont = new Label();
            txtActiveFont = new TextBox();
            pnlSettings.SuspendLayout();
            SuspendLayout();
            // 
            // pnlSettings
            // 
            pnlSettings.Controls.Add(lblActivePath);
            pnlSettings.Controls.Add(txtActivePath);
            pnlSettings.Controls.Add(lblActiveFont);
            pnlSettings.Controls.Add(txtActiveFont);
            pnlSettings.Location = new Point(12, 12);
            pnlSettings.Name = "pnlSettings";
            pnlSettings.Size = new Size(450, 250);
            pnlSettings.TabIndex = 0;
            // 
            // lblActivePath
            // 
            lblActivePath.AutoSize = true;
            lblActivePath.Location = new Point(3, 32);
            lblActivePath.Name = "lblActivePath";
            lblActivePath.Size = new Size(70, 15);
            lblActivePath.TabIndex = 3;
            lblActivePath.Text = "Active path:";
            // 
            // txtActivePath
            // 
            txtActivePath.BackColor = Color.White;
            txtActivePath.Enabled = false;
            txtActivePath.Location = new Point(77, 29);
            txtActivePath.Multiline = true;
            txtActivePath.Name = "txtActivePath";
            txtActivePath.PlaceholderText = "Unknown";
            txtActivePath.Size = new Size(350, 50);
            txtActivePath.TabIndex = 2;
            txtActivePath.TextAlign = HorizontalAlignment.Center;
            // 
            // lblActiveFont
            // 
            lblActiveFont.AutoSize = true;
            lblActiveFont.Location = new Point(3, 6);
            lblActiveFont.Name = "lblActiveFont";
            lblActiveFont.Size = new Size(68, 15);
            lblActiveFont.TabIndex = 1;
            lblActiveFont.Text = "Active font:";
            // 
            // txtActiveFont
            // 
            txtActiveFont.BackColor = Color.White;
            txtActiveFont.Enabled = false;
            txtActiveFont.Location = new Point(77, 3);
            txtActiveFont.Name = "txtActiveFont";
            txtActiveFont.PlaceholderText = "Unknown";
            txtActiveFont.Size = new Size(350, 23);
            txtActiveFont.TabIndex = 0;
            txtActiveFont.TextAlign = HorizontalAlignment.Center;
            // 
            // frmSettings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 261);
            Controls.Add(pnlSettings);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "frmSettings";
            Text = "frmSettings";
            pnlSettings.ResumeLayout(false);
            pnlSettings.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlSettings;
        private Label lblActivePath;
        private TextBox txtActivePath;
        private Label lblActiveFont;
        private TextBox txtActiveFont;
    }
}