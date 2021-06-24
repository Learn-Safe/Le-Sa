
namespace Le_Sa.Account
{
    partial class formLogin
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
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.llblForgotPassword = new System.Windows.Forms.LinkLabel();
            this.crBtnVisibility = new Le_Sa.CustRoundedButton();
            this.cTBUsername = new Le_Sa.CustomControls.CustomTextBox();
            this.cTBPassword = new Le_Sa.CustomControls.CustomTextBox();
            this.crBtnContinue = new Le_Sa.CustRoundedButton();
            this.SuspendLayout();
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.White;
            this.lblUsername.Location = new System.Drawing.Point(12, 206);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(105, 25);
            this.lblUsername.TabIndex = 65;
            this.lblUsername.Text = "Username";
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.White;
            this.lblWelcome.Location = new System.Drawing.Point(4, 89);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(186, 62);
            this.lblWelcome.TabIndex = 64;
            this.lblWelcome.Text = "Hello there,\r\nwelcome back\r\n";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.White;
            this.lblPassword.Location = new System.Drawing.Point(7, 285);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(99, 25);
            this.lblPassword.TabIndex = 66;
            this.lblPassword.Text = "Password";
            // 
            // llblForgotPassword
            // 
            this.llblForgotPassword.AutoSize = true;
            this.llblForgotPassword.Font = new System.Drawing.Font("Malgun Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llblForgotPassword.LinkColor = System.Drawing.Color.LightGray;
            this.llblForgotPassword.Location = new System.Drawing.Point(8, 345);
            this.llblForgotPassword.Name = "llblForgotPassword";
            this.llblForgotPassword.Size = new System.Drawing.Size(128, 20);
            this.llblForgotPassword.TabIndex = 72;
            this.llblForgotPassword.TabStop = true;
            this.llblForgotPassword.Text = "Forgot password?";
            this.llblForgotPassword.VisitedLinkColor = System.Drawing.Color.LightGray;
            // 
            // crBtnVisibility
            // 
            this.crBtnVisibility.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.crBtnVisibility.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.crBtnVisibility.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.crBtnVisibility.BorderColor = System.Drawing.SystemColors.ScrollBar;
            this.crBtnVisibility.BorderRadius = 20;
            this.crBtnVisibility.BorderSize = 2;
            this.crBtnVisibility.FlatAppearance.BorderSize = 0;
            this.crBtnVisibility.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.crBtnVisibility.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.crBtnVisibility.Image = global::Le_Sa.Properties.Resources.hide_22px;
            this.crBtnVisibility.Location = new System.Drawing.Point(228, 311);
            this.crBtnVisibility.Name = "crBtnVisibility";
            this.crBtnVisibility.Size = new System.Drawing.Size(27, 27);
            this.crBtnVisibility.TabIndex = 68;
            this.crBtnVisibility.TextColor = System.Drawing.SystemColors.ScrollBar;
            this.crBtnVisibility.UseVisualStyleBackColor = false;
            this.crBtnVisibility.MouseDown += new System.Windows.Forms.MouseEventHandler(this.crBtnVisibility_MouseDown);
            this.crBtnVisibility.MouseUp += new System.Windows.Forms.MouseEventHandler(this.crBtnVisibility_MouseUp);
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
            this.cTBUsername.Location = new System.Drawing.Point(10, 232);
            this.cTBUsername.Margin = new System.Windows.Forms.Padding(1);
            this.cTBUsername.Multiline = false;
            this.cTBUsername.Name = "cTBUsername";
            this.cTBUsername.Padding = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.cTBUsername.PasswordChar = false;
            this.cTBUsername.Size = new System.Drawing.Size(245, 27);
            this.cTBUsername.TabIndex = 67;
            this.cTBUsername.Texts = "";
            this.cTBUsername.UnderlinedStyle = false;
            // 
            // cTBPassword
            // 
            this.cTBPassword.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.cTBPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(75)))));
            this.cTBPassword.BorderFocusColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(75)))));
            this.cTBPassword.BorderRadius = 20;
            this.cTBPassword.BorderSize = 0;
            this.cTBPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cTBPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.cTBPassword.Location = new System.Drawing.Point(10, 311);
            this.cTBPassword.Margin = new System.Windows.Forms.Padding(1);
            this.cTBPassword.Multiline = false;
            this.cTBPassword.Name = "cTBPassword";
            this.cTBPassword.Padding = new System.Windows.Forms.Padding(6, 4, 35, 4);
            this.cTBPassword.PasswordChar = true;
            this.cTBPassword.Size = new System.Drawing.Size(245, 27);
            this.cTBPassword.TabIndex = 69;
            this.cTBPassword.Texts = "";
            this.cTBPassword.UnderlinedStyle = false;
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
            this.crBtnContinue.Location = new System.Drawing.Point(12, 425);
            this.crBtnContinue.Name = "crBtnContinue";
            this.crBtnContinue.Size = new System.Drawing.Size(241, 31);
            this.crBtnContinue.TabIndex = 70;
            this.crBtnContinue.Text = "Continue";
            this.crBtnContinue.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.crBtnContinue.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(107)))), ((int)(((byte)(22)))));
            this.crBtnContinue.UseVisualStyleBackColor = false;
            this.crBtnContinue.Click += new System.EventHandler(this.crBtnContinue_Click);
            // 
            // formLogin
            // 
            this.AcceptButton = this.crBtnContinue;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(46)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(265, 490);
            this.Controls.Add(this.crBtnVisibility);
            this.Controls.Add(this.cTBUsername);
            this.Controls.Add(this.cTBPassword);
            this.Controls.Add(this.crBtnContinue);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.llblForgotPassword);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(265, 490);
            this.MinimumSize = new System.Drawing.Size(265, 424);
            this.Name = "formLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustRoundedButton crBtnVisibility;
        private CustomControls.CustomTextBox cTBUsername;
        private CustomControls.CustomTextBox cTBPassword;
        private CustRoundedButton crBtnContinue;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.LinkLabel llblForgotPassword;
    }
}