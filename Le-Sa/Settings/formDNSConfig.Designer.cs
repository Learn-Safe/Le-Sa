
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formDNSConfig));
            this.pnlDesktop = new System.Windows.Forms.Panel();
            this.crBtnClose = new Le_Sa.CustRoundedButton();
            this.crBtnYT = new Le_Sa.CustRoundedButton();
            this.wvOpenDNS = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.pnlNav = new System.Windows.Forms.Panel();
            this.crBtnDNSStatus = new Le_Sa.CustRoundedButton();
            this.crBtnResetThisDevice = new Le_Sa.CustRoundedButton();
            this.crBtnSetupRouter = new Le_Sa.CustRoundedButton();
            this.crBtnSetupThisDevice = new Le_Sa.CustRoundedButton();
            this.crBtnSignUp = new Le_Sa.CustRoundedButton();
            this.crBtnHome = new Le_Sa.CustRoundedButton();
            this.crBtnReload = new Le_Sa.CustRoundedButton();
            this.crBtnForward = new Le_Sa.CustRoundedButton();
            this.crBtnBack = new Le_Sa.CustRoundedButton();
            this.pnlDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wvOpenDNS)).BeginInit();
            this.pnlNav.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDesktop
            // 
            this.pnlDesktop.BackColor = System.Drawing.Color.White;
            this.pnlDesktop.Controls.Add(this.crBtnClose);
            this.pnlDesktop.Controls.Add(this.crBtnYT);
            this.pnlDesktop.Controls.Add(this.wvOpenDNS);
            this.pnlDesktop.Controls.Add(this.pnlNav);
            this.pnlDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDesktop.Location = new System.Drawing.Point(0, 0);
            this.pnlDesktop.Name = "pnlDesktop";
            this.pnlDesktop.Size = new System.Drawing.Size(694, 521);
            this.pnlDesktop.TabIndex = 0;
            // 
            // crBtnClose
            // 
            this.crBtnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.crBtnClose.BackColor = System.Drawing.Color.Red;
            this.crBtnClose.BackgroundColor = System.Drawing.Color.Red;
            this.crBtnClose.BorderColor = System.Drawing.Color.Transparent;
            this.crBtnClose.BorderRadius = 0;
            this.crBtnClose.BorderSize = 2;
            this.crBtnClose.FlatAppearance.BorderSize = 0;
            this.crBtnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.crBtnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crBtnClose.ForeColor = System.Drawing.Color.Black;
            this.crBtnClose.Location = new System.Drawing.Point(126, 482);
            this.crBtnClose.Name = "crBtnClose";
            this.crBtnClose.Size = new System.Drawing.Size(17, 17);
            this.crBtnClose.TabIndex = 8;
            this.crBtnClose.Text = "X";
            this.crBtnClose.TextColor = System.Drawing.Color.Black;
            this.crBtnClose.UseVisualStyleBackColor = false;
            this.crBtnClose.Click += new System.EventHandler(this.crBtnClose_Click);
            // 
            // crBtnYT
            // 
            this.crBtnYT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.crBtnYT.BackColor = System.Drawing.Color.Red;
            this.crBtnYT.BackgroundColor = System.Drawing.Color.Red;
            this.crBtnYT.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.crBtnYT.BorderRadius = 37;
            this.crBtnYT.BorderSize = 2;
            this.crBtnYT.FlatAppearance.BorderSize = 0;
            this.crBtnYT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.crBtnYT.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crBtnYT.ForeColor = System.Drawing.Color.White;
            this.crBtnYT.Location = new System.Drawing.Point(-16, 481);
            this.crBtnYT.Name = "crBtnYT";
            this.crBtnYT.Size = new System.Drawing.Size(159, 37);
            this.crBtnYT.TabIndex = 7;
            this.crBtnYT.Text = "How to setup?";
            this.crBtnYT.TextColor = System.Drawing.Color.White;
            this.crBtnYT.UseVisualStyleBackColor = false;
            this.crBtnYT.Click += new System.EventHandler(this.crBtnYT_Click);
            // 
            // wvOpenDNS
            // 
            this.wvOpenDNS.BackColor = System.Drawing.Color.White;
            this.wvOpenDNS.CreationProperties = null;
            this.wvOpenDNS.DefaultBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(75)))));
            this.wvOpenDNS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wvOpenDNS.Location = new System.Drawing.Point(0, 68);
            this.wvOpenDNS.Name = "wvOpenDNS";
            this.wvOpenDNS.Size = new System.Drawing.Size(694, 453);
            this.wvOpenDNS.Source = new System.Uri("https://login.opendns.com/?return_to=https://dashboard.opendns.com/", System.UriKind.Absolute);
            this.wvOpenDNS.TabIndex = 6;
            this.wvOpenDNS.ZoomFactor = 1D;
            this.wvOpenDNS.NavigationCompleted += new System.EventHandler<Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs>(this.wvOpenDNS_NavigationCompleted);
            // 
            // pnlNav
            // 
            this.pnlNav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(75)))));
            this.pnlNav.Controls.Add(this.crBtnDNSStatus);
            this.pnlNav.Controls.Add(this.crBtnResetThisDevice);
            this.pnlNav.Controls.Add(this.crBtnSetupRouter);
            this.pnlNav.Controls.Add(this.crBtnSetupThisDevice);
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
            // crBtnDNSStatus
            // 
            this.crBtnDNSStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.crBtnDNSStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(27)))), ((int)(((byte)(56)))));
            this.crBtnDNSStatus.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(27)))), ((int)(((byte)(56)))));
            this.crBtnDNSStatus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.crBtnDNSStatus.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(27)))), ((int)(((byte)(56)))));
            this.crBtnDNSStatus.BorderRadius = 10;
            this.crBtnDNSStatus.BorderSize = 0;
            this.crBtnDNSStatus.FlatAppearance.BorderSize = 0;
            this.crBtnDNSStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.crBtnDNSStatus.Font = new System.Drawing.Font("Microsoft Tai Le", 11F);
            this.crBtnDNSStatus.ForeColor = System.Drawing.Color.White;
            this.crBtnDNSStatus.Location = new System.Drawing.Point(203, 35);
            this.crBtnDNSStatus.Name = "crBtnDNSStatus";
            this.crBtnDNSStatus.Size = new System.Drawing.Size(241, 29);
            this.crBtnDNSStatus.TabIndex = 14;
            this.crBtnDNSStatus.Text = "Check user DNS Status";
            this.crBtnDNSStatus.TextColor = System.Drawing.Color.White;
            this.crBtnDNSStatus.UseVisualStyleBackColor = false;
            this.crBtnDNSStatus.Click += new System.EventHandler(this.crBtnDNSStatus_Click);
            // 
            // crBtnResetThisDevice
            // 
            this.crBtnResetThisDevice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.crBtnResetThisDevice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(98)))), ((int)(((byte)(89)))));
            this.crBtnResetThisDevice.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(98)))), ((int)(((byte)(89)))));
            this.crBtnResetThisDevice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.crBtnResetThisDevice.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(87)))), ((int)(((byte)(78)))));
            this.crBtnResetThisDevice.BorderRadius = 10;
            this.crBtnResetThisDevice.BorderSize = 2;
            this.crBtnResetThisDevice.FlatAppearance.BorderSize = 0;
            this.crBtnResetThisDevice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.crBtnResetThisDevice.Font = new System.Drawing.Font("Microsoft Tai Le", 11F);
            this.crBtnResetThisDevice.ForeColor = System.Drawing.Color.White;
            this.crBtnResetThisDevice.Location = new System.Drawing.Point(450, 36);
            this.crBtnResetThisDevice.Name = "crBtnResetThisDevice";
            this.crBtnResetThisDevice.Size = new System.Drawing.Size(241, 29);
            this.crBtnResetThisDevice.TabIndex = 13;
            this.crBtnResetThisDevice.Text = "Reset DNS settings on this device";
            this.crBtnResetThisDevice.TextColor = System.Drawing.Color.White;
            this.crBtnResetThisDevice.UseVisualStyleBackColor = false;
            this.crBtnResetThisDevice.Click += new System.EventHandler(this.crBtnResetThisDevice_Click);
            // 
            // crBtnSetupRouter
            // 
            this.crBtnSetupRouter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.crBtnSetupRouter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(27)))), ((int)(((byte)(56)))));
            this.crBtnSetupRouter.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(27)))), ((int)(((byte)(56)))));
            this.crBtnSetupRouter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.crBtnSetupRouter.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.crBtnSetupRouter.BorderRadius = 10;
            this.crBtnSetupRouter.BorderSize = 0;
            this.crBtnSetupRouter.FlatAppearance.BorderSize = 0;
            this.crBtnSetupRouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.crBtnSetupRouter.Font = new System.Drawing.Font("Microsoft Tai Le", 11F);
            this.crBtnSetupRouter.ForeColor = System.Drawing.Color.White;
            this.crBtnSetupRouter.Location = new System.Drawing.Point(203, 2);
            this.crBtnSetupRouter.Name = "crBtnSetupRouter";
            this.crBtnSetupRouter.Size = new System.Drawing.Size(241, 29);
            this.crBtnSetupRouter.TabIndex = 12;
            this.crBtnSetupRouter.Text = "Setup OpenDNS on your router";
            this.crBtnSetupRouter.TextColor = System.Drawing.Color.White;
            this.crBtnSetupRouter.UseVisualStyleBackColor = false;
            this.crBtnSetupRouter.Click += new System.EventHandler(this.crBtnSetupRouter_Click);
            // 
            // crBtnSetupThisDevice
            // 
            this.crBtnSetupThisDevice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.crBtnSetupThisDevice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(27)))), ((int)(((byte)(56)))));
            this.crBtnSetupThisDevice.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(27)))), ((int)(((byte)(56)))));
            this.crBtnSetupThisDevice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.crBtnSetupThisDevice.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.crBtnSetupThisDevice.BorderRadius = 10;
            this.crBtnSetupThisDevice.BorderSize = 0;
            this.crBtnSetupThisDevice.FlatAppearance.BorderSize = 0;
            this.crBtnSetupThisDevice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.crBtnSetupThisDevice.Font = new System.Drawing.Font("Microsoft Tai Le", 11F);
            this.crBtnSetupThisDevice.ForeColor = System.Drawing.Color.White;
            this.crBtnSetupThisDevice.Location = new System.Drawing.Point(450, 2);
            this.crBtnSetupThisDevice.Name = "crBtnSetupThisDevice";
            this.crBtnSetupThisDevice.Size = new System.Drawing.Size(241, 29);
            this.crBtnSetupThisDevice.TabIndex = 11;
            this.crBtnSetupThisDevice.Text = "Setup OpenDNS on this device";
            this.crBtnSetupThisDevice.TextColor = System.Drawing.Color.White;
            this.crBtnSetupThisDevice.UseVisualStyleBackColor = false;
            this.crBtnSetupThisDevice.Click += new System.EventHandler(this.crBtnSetupThisDevice_Click);
            // 
            // crBtnSignUp
            // 
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
            this.crBtnSignUp.Location = new System.Drawing.Point(77, 3);
            this.crBtnSignUp.Name = "crBtnSignUp";
            this.crBtnSignUp.Size = new System.Drawing.Size(120, 62);
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
            this.crBtnHome.Location = new System.Drawing.Point(3, 2);
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
            this.crBtnReload.Location = new System.Drawing.Point(40, 2);
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
            this.crBtnForward.Location = new System.Drawing.Point(40, 34);
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
            this.crBtnBack.Location = new System.Drawing.Point(3, 34);
            this.crBtnBack.Name = "crBtnBack";
            this.crBtnBack.Size = new System.Drawing.Size(31, 31);
            this.crBtnBack.TabIndex = 2;
            this.crBtnBack.TextColor = System.Drawing.Color.White;
            this.crBtnBack.UseVisualStyleBackColor = false;
            this.crBtnBack.Click += new System.EventHandler(this.crBtnBack_Click);
            // 
            // formDNSConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(694, 521);
            this.Controls.Add(this.pnlDesktop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private CustRoundedButton crBtnSetupThisDevice;
        private CustRoundedButton crBtnSetupRouter;
        private CustRoundedButton crBtnDNSStatus;
        private CustRoundedButton crBtnResetThisDevice;
        private CustRoundedButton crBtnYT;
        private CustRoundedButton crBtnClose;
    }
}