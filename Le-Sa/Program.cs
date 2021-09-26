using Le_Sa.Models.AdminCheck;
using System;
using System.Windows.Forms;

namespace Le_Sa
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (AdminCheck.IsAdmin())
            {
                Application.Run(new formLoadingScreen());
            }
            else
            {
                AdminCheck.RestartUnderAdmin();
            }
        }
    }
}