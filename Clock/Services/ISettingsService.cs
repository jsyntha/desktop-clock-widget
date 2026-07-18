using System;
using System.Collections.Generic;
using System.Text;

namespace Clock.Services
{
    public interface ISettingsService
    {
        Point LoadSettings(Point location);
        void SaveSettings(Point location);
    }
}
