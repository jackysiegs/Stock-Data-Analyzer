using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stock_Data_Analyzer
{
    /// Class to help manage darkmode/lightmode
    public static class ThemeManager
    {
        public static bool IsDarkMode { get; private set; } = false;


        public delegate void ThemeChangedEventHandler(bool isDarkMode);
        public static event ThemeChangedEventHandler OnThemeChanged;

        public static void ToggleTheme()
        {
            IsDarkMode = !IsDarkMode;
            OnThemeChanged?.Invoke(IsDarkMode);
        }

        public static bool GetCurrentDarkModeStatus()
        {
            if (IsDarkMode)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

}
