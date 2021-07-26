using Le_Sa.Models.RandomString;
using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Le_Sa.Models.Copy;
using System.IO;
using Le_Sa.Models.Email;
using FireSharp.Response;
using FireSharp.Interfaces;
using FireSharp.Config;

namespace Le_Sa.Account
{
    public partial class formSignUp : Form
    {
        private string otp;
        private int sec = 59;
        private int min = 04;
        private string source;
        private string ImageLoc;
        private Point lastPoint;
        System.Timers.Timer tmrOTP;
        private string destinationFile;
        private string destinationPath;

        public formSignUp()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        readonly IFirebaseConfig ifc = new FirebaseConfig()
        {
            AuthSecret = "K9Ul4asnJqIMFlBlpm0AkjcEnwWagBxs4Iy0xZes",
            BasePath = "https://le-sa-f718d-default-rtdb.firebaseio.com/"
        };
        IFirebaseClient client;

        private void formSignUp_Load(object sender, EventArgs e)
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

        private void llblHaveAnAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            formLogin login = new formLogin();
            login.Show();
            this.Hide();
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
                    min = 05;
                    sec = 00;
                    cTBEmail.Enabled = true;
                    crBtnSendOTP.Enabled = true;
                }
                //Update lable
                lblOTPTimer.Text = string.Format("{0}:{1}", min.ToString().PadLeft(2, '0'), sec.ToString().PadLeft(2, '0'));
            }));
        }
        #endregion

        #region OTP
        private void crBtnSendOTP_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cTBEmail.Texts))
            {
                MessageBox.Show("Please fill Email fields before strength check", "Fields are empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                crBtnSendOTP.Enabled = false;
                cTBEmail.Enabled = false;
                otp = RandomStringGenerator.GenerateRandomString(6, true, false, true, false);
                bool sendMsg = Email.SendMsg(cTBEmail.Texts, "Le-Sa", "Use this One Time Password to verify your account 👉 " + otp + " 👈");

                if (sendMsg == true)
                {
                    tmrOTP.Start();
                    MessageBox.Show("OTP Sent successfully to your email address (" + cTBEmail.Texts + ")" + Environment.NewLine + Environment.NewLine + "Please Check your inbox", "OTP Sent", MessageBoxButtons.OK);
                    crBtnResendOTP.Visible = true;
                }
                else
                {
                    cTBEmail.Enabled = true;
                    crBtnSendOTP.Enabled = true;
                }
            }
        }

        private void crBtnResendOTP_Click(object sender, EventArgs e)
        {
            bool sendMsg = Email.SendMsg(cTBEmail.Texts, "Le-Sa", "Use this One Time Password to verify your account 👉 " + otp + " 👈");

            if (sendMsg == true)
            {
                MessageBox.Show("OTP Sent successfully to your email address ( " + cTBEmail.Texts + " )" + Environment.NewLine + "Please Check your inbox" + Environment.NewLine + "Please check your spam or junk mail if you not received it within the next 2 minutes");
            }
            else
            {
                cTBEmail.Enabled = true;
                crBtnSendOTP.Enabled = true;
            }
        }
        #endregion

        #region DP
        private void crBtnRemovwDP_Click(object sender, EventArgs e)
        {
            crPBDP.Image = Properties.Resources.user_90px;
            try
            {
                File.Delete(ImageLoc);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void crBtnDP_Click(object sender, EventArgs e)
        {
            OpenFileDialog dp = new OpenFileDialog
            {
                Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png"
            };
            if (dp.ShowDialog() == DialogResult.OK)
            {
                source = dp.FileName.ToString();
                destinationPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\Le-Sa\User Data\DP\";
                destinationFile = "DP";
                crPBDP.SizeMode = PictureBoxSizeMode.StretchImage;

                Copy.CopyFile(null, source, destinationPath, destinationFile);
                ImageLoc = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\Le-Sa\User Data\DP\DP";
                crPBDP.Image = new Bitmap(ImageLoc);
            }
        }
        #endregion

        #region Password

        private void crBtnGeneratePassword_Click(object sender, EventArgs e)
        {
            string generatedPass = RandomStringGenerator.GenerateRandomString(14, true, true, true, true);
            cTBPassword.Texts = generatedPass;
            cTBConfPass.Texts = generatedPass;
        }

        private void crBtnPassVisibility_MouseDown(object sender, MouseEventArgs e)
        {
            PasscharDisabled();
        }

        private void crBtnPassVisibility_MouseUp(object sender, MouseEventArgs e)
        {
            PasscharEnabled();
        }

        private void crBtnConfPassVisibility_MouseDown(object sender, MouseEventArgs e)
        {
            PasscharDisabled();
        }

        private void crBtnConfPassVisibility_MouseUp(object sender, MouseEventArgs e)
        {
            PasscharEnabled();
        }

        private void PasscharDisabled()
        {
            cTBPassword.PasswordChar = false;
            cTBConfPass.PasswordChar = false;
            crBtnPassVisibility.Image = Properties.Resources.show_22px;
            crBtnConfPassVisibility.Image = Properties.Resources.show_22px;
        }

        private void PasscharEnabled()
        {
            cTBPassword.PasswordChar = true;
            cTBConfPass.PasswordChar = true;
            crBtnPassVisibility.Image = Properties.Resources.hide_22px;
            crBtnConfPassVisibility.Image = Properties.Resources.hide_22px;
        }

        #region Password Strength
        private void crBtnStrength_Click(object sender, EventArgs e)
        {
            if (cTBPassword.Texts == "" || cTBConfPass.Texts == "")
            {
                lblStrength.Visible = false;
                MessageBox.Show("Please fill password fields before strength check", "Fields are empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cTBPassword.Texts != cTBConfPass.Texts)
            {
                lblStrength.Visible = false;
                MessageBox.Show("Passwords didn't match!", "Confirmation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int passwordScore = CheckString.StrengthScore(cTBPassword.Texts, true, true, true, true);
                (string strengthLevel, Color strengthColor) = (CheckString.StrengthNaming(passwordScore).Item1, CheckString.StrengthNaming(passwordScore).Item2);
                lblStrength.Text = strengthLevel;
                lblStrength.ForeColor = strengthColor;
                lblStrength.Visible = true;
            }
        }
        #endregion

        #endregion

        #region Clear
        private void cBtnClear_Click(object sender, EventArgs e)
        {
            cTBUsername.Texts = "";
            cTBPassword.Texts = "";
            cTBConfPass.Texts = "";
            cTBPhoneNumber.Texts = "";
            cTBEmail.Texts = "";
            cTBOTP.Texts = "";
            otp = null;

            lblOTPTimer.Text = "00:00";
            crBtnResendOTP.Visible = false;
            crBtnSendOTP.Enabled = true;
            cTBEmail.Enabled = true;
            lblStrength.Visible = false;
        }
        #endregion

        #region Create account
        private void crBtnContinue_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cTBUsername.Texts) || string.IsNullOrEmpty(cTBPassword.Texts) || string.IsNullOrEmpty(cTBConfPass.Texts) || string.IsNullOrEmpty(cTBEmail.Texts) || string.IsNullOrEmpty(cTBPhoneNumber.Texts) || string.IsNullOrEmpty(cTBOTP.Texts))
            {
                MessageBox.Show("Please fill all fields", "Fields are empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (cTBUsername.Texts.Length <= 3)
                {
                    MessageBox.Show("Username must be a minimum of 6 characters", "Username is too short", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        if (cTBPassword.Texts != cTBConfPass.Texts)
                        {
                            MessageBox.Show("Passwords didn't match!", "Confirmation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            if (CheckString.StrengthScore(cTBPassword.Texts, true, true, true, true) < 5)
                            {
                                MessageBox.Show("Password strength must be Strong or Excellent.\r\nYou can generate new password by clicking Generate Password button.\r\nUse Check Strength button to check your password strength.", "Weak Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            else
                            {

                                if (cTBOTP.Texts != otp)
                                {
                                    MessageBox.Show("OTP didn't match!", "Confirmation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                                else
                                {
                                    try
                                    {
                                        FirebaseResponse res = client.Get(@"Users/" + cTBUsername.Texts);
                                        User ResUser = res.ResultAs<User>();
                                        User UserInput = new User() // USER INPUT
                                        {
                                            username = cTBUsername.Texts
                                        };

                                        if (User.IsTaken(ResUser, UserInput)) // Check username availability
                                        {
                                            User.ShowError();
                                        }
                                        else
                                        {

                                            User userData = new User()
                                            {
                                                username = cTBUsername.Texts,
                                                password = cTBPassword.Texts,
                                                email = cTBEmail.Texts,
                                                phone_no = cTBPhoneNumber.Texts,
                                                status = true,
                                                start = "none",
                                                duration = "none",
                                                login_count = 0
                                            };

                                            SetResponse set = client.Set(@"users/" + cTBUsername.Texts, userData);

                                            tmrOTP.Stop();
                                            MessageBox.Show("User accout created successfully." + Environment.NewLine + "Thanks for choosing Le-Sa", "Account Created", MessageBoxButtons.OK);

                                            formDesktop desktop = new formDesktop();
                                            desktop.Show();
                                            this.Hide();
                                        }
                                    }
                                    catch (Exception insert)
                                    {
                                        MessageBox.Show(insert.Message, insert.StackTrace);
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        #endregion

        #region Titlebar
        private void crBrnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void crBtnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion

        #region Drag
        private void pnlBackground_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void pnlBackground_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        private void crPnlPassword0_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void crPnlPassword0_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        private void crPnlPassword1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void crPnlPassword1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        #endregion

    }
}
