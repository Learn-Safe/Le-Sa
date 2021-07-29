
namespace Le_Sa.Settings
{
    partial class formDNSConfig
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
            this.wvOpenDNS = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.pnlNav = new System.Windows.Forms.Panel();
            this.crBtnSignUp = new Le_Sa.CustRoundedButton();
            this.crBtnHome = new Le_Sa.CustRoundedButton();
            this.crBtnReload = new Le_Sa.CustRoundedButton();
            this.crBtnForward = new Le_Sa.CustRoundedButton();
            this.crBtnBack = new Le_Sa.CustRoundedButton();
            this.crBtnSetup = new Le_Sa.CustRoundedButton();
            this.custRoundedButton1 = new Le_Sa.CustRoundedButton();
            this.pnlDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wvOpenDNS)).BeginInit();
            this.pnlNav.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDesktop
            // 
            this.pnlDesktop.Controls.Add(this.wvOpenDNS);
            this.pnlDesktop.Controls.Add(this.pnlNav);
            this.pnlDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDesktop.Location = new System.Drawing.Point(0, 0);
            this.pnlDesktop.Name = "pnlDesktop";
            this.pnlDesktop.Size = new System.Drawing.Size(694, 521);
            this.pnlDesktop.TabIndex = 0;
            // 
            // wvOpenDNS
            // 
            this.wvOpenDNS.CreationProperties = null;
            this.wvOpenDNS.DefaultBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(75)))));
            this.wvOpenDNS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wvOpenDNS.Location = new System.Drawing.Point(0, 68);
            this.wvOpenDNS.Name = "wvOpenDNS";
            this.wvOpenDNS.Size = new System.Drawing.Size(694, 453);
            this.wvOpenDNS.Source = new System.Uri("https://login.opendns.com/?return_to=https://dashboard.opendns.com/", System.UriKind.Absolute);
            this.wvOpenDNS.TabIndex = 6;
            this.wvOpenDNS.ZoomFactor = 1D;
            // 
            // pnlNav
            // 
            this.pnlNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(75)))));
            this.pnlNav.Controls.Add(this.custRoundedButton1);
            this.pnlNav.Controls.Add(this.crBtnSetup);
            this.pnlNav.Controls.Add(this.crBtnSignUp);
            this.pnlNav.Controls.Add(this.crBtnHome);
            this.pnlNav.Controls.Add(this.crBtnReload);
            this.pnlNav.Controls.Add(this.crBtnForward);
            this.pnlNav.Controls.Add(this.crBtnBack);
            this.pnlNav.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlNav.Location = new System.Drawing.Point(0, 0);
            this.pnlNav.Name = "pnlNav";
            this.pnlNav.Size = new System.Drawing.Size(694, 68);
            this.pnlNav.TabIndex = 5;
            // 
            // crBtnSignUp
            // 
            this.crBtnSignUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.crBtnSignUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(27)))), ((int)(((byte)(56)))));
            this.crBtnSignUp.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(27)))), ((int)(((byte)(56)))));
            this.crBtnSignUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.crBtnSignUp.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.crBtnSignUp.BorderRadius = 10;
            this.crBtnSignUp.BorderSize = 0;
            this.crBtnSignUp.FlatAppearance.BorderSize = 0;
            this.crBtnSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.crBtnSignUp.Font = new System.Drawing.Font("Microsoft Tai Le", 11F);
            this.crBtnSignUp.ForeColor = System.Drawing.Color.White;
            this.crBtnSignUp.Location = new System.Drawing.Point(514, 3);
            this.crBtnSignUp.Name = "crBtnSignUp";
            this.crBtnSignUp.Size = new System.Drawing.Size(175, 29);
            this.crBtnSignUp.TabIndex = 10;
            this.crBtnSignUp.Text = "Didn\'t have an account?";
            this.crBtnSignUp.TextColor = System.Drawing.Color.White;
            this.crBtnSignUp.UseVisualStyleBackColor = false;
            this.crBtnSignUp.Click += new System.EventHandler(this.crBtnSignUp_Click);
            // 
            // crBtnHome
            // 
            this.crBtnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(27)))), ((int)(((byte)(56)))));
            this.crBtnHome.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(27)))), ((int)(((byte)(56)))));
            this.crBtnHome.BackgroundImage = global::Le_Sa.Properties.Resources.home_48px;
            this.crBtnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.crBtnHome.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.crBtnHome.BorderRadius = 10;
            this.crBtnHome.BorderSize = 0;
            this.crBtnHome.FlatAppearance.BorderSize = 0;
            this.crBtnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.crBtnHome.ForeColor = System.Drawing.Color.White;
            this.crBtnHome.Location = new System.Drawing.Point(3, 3);
            this.crBtnHome.Name = "crBtnHome";
            this.crBtnHome.Size = new System.Drawing.Size(31, 31);
            this.crBtnHome.TabIndex = 8;
            this.crBtnHome.TextColor = System.Drawing.Color.White;
            this.crBtnHome.UseVisualStyleBackColor = false;
            this.crBtnHome.Click += new System.EventHandler(this.crBtnHome_Click);
            // 
            // crBtnReload
            // 
            this.crBtnReload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(27)))), ((int)(((byte)(56)))));
            this.crBtnReload.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(27)))), ((int)(((byte)(56)))));
            this.crBtnReload.BackgroundImage = global::Le_Sa.Properties.Resources.reload_48px;
            this.crBtnReload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.crBtnReload.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.crBtnReload.BorderRadius = 10;
            this.crBtnReload.BorderSize = 0;
            this.crBtnReload.FlatAppearance.BorderSize = 0;
            this.crBtnReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.crBtnReload.ForeColor = System.Drawing.Color.White;
            this.crBtnReload.Location = new System.Drawing.Point(40, 3);
            this.crBtnReload.Name = "crBtnReload";
            this.crBtnReload.Size = new System.Drawing.Size(31, 31);
            this.crBtnReload.TabIndex = 6;
            this.crBtnReload.TextColor = System.Drawing.Color.White;
            this.crBtnReload.UseVisualStyleBackColor = false;
            this.crBtnReload.Click += new System.EventHandler(this.crBtnReload_Click);
            // 
            // crBtnForward
            // 
            this.crBtnForward.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(27)))), ((int)(((byte)(56)))));
            this.crBtnForward.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(27)))), ((int)(((byte)(56)))));
            this.crBtnForward.BackgroundImage = global::Le_Sa.Properties.Resources.forward_48px;
            this.crBtnForward.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.crBtnForward.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.crBtnForward.BorderRadius = 10;
            this.crBtnForward.BorderSize = 0;
            this.crBtnForward.FlatAppearance.BorderSize = 0;
            this.crBtnForward.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.crBtnForward.ForeColor = System.Drawing.Color.White;
            this.crBtnForward.Location = new System.Drawing.Point(40, 35);
            this.crBtnForward.Name = "crBtnForward";
            this.crBtnForward.Size = new System.Drawing.Size(31, 31);
            this.crBtnForward.TabIndex = 4;
            this.crBtnForward.TextColor = System.Drawing.Color.White;
            this.crBtnForward.UseVisualStyleBackColor = false;
            this.crBtnForward.Click += new System.EventHandler(this.crBtnForward_Click);
            // 
            // crBtnBack
            // 
            this.crBtnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(27)))), ((int)(((byte)(56)))));
            this.crBtnBack.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(27)))), ((int)(((byte)(56)))));
            this.crBtnBack.BackgroundImage = global::Le_Sa.Properties.Resources.back_48px;
            this.crBtnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.crBtnBack.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.crBtnBack.BorderRadius = 10;
            this.crBtnBack.BorderSize = 0;
            this.crBtnBack.FlatAppearance.BorderSize = 0;
            this.crBtnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.crBtnBack.ForeColor = System.Drawing.Color.White;
            this.crBtnBack.Location = new System.Drawing.Point(3, 35);
            this.crBtnBack.Name = "crBtnBack";
            this.crBtnBack.Size = new System.Drawing.Size(31, 31);
            this.crBtnBack.TabIndex = 2;
            this.crBtnBack.TextColor = System.Drawing.Color.White;
            this.crBtnBack.UseVisualStyleBackColor = false;
            this.crBtnBack.Click += new System.EventHandler(this.crBtnBack_Click);
            // 
            // crBtnSetup
            // 
            this.crBtnSetup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.crBtnSetup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(27)))), ((int)(((byte)(56)))));
            this.crBtnSetup.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(27)))), ((int)(((byte)(56)))));
            this.crBtnSetup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.crBtnSetup.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.crBtnSetup.BorderRadius = 10;
            this.crBtnSetup.BorderSize = 0;
            this.crBtnSetup.FlatAppearance.BorderSize = 0;
            this.crBtnSetup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.crBtnSetup.Font = new System.Drawing.Font("Microsoft Tai Le", 11F);
            this.crBtnSetup.ForeColor = System.Drawing.Color.White;
            this.crBtnSetup.Location = new System.Drawing.Point(467, 35);
            this.crBtnSetup.Name = "crBtnSetup";
            this.crBtnSetup.Size = new System.Drawing.Size(222, 29);
            this.crBtnSetup.TabIndex = 11;
            this.crBtnSetup.Text = "Setup OpenDNS on this device";
            this.crBtnSetup.TextColor = System.Drawing.Color.White;
            this.crBtnSetup.UseVisualStyleBackColor = false;
            // 
            // custRoundedButton1
            // 
            this.custRoundedButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.custRoundedButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(27)))), ((int)(((byte)(56)))));
            this.custRoundedButton1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(27)))), ((int)(((byte)(56)))));
            this.custRoundedButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.custRoundedButton1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.custRoundedButton1.BorderRadius = 10;
            this.custRoundedButton1.BorderSize = 0;
            this.custRoundedButton1.FlatAppearance.BorderSize = 0;
            this.custRoundedButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.custRoundedButton1.Font = new System.Drawing.Font("Microsoft Tai Le", 11F);
            this.custRoundedButton1.ForeColor = System.Drawing.Color.White;
            this.custRoundedButton1.Location = new System.Drawing.Point(238, 35);
            this.custRoundedButton1.Name = "custRoundedButton1";
            this.custRoundedButton1.Size = new System.Drawing.Size(223, 29);
            this.custRoundedButton1.TabIndex = 12;
            this.custRoundedButton1.Text = "Setup OpenDNS on your router";
            this.custRoundedButton1.TextColor = System.Drawing.Color.White;
            this.custRoundedButton1.UseVisualStyleBackColor = false;
            // 
            // formDNSConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(75)))));
            this.ClientSize = new System.Drawing.Size(694, 521);
            this.Controls.Add(this.pnlDesktop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formDNSConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "formDNSConfig";
            this.pnlDesktop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.wvOpenDNS)).EndInit();
            this.pnlNav.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDesktop;
        private Microsoft.Web.WebView2.WinForms.WebView2 wvOpenDNS;
        private System.Windows.Forms.Panel pnlNav;
        private CustRoundedButton crBtnReload;
        private CustRoundedButton crBtnForward;
        private CustRoundedButton crBtnBack;
        private CustRoundedButton crBtnHome;
        private CustRoundedButton crBtnSignUp;
        private CustRoundedButton crBtnSetup;
        private CustRoundedButton custRoundedButton1;
    }
}