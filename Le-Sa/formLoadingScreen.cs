using Le_Sa.Account;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Le_Sa
{
    public partial class formLoadingScreen : Form
    {
        public formLoadingScreen()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private readonly string db = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Sathsara\source\repos\sathsarabandaraj\Le-Sa\Le-Sa\Data\user.mdf;Integrated Security = True; Timeout=30";

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );

        private void timerLoading_Tick(object sender, EventArgs e)
        {
            pnlLoadingFront.Width += 8;
            if (pnlLoadingFront.Width >= 925)
            {
                timerLoading.Stop();
            }
        }

        private void crBtnContinue_Click(object sender, EventArgs e)
        {
            if (cTBUsername.Texts == "" || cTBPassword.Texts == "")
            {
                MessageBox.Show("Please enter USERNAME and PASSWORD", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                SqlConnection con = new SqlConnection(db);
                con.Open();
                SqlCommand uname = new SqlCommand("SELECT username FROM tbl_user WHERE username = '" + cTBUsername.Texts + "'", con); //Checks if the USERNAME is in the database
                string username = uname.ExecuteScalar() as string;
                con.Close();
                if (cTBUsername.Texts.Equals(username))
                {
                    con.Open();
                    SqlCommand pass = new SqlCommand("SELECT password FROM tbl_user WHERE username = '" + cTBUsername.Texts + "'", con);//Checks if the PASSWORD entered is similar to the PASSWORD of the USERNAME checked from the database  
                    string password = pass.ExecuteScalar() as string;
                    con.Close();
                    if (cTBPassword.Texts.Equals(password))
                    {
                        formDesktop desktop = new formDesktop();
                        desktop.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Wrong USERNAME or PASSWORD", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Wrong USERNAME or PASSWORD", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); 
                }
            }
        }

        private void crBtnVisibility_MouseDown(object sender, MouseEventArgs e)
        {
            crBtnVisibility.Image = Properties.Resources.show_22px;
            cTBPassword.PasswordChar = false;
        }

        private void crBtnVisibility_MouseUp(object sender, MouseEventArgs e)
        {
            crBtnVisibility.Image = Properties.Resources.hide_22px;
            cTBPassword.PasswordChar = true;
        }
    }
}
