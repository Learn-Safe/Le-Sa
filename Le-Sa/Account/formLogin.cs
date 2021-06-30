using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Le_Sa.Account
{ 
    public partial class formLogin : Form
    {
        public formLogin()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
           Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private static readonly string fileName = Directory.GetCurrentDirectory() + @"\Data\user.mdf";
        private static readonly string db = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename=" + fileName + ";Integrated Security = True; Timeout=30";

        #region Rounded Corner
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
        #endregion

        private void crBtnContinue_Click(object sender, EventArgs e)
        {
            if (cTBUsername.Texts == "" || cTBPassword.Texts == "")
            {
                login_error("Please enter USERNAME and PASSWORD", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                        MessageBox.Show("Wrong USERNAME or PASSWORD", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); //This messagebox appear if enter wrong PASSWORD
                    }
                }
                else
                {
                    MessageBox.Show("Wrong USERNAME or PASSWORD", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); //This messagebox appear if enter wrong USERNAME
                }
            }
        }

        private void login_error(string message, string caption,MessageBoxButtons buttons, MessageBoxIcon icon)
        {
            MessageBox.Show(message, caption, buttons, icon); //This messagebox appear if enter wrong credentials
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
