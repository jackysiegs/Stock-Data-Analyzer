using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stock_Data_Analyzer
{
    internal static class Program
    {
        /// Inspired by Dr. Henrick Jeanty
        /// Main function
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new formLoader());
        }
    }
}
