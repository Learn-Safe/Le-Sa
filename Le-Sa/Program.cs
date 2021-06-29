using Le_Sa.Models.RandomString;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Security.Principal;
using System.Diagnostics;
using System.Threading;
using Le_Sa.Models.Copy;
using System.IO;
using System.Data.SqlClient;
using Le_Sa.Account;

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

            string db = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Sathsara\source\repos\sathsarabandaraj\Le-Sa\Le-Sa\Data\user.mdf;Integrated Security = True; Timeout=30";
            try
            {
                SqlConnection con = new SqlConnection(db);
                con.Open();
                SqlCommand countCommand = new SqlCommand("SELECT COUNT(*) FROM tbl_user", con);
                int count = int.Parse(countCommand.ExecuteScalar().ToString());
                if (count == 0)
                {
                    Application.Run(new formSignUp());
                }
                else
                {
                    Application.Run(new formLoadingScreen());
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}