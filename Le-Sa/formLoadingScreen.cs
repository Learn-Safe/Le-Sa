using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using Le_Sa.Account;
using Le_Sa.Models.Hashing;
using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Le_Sa
{
    public partial class formLoadingScreen : Form
    {
        public formLoadingScreen()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        #region Round Corners
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

        private void timerLoading_Tick(object sender, EventArgs e)
        {
            pnlLoadingFront.Width += 8;
            if (pnlLoadingFront.Width >= 925)
            {
                timerLoading.Stop();
            }
        }

        private void formLoadingScreen_Load(object sender, EventArgs e)
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
            if (cTBUsername.Texts == "" || cTBPassword.Texts == "")
            {
                MessageBox.Show("Please enter USERNAME and PASSWORD", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    FirebaseResponse res = client.Get(@"users/" + cTBUsername.Texts);
                    User ResUser = res.ResultAs<User>();

                    /*File.WriteAllText(@"C:\Users\saths\Desktop\user.json", JsonConvert.SerializeObject(ResUser));

                    // serialize JSON directly to a file
                    using (StreamWriter file = File.CreateText(@"C:\Users\saths\Desktop\user.json"))
                    {
                        JsonSerializer serializer = new JsonSerializer();
                        serializer.Serialize(file, ResUser);
                    }*/

                    string hashedPassword = Hashing.ToSHA512(cTBPassword.Texts);
                    User UserInput = new User() // USER INPUT
                    {
                        username = cTBUsername.Texts,
                        password = hashedPassword
                    };

                    if (User.IsEqual(ResUser, UserInput))
                    {
                        Properties.Settings.Default.username = ResUser.username;
                        Properties.Settings.Default.Save();
                        Properties.Settings.Default.password = hashedPassword;
                        Properties.Settings.Default.Save();
                        Properties.Settings.Default.phoneNo = ResUser.phone_no;
                        Properties.Settings.Default.Save();
                        Properties.Settings.Default.email = ResUser.email;
                        Properties.Settings.Default.Save();

                        formDesktop desktop = new formDesktop();
                        desktop.Show();
                        this.Hide();
                    }

                    else
                    {
                        User.ShowError();
                    }
                }
                catch (Exception fireError)
                {
                    MessageBox.Show(fireError.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void llblHaveAnAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            formSignUp signUp = new formSignUp();
            signUp.Show();
            this.Hide();
        }

        private void llblForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            formForgotPassword forgotPass = new formForgotPassword();
            forgotPass.Show();
            this.Hide();
        }
    }
}
