
namespace Le_Sa.Account
{
    partial class formCreateNewPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formCreateNewPassword));
            this.lblStrength = new System.Windows.Forms.Label();
            this.lblConfPass = new System.Windows.Forms.Label();
            this.lblNewPass = new System.Windows.Forms.Label();
            this.lblCreateNewPassword = new System.Windows.Forms.Label();
            this.lblNewPassMsg = new System.Windows.Forms.Label();
            this.crBtnConfPassVisibility = new Le_Sa.CustRoundedButton();
            this.crBtnPassVisibility = new Le_Sa.CustRoundedButton();
            this.crBtnStrength = new Le_Sa.CustRoundedButton();
            this.crBtnGeneratePassword = new Le_Sa.CustRoundedButton();
            this.crBtnChangePassword = new Le_Sa.CustRoundedButton();
            this.cTBConfPassword = new Le_Sa.CustomControls.CustomTextBox();
            this.cTBNewPassword = new Le_Sa.CustomControls.CustomTextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblStrength
            // 
            this.lblStrength.AutoSize = true;
            this.lblStrength.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.lblStrength.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblStrength.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStrength.Location = new System.Drawing.Point(166, 342);
            this.lblStrength.Name = "lblStrength";
            this.lblStrength.Size = new System.Drawing.Size(0, 21);
            this.lblStrength.TabIndex = 146;
            // 
            // lblConfPass
            // 
            this.lblConfPass.AutoSize = true;
            this.lblConfPass.BackColor = System.Drawing.Color.Transparent;
            this.lblConfPass.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfPass.ForeColor = System.Drawing.Color.White;
            this.lblConfPass.Location = new System.Drawing.Point(11, 214);
            this.lblConfPass.Name = "lblConfPass";
            this.lblConfPass.Size = new System.Drawing.Size(179, 25);
            this.lblConfPass.TabIndex = 142;
            this.lblConfPass.Text = "Confirm Password";
            // 
            // lblNewPass
            // 
            this.lblNewPass.AutoSize = true;
            this.lblNewPass.BackColor = System.Drawing.Color.Transparent;
            this.lblNewPass.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewPass.ForeColor = System.Drawing.Color.White;
            this.lblNewPass.Location = new System.Drawing.Point(11, 139);
            this.lblNewPass.Name = "lblNewPass";
            this.lblNewPass.Size = new System.Drawing.Size(146, 25);
            this.lblNewPass.TabIndex = 140;
            this.lblNewPass.Text = "New Password";
            // 
            // lblCreateNewPassword
            // 
            this.lblCreateNewPassword.AutoSize = true;
            this.lblCreateNewPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreateNewPassword.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblCreateNewPassword.Location = new System.Drawing.Point(10, 15);
            this.lblCreateNewPassword.Name = "lblCreateNewPassword";
            this.lblCreateNewPassword.Size = new System.Drawing.Size(304, 33);
            this.lblCreateNewPassword.TabIndex = 149;
            this.lblCreateNewPassword.Text = "Create New Password";
            // 
            // lblNewPassMsg
            // 
            this.lblNewPassMsg.Font = new System.Drawing.Font("Microsoft Tai Le", 10F);
            this.lblNewPassMsg.ForeColor = System.Drawing.Color.LightGray;
            this.lblNewPassMsg.Location = new System.Drawing.Point(40, 58);
            this.lblNewPassMsg.Name = "lblNewPassMsg";
            this.lblNewPassMsg.Size = new System.Drawing.Size(244, 40);
            this.lblNewPassMsg.TabIndex = 150;
            this.lblNewPassMsg.Text = "Set your new password so you can access your account";
            this.lblNewPassMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.crBtnConfPassVisibility.Location = new System.Drawing.Point(285, 245);
            this.crBtnConfPassVisibility.Name = "crBtnConfPassVisibility";
            this.crBtnConfPassVisibility.Size = new System.Drawing.Size(27, 27);
            this.crBtnConfPassVisibility.TabIndex = 148;
            this.crBtnConfPassVisibility.TextColor = System.Drawing.SystemColors.ScrollBar;
            this.crBtnConfPassVisibility.UseVisualStyleBackColor = false;
            this.crBtnConfPassVisibility.MouseDown += new System.Windows.Forms.MouseEventHandler(this.crBtnPassVisibility_MouseDown);
            this.crBtnConfPassVisibility.MouseUp += new System.Windows.Forms.MouseEventHandler(this.crBtnPassVisibility_MouseUp);
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
            this.crBtnPassVisibility.Location = new System.Drawing.Point(285, 170);
            this.crBtnPassVisibility.Name = "crBtnPassVisibility";
            this.crBtnPassVisibility.Size = new System.Drawing.Size(27, 27);
            this.crBtnPassVisibility.TabIndex = 147;
            this.crBtnPassVisibility.TextColor = System.Drawing.SystemColors.ScrollBar;
            this.crBtnPassVisibility.UseVisualStyleBackColor = false;
            this.crBtnPassVisibility.MouseDown += new System.Windows.Forms.MouseEventHandler(this.crBtnPassVisibility_MouseDown);
            this.crBtnPassVisibility.MouseUp += new System.Windows.Forms.MouseEventHandler(this.crBtnPassVisibility_MouseUp);
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
            this.crBtnStrength.Location = new System.Drawing.Point(16, 339);
            this.crBtnStrength.Name = "crBtnStrength";
            this.crBtnStrength.Size = new System.Drawing.Size(135, 27);
            this.crBtnStrength.TabIndex = 145;
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
            this.crBtnGeneratePassword.Location = new System.Drawing.Point(16, 298);
            this.crBtnGeneratePassword.Name = "crBtnGeneratePassword";
            this.crBtnGeneratePassword.Size = new System.Drawing.Size(163, 25);
            this.crBtnGeneratePassword.TabIndex = 144;
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
            this.crBtnChangePassword.Location = new System.Drawing.Point(10, 394);
            this.crBtnChangePassword.Name = "crBtnChangePassword";
            this.crBtnChangePassword.Size = new System.Drawing.Size(304, 31);
            this.crBtnChangePassword.TabIndex = 143;
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
            this.cTBConfPassword.Location = new System.Drawing.Point(16, 245);
            this.cTBConfPassword.Margin = new System.Windows.Forms.Padding(1);
            this.cTBConfPassword.Multiline = false;
            this.cTBConfPassword.Name = "cTBConfPassword";
            this.cTBConfPassword.Padding = new System.Windows.Forms.Padding(6, 4, 35, 4);
            this.cTBConfPassword.PasswordChar = true;
            this.cTBConfPassword.Size = new System.Drawing.Size(296, 27);
            this.cTBConfPassword.TabIndex = 141;
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
            this.cTBNewPassword.Location = new System.Drawing.Point(16, 170);
            this.cTBNewPassword.Margin = new System.Windows.Forms.Padding(1);
            this.cTBNewPassword.Multiline = false;
            this.cTBNewPassword.Name = "cTBNewPassword";
            this.cTBNewPassword.Padding = new System.Windows.Forms.Padding(6, 4, 35, 4);
            this.cTBNewPassword.PasswordChar = true;
            this.cTBNewPassword.Size = new System.Drawing.Size(297, 27);
            this.cTBNewPassword.TabIndex = 139;
            this.cTBNewPassword.Texts = "";
            this.cTBNewPassword.UnderlinedStyle = false;
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
            this.btnClose.Location = new System.Drawing.Point(304, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(20, 20);
            this.btnClose.TabIndex = 151;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // formCreateNewPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(46)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(324, 435);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblNewPassMsg);
            this.Controls.Add(this.lblCreateNewPassword);
            this.Controls.Add(this.crBtnConfPassVisibility);
            this.Controls.Add(this.crBtnPassVisibility);
            this.Controls.Add(this.lblStrength);
            this.Controls.Add(this.crBtnStrength);
            this.Controls.Add(this.crBtnGeneratePassword);
            this.Controls.Add(this.crBtnChangePassword);
            this.Controls.Add(this.lblConfPass);
            this.Controls.Add(this.cTBConfPassword);
            this.Controls.Add(this.lblNewPass);
            this.Controls.Add(this.cTBNewPassword);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formCreateNewPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formCreateNewPassword";
            this.Load += new System.EventHandler(this.formCreateNewPassword_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustRoundedButton crBtnConfPassVisibility;
        private CustRoundedButton crBtnPassVisibility;
        private System.Windows.Forms.Label lblStrength;
        private CustRoundedButton crBtnStrength;
        private CustRoundedButton crBtnGeneratePassword;
        private CustRoundedButton crBtnChangePassword;
        private System.Windows.Forms.Label lblConfPass;
        private CustomControls.CustomTextBox cTBConfPassword;
        private System.Windows.Forms.Label lblNewPass;
        private CustomControls.CustomTextBox cTBNewPassword;
        private System.Windows.Forms.Label lblCreateNewPassword;
        private System.Windows.Forms.Label lblNewPassMsg;
        private System.Windows.Forms.Button btnClose;
    }
}