using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Le_Sa.Models.Hashing;
using FireSharp.Response;
using FireSharp.Config;
using FireSharp.Interfaces;
using Le_Sa.Models.RandomString;

namespace Le_Sa.Account
{
    public partial class formCreateNewPassword : Form
    {
        IFirebaseClient client;
        private static string inputUsername;

        public formCreateNewPassword()
        {
            InitializeComponent();
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 15, 15));
            inputUsername = formForgotPassword.inputUsername;
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

        private void formCreateNewPassword_Load(object sender, EventArgs e)
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

        readonly IFirebaseConfig ifc = new FirebaseConfig()
        {
            AuthSecret = "K9Ul4asnJqIMFlBlpm0AkjcEnwWagBxs4Iy0xZes",
            BasePath = "https://le-sa-f718d-default-rtdb.firebaseio.com/"
        };

        #region New Password
        private void crBtnGeneratePassword_Click(object sender, EventArgs e)
        {
            string generatedPass = RandomStringGenerator.GenerateRandomString(14, true, true, true, true);
            cTBNewPassword.Texts = generatedPass;
            cTBConfPassword.Texts = generatedPass;
            StrengthCheck();
        }

        private void crBtnPassVisibility_MouseDown(object sender, MouseEventArgs e)
        {
            cTBNewPassword.PasswordChar = false;
            cTBConfPassword.PasswordChar = false;
            crBtnPassVisibility.Image = Properties.Resources.show_22px;
            crBtnConfPassVisibility.Image = Properties.Resources.show_22px;
        }

        private void crBtnPassVisibility_MouseUp(object sender, MouseEventArgs e)
        {
            cTBNewPassword.PasswordChar = true;
            cTBConfPassword.PasswordChar = true;
            crBtnPassVisibility.Image = Properties.Resources.hide_22px;
            crBtnConfPassVisibility.Image = Properties.Resources.hide_22px;
        }

        #region Strength
        private void StrengthCheck()
        {
            int passwordScore = CheckString.StrengthScore(cTBNewPassword.Texts, true, true, true, true);
            (string strengthLevel, Color strengthColor) = (CheckString.StrengthNaming(passwordScore).Item1, CheckString.StrengthNaming(passwordScore).Item2);
            lblStrength.Text = strengthLevel;
            lblStrength.ForeColor = strengthColor;
            lblStrength.Visible = true;
        }

        private void crBtnStrength_Click(object sender, EventArgs e)
        {
            if (cTBNewPassword.Texts == "" || cTBConfPassword.Texts == "")
            {
                lblStrength.Visible = false;
                MessageBox.Show("Please fill password fields before strength check", "Fields are empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cTBNewPassword.Texts != cTBConfPassword.Texts)
            {
                lblStrength.Visible = false;
                MessageBox.Show("Passwords didn't match!", "Confirmation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                StrengthCheck();
            }
        }
        #endregion

        #endregion

        private void crBtnChangePassword_Click(object sender, EventArgs e)
        {
            string hashedPassword = Hashing.ToSHA512(cTBNewPassword.Texts);
            if (cTBNewPassword.Texts != cTBConfPassword.Texts)
            {
                MessageBox.Show("Passwords didn't match!", "Confirmation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (hashedPassword == Properties.Settings.Default.password)
            {
                MessageBox.Show("You can't use your current password.\r\nYou need to choose a new password or you can login to your account by closing this window.");
            }
            else
            {
                try
                {
                    FirebaseResponse res = client.Get($@"users/{inputUsername}");
                    User ResUser = res.ResultAs<User>();

                    User resetPass = new User()
                    {
                        username = ResUser.username,
                        password = hashedPassword,
                        email = ResUser.email,
                        phone_no = ResUser.phone_no,
                        status = ResUser.status,
                        start = ResUser.start,
                        duration = ResUser.duration,
                        login_count = ResUser.login_count
                    };

                    Properties.Settings.Default.username = ResUser.username;
                    Properties.Settings.Default.Save();
                    Properties.Settings.Default.password = hashedPassword;
                    Properties.Settings.Default.Save();
                    Properties.Settings.Default.phoneNo = ResUser.phone_no;
                    Properties.Settings.Default.Save();
                    Properties.Settings.Default.email = ResUser.email;
                    Properties.Settings.Default.Save();

                    SetResponse set = client.Set($@"users/{ResUser.username}", resetPass);

                    MessageBox.Show("Password resetted successfully.\r\nNow you can login using new password", "Sucessful", MessageBoxButtons.OK);

                    formLogin login = new formLogin();
                    login.Show();
                    this.Hide();
                }
                catch (Exception fireError)
                {
                    MessageBox.Show(fireError.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            formLogin loginForm = new formLogin();
            loginForm.Show();
            this.Close();
        }
    }
}
