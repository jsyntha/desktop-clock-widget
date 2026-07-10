using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Clock
{
    public partial class frmSettings : Form
    {
        frmClock clockForm = new frmClock();
        public frmSettings()
        {
            InitializeComponent();

            txtActiveFont.Text = $"{clockForm.FontName}";
            txtActivePath.Text = $"{clockForm.FontPath}";
        }
    }
}
