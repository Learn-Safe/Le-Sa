
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formDesktop));
            this.pnlDesktop = new System.Windows.Forms.Panel();
            this.pnlUser = new System.Windows.Forms.Panel();
            this.lblUserName = new System.Windows.Forms.Label();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.crBtnSettings = new Le_Sa.CustRoundedButton();
            this.crBtnHistory = new Le_Sa.CustRoundedButton();
            this.crBtnBrowserControls = new Le_Sa.CustRoundedButton();
            this.cRPBDP = new Le_Sa.CustRoundedPictureBox();
            this.pnlUser.SuspendLayout();
            this.pnlMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cRPBDP)).BeginInit();
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
            this.pnlUser.Controls.Add(this.cRPBDP);
            this.pnlUser.Controls.Add(this.lblUserName);
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
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(27)))), ((int)(((byte)(56)))));
            this.pnlMenu.Controls.Add(this.crBtnHistory);
            this.pnlMenu.Controls.Add(this.crBtnSettings);
            this.pnlMenu.Controls.Add(this.crBtnBrowserControls);
            this.pnlMenu.Controls.Add(this.pnlUser);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(240, 561);
            this.pnlMenu.TabIndex = 0;
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
            this.crBtnHistory.Location = new System.Drawing.Point(12, 246);
            this.crBtnHistory.Name = "crBtnHistory";
            this.crBtnHistory.Size = new System.Drawing.Size(216, 105);
            this.crBtnHistory.TabIndex = 10;
            this.crBtnHistory.Text = "History";
            this.crBtnHistory.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.crBtnHistory.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(211)))), ((int)(((byte)(213)))));
            this.crBtnHistory.UseVisualStyleBackColor = false;
            this.crBtnHistory.Click += new System.EventHandler(this.crBtnHistory_Click);
            // 
            // crBtnBrowserControls
            // 
            this.crBtnBrowserControls.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(46)))), ((int)(((byte)(76)))));
            this.crBtnBrowserControls.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(46)))), ((int)(((byte)(76)))));
            this.crBtnBrowserControls.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.crBtnBrowserControls.BorderRadius = 20;
            this.crBtnBrowserControls.BorderSize = 0;
            this.crBtnBrowserControls.FlatAppearance.BorderSize = 0;
            this.crBtnBrowserControls.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.crBtnBrowserControls.Font = new System.Drawing.Font("Microsoft Tai Le", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crBtnBrowserControls.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(211)))), ((int)(((byte)(213)))));
            this.crBtnBrowserControls.Image = global::Le_Sa.Properties.Resources.browser_control_65;
            this.crBtnBrowserControls.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.crBtnBrowserControls.Location = new System.Drawing.Point(12, 357);
            this.crBtnBrowserControls.Name = "crBtnBrowserControls";
            this.crBtnBrowserControls.Size = new System.Drawing.Size(216, 105);
            this.crBtnBrowserControls.TabIndex = 0;
            this.crBtnBrowserControls.Text = "Browser Controls";
            this.crBtnBrowserControls.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.crBtnBrowserControls.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(211)))), ((int)(((byte)(213)))));
            this.crBtnBrowserControls.UseVisualStyleBackColor = false;
            this.crBtnBrowserControls.Click += new System.EventHandler(this.crBtnBrowserControls_Click);
            // 
            // cRPBDP
            // 
            this.cRPBDP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(46)))), ((int)(((byte)(76)))));
            this.cRPBDP.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(46)))), ((int)(((byte)(76)))));
            this.cRPBDP.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(44)))), ((int)(((byte)(90)))));
            this.cRPBDP.BorderRadius = 150;
            this.cRPBDP.BorderSize = 3;
            this.cRPBDP.Image = global::Le_Sa.Properties.Resources.user_90px;
            this.cRPBDP.Location = new System.Drawing.Point(45, 27);
            this.cRPBDP.Name = "cRPBDP";
            this.cRPBDP.Size = new System.Drawing.Size(150, 150);
            this.cRPBDP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.cRPBDP.TabIndex = 2;
            this.cRPBDP.TabStop = false;
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(950, 600);
            this.Name = "formDesktop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Le-Sa";
            this.Load += new System.EventHandler(this.formDesktop_Load);
            this.pnlUser.ResumeLayout(false);
            this.pnlUser.PerformLayout();
            this.pnlMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cRPBDP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlDesktop;
        private System.Windows.Forms.Panel pnlUser;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Panel pnlMenu;
        private CustRoundedButton crBtnSettings;
        private CustRoundedButton crBtnBrowserControls;
        private CustRoundedButton crBtnHistory;
        private CustRoundedPictureBox cRPBDP;
    }
}