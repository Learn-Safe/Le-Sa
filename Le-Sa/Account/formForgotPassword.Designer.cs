
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
            this.lblForgotPass = new System.Windows.Forms.Label();
            this.cTBUsername = new Le_Sa.CustomControls.CustomTextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblForgotPass
            // 
            this.lblForgotPass.AutoSize = true;
            this.lblForgotPass.BackColor = System.Drawing.Color.Transparent;
            this.lblForgotPass.Enabled = false;
            this.lblForgotPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForgotPass.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblForgotPass.Location = new System.Drawing.Point(12, 9);
            this.lblForgotPass.Name = "lblForgotPass";
            this.lblForgotPass.Size = new System.Drawing.Size(208, 37);
            this.lblForgotPass.TabIndex = 0;
            this.lblForgotPass.Text = "Get on Board";
            this.lblForgotPass.Click += new System.EventHandler(this.lblWelcome_Click);
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
            this.cTBUsername.Location = new System.Drawing.Point(10, 114);
            this.cTBUsername.Margin = new System.Windows.Forms.Padding(1);
            this.cTBUsername.Multiline = false;
            this.cTBUsername.Name = "cTBUsername";
            this.cTBUsername.Padding = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.cTBUsername.PasswordChar = false;
            this.cTBUsername.Size = new System.Drawing.Size(245, 27);
            this.cTBUsername.TabIndex = 69;
            this.cTBUsername.Texts = "";
            this.cTBUsername.UnderlinedStyle = false;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.White;
            this.lblUsername.Location = new System.Drawing.Point(12, 88);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(105, 25);
            this.lblUsername.TabIndex = 68;
            this.lblUsername.Text = "Username";
            // 
            // formForgotPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(46)))), ((int)(((byte)(76)))));
            this.ClientSize = new System.Drawing.Size(265, 273);
            this.Controls.Add(this.cTBUsername);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblForgotPass);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formForgotPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formForgotPassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblForgotPass;
        private CustomControls.CustomTextBox cTBUsername;
        private System.Windows.Forms.Label lblUsername;
    }
}