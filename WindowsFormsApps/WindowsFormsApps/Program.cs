using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApps
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new frmPhepTinhCoBan());
            //Application.Run(new frmLopHoc());
            //Application.Run(new frmUser());
            //Application.Run(new frmManageUser());
            Application.Run(new frmTimer());
        }
    }
}
