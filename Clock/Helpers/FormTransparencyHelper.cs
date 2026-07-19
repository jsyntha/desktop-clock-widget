using System;
using System.Collections.Generic;
using System.Text;

namespace Clock.Helpers
{
    public class FormTransparencyHelper
    {
        private readonly Form _parentForm;
        private readonly Color _charcoalGrey = Color.FromArgb(60, 56, 66);

        public FormTransparencyHelper(Form parentForm)
        {
            _parentForm = parentForm;
        }

        public void CheckAndSetTransparency(Color fontColor)
        {
            if ((fontColor.R + fontColor.G + fontColor.B) > 382)
            {
                _parentForm.TransparencyKey = Color.Black;
                _parentForm.BackColor = Color.Black;
            }
            else
            {
                _parentForm.TransparencyKey = _charcoalGrey;
                _parentForm.BackColor = _charcoalGrey;
            }
        }
    }
}