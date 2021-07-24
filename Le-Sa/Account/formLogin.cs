using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using Newtonsoft.Json;
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

        readonly IFirebaseConfig ifc = new FirebaseConfig()
        {
            AuthSecret = "K9Ul4asnJqIMFlBlpm0AkjcEnwWagBxs4Iy0xZes",
            BasePath = "https://le-sa-f718d-default-rtdb.firebaseio.com/"
        };

        IFirebaseClient client;

        private void formLogin_Load(object sender, EventArgs e)
        {
            try
            {
                client = new FireSharp.FirebaseClient(ifc);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void crBtnContinue_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cTBUsername.Texts) || string.IsNullOrEmpty(cTBPassword.Texts))
            {
                MessageBox.Show("Please enter USERNAME and PASSWORD", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                FirebaseResponse res = client.Get(@"Users/" + cTBUsername.Texts);
                User ResUser = res.ResultAs<User>();
                User UserInput = new User() // USER INPUT
                {
                    username = cTBUsername.Texts,
                    password = cTBPassword.Texts
                };

                if (User.IsEqual(ResUser, UserInput))
                {
                    formDesktop desktop = new formDesktop();
                    desktop.Show();
                    this.Hide();
                }

                else
                {
                    User.ShowError();
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
