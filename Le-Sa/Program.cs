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
            Application.ApplicationExit += new EventHandler(Application_ApplicationExit);
            AppDomain.CurrentDomain.ProcessExit += new EventHandler(CurrentDomain_ProcessExit);
            if (AdminCheck.IsAdmin())
            {
                Application.Run(new formDesktop());
            }
            else
            {
                AdminCheck.RestartUnderAdmin();
            }
        }

        private static void CurrentDomain_ProcessExit(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private static void Application_ApplicationExit(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}