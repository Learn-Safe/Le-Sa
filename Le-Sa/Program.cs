using Le_Sa.Models.RandomString;
using System;
using System.IO;
using System.Data.SqlClient;
using Le_Sa.Account;
using Le_Sa.BrowserControls;
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
            Application.Run(new formLoadingScreen());
        }
    }
}