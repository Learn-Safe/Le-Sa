
namespace Le_Sa.Account
{
    partial class formForgotPassword
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblForgotPass = new System.Windows.Forms.Label();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.pnlNewPass = new System.Windows.Forms.Panel();
            this.lblStrength = new System.Windows.Forms.Label();
            this.lblConfPass = new System.Windows.Forms.Label();
            this.lblNewPass = new System.Windows.Forms.Label();
            this.lblOTPTimer = new System.Windows.Forms.Label();
            this.lblOTP = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.crBtnConfPassVisibility = new Le_Sa.CustRoundedButton();
            this.crBtnPassVisibility = new Le_Sa.CustRoundedButton();
            this.crBtnStrength = new Le_Sa.CustRoundedButton();
            this.crBtnGeneratePassword = new Le_Sa.CustRoundedButton();
            this.crBtnChangePassword = new Le_Sa.CustRoundedButton();
            this.cTBConfPassword = new Le_Sa.CustomControls.CustomTextBox();
            this.cTBNewPassword = new Le_Sa.CustomControls.CustomTextBox();
            this.crBtnContinue = new Le_Sa.CustRoundedButton();
            this.cTBOTP = new Le_Sa.CustomControls.CustomTextBox();
            this.crBtnResendOTP = new Le_Sa.CustRoundedButton();
            this.crBtnSendOTP = new Le_Sa.CustRoundedButton();
            this.cTBUsername = new Le_Sa.CustomControls.CustomTextBox();
            this.crBrnClose = new Le_Sa.CustRoundedButton();
            this.pnlHeader.SuspendLayout();
            this.pnlContent.SuspendLayout();
            this.pnlNewPass.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.crBrnClose);
            this.pnlHeader.Controls.Add(this.lblForgotPass);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(252, 85);
            this.pnlHeader.TabIndex = 123;
            // 
            // lblForgotPass
            // 
            this.lblForgotPass.BackColor = System.Drawing.Color.Transparent;
            this.lblForgotPass.Enabled = false;
            this.lblForgotPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForgotPass.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblForgotPass.Location = new System.Drawing.Point(3, 0);
            this.lblForgotPass.Name = "lblForgotPass";
            this.lblForgotPass.Size = new System.Drawing.Size(241, 81);
            this.lblForgotPass.TabIndex = 123;
            this.lblForgotPass.Text = "Reset your Password ";
            // 
            // pnlContent
            // 
            this.pnlContent.Controls.Add(this.pnlNewPass);
            this.pnlContent.Controls.Add(this.crBtnContinue);
            this.pnlContent.Controls.Add(this.lblOTPTimer);
            this.pnlContent.Controls.Add(this.cTBOTP);
            this.pnlContent.Controls.Add(this.lblOTP);
            this.pnlContent.Controls.Add(this.crBtnResendOTP);
            this.pnlContent.Controls.Add(this.crBtnSendOTP);
            this.pnlContent.Controls.Add(this.cTBUsername);
            this.pnlContent.Controls.Add(this.lblUsername);
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 85);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(252, 226);
            this.pnlContent.TabIndex = 124;
            // 
            // pnlNewPass
            // 
            this.pnlNewPass.Controls.Add(this.crBtnConfPassVisibility);
            this.pnlNewPass.Controls.Add(this.crBtnPassVisibility);
            this.pnlNewPass.Controls.Add(this.lblStrength);
            this.pnlNewPass.Controls.Add(this.crBtnStrength);
            this.pnlNewPass.Controls.Add(this.crBtnGeneratePassword);
            this.pnlNewPass.Controls.Add(this.crBtnChangePassword);
            this.pnlNewPass.Controls.Add(this.lblConfPass);
            this.pnlNewPass.Controls.Add(this.cTBConfPassword);
            this.pnlNewPass.Controls.Add(this.lblNewPass);
            this.pnlNewPass.Controls.Add(this.cTBNewPassword);
            this.pnlNewPass.Location = new System.Drawing.Point(0, 223);
            this.pnlNewPass.Name = "pnlNewPass";
            this.pnlNewPass.Size = new System.Drawing.Size(253, 224);
            this.pnlNewPass.TabIndex = 129;
            // 
            // lblStrength
            // 
            this.lblStrength.AutoSize = true;
            this.lblStrength.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.lblStrength.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblStrength.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStrength.Location = new System.Drawing.Point(144, 152);
            this.lblStrength.Name = "lblStrength";
            this.lblStrength.Size = new System.Drawing.Size(0, 21);
            this.lblStrength.TabIndex = 136;
            // 
            // lblConfPass
            // 
            this.lblConfPass.AutoSize = true;
            this.lblConfPass.BackColor = System.Drawing.Color.Transparent;
            this.lblConfPass.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfPass.ForeColor = System.Drawing.Color.White;
            this.lblConfPass.Location = new System.Drawing.Point(5, 65);
            this.lblConfPass.Name = "lblConfPass";
            this.lblConfPass.Size = new System.Drawing.Size(179, 25);
            this.lblConfPass.TabIndex = 132;
            this.lblConfPass.Text = "Confirm Password";
            // 
            // lblNewPass
            // 
            this.lblNewPass.AutoSize = true;
            this.lblNewPass.BackColor = System.Drawing.Color.Transparent;
            this.lblNewPass.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewPass.ForeColor = System.Drawing.Color.White;
            this.lblNewPass.Location = new System.Drawing.Point(5, 7);
            this.lblNewPass.Name = "lblNewPass";
            this.lblNewPass.Size = new System.Drawing.Size(146, 25);
            this.lblNewPass.TabIndex = 130;
            this.lblNewPass.Text = "New Password";
            // 
            // lblOTPTimer
            // 
            this.lblOTPTimer.AutoSize = true;
            this.lblOTPTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOTPTimer.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblOTPTimer.Location = new System.Drawing.Point(197, 116);
            this.lblOTPTimer.Name = "lblOTPTimer";
            this.lblOTPTimer.Size = new System.Drawing.Size(49, 20);
            this.lblOTPTimer.TabIndex = 126;
            this.lblOTPTimer.Text = "05:00";
            this.lblOTPTimer.Visible = false;
            // 
            // lblOTP
            // 
            this.lblOTP.AutoSize = true;
            this.lblOTP.BackColor = System.Drawing.Color.Transparent;
            this.lblOTP.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOTP.ForeColor = System.Drawing.Color.White;
            this.lblOTP.Location = new System.Drawing.Point(5, 111);
            this.lblOTP.Name = "lblOTP";
            this.lblOTP.Size = new System.Drawing.Size(50, 25);
            this.lblOTP.TabIndex = 124;
            this.lblOTP.Text = "OTP";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.White;
            this.lblUsername.Location = new System.Drawing.Point(5, 10);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(105, 25);
            this.lblUsername.TabIndex = 120;
            this.lblUsername.Text = "Username";
            // 
            // crBtnConfPassVisibility
            // 
            this.crBtnConfPassVisibility.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.crBtnConfPassVisibility.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.crBtnConfPassVisibility.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.crBtnConfPassVisibility.BorderColor = System.Drawing.SystemColors.ScrollBar;
            this.crBtnConfPassVisibility.BorderRadius = 20;
            this.crBtnConfPassVisibility.BorderSize = 2;
            this.crBtnConfPassVisibility.FlatAppearance.BorderSize = 0;
            this.crBtnConfPassVisibility.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.crBtnConfPassVisibility.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.crBtnConfPassVisibility.Image = global::Le_Sa.Properties.Resources.hide_22px;
            this.crBtnConfPassVisibility.Location = new System.Drawing.Point(221, 90);
            this.crBtnConfPassVisibility.Name = "crBtnConfPassVisibility";
            this.crBtnConfPassVisibility.Size = new System.Drawing.Size(27, 27);
            this.crBtnConfPassVisibility.TabIndex = 138;
            this.crBtnConfPassVisibility.TextColor = System.Drawing.SystemColors.ScrollBar;
            this.crBtnConfPassVisibility.UseVisualStyleBackColor = false;
            this.crBtnConfPassVisibility.MouseDown += new System.Windows.Forms.MouseEventHandler(this.crBtnPassVisibility_MouseDown);
            this.crBtnConfPassVisibility.MouseUp += new System.Windows.Forms.MouseEventHandler(this.crBtnConfPassVisibility_MouseUp);
            // 
            // crBtnPassVisibility
            // 
            this.crBtnPassVisibility.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.crBtnPassVisibility.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.crBtnPassVisibility.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.crBtnPassVisibility.BorderColor = System.Drawing.SystemColors.ScrollBar;
            this.crBtnPassVisibility.BorderRadius = 20;
            this.crBtnPassVisibility.BorderSize = 2;
            this.crBtnPassVisibility.FlatAppearance.BorderSize = 0;
            this.crBtnPassVisibility.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.crBtnPassVisibility.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.crBtnPassVisibility.Image = global::Le_Sa.Properties.Resources.hide_22px;
            this.crBtnPassVisibility.Location = new System.Drawing.Point(221, 32);
            this.crBtnPassVisibility.Name = "crBtnPassVisibility";
            this.crBtnPassVisibility.Size = new System.Drawing.Size(27, 27);
            this.crBtnPassVisibility.TabIndex = 137;
            this.crBtnPassVisibility.TextColor = System.Drawing.SystemColors.ScrollBar;
            this.crBtnPassVisibility.UseVisualStyleBackColor = false;
            this.crBtnPassVisibility.MouseDown += new System.Windows.Forms.MouseEventHandler(this.crBtnPassVisibility_MouseDown);
            this.crBtnPassVisibility.MouseUp += new System.Windows.Forms.MouseEventHandler(this.crBtnConfPassVisibility_MouseUp);
            // 
            // crBtnStrength
            // 
            this.crBtnStrength.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.crBtnStrength.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.crBtnStrength.BorderColor = System.Drawing.SystemColors.ScrollBar;
            this.crBtnStrength.BorderRadius = 11;
            this.crBtnStrength.BorderSize = 0;
            this.crBtnStrength.FlatAppearance.BorderSize = 0;
            this.crBtnStrength.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.crBtnStrength.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crBtnStrength.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.crBtnStrength.Location = new System.Drawing.Point(3, 148);
            this.crBtnStrength.Name = "crBtnStrength";
            this.crBtnStrength.Size = new System.Drawing.Size(135, 27);
            this.crBtnStrength.TabIndex = 135;
            this.crBtnStrength.Text = "Check Strength";
            this.crBtnStrength.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.crBtnStrength.UseVisualStyleBackColor = false;
            this.crBtnStrength.Click += new System.EventHandler(this.crBtnStrength_Click);
            // 
            // crBtnGeneratePassword
            // 
            this.crBtnGeneratePassword.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.crBtnGeneratePassword.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.crBtnGeneratePassword.BorderColor = System.Drawing.SystemColors.ScrollBar;
            this.crBtnGeneratePassword.BorderRadius = 11;
            this.crBtnGeneratePassword.BorderSize = 0;
            this.crBtnGeneratePassword.FlatAppearance.BorderSize = 0;
            this.crBtnGeneratePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.crBtnGeneratePassword.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crBtnGeneratePassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.crBtnGeneratePassword.Location = new System.Drawing.Point(3, 121);
            this.crBtnGeneratePassword.Name = "crBtnGeneratePassword";
            this.crBtnGeneratePassword.Size = new System.Drawing.Size(163, 25);
            this.crBtnGeneratePassword.TabIndex = 134;
            this.crBtnGeneratePassword.Text = "Generate Password";
            this.crBtnGeneratePassword.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.crBtnGeneratePassword.UseVisualStyleBackColor = false;
            this.crBtnGeneratePassword.Click += new System.EventHandler(this.crBtnGeneratePassword_Click);
            // 
            // crBtnChangePassword
            // 
            this.crBtnChangePassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(199)))), ((int)(((byte)(68)))));
            this.crBtnChangePassword.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(199)))), ((int)(((byte)(68)))));
            this.crBtnChangePassword.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.crBtnChangePassword.BorderRadius = 20;
            this.crBtnChangePassword.BorderSize = 0;
            this.crBtnChangePassword.FlatAppearance.BorderSize = 0;
            this.crBtnChangePassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.crBtnChangePassword.Font = new System.Drawing.Font("Microsoft Tai Le", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crBtnChangePassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(22)))));
            this.crBtnChangePassword.Location = new System.Drawing.Point(3, 181);
            this.crBtnChangePassword.Name = "crBtnChangePassword";
            this.crBtnChangePassword.Size = new System.Drawing.Size(245, 31);
            this.crBtnChangePassword.TabIndex = 133;
            this.crBtnChangePassword.Text = "Continue";
            this.crBtnChangePassword.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.crBtnChangePassword.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(22)))));
            this.crBtnChangePassword.UseVisualStyleBackColor = false;
            this.crBtnChangePassword.Click += new System.EventHandler(this.crBtnChangePassword_Click);
            // 
            // cTBConfPassword
            // 
            this.cTBConfPassword.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cTBConfPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(75)))));
            this.cTBConfPassword.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(75)))));
            this.cTBConfPassword.BorderRadius = 20;
            this.cTBConfPassword.BorderSize = 0;
            this.cTBConfPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cTBConfPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.cTBConfPassword.Location = new System.Drawing.Point(3, 90);
            this.cTBConfPassword.Margin = new System.Windows.Forms.Padding(1);
            this.cTBConfPassword.Multiline = false;
            this.cTBConfPassword.Name = "cTBConfPassword";
            this.cTBConfPassword.Padding = new System.Windows.Forms.Padding(6, 4, 35, 4);
            this.cTBConfPassword.PasswordChar = true;
            this.cTBConfPassword.Size = new System.Drawing.Size(245, 27);
            this.cTBConfPassword.TabIndex = 131;
            this.cTBConfPassword.Texts = "";
            this.cTBConfPassword.UnderlinedStyle = false;
            // 
            // cTBNewPassword
            // 
            this.cTBNewPassword.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cTBNewPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(75)))));
            this.cTBNewPassword.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(75)))));
            this.cTBNewPassword.BorderRadius = 20;
            this.cTBNewPassword.BorderSize = 0;
            this.cTBNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cTBNewPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.cTBNewPassword.Location = new System.Drawing.Point(3, 32);
            this.cTBNewPassword.Margin = new System.Windows.Forms.Padding(1);
            this.cTBNewPassword.Multiline = false;
            this.cTBNewPassword.Name = "cTBNewPassword";
            this.cTBNewPassword.Padding = new System.Windows.Forms.Padding(6, 4, 35, 4);
            this.cTBNewPassword.PasswordChar = true;
            this.cTBNewPassword.Size = new System.Drawing.Size(245, 27);
            this.cTBNewPassword.TabIndex = 129;
            this.cTBNewPassword.Texts = "";
            this.cTBNewPassword.UnderlinedStyle = false;
            // 
            // crBtnContinue
            // 
            this.crBtnContinue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(199)))), ((int)(((byte)(68)))));
            this.crBtnContinue.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(199)))), ((int)(((byte)(68)))));
            this.crBtnContinue.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.crBtnContinue.BorderRadius = 20;
            this.crBtnContinue.BorderSize = 0;
            this.crBtnContinue.FlatAppearance.BorderSize = 0;
            this.crBtnContinue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.crBtnContinue.Font = new System.Drawing.Font("Microsoft Tai Le", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crBtnContinue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(22)))));
            this.crBtnContinue.Location = new System.Drawing.Point(3, 174);
            this.crBtnContinue.Name = "crBtnContinue";
            this.crBtnContinue.Size = new System.Drawing.Size(245, 31);
            this.crBtnContinue.TabIndex = 127;
            this.crBtnContinue.Text = "Continue";
            this.crBtnContinue.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.crBtnContinue.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(22)))));
            this.crBtnContinue.UseVisualStyleBackColor = false;
            this.crBtnContinue.Click += new System.EventHandler(this.crBtnContinue_Click);
            // 
            // cTBOTP
            // 
            this.cTBOTP.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cTBOTP.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(75)))));
            this.cTBOTP.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(75)))));
            this.cTBOTP.BorderRadius = 20;
            this.cTBOTP.BorderSize = 0;
            this.cTBOTP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cTBOTP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.cTBOTP.Location = new System.Drawing.Point(3, 135);
            this.cTBOTP.Margin = new System.Windows.Forms.Padding(1);
            this.cTBOTP.Multiline = false;
            this.cTBOTP.Name = "cTBOTP";
            this.cTBOTP.Padding = new System.Windows.Forms.Padding(6, 4, 35, 4);
            this.cTBOTP.PasswordChar = false;
            this.cTBOTP.Size = new System.Drawing.Size(245, 27);
            this.cTBOTP.TabIndex = 125;
            this.cTBOTP.Texts = "";
            this.cTBOTP.UnderlinedStyle = false;
            // 
            // crBtnResendOTP
            // 
            this.crBtnResendOTP.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.crBtnResendOTP.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.crBtnResendOTP.BorderColor = System.Drawing.SystemColors.ScrollBar;
            this.crBtnResendOTP.BorderRadius = 10;
            this.crBtnResendOTP.BorderSize = 0;
            this.crBtnResendOTP.FlatAppearance.BorderSize = 0;
            this.crBtnResendOTP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.crBtnResendOTP.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crBtnResendOTP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.crBtnResendOTP.Location = new System.Drawing.Point(128, 74);
            this.crBtnResendOTP.Name = "crBtnResendOTP";
            this.crBtnResendOTP.Size = new System.Drawing.Size(120, 25);
            this.crBtnResendOTP.TabIndex = 123;
            this.crBtnResendOTP.Text = "Resend OTP";
            this.crBtnResendOTP.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.crBtnResendOTP.UseVisualStyleBackColor = false;
            this.crBtnResendOTP.Visible = false;
            this.crBtnResendOTP.Click += new System.EventHandler(this.crBtnResendOTP_Click);
            // 
            // crBtnSendOTP
            // 
            this.crBtnSendOTP.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.crBtnSendOTP.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.crBtnSendOTP.BorderColor = System.Drawing.SystemColors.ScrollBar;
            this.crBtnSendOTP.BorderRadius = 10;
            this.crBtnSendOTP.BorderSize = 0;
            this.crBtnSendOTP.FlatAppearance.BorderSize = 0;
            this.crBtnSendOTP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.crBtnSendOTP.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crBtnSendOTP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.crBtnSendOTP.Location = new System.Drawing.Point(3, 74);
            this.crBtnSendOTP.Name = "crBtnSendOTP";
            this.crBtnSendOTP.Size = new System.Drawing.Size(120, 25);
            this.crBtnSendOTP.TabIndex = 122;
            this.crBtnSendOTP.Text = "Send OTP";
            this.crBtnSendOTP.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.crBtnSendOTP.UseVisualStyleBackColor = false;
            this.crBtnSendOTP.Click += new System.EventHandler(this.crBtnSendOTP_Click);
            // 
            // cTBUsername
            // 
            this.cTBUsername.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cTBUsername.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(75)))));
            this.cTBUsername.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(75)))));
            this.cTBUsername.BorderRadius = 20;
            this.cTBUsername.BorderSize = 0;
            this.cTBUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cTBUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.cTBUsername.Location = new System.Drawing.Point(3, 36);
            this.cTBUsername.Margin = new System.Windows.Forms.Padding(1);
            this.cTBUsername.Multiline = false;
            this.cTBUsername.Name = "cTBUsername";
            this.cTBUsername.Padding = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.cTBUsername.PasswordChar = false;
            this.cTBUsername.Size = new System.Drawing.Size(245, 27);
            this.cTBUsername.TabIndex = 121;
            this.cTBUsername.Texts = "";
            this.cTBUsername.UnderlinedStyle = false;
            // 
            // crBrnClose
            // 
            this.crBrnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.crBrnClose.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.crBrnClose.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.crBrnClose.BorderRadius = 30;
            this.crBrnClose.BorderSize = 0;
            this.crBrnClose.FlatAppearance.BorderSize = 0;
            this.crBrnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.crBrnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crBrnClose.ForeColor = System.Drawing.Color.White;
            this.crBrnClose.Location = new System.Drawing.Point(220, 1);
            this.crBrnClose.Name = "crBrnClose";
            this.crBrnClose.Size = new System.Drawing.Size(30, 30);
            this.crBrnClose.TabIndex = 124;
            this.crBrnClose.Text = " X";
            this.crBrnClose.TextColor = System.Drawing.Color.White;
            this.crBrnClose.UseVisualStyleBackColor = false;
            this.crBrnClose.Click += new System.EventHandler(this.crBrnClose_Click);
            // 
            // formForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(46)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(252, 311);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formForgotPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formForgotPassword";
            this.Load += new System.EventHandler(this.formForgotPassword_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlContent.ResumeLayout(false);
            this.pnlContent.PerformLayout();
            this.pnlNewPass.ResumeLayout(false);
            this.pnlNewPass.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private CustRoundedButton crBrnClose;
        private System.Windows.Forms.Label lblForgotPass;
        private System.Windows.Forms.Panel pnlContent;
        private CustRoundedButton crBtnContinue;
        private System.Windows.Forms.Label lblOTPTimer;
        private CustomControls.CustomTextBox cTBOTP;
        private System.Windows.Forms.Label lblOTP;
        private CustRoundedButton crBtnResendOTP;
        private CustRoundedButton crBtnSendOTP;
        private CustomControls.CustomTextBox cTBUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Panel pnlNewPass;
        private CustRoundedButton crBtnChangePassword;
        private System.Windows.Forms.Label lblConfPass;
        private CustomControls.CustomTextBox cTBConfPassword;
        private System.Windows.Forms.Label lblNewPass;
        private CustomControls.CustomTextBox cTBNewPassword;
        private CustRoundedButton crBtnGeneratePassword;
        private CustRoundedButton crBtnStrength;
        private System.Windows.Forms.Label lblStrength;
        private CustRoundedButton crBtnConfPassVisibility;
        private CustRoundedButton crBtnPassVisibility;
    }
}