
namespace Le_Sa
{
    partial class formDesktop
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
            this.pnlDesktop = new System.Windows.Forms.Panel();
            this.pnlUser = new System.Windows.Forms.Panel();
            this.lblUserName = new System.Windows.Forms.Label();
            this.pbUserPic = new System.Windows.Forms.PictureBox();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.crBtnHistory = new Le_Sa.CustRoundedButton();
            this.custRoundedButton5 = new Le_Sa.CustRoundedButton();
            this.custRoundedButton4 = new Le_Sa.CustRoundedButton();
            this.crBtnSettings = new Le_Sa.CustRoundedButton();
            this.crBtnDashboard = new Le_Sa.CustRoundedButton();
            this.pnlUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserPic)).BeginInit();
            this.pnlMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDesktop
            // 
            this.pnlDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(75)))));
            this.pnlDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDesktop.Location = new System.Drawing.Point(240, 0);
            this.pnlDesktop.Name = "pnlDesktop";
            this.pnlDesktop.Size = new System.Drawing.Size(694, 561);
            this.pnlDesktop.TabIndex = 2;
            // 
            // pnlUser
            // 
            this.pnlUser.Controls.Add(this.lblUserName);
            this.pnlUser.Controls.Add(this.pbUserPic);
            this.pnlUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUser.Location = new System.Drawing.Point(0, 0);
            this.pnlUser.Name = "pnlUser";
            this.pnlUser.Size = new System.Drawing.Size(240, 240);
            this.pnlUser.TabIndex = 0;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Tai Le", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(169)))), ((int)(((byte)(173)))));
            this.lblUserName.Location = new System.Drawing.Point(48, 192);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(145, 31);
            this.lblUserName.TabIndex = 1;
            this.lblUserName.Text = "USERNAME";
            // 
            // pbUserPic
            // 
            this.pbUserPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pbUserPic.Location = new System.Drawing.Point(55, 42);
            this.pbUserPic.Name = "pbUserPic";
            this.pbUserPic.Size = new System.Drawing.Size(130, 130);
            this.pbUserPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbUserPic.TabIndex = 0;
            this.pbUserPic.TabStop = false;
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(27)))), ((int)(((byte)(56)))));
            this.pnlMenu.Controls.Add(this.crBtnHistory);
            this.pnlMenu.Controls.Add(this.custRoundedButton5);
            this.pnlMenu.Controls.Add(this.custRoundedButton4);
            this.pnlMenu.Controls.Add(this.crBtnSettings);
            this.pnlMenu.Controls.Add(this.crBtnDashboard);
            this.pnlMenu.Controls.Add(this.pnlUser);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(240, 561);
            this.pnlMenu.TabIndex = 0;
            // 
            // crBtnHistory
            // 
            this.crBtnHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(46)))), ((int)(((byte)(76)))));
            this.crBtnHistory.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(46)))), ((int)(((byte)(76)))));
            this.crBtnHistory.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.crBtnHistory.BorderRadius = 20;
            this.crBtnHistory.BorderSize = 0;
            this.crBtnHistory.FlatAppearance.BorderSize = 0;
            this.crBtnHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.crBtnHistory.Font = new System.Drawing.Font("Microsoft Tai Le", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crBtnHistory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(211)))), ((int)(((byte)(213)))));
            this.crBtnHistory.Image = global::Le_Sa.Properties.Resources.history_65px;
            this.crBtnHistory.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.crBtnHistory.Location = new System.Drawing.Point(125, 358);
            this.crBtnHistory.Name = "crBtnHistory";
            this.crBtnHistory.Size = new System.Drawing.Size(105, 105);
            this.crBtnHistory.TabIndex = 10;
            this.crBtnHistory.Text = "History";
            this.crBtnHistory.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.crBtnHistory.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(211)))), ((int)(((byte)(213)))));
            this.crBtnHistory.UseVisualStyleBackColor = false;
            this.crBtnHistory.Click += new System.EventHandler(this.crBtnHistory_Click);
            // 
            // custRoundedButton5
            // 
            this.custRoundedButton5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(46)))), ((int)(((byte)(76)))));
            this.custRoundedButton5.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(46)))), ((int)(((byte)(76)))));
            this.custRoundedButton5.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.custRoundedButton5.BorderRadius = 20;
            this.custRoundedButton5.BorderSize = 0;
            this.custRoundedButton5.FlatAppearance.BorderSize = 0;
            this.custRoundedButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.custRoundedButton5.Font = new System.Drawing.Font("Microsoft Tai Le", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custRoundedButton5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(211)))), ((int)(((byte)(213)))));
            this.custRoundedButton5.Location = new System.Drawing.Point(12, 358);
            this.custRoundedButton5.Name = "custRoundedButton5";
            this.custRoundedButton5.Size = new System.Drawing.Size(105, 105);
            this.custRoundedButton5.TabIndex = 9;
            this.custRoundedButton5.Text = "custRoundedButton5";
            this.custRoundedButton5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.custRoundedButton5.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(211)))), ((int)(((byte)(213)))));
            this.custRoundedButton5.UseVisualStyleBackColor = false;
            // 
            // custRoundedButton4
            // 
            this.custRoundedButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(46)))), ((int)(((byte)(76)))));
            this.custRoundedButton4.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(46)))), ((int)(((byte)(76)))));
            this.custRoundedButton4.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.custRoundedButton4.BorderRadius = 20;
            this.custRoundedButton4.BorderSize = 0;
            this.custRoundedButton4.FlatAppearance.BorderSize = 0;
            this.custRoundedButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.custRoundedButton4.Font = new System.Drawing.Font("Microsoft Tai Le", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.custRoundedButton4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(211)))), ((int)(((byte)(213)))));
            this.custRoundedButton4.Location = new System.Drawing.Point(125, 246);
            this.custRoundedButton4.Name = "custRoundedButton4";
            this.custRoundedButton4.Size = new System.Drawing.Size(105, 105);
            this.custRoundedButton4.TabIndex = 8;
            this.custRoundedButton4.Text = "custRoundedButton4";
            this.custRoundedButton4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.custRoundedButton4.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(211)))), ((int)(((byte)(213)))));
            this.custRoundedButton4.UseVisualStyleBackColor = false;
            // 
            // crBtnSettings
            // 
            this.crBtnSettings.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.crBtnSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(46)))), ((int)(((byte)(74)))));
            this.crBtnSettings.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(46)))), ((int)(((byte)(74)))));
            this.crBtnSettings.BorderColor = System.Drawing.Color.PapayaWhip;
            this.crBtnSettings.BorderRadius = 15;
            this.crBtnSettings.BorderSize = 0;
            this.crBtnSettings.FlatAppearance.BorderSize = 0;
            this.crBtnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.crBtnSettings.Font = new System.Drawing.Font("Microsoft Tai Le", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crBtnSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(39)))), ((int)(((byte)(29)))));
            this.crBtnSettings.Location = new System.Drawing.Point(12, 510);
            this.crBtnSettings.Name = "crBtnSettings";
            this.crBtnSettings.Size = new System.Drawing.Size(216, 39);
            this.crBtnSettings.TabIndex = 7;
            this.crBtnSettings.Text = "Settings";
            this.crBtnSettings.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(39)))), ((int)(((byte)(29)))));
            this.crBtnSettings.UseVisualStyleBackColor = false;
            this.crBtnSettings.Click += new System.EventHandler(this.crBtnSettings_Click);
            // 
            // crBtnDashboard
            // 
            this.crBtnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(46)))), ((int)(((byte)(76)))));
            this.crBtnDashboard.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(46)))), ((int)(((byte)(76)))));
            this.crBtnDashboard.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.crBtnDashboard.BorderRadius = 20;
            this.crBtnDashboard.BorderSize = 0;
            this.crBtnDashboard.FlatAppearance.BorderSize = 0;
            this.crBtnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.crBtnDashboard.Font = new System.Drawing.Font("Microsoft Tai Le", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crBtnDashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(211)))), ((int)(((byte)(213)))));
            this.crBtnDashboard.Image = global::Le_Sa.Properties.Resources.dashboard_65px;
            this.crBtnDashboard.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.crBtnDashboard.Location = new System.Drawing.Point(11, 246);
            this.crBtnDashboard.Name = "crBtnDashboard";
            this.crBtnDashboard.Size = new System.Drawing.Size(105, 105);
            this.crBtnDashboard.TabIndex = 0;
            this.crBtnDashboard.Text = "Dashboard";
            this.crBtnDashboard.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.crBtnDashboard.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(211)))), ((int)(((byte)(213)))));
            this.crBtnDashboard.UseVisualStyleBackColor = false;
            this.crBtnDashboard.Click += new System.EventHandler(this.crBtnDashboard_Click);
            // 
            // formDesktop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(74)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(934, 561);
            this.Controls.Add(this.pnlDesktop);
            this.Controls.Add(this.pnlMenu);
            this.MinimumSize = new System.Drawing.Size(950, 600);
            this.Name = "formDesktop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Le-Sa";
            this.pnlUser.ResumeLayout(false);
            this.pnlUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserPic)).EndInit();
            this.pnlMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlDesktop;
        private System.Windows.Forms.Panel pnlUser;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.PictureBox pbUserPic;
        private System.Windows.Forms.Panel pnlMenu;
        private CustRoundedButton crBtnSettings;
        private CustRoundedButton crBtnDashboard;
        private CustRoundedButton custRoundedButton5;
        private CustRoundedButton custRoundedButton4;
        private CustRoundedButton crBtnHistory;
    }
}