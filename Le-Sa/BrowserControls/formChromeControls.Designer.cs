
namespace Le_Sa.BrowserControls
{
    partial class formChromeControls
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
            this.pnlDescription = new System.Windows.Forms.Panel();
            this.cRPnlStatus = new Le_Sa.CustRoundedPanel();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblPolicy = new System.Windows.Forms.Label();
            this.pnlControls = new System.Windows.Forms.Panel();
            this.lblBrowserAddPersonEnabled = new System.Windows.Forms.Label();
            this.cTBtnBrowserAddPersonEnabled = new Le_Sa.CustomControls.CustToggleButton();
            this.lblAllowDeletingBrowserHistory = new System.Windows.Forms.Label();
            this.cTBtnAllowDeletingBrowserHistory = new Le_Sa.CustomControls.CustToggleButton();
            this.lblDeveloperToolsAvailability = new System.Windows.Forms.Label();
            this.cTBtnDeveloperToolsAvailability = new Le_Sa.CustomControls.CustToggleButton();
            this.lblPasswordLeakDetectionEnabled = new System.Windows.Forms.Label();
            this.cTBtnPasswordLeakDetectionEnabled = new Le_Sa.CustomControls.CustToggleButton();
            this.lblBlockExternalExtensions = new System.Windows.Forms.Label();
            this.cTBtnBlockExternalExtensions = new Le_Sa.CustomControls.CustToggleButton();
            this.lblDisableGuestMode = new System.Windows.Forms.Label();
            this.cTBtnGuestMode = new Le_Sa.CustomControls.CustToggleButton();
            this.lblDisableIncognitoMode = new System.Windows.Forms.Label();
            this.cTBtnIncognitoMode = new Le_Sa.CustomControls.CustToggleButton();
            this.pnlDescription.SuspendLayout();
            this.cRPnlStatus.SuspendLayout();
            this.pnlControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDescription
            // 
            this.pnlDescription.Controls.Add(this.cRPnlStatus);
            this.pnlDescription.Controls.Add(this.lblDescription);
            this.pnlDescription.Controls.Add(this.lblPolicy);
            this.pnlDescription.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlDescription.Location = new System.Drawing.Point(359, 0);
            this.pnlDescription.MaximumSize = new System.Drawing.Size(335, 0);
            this.pnlDescription.Name = "pnlDescription";
            this.pnlDescription.Padding = new System.Windows.Forms.Padding(5);
            this.pnlDescription.Size = new System.Drawing.Size(335, 521);
            this.pnlDescription.TabIndex = 0;
            // 
            // cRPnlStatus
            // 
            this.cRPnlStatus.BackColor = System.Drawing.Color.Gray;
            this.cRPnlStatus.BackgroundColor = System.Drawing.Color.Gray;
            this.cRPnlStatus.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(212)))), ((int)(((byte)(20)))));
            this.cRPnlStatus.BorderRadius = 10;
            this.cRPnlStatus.BorderSize = 0;
            this.cRPnlStatus.Controls.Add(this.lblStatus);
            this.cRPnlStatus.Enabled = false;
            this.cRPnlStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(4)))), ((int)(((byte)(7)))));
            this.cRPnlStatus.Location = new System.Drawing.Point(233, 12);
            this.cRPnlStatus.Name = "cRPnlStatus";
            this.cRPnlStatus.Size = new System.Drawing.Size(90, 25);
            this.cRPnlStatus.TabIndex = 0;
            this.cRPnlStatus.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(4)))), ((int)(((byte)(7)))));
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Enabled = false;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblStatus.Location = new System.Drawing.Point(7, 5);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(76, 19);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "Unknown";
            this.lblStatus.SizeChanged += new System.EventHandler(this.lblStatus_SizeChanged);
            // 
            // lblDescription
            // 
            this.lblDescription.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F);
            this.lblDescription.ForeColor = System.Drawing.SystemColors.Info;
            this.lblDescription.Location = new System.Drawing.Point(29, 76);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(294, 408);
            this.lblDescription.TabIndex = 1;
            this.lblDescription.Text = "In here you can change some Chrome Browser settings.\r\n\r\nPlease select item to vie" +
    "w more. ";
            // 
            // lblPolicy
            // 
            this.lblPolicy.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPolicy.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblPolicy.Location = new System.Drawing.Point(8, 12);
            this.lblPolicy.Name = "lblPolicy";
            this.lblPolicy.Size = new System.Drawing.Size(218, 55);
            this.lblPolicy.TabIndex = 0;
            this.lblPolicy.Text = "Chrome Controls";
            // 
            // pnlControls
            // 
            this.pnlControls.Controls.Add(this.lblBrowserAddPersonEnabled);
            this.pnlControls.Controls.Add(this.cTBtnBrowserAddPersonEnabled);
            this.pnlControls.Controls.Add(this.lblAllowDeletingBrowserHistory);
            this.pnlControls.Controls.Add(this.cTBtnAllowDeletingBrowserHistory);
            this.pnlControls.Controls.Add(this.lblDeveloperToolsAvailability);
            this.pnlControls.Controls.Add(this.cTBtnDeveloperToolsAvailability);
            this.pnlControls.Controls.Add(this.lblPasswordLeakDetectionEnabled);
            this.pnlControls.Controls.Add(this.cTBtnPasswordLeakDetectionEnabled);
            this.pnlControls.Controls.Add(this.lblBlockExternalExtensions);
            this.pnlControls.Controls.Add(this.cTBtnBlockExternalExtensions);
            this.pnlControls.Controls.Add(this.lblDisableGuestMode);
            this.pnlControls.Controls.Add(this.cTBtnGuestMode);
            this.pnlControls.Controls.Add(this.lblDisableIncognitoMode);
            this.pnlControls.Controls.Add(this.cTBtnIncognitoMode);
            this.pnlControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlControls.Location = new System.Drawing.Point(0, 0);
            this.pnlControls.Name = "pnlControls";
            this.pnlControls.Padding = new System.Windows.Forms.Padding(5);
            this.pnlControls.Size = new System.Drawing.Size(359, 521);
            this.pnlControls.TabIndex = 1;
            // 
            // lblBrowserAddPersonEnabled
            // 
            this.lblBrowserAddPersonEnabled.AutoSize = true;
            this.lblBrowserAddPersonEnabled.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrowserAddPersonEnabled.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblBrowserAddPersonEnabled.Location = new System.Drawing.Point(12, 210);
            this.lblBrowserAddPersonEnabled.Name = "lblBrowserAddPersonEnabled";
            this.lblBrowserAddPersonEnabled.Size = new System.Drawing.Size(167, 21);
            this.lblBrowserAddPersonEnabled.TabIndex = 17;
            this.lblBrowserAddPersonEnabled.Text = "Block Add New Person";
            this.lblBrowserAddPersonEnabled.Click += new System.EventHandler(this.lblBrowserAddPersonEnabled_Click);
            // 
            // cTBtnBrowserAddPersonEnabled
            // 
            this.cTBtnBrowserAddPersonEnabled.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cTBtnBrowserAddPersonEnabled.AutoSize = true;
            this.cTBtnBrowserAddPersonEnabled.Location = new System.Drawing.Point(306, 210);
            this.cTBtnBrowserAddPersonEnabled.MinimumSize = new System.Drawing.Size(45, 22);
            this.cTBtnBrowserAddPersonEnabled.Name = "cTBtnBrowserAddPersonEnabled";
            this.cTBtnBrowserAddPersonEnabled.OffBackColor = System.Drawing.Color.Gray;
            this.cTBtnBrowserAddPersonEnabled.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.cTBtnBrowserAddPersonEnabled.OnBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cTBtnBrowserAddPersonEnabled.OnToggleColor = System.Drawing.Color.Gainsboro;
            this.cTBtnBrowserAddPersonEnabled.Size = new System.Drawing.Size(45, 22);
            this.cTBtnBrowserAddPersonEnabled.TabIndex = 16;
            this.cTBtnBrowserAddPersonEnabled.Tag = "BrowserAddPersonEnabled";
            this.cTBtnBrowserAddPersonEnabled.UseVisualStyleBackColor = true;
            this.cTBtnBrowserAddPersonEnabled.CheckedChanged += new System.EventHandler(this.cTBtnBrowserAddPersonEnabled_CheckedChanged);
            // 
            // lblAllowDeletingBrowserHistory
            // 
            this.lblAllowDeletingBrowserHistory.AutoSize = true;
            this.lblAllowDeletingBrowserHistory.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAllowDeletingBrowserHistory.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblAllowDeletingBrowserHistory.Location = new System.Drawing.Point(12, 177);
            this.lblAllowDeletingBrowserHistory.Name = "lblAllowDeletingBrowserHistory";
            this.lblAllowDeletingBrowserHistory.Size = new System.Drawing.Size(163, 21);
            this.lblAllowDeletingBrowserHistory.TabIndex = 15;
            this.lblAllowDeletingBrowserHistory.Text = "Block History Deletion";
            this.lblAllowDeletingBrowserHistory.Click += new System.EventHandler(this.lblAllowDeletingBrowserHistory_Click);
            // 
            // cTBtnAllowDeletingBrowserHistory
            // 
            this.cTBtnAllowDeletingBrowserHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cTBtnAllowDeletingBrowserHistory.AutoSize = true;
            this.cTBtnAllowDeletingBrowserHistory.Location = new System.Drawing.Point(306, 177);
            this.cTBtnAllowDeletingBrowserHistory.MinimumSize = new System.Drawing.Size(45, 22);
            this.cTBtnAllowDeletingBrowserHistory.Name = "cTBtnAllowDeletingBrowserHistory";
            this.cTBtnAllowDeletingBrowserHistory.OffBackColor = System.Drawing.Color.Gray;
            this.cTBtnAllowDeletingBrowserHistory.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.cTBtnAllowDeletingBrowserHistory.OnBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cTBtnAllowDeletingBrowserHistory.OnToggleColor = System.Drawing.Color.Gainsboro;
            this.cTBtnAllowDeletingBrowserHistory.Size = new System.Drawing.Size(45, 22);
            this.cTBtnAllowDeletingBrowserHistory.TabIndex = 14;
            this.cTBtnAllowDeletingBrowserHistory.Tag = "AllowDeletingBrowserHistory";
            this.cTBtnAllowDeletingBrowserHistory.UseVisualStyleBackColor = true;
            this.cTBtnAllowDeletingBrowserHistory.CheckedChanged += new System.EventHandler(this.cTBtnAllowDeletingBrowserHistory_CheckedChanged);
            // 
            // lblDeveloperToolsAvailability
            // 
            this.lblDeveloperToolsAvailability.AutoSize = true;
            this.lblDeveloperToolsAvailability.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeveloperToolsAvailability.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblDeveloperToolsAvailability.Location = new System.Drawing.Point(12, 144);
            this.lblDeveloperToolsAvailability.Name = "lblDeveloperToolsAvailability";
            this.lblDeveloperToolsAvailability.Size = new System.Drawing.Size(186, 21);
            this.lblDeveloperToolsAvailability.TabIndex = 13;
            this.lblDeveloperToolsAvailability.Text = "Disabled Developer Tools";
            this.lblDeveloperToolsAvailability.Click += new System.EventHandler(this.lblDeveloperToolsAvailability_Click);
            // 
            // cTBtnDeveloperToolsAvailability
            // 
            this.cTBtnDeveloperToolsAvailability.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cTBtnDeveloperToolsAvailability.AutoSize = true;
            this.cTBtnDeveloperToolsAvailability.Location = new System.Drawing.Point(306, 144);
            this.cTBtnDeveloperToolsAvailability.MinimumSize = new System.Drawing.Size(45, 22);
            this.cTBtnDeveloperToolsAvailability.Name = "cTBtnDeveloperToolsAvailability";
            this.cTBtnDeveloperToolsAvailability.OffBackColor = System.Drawing.Color.Gray;
            this.cTBtnDeveloperToolsAvailability.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.cTBtnDeveloperToolsAvailability.OnBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cTBtnDeveloperToolsAvailability.OnToggleColor = System.Drawing.Color.Gainsboro;
            this.cTBtnDeveloperToolsAvailability.Size = new System.Drawing.Size(45, 22);
            this.cTBtnDeveloperToolsAvailability.TabIndex = 12;
            this.cTBtnDeveloperToolsAvailability.Tag = "DeveloperToolsAvailability";
            this.cTBtnDeveloperToolsAvailability.UseVisualStyleBackColor = true;
            this.cTBtnDeveloperToolsAvailability.CheckedChanged += new System.EventHandler(this.cTBtnDeveloperToolsAvailability_CheckedChanged);
            // 
            // lblPasswordLeakDetectionEnabled
            // 
            this.lblPasswordLeakDetectionEnabled.AutoSize = true;
            this.lblPasswordLeakDetectionEnabled.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPasswordLeakDetectionEnabled.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblPasswordLeakDetectionEnabled.Location = new System.Drawing.Point(12, 111);
            this.lblPasswordLeakDetectionEnabled.Name = "lblPasswordLeakDetectionEnabled";
            this.lblPasswordLeakDetectionEnabled.Size = new System.Drawing.Size(250, 21);
            this.lblPasswordLeakDetectionEnabled.TabIndex = 11;
            this.lblPasswordLeakDetectionEnabled.Text = "Enable Leaked Password Detection";
            this.lblPasswordLeakDetectionEnabled.Click += new System.EventHandler(this.lblPasswordLeakDetectionEnabled_Click);
            // 
            // cTBtnPasswordLeakDetectionEnabled
            // 
            this.cTBtnPasswordLeakDetectionEnabled.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cTBtnPasswordLeakDetectionEnabled.AutoSize = true;
            this.cTBtnPasswordLeakDetectionEnabled.Location = new System.Drawing.Point(306, 111);
            this.cTBtnPasswordLeakDetectionEnabled.MinimumSize = new System.Drawing.Size(45, 22);
            this.cTBtnPasswordLeakDetectionEnabled.Name = "cTBtnPasswordLeakDetectionEnabled";
            this.cTBtnPasswordLeakDetectionEnabled.OffBackColor = System.Drawing.Color.Gray;
            this.cTBtnPasswordLeakDetectionEnabled.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.cTBtnPasswordLeakDetectionEnabled.OnBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cTBtnPasswordLeakDetectionEnabled.OnToggleColor = System.Drawing.Color.Gainsboro;
            this.cTBtnPasswordLeakDetectionEnabled.Size = new System.Drawing.Size(45, 22);
            this.cTBtnPasswordLeakDetectionEnabled.TabIndex = 10;
            this.cTBtnPasswordLeakDetectionEnabled.Tag = "PasswordLeakDetectionEnabled";
            this.cTBtnPasswordLeakDetectionEnabled.UseVisualStyleBackColor = true;
            this.cTBtnPasswordLeakDetectionEnabled.CheckedChanged += new System.EventHandler(this.cTBtnPasswordLeakDetectionEnabled_CheckedChanged);
            // 
            // lblBlockExternalExtensions
            // 
            this.lblBlockExternalExtensions.AutoSize = true;
            this.lblBlockExternalExtensions.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBlockExternalExtensions.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblBlockExternalExtensions.Location = new System.Drawing.Point(12, 78);
            this.lblBlockExternalExtensions.Name = "lblBlockExternalExtensions";
            this.lblBlockExternalExtensions.Size = new System.Drawing.Size(183, 21);
            this.lblBlockExternalExtensions.TabIndex = 9;
            this.lblBlockExternalExtensions.Text = "Block External Extensions";
            this.lblBlockExternalExtensions.Click += new System.EventHandler(this.lblBlockExternalExtensions_Click);
            // 
            // cTBtnBlockExternalExtensions
            // 
            this.cTBtnBlockExternalExtensions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cTBtnBlockExternalExtensions.AutoSize = true;
            this.cTBtnBlockExternalExtensions.Location = new System.Drawing.Point(306, 78);
            this.cTBtnBlockExternalExtensions.MinimumSize = new System.Drawing.Size(45, 22);
            this.cTBtnBlockExternalExtensions.Name = "cTBtnBlockExternalExtensions";
            this.cTBtnBlockExternalExtensions.OffBackColor = System.Drawing.Color.Gray;
            this.cTBtnBlockExternalExtensions.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.cTBtnBlockExternalExtensions.OnBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cTBtnBlockExternalExtensions.OnToggleColor = System.Drawing.Color.Gainsboro;
            this.cTBtnBlockExternalExtensions.Size = new System.Drawing.Size(45, 22);
            this.cTBtnBlockExternalExtensions.TabIndex = 8;
            this.cTBtnBlockExternalExtensions.Tag = "BlockExternalExtensions";
            this.cTBtnBlockExternalExtensions.UseVisualStyleBackColor = true;
            this.cTBtnBlockExternalExtensions.CheckedChanged += new System.EventHandler(this.cTBtnBlockExternalExtensions_CheckedChanged);
            // 
            // lblDisableGuestMode
            // 
            this.lblDisableGuestMode.AutoSize = true;
            this.lblDisableGuestMode.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisableGuestMode.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblDisableGuestMode.Location = new System.Drawing.Point(12, 45);
            this.lblDisableGuestMode.Name = "lblDisableGuestMode";
            this.lblDisableGuestMode.Size = new System.Drawing.Size(149, 21);
            this.lblDisableGuestMode.TabIndex = 7;
            this.lblDisableGuestMode.Text = "Disable Guest Mode";
            this.lblDisableGuestMode.Click += new System.EventHandler(this.lblDisableGuestMode_Click);
            // 
            // cTBtnGuestMode
            // 
            this.cTBtnGuestMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cTBtnGuestMode.AutoSize = true;
            this.cTBtnGuestMode.Location = new System.Drawing.Point(306, 45);
            this.cTBtnGuestMode.MinimumSize = new System.Drawing.Size(45, 22);
            this.cTBtnGuestMode.Name = "cTBtnGuestMode";
            this.cTBtnGuestMode.OffBackColor = System.Drawing.Color.Gray;
            this.cTBtnGuestMode.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.cTBtnGuestMode.OnBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cTBtnGuestMode.OnToggleColor = System.Drawing.Color.Gainsboro;
            this.cTBtnGuestMode.Size = new System.Drawing.Size(45, 22);
            this.cTBtnGuestMode.TabIndex = 6;
            this.cTBtnGuestMode.Tag = "BrowserGuestModeEnabled";
            this.cTBtnGuestMode.UseVisualStyleBackColor = true;
            this.cTBtnGuestMode.CheckedChanged += new System.EventHandler(this.cTBtnGuestMode_CheckedChanged);
            // 
            // lblDisableIncognitoMode
            // 
            this.lblDisableIncognitoMode.AutoSize = true;
            this.lblDisableIncognitoMode.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisableIncognitoMode.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblDisableIncognitoMode.Location = new System.Drawing.Point(12, 12);
            this.lblDisableIncognitoMode.Name = "lblDisableIncognitoMode";
            this.lblDisableIncognitoMode.Size = new System.Drawing.Size(178, 21);
            this.lblDisableIncognitoMode.TabIndex = 5;
            this.lblDisableIncognitoMode.Text = "Disable Incognito Mode ";
            this.lblDisableIncognitoMode.Click += new System.EventHandler(this.lblDisableIncognitoMode_Click);
            // 
            // cTBtnIncognitoMode
            // 
            this.cTBtnIncognitoMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cTBtnIncognitoMode.AutoSize = true;
            this.cTBtnIncognitoMode.Location = new System.Drawing.Point(306, 12);
            this.cTBtnIncognitoMode.MinimumSize = new System.Drawing.Size(45, 22);
            this.cTBtnIncognitoMode.Name = "cTBtnIncognitoMode";
            this.cTBtnIncognitoMode.OffBackColor = System.Drawing.Color.Gray;
            this.cTBtnIncognitoMode.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.cTBtnIncognitoMode.OnBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cTBtnIncognitoMode.OnToggleColor = System.Drawing.Color.Gainsboro;
            this.cTBtnIncognitoMode.Size = new System.Drawing.Size(45, 22);
            this.cTBtnIncognitoMode.TabIndex = 4;
            this.cTBtnIncognitoMode.Tag = "IncognitoModeAvailability";
            this.cTBtnIncognitoMode.UseVisualStyleBackColor = true;
            this.cTBtnIncognitoMode.CheckedChanged += new System.EventHandler(this.cTBtnIncognitoMode_CheckedChanged);
            // 
            // formChromeControls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(75)))));
            this.ClientSize = new System.Drawing.Size(694, 521);
            this.Controls.Add(this.pnlControls);
            this.Controls.Add(this.pnlDescription);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formChromeControls";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "formChromeControls";
            this.Load += new System.EventHandler(this.formChromeControls_Load);
            this.pnlDescription.ResumeLayout(false);
            this.cRPnlStatus.ResumeLayout(false);
            this.cRPnlStatus.PerformLayout();
            this.pnlControls.ResumeLayout(false);
            this.pnlControls.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDescription;
        private System.Windows.Forms.Label lblDeveloperToolsAvailability;
        private CustomControls.CustToggleButton cTBtnDeveloperToolsAvailability;
        private System.Windows.Forms.Label lblPasswordLeakDetectionEnabled;
        private CustomControls.CustToggleButton cTBtnPasswordLeakDetectionEnabled;
        private System.Windows.Forms.Label lblBlockExternalExtensions;
        private CustomControls.CustToggleButton cTBtnBlockExternalExtensions;
        private System.Windows.Forms.Label lblDisableGuestMode;
        private CustomControls.CustToggleButton cTBtnGuestMode;
        private System.Windows.Forms.Label lblDisableIncognitoMode;
        private CustomControls.CustToggleButton cTBtnIncognitoMode;
        private System.Windows.Forms.Panel pnlControls;
        private System.Windows.Forms.Label lblPolicy;
        private CustRoundedPanel cRPnlStatus;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblAllowDeletingBrowserHistory;
        private CustomControls.CustToggleButton cTBtnAllowDeletingBrowserHistory;
        private System.Windows.Forms.Label lblBrowserAddPersonEnabled;
        private CustomControls.CustToggleButton cTBtnBrowserAddPersonEnabled;
    }
}