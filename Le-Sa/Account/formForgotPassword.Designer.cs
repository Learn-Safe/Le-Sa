
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formForgotPassword));
            this.lblForgotPass = new System.Windows.Forms.Label();
            this.crBtnContinue = new Le_Sa.CustRoundedButton();
            this.lblOTPTimer = new System.Windows.Forms.Label();
            this.cTBOTP = new Le_Sa.CustomControls.CustomTextBox();
            this.lblOTP = new System.Windows.Forms.Label();
            this.crBtnResendOTP = new Le_Sa.CustRoundedButton();
            this.crBtnSendOTP = new Le_Sa.CustRoundedButton();
            this.cTBUsername = new Le_Sa.CustomControls.CustomTextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblForgotPass
            // 
            this.lblForgotPass.AutoSize = true;
            this.lblForgotPass.BackColor = System.Drawing.Color.Transparent;
            this.lblForgotPass.Enabled = false;
            this.lblForgotPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForgotPass.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblForgotPass.Location = new System.Drawing.Point(10, 23);
            this.lblForgotPass.Name = "lblForgotPass";
            this.lblForgotPass.Size = new System.Drawing.Size(319, 37);
            this.lblForgotPass.TabIndex = 123;
            this.lblForgotPass.Text = "Reset your Password";
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
            this.crBtnContinue.Location = new System.Drawing.Point(10, 345);
            this.crBtnContinue.Name = "crBtnContinue";
            this.crBtnContinue.Size = new System.Drawing.Size(319, 31);
            this.crBtnContinue.TabIndex = 127;
            this.crBtnContinue.Text = "Continue";
            this.crBtnContinue.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.crBtnContinue.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(22)))));
            this.crBtnContinue.UseVisualStyleBackColor = false;
            this.crBtnContinue.Click += new System.EventHandler(this.crBtnContinue_Click);
            // 
            // lblOTPTimer
            // 
            this.lblOTPTimer.AutoSize = true;
            this.lblOTPTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOTPTimer.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblOTPTimer.Location = new System.Drawing.Point(273, 252);
            this.lblOTPTimer.Name = "lblOTPTimer";
            this.lblOTPTimer.Size = new System.Drawing.Size(49, 20);
            this.lblOTPTimer.TabIndex = 126;
            this.lblOTPTimer.Text = "05:00";
            this.lblOTPTimer.Visible = false;
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
            this.cTBOTP.Location = new System.Drawing.Point(17, 279);
            this.cTBOTP.Margin = new System.Windows.Forms.Padding(1);
            this.cTBOTP.Multiline = false;
            this.cTBOTP.Name = "cTBOTP";
            this.cTBOTP.Padding = new System.Windows.Forms.Padding(6, 4, 35, 4);
            this.cTBOTP.PasswordChar = false;
            this.cTBOTP.Size = new System.Drawing.Size(305, 27);
            this.cTBOTP.TabIndex = 125;
            this.cTBOTP.Texts = "";
            this.cTBOTP.UnderlinedStyle = false;
            // 
            // lblOTP
            // 
            this.lblOTP.AutoSize = true;
            this.lblOTP.BackColor = System.Drawing.Color.Transparent;
            this.lblOTP.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOTP.ForeColor = System.Drawing.Color.White;
            this.lblOTP.Location = new System.Drawing.Point(12, 248);
            this.lblOTP.Name = "lblOTP";
            this.lblOTP.Size = new System.Drawing.Size(50, 25);
            this.lblOTP.TabIndex = 124;
            this.lblOTP.Text = "OTP";
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
            this.crBtnResendOTP.Location = new System.Drawing.Point(175, 192);
            this.crBtnResendOTP.Name = "crBtnResendOTP";
            this.crBtnResendOTP.Size = new System.Drawing.Size(147, 25);
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
            this.crBtnSendOTP.Location = new System.Drawing.Point(17, 192);
            this.crBtnSendOTP.Name = "crBtnSendOTP";
            this.crBtnSendOTP.Size = new System.Drawing.Size(147, 25);
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
            this.cTBUsername.Location = new System.Drawing.Point(17, 153);
            this.cTBUsername.Margin = new System.Windows.Forms.Padding(1);
            this.cTBUsername.Multiline = false;
            this.cTBUsername.Name = "cTBUsername";
            this.cTBUsername.Padding = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.cTBUsername.PasswordChar = false;
            this.cTBUsername.Size = new System.Drawing.Size(305, 27);
            this.cTBUsername.TabIndex = 121;
            this.cTBUsername.Texts = "";
            this.cTBUsername.UnderlinedStyle = false;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.White;
            this.lblUsername.Location = new System.Drawing.Point(12, 122);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(105, 25);
            this.lblUsername.TabIndex = 120;
            this.lblUsername.Text = "Username";
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImage = global::Le_Sa.Properties.Resources.close_20px;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.Transparent;
            this.btnClose.Location = new System.Drawing.Point(319, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(20, 20);
            this.btnClose.TabIndex = 128;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // formForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(46)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(339, 388);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.crBtnContinue);
            this.Controls.Add(this.lblForgotPass);
            this.Controls.Add(this.lblOTPTimer);
            this.Controls.Add(this.cTBOTP);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblOTP);
            this.Controls.Add(this.cTBUsername);
            this.Controls.Add(this.crBtnResendOTP);
            this.Controls.Add(this.crBtnSendOTP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "formForgotPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formForgotPassword";
            this.Load += new System.EventHandler(this.formForgotPassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblForgotPass;
        private CustRoundedButton crBtnContinue;
        private System.Windows.Forms.Label lblOTPTimer;
        private CustomControls.CustomTextBox cTBOTP;
        private System.Windows.Forms.Label lblOTP;
        private CustRoundedButton crBtnResendOTP;
        private CustRoundedButton crBtnSendOTP;
        private CustomControls.CustomTextBox cTBUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Button btnClose;
    }
}