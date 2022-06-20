using FireSharp.Config;
using FireSharp.Interfaces;
using System;
using System.Drawing;
using System.Windows.Forms;
using Le_Sa.Models.RandomString;
using Le_Sa.Models.Email;
using System.IO;
using Le_Sa.Models.Copy;
using FireSharp.Response;

namespace Le_Sa.Settings
{
    public partial class formAccountSettings : Form
    {
        private string otp;
        private int sec = 00;
        private int min = 05;
        private string source;
        private string ImageLoc = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\Le-Sa\User Data\DP\DP";
        private Point lastPoint;
        System.Timers.Timer tmrOTP;
        private string destinationFile;
        private string destinationPath;
        private IFirebaseClient client;

        public formAccountSettings()
        {
            InitializeComponent();
        }

        readonly IFirebaseConfig ifc = new FirebaseConfig()
        {
            AuthSecret = "K9Ul4asnJqIMFlBlpm0AkjcEnwWagBxs4Iy0xZes",
            BasePath = "https://le-sa-f718d-default-rtdb.firebaseio.com/"
        };

        private void formAccountSettings_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.accDataWarningDontShow == true)
            {
                crPnlWarning.Visible = false;
            }
            cTBUsername.Texts = Properties.Settings.Default.username;
            cTBPhoneNumber.Texts = Properties.Settings.Default.phoneNo;
            cTBEmail.Texts = Properties.Settings.Default.email;

            try
            {
                if (File.Exists(ImageLoc))
                {
                    crPBDP.Image = new Bitmap(ImageLoc);
                }
                else
                {
                    crPBDP.Image = Properties.Resources.user_90px;
                }
            }
            catch
            {
                crPBDP.Image = Properties.Resources.user_90px;
            }

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

        #region Warning Msg
        private void crBtnCloseWarning_Click(object sender, EventArgs e)
        {
            crPnlWarning.Visible = false;
        }

        private void crBtnUnderstand_Click(object sender, EventArgs e)
        {
            crPnlWarning.Visible = false;
            if (cBoxDontShowAgain.Checked)
            {
                Properties.Settings.Default.accDataWarningDontShow = true;
                Properties.Settings.Default.Save();
            }
            Properties.Settings.Default.accDataWarningUnderstand = true;
            Properties.Settings.Default.Save();
        }
        #endregion

        #region OTP
        private void crBtnSendOTP_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cTBEmail.Texts))
            {
                MessageBox.Show("Please fill Email fields before strength check", "Fields are empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cTBEmail.Texts == Properties.Settings.Default.email)
            {
                MessageBox.Show("You need to use different email to verify, You have already verified this email address.", "Email Already Verified", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                otp = RandomStringGenerator.GenerateRandomString(6, true, false, true, false);
                bool sendMsg = Email.SendMsg(cTBEmail.Texts, "Le-Sa", "Use this One Time Password to verify your new Email address 👉 " + otp + " 👈");

                if (sendMsg == true)
                {
                    tmrOTP.Start();
                    MessageBox.Show("OTP Sent successfully to your email address (" + cTBEmail.Texts + ")" + Environment.NewLine + Environment.NewLine + "Please Check your inbox", "OTP Sent", MessageBoxButtons.OK);
                    crBtnResendOTP.Visible = true;
                    crBtnChangeEmail.Visible = true;
                    crBtnSendOTP.Enabled = false;
                    cTBEmail.Enabled = false;
                    lblOTP.Visible = true;
                    cTBOTP.Visible = true;
                    lblOTPTimer.Visible = true;
                }
            }
        }

        private void crBtnResendOTP_Click(object sender, EventArgs e)
        {
            bool sendMsg = Email.SendMsg(cTBEmail.Texts, "Le-Sa", "Use this One Time Password to verify your new Email address 👉 " + otp + " 👈");

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
            crPBDP.Image.Dispose();
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

                crPBDP.Image.Dispose();
                Copy.CopyFile(null, source, destinationPath, destinationFile);
                crPBDP.Image = new Bitmap(ImageLoc);
            }
        }


        #endregion

        private void crBtnChangeEmail_Click(object sender, EventArgs e)
        {
            otp = null;
            lblOTP.Visible = false;
            cTBOTP.Visible = false;
            lblOTPTimer.Visible = false;
            crBtnChangeEmail.Visible = false;
            cTBEmail.Enabled = true;
            crBtnSendOTP.Enabled = true;
            crBtnResendOTP.Visible = false;
            tmrOTP.Stop();
            lblOTPTimer.Text = "00:00";
        }

        private void crBtnSaveChanges_Click(object sender, EventArgs e)
        {
            if (cTBPhoneNumber.Texts == Properties.Settings.Default.phoneNo && cTBEmail.Texts == Properties.Settings.Default.email)
            {
                MessageBox.Show("Please cahnge field you want to update", "Same data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(cTBUsername.Texts) || string.IsNullOrEmpty(cTBUsername.Texts) || string.IsNullOrEmpty(cTBUsername.Texts))
            {
                MessageBox.Show("Please fill all fields", "Fields are empty", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (cTBEmail.Texts != Properties.Settings.Default.email)
            {
                if (cTBOTP.Texts != otp)
                {
                    MessageBox.Show("OTP didn't match!", "Confirmation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                DialogResult updateUserData = MessageBox.Show($"Account data will be saved as follows.\nUsername : {cTBUsername.Texts}\nEmail : {cTBEmail.Texts}\nPhone No. : {cTBPhoneNumber.Texts}", "Update Account Data", MessageBoxButtons.OKCancel);
                if (updateUserData == DialogResult.OK)
                {
                    try
                    {
                        FirebaseResponse res = client.Get(@"users/" + cTBUsername.Texts);
                        User ResUser = res.ResultAs<User>();

                        User updateUser = new User()
                        {
                            username = ResUser.username,
                            password = ResUser.password,
                            email = cTBEmail.Texts,
                            phone_no = cTBPhoneNumber.Texts,
                            status = ResUser.status,
                            start = ResUser.start,
                            duration = ResUser.duration,
                            login_count = ResUser.login_count
                        };

                        SetResponse set = client.Set(@"users/" + ResUser.username, updateUser);

                        Properties.Settings.Default.username = cTBUsername.Texts;
                        Properties.Settings.Default.phoneNo = cTBPhoneNumber.Texts;
                        Properties.Settings.Default.email = cTBEmail.Texts;
                        Properties.Settings.Default.Save();

                        cBtnClear.Visible = false;
                        MessageBox.Show("User data changed successfully.", "Sucessful", MessageBoxButtons.OK);
                    }
                    catch (Exception fireError)
                    {
                        MessageBox.Show(fireError.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        #region Clear
        private void cBtnClear_Click(object sender, EventArgs e)
        {
            cTBUsername.Texts = Properties.Settings.Default.username;
            cTBPhoneNumber.Texts = Properties.Settings.Default.phoneNo;
            cTBEmail.Texts = Properties.Settings.Default.email;
            cTBOTP.Texts = "";
            crPBDP.Image.Dispose();
            otp = null;

            crBtnChangeEmail.Visible = false;
            tmrOTP.Stop();
            lblOTPTimer.Visible = false;
            lblOTPTimer.Text = "00:00";
            crBtnResendOTP.Visible = false;
            crBtnSendOTP.Enabled = true;
            cTBEmail.Enabled = true;
        }
        #endregion
    }
}

