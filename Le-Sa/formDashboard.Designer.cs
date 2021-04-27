namespace Le_Sa
{
    partial class formDashboard
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
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.ibtnSettings = new FontAwesome.Sharp.IconButton();
            this.ibtnInfo = new FontAwesome.Sharp.IconButton();
            this.ibtnRports = new FontAwesome.Sharp.IconButton();
            this.ibtnDashboard = new FontAwesome.Sharp.IconButton();
            this.pnlUser = new System.Windows.Forms.Panel();
            this.lblUserName = new System.Windows.Forms.Label();
            this.pbUserPic = new System.Windows.Forms.PictureBox();
            this.pnlMenu.SuspendLayout();
            this.pnlUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserPic)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.pnlMenu.Controls.Add(this.ibtnSettings);
            this.pnlMenu.Controls.Add(this.ibtnInfo);
            this.pnlMenu.Controls.Add(this.ibtnRports);
            this.pnlMenu.Controls.Add(this.ibtnDashboard);
            this.pnlMenu.Controls.Add(this.pnlUser);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(186, 557);
            this.pnlMenu.TabIndex = 0;
            // 
            // ibtnSettings
            // 
            this.ibtnSettings.AutoSize = true;
            this.ibtnSettings.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ibtnSettings.FlatAppearance.BorderSize = 0;
            this.ibtnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnSettings.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.ibtnSettings.IconChar = FontAwesome.Sharp.IconChar.Tools;
            this.ibtnSettings.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.ibtnSettings.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnSettings.IconSize = 30;
            this.ibtnSettings.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.ibtnSettings.Location = new System.Drawing.Point(0, 517);
            this.ibtnSettings.Name = "ibtnSettings";
            this.ibtnSettings.Size = new System.Drawing.Size(186, 40);
            this.ibtnSettings.TabIndex = 5;
            this.ibtnSettings.Text = "Settings";
            this.ibtnSettings.UseVisualStyleBackColor = true;
            this.ibtnSettings.Click += new System.EventHandler(this.ibtnSettings_Click);
            this.ibtnSettings.Leave += new System.EventHandler(this.ibtnSettings_Leave);
            // 
            // ibtnInfo
            // 
            this.ibtnInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtnInfo.FlatAppearance.BorderSize = 0;
            this.ibtnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnInfo.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.ibtnInfo.IconChar = FontAwesome.Sharp.IconChar.Info;
            this.ibtnInfo.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.ibtnInfo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnInfo.IconSize = 30;
            this.ibtnInfo.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.ibtnInfo.Location = new System.Drawing.Point(0, 224);
            this.ibtnInfo.Name = "ibtnInfo";
            this.ibtnInfo.Size = new System.Drawing.Size(186, 40);
            this.ibtnInfo.TabIndex = 3;
            this.ibtnInfo.Text = "Info";
            this.ibtnInfo.UseVisualStyleBackColor = true;
            this.ibtnInfo.Click += new System.EventHandler(this.ibtnInfo_Click);
            this.ibtnInfo.Leave += new System.EventHandler(this.ibtnInfo_Leave);
            // 
            // ibtnRports
            // 
            this.ibtnRports.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtnRports.FlatAppearance.BorderSize = 0;
            this.ibtnRports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnRports.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnRports.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.ibtnRports.IconChar = FontAwesome.Sharp.IconChar.ChartBar;
            this.ibtnRports.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.ibtnRports.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnRports.IconSize = 30;
            this.ibtnRports.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.ibtnRports.Location = new System.Drawing.Point(0, 184);
            this.ibtnRports.Name = "ibtnRports";
            this.ibtnRports.Size = new System.Drawing.Size(186, 40);
            this.ibtnRports.TabIndex = 2;
            this.ibtnRports.Text = "Reports";
            this.ibtnRports.UseVisualStyleBackColor = true;
            this.ibtnRports.Click += new System.EventHandler(this.ibtnRports_Click);
            this.ibtnRports.Leave += new System.EventHandler(this.ibtnRports_Leave);
            // 
            // ibtnDashboard
            // 
            this.ibtnDashboard.BackColor = System.Drawing.Color.White;
            this.ibtnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtnDashboard.FlatAppearance.BorderSize = 0;
            this.ibtnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnDashboard.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnDashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.ibtnDashboard.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.ibtnDashboard.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.ibtnDashboard.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnDashboard.IconSize = 30;
            this.ibtnDashboard.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.ibtnDashboard.Location = new System.Drawing.Point(0, 144);
            this.ibtnDashboard.Name = "ibtnDashboard";
            this.ibtnDashboard.Size = new System.Drawing.Size(186, 40);
            this.ibtnDashboard.TabIndex = 1;
            this.ibtnDashboard.Text = "Dashboard";
            this.ibtnDashboard.UseVisualStyleBackColor = false;
            this.ibtnDashboard.Click += new System.EventHandler(this.ibtnDashboard_Click);
            this.ibtnDashboard.Leave += new System.EventHandler(this.ibtnDashboard_Leave);
            // 
            // pnlUser
            // 
            this.pnlUser.Controls.Add(this.lblUserName);
            this.pnlUser.Controls.Add(this.pbUserPic);
            this.pnlUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUser.Location = new System.Drawing.Point(0, 0);
            this.pnlUser.Name = "pnlUser";
            this.pnlUser.Size = new System.Drawing.Size(186, 144);
            this.pnlUser.TabIndex = 0;
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(156)))), ((int)(((byte)(149)))));
            this.lblUserName.Location = new System.Drawing.Point(46, 92);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(94, 21);
            this.lblUserName.TabIndex = 1;
            this.lblUserName.Text = "User Name";
            // 
            // pbUserPic
            // 
            this.pbUserPic.Image = global::Le_Sa.Properties.Resources.user_ico_64;
            this.pbUserPic.Location = new System.Drawing.Point(60, 16);
            this.pbUserPic.Name = "pbUserPic";
            this.pbUserPic.Size = new System.Drawing.Size(67, 67);
            this.pbUserPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbUserPic.TabIndex = 0;
            this.pbUserPic.TabStop = false;
            // 
            // formDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(951, 557);
            this.Controls.Add(this.pnlMenu);
            this.MinimumSize = new System.Drawing.Size(967, 596);
            this.Name = "formDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.formDashboard_Load);
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            this.pnlUser.ResumeLayout(false);
            this.pnlUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlUser;
        private System.Windows.Forms.PictureBox pbUserPic;
        private System.Windows.Forms.Label lblUserName;
        private FontAwesome.Sharp.IconButton ibtnDashboard;
        private FontAwesome.Sharp.IconButton ibtnSettings;
        private FontAwesome.Sharp.IconButton ibtnInfo;
        private FontAwesome.Sharp.IconButton ibtnRports;
    }
}