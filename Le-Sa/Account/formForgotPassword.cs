using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using Le_Sa.Models.Email;
using Le_Sa.Models.Hashing;
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

namespace Le_Sa.Account
{
    public partial class formForgotPassword : Form
    {
        System.Timers.Timer tmrOTP;
        private string otp;
        private int sec = 00;
        private int min = 05;
        IFirebaseClient client;
        private string emailAddress;

        public formForgotPassword()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 15, 15));
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


        private void formForgotPassword_Load(object sender, EventArgs e)
        {
            try
            {
                client = new FireSharp.FirebaseClient(ifc);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            tmrOTP = new System.Timers.Timer
            {
                Interval = 1000//1s
            };
            tmrOTP.Elapsed += OnTimeEvent;
        }

        #region Timer Event
        private void OnTimeEvent(object sender, System.Timers.ElapsedEventArgs e)
        {

            Invoke(new Action(() =>
            {
                sec -= 1;
                if (min != 00 && sec == 00 || min > 00 && sec == -01)
                {
                    sec = 59;
                    min -= 1;
                }
                if (min == 00 && sec == -01)
                {
                    tmrOTP.Stop();
                    crBtnResendOTP.Visible = false;
                    otp = null;
                    MessageBox.Show("OTP that sent to you is expired. You can't use it anymore." + Environment.NewLine + " You can get a new otp now.", "OTP expired", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lblOTPTimer.Visible = false;
                    min = 05;
                    sec = 00;
                    cTBUsername.Enabled = true;
                    crBtnSendOTP.Enabled = true;
                }
                //Update lable in every sec
                lblOTPTimer.Text = string.Format("{0}:{1}", min.ToString().PadLeft(2, '0'), sec.ToString().PadLeft(2, '0'));
            }));
        }
        #endregion

        #region OTP
        private void crBtnSendOTP_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cTBUsername.Texts))
            {
                MessageBox.Show("Please fill Username fields for get OTP", "Fields are empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                const string usernameChars = @"ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789._";
                if (cTBUsername.Texts.IndexOfAny(usernameChars.ToCharArray()) == -1)
                {
                    MessageBox.Show("Sorry, only letters (a-z , A-Z), numbers (0-9), underscore( _ ), and periods (.) are allowed for Username.", "Username contains an illegal character", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    crBtnSendOTP.Enabled = false;
                    cTBUsername.Enabled = false;
                    otp = RandomStringGenerator.GenerateRandomString(6, true, false, true, false);
                    try
                    {
                        FirebaseResponse res = client.Get(@"users/" + cTBUsername.Texts);
                        User ResUser = res.ResultAs<User>();
                        User UserInput = new User() // USER INPUT
                        {
                            username = cTBUsername.Texts
                        };
                        emailAddress = User.userEmail(ResUser, UserInput);
                    }
                    catch (Exception fireError)
                    {
                        MessageBox.Show(fireError.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    bool sendMsg = Email.SendMsg(emailAddress, "Le-Sa", "Use this One Time Password to reset your current password 👉 " + otp + " 👈");
                    if (sendMsg)
                    {
                        lblOTPTimer.Visible = true;
                        tmrOTP.Start();
                        crBtnResendOTP.Visible = true;
                        MessageBox.Show("OTP Sent successfully to your email address (" + HideEmailAddress(emailAddress) + ")" + Environment.NewLine + Environment.NewLine + "Please Check your inbox", "OTP Sent", MessageBoxButtons.OK);
                        crBtnResendOTP.Visible = true;
                    }
                    else
                    {
                        tmrOTP.Stop();
                        otp = null;
                        sec = 00;
                        min = 05;
                        lblOTPTimer.Visible = false;
                        crBtnResendOTP.Visible = false;
                        cTBUsername.Enabled = true;
                        crBtnSendOTP.Enabled = true;
                    }
                }
            }
        }

        private void crBtnResendOTP_Click(object sender, EventArgs e)
        {
            bool sendMsg = Email.SendMsg(emailAddress, "Le-Sa", "Use this One Time Password to reset your current password 👉 " + otp + " 👈");

            if (sendMsg)
            {
                MessageBox.Show("OTP Sent successfully to your email address (" + HideEmailAddress(emailAddress) + ")"  + Environment.NewLine + "Please check your spam or junk mail if you not received it within the next 2 minutes");
            }
            else
            {
                tmrOTP.Stop();
                otp = null;
                sec = 00;
                min = 05;
                lblOTPTimer.Visible = false;
                crBtnResendOTP.Visible = false;
                cTBUsername.Enabled = true;
                crBtnSendOTP.Enabled = true;
            }
        }
        #endregion

        #region Hide Part of Email Address
        private string HideEmailAddress(string email)
        {
            string localPart = (email.Split('@')[0]);
            string domainPart = (email.Split('@')[1]);
            int localLength = localPart.Length;
            string showenPart = email.Substring(0, (int)Math.Round(((double)localLength) / 3));
            int hiddenLength = localLength - (int)Math.Round((double)localLength / 3);
            string hiddenEmail = showenPart + string.Concat(Enumerable.Repeat("*", hiddenLength))+ "@" + domainPart;
            return hiddenEmail;
        }
        #endregion

        #region Verify Acc
        private void crBtnContinue_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cTBUsername.Texts) || string.IsNullOrEmpty(cTBOTP.Texts))
            {
                MessageBox.Show("Please fill all fileds and verify your account before continue", "Fields are empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }else if (cTBOTP.Texts != otp)
            {
                MessageBox.Show("OTP didn't match!", "Confirmation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (otp == null)
            {
                MessageBox.Show("OTP that sent to you is expired. You can't use it anymore." + Environment.NewLine + " You can get a new otp now.", "OTP expired", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                tmrOTP.Stop();
                cTBUsername.Enabled = false;
                cTBOTP.Enabled = false;
                crBtnContinue.Visible = false;
                this.Width += 20;
                pnlContent.AutoScroll = true;
                pnlContent.AutoScrollPosition = new Point(0, 210);
            }
        }
        #endregion

        #region Reset Password
        private void crBtnChangePassword_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cTBUsername.Texts) || string.IsNullOrEmpty(cTBOTP.Texts) || string.IsNullOrEmpty(cTBUsername.Texts) || string.IsNullOrEmpty(cTBUsername.Texts))
            {
                MessageBox.Show("Please fill all fields", "Fields are empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cTBNewPassword.Texts != cTBConfPassword.Texts)
            {
                MessageBox.Show("Passwords didn't match!", "Confirmation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    FirebaseResponse res = client.Get(@"users/" + cTBUsername.Texts);
                    User ResUser = res.ResultAs<User>();

                    string hashedPassword = Hashing.ToSHA512(cTBNewPassword.Texts);
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

                    SetResponse set = client.Set(@"users/" + ResUser.username, resetPass);

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
        #endregion

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

        private void crBtnConfPassVisibility_MouseUp(object sender, MouseEventArgs e)
        {
            cTBNewPassword.PasswordChar = true;
            cTBConfPassword.PasswordChar = true;
            crBtnPassVisibility.Image = Properties.Resources.hide_22px;
            crBtnConfPassVisibility.Image = Properties.Resources.hide_22px;
        }

        #region Strength
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

        private void StrengthCheck()
        {
            int passwordScore = CheckString.StrengthScore(cTBNewPassword.Texts, true, true, true, true);
            (string strengthLevel, Color strengthColor) = (CheckString.StrengthNaming(passwordScore).Item1, CheckString.StrengthNaming(passwordScore).Item2);
            lblStrength.Text = strengthLevel;
            lblStrength.ForeColor = strengthColor;
            lblStrength.Visible = true;
        }
        #endregion

        #endregion

        private void crBrnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}