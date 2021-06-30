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

            string fileName = Directory.GetCurrentDirectory() + @"\Data\user.mdf";
            string db = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=" + fileName + "; Integrated Security = True; Timeout=30";
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