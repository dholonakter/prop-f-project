using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
// RFID DLL
using Phidget22;
using Phidget22.Events;

namespace ShopApp
{
    static class Program
    {
        static internal Login original;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            original = new Login();
            Application.Run(original);
        }
    }
}
