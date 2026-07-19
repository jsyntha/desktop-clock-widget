using System;
using System.Collections.Generic;
using System.Text;

namespace Clock.Helpers
{
    public class FormColourHelper
    {
        private readonly Form _parentForm;
        private static readonly Color _charcoalGrey = Color.FromArgb(60, 56, 66);
        private const int _brightnessThreshold = 382;

        public FormColourHelper(Form parentForm)
        {
            _parentForm = parentForm;
        }

        public static Color GetContrastingBackground(Color fontColor)
        {
            if ((fontColor.R + fontColor.G + fontColor.B) > _brightnessThreshold)
            {
                return Color.Black;
            }
            else
            {
                return _charcoalGrey;
            }
        }

        public void CheckAndSetTransparencyKey(Color fontColour)
        {
            Color background = GetContrastingBackground(fontColour);

            _parentForm.TransparencyKey = background;
            _parentForm.BackColor = background;
        }
    }
}