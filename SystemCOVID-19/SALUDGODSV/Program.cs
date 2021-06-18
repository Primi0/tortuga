using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SALUDGODSV.View;
using System.Windows.Forms;

namespace SALUDGODSV
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AppointmentSystem());
        }
    }
}
