
namespace Le_Sa.BrowserControls.Firefox
{
    partial class formFirefoxControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formFirefoxControl));
            this.pnlControls = new System.Windows.Forms.Panel();
            this.lblDisableDeveloperTools = new System.Windows.Forms.Label();
            this.cTBtnDisableDeveloperTools = new Le_Sa.CustomControls.CustToggleButton();
            this.lblInstallAddonsPermission = new System.Windows.Forms.Label();
            this.cTBtnInstallAddonsPermission = new Le_Sa.CustomControls.CustToggleButton();
            this.lblDisablePrivateBrowsing = new System.Windows.Forms.Label();
            this.cTBtnDisablePrivateBrowsing = new Le_Sa.CustomControls.CustToggleButton();
            this.pnlDescription = new System.Windows.Forms.Panel();
            this.crBtnStatus = new Le_Sa.CustRoundedButton();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblPolicy = new System.Windows.Forms.Label();
            this.pnlControls.SuspendLayout();
            this.pnlDescription.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlControls
            // 
            this.pnlControls.Controls.Add(this.lblDisableDeveloperTools);
            this.pnlControls.Controls.Add(this.cTBtnDisableDeveloperTools);
            this.pnlControls.Controls.Add(this.lblInstallAddonsPermission);
            this.pnlControls.Controls.Add(this.cTBtnInstallAddonsPermission);
            this.pnlControls.Controls.Add(this.lblDisablePrivateBrowsing);
            this.pnlControls.Controls.Add(this.cTBtnDisablePrivateBrowsing);
            this.pnlControls.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlControls.Location = new System.Drawing.Point(0, 0);
            this.pnlControls.Name = "pnlControls";
            this.pnlControls.Padding = new System.Windows.Forms.Padding(5);
            this.pnlControls.Size = new System.Drawing.Size(359, 521);
            this.pnlControls.TabIndex = 3;
            // 
            // lblDisableDeveloperTools
            // 
            this.lblDisableDeveloperTools.AutoSize = true;
            this.lblDisableDeveloperTools.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisableDeveloperTools.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblDisableDeveloperTools.Location = new System.Drawing.Point(14, 78);
            this.lblDisableDeveloperTools.Name = "lblDisableDeveloperTools";
            this.lblDisableDeveloperTools.Size = new System.Drawing.Size(186, 21);
            this.lblDisableDeveloperTools.TabIndex = 13;
            this.lblDisableDeveloperTools.Text = "Disabled Developer Tools";
            this.lblDisableDeveloperTools.Click += new System.EventHandler(this.lblDisableDeveloperTools_Click);
            // 
            // cTBtnDisableDeveloperTools
            // 
            this.cTBtnDisableDeveloperTools.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cTBtnDisableDeveloperTools.AutoSize = true;
            this.cTBtnDisableDeveloperTools.Location = new System.Drawing.Point(308, 78);
            this.cTBtnDisableDeveloperTools.MinimumSize = new System.Drawing.Size(45, 22);
            this.cTBtnDisableDeveloperTools.Name = "cTBtnDisableDeveloperTools";
            this.cTBtnDisableDeveloperTools.OffBackColor = System.Drawing.Color.Gray;
            this.cTBtnDisableDeveloperTools.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.cTBtnDisableDeveloperTools.OnBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cTBtnDisableDeveloperTools.OnToggleColor = System.Drawing.Color.Gainsboro;
            this.cTBtnDisableDeveloperTools.Size = new System.Drawing.Size(45, 22);
            this.cTBtnDisableDeveloperTools.TabIndex = 12;
            this.cTBtnDisableDeveloperTools.Tag = "DisableDeveloperTools";
            this.cTBtnDisableDeveloperTools.UseVisualStyleBackColor = true;
            this.cTBtnDisableDeveloperTools.CheckedChanged += new System.EventHandler(this.cTBtnDisableDeveloperTools_CheckedChanged);
            // 
            // lblInstallAddonsPermission
            // 
            this.lblInstallAddonsPermission.AutoSize = true;
            this.lblInstallAddonsPermission.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstallAddonsPermission.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblInstallAddonsPermission.Location = new System.Drawing.Point(12, 45);
            this.lblInstallAddonsPermission.Name = "lblInstallAddonsPermission";
            this.lblInstallAddonsPermission.Size = new System.Drawing.Size(197, 21);
            this.lblInstallAddonsPermission.TabIndex = 9;
            this.lblInstallAddonsPermission.Text = "Block Extension Installation";
            this.lblInstallAddonsPermission.Click += new System.EventHandler(this.lblInstallAddonsPermission_Click);
            // 
            // cTBtnInstallAddonsPermission
            // 
            this.cTBtnInstallAddonsPermission.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cTBtnInstallAddonsPermission.AutoSize = true;
            this.cTBtnInstallAddonsPermission.Location = new System.Drawing.Point(306, 45);
            this.cTBtnInstallAddonsPermission.MinimumSize = new System.Drawing.Size(45, 22);
            this.cTBtnInstallAddonsPermission.Name = "cTBtnInstallAddonsPermission";
            this.cTBtnInstallAddonsPermission.OffBackColor = System.Drawing.Color.Gray;
            this.cTBtnInstallAddonsPermission.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.cTBtnInstallAddonsPermission.OnBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cTBtnInstallAddonsPermission.OnToggleColor = System.Drawing.Color.Gainsboro;
            this.cTBtnInstallAddonsPermission.Size = new System.Drawing.Size(45, 22);
            this.cTBtnInstallAddonsPermission.TabIndex = 8;
            this.cTBtnInstallAddonsPermission.Tag = "InstallAddonsPermission";
            this.cTBtnInstallAddonsPermission.UseVisualStyleBackColor = true;
            this.cTBtnInstallAddonsPermission.CheckedChanged += new System.EventHandler(this.cTBtnInstallAddonsPermission_CheckedChanged);
            // 
            // lblDisablePrivateBrowsing
            // 
            this.lblDisablePrivateBrowsing.AutoSize = true;
            this.lblDisablePrivateBrowsing.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisablePrivateBrowsing.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblDisablePrivateBrowsing.Location = new System.Drawing.Point(12, 12);
            this.lblDisablePrivateBrowsing.Name = "lblDisablePrivateBrowsing";
            this.lblDisablePrivateBrowsing.Size = new System.Drawing.Size(178, 21);
            this.lblDisablePrivateBrowsing.TabIndex = 5;
            this.lblDisablePrivateBrowsing.Text = "Disable Incognito Mode ";
            this.lblDisablePrivateBrowsing.Click += new System.EventHandler(this.lblDisablePrivateBrowsing_Click);
            // 
            // cTBtnDisablePrivateBrowsing
            // 
            this.cTBtnDisablePrivateBrowsing.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cTBtnDisablePrivateBrowsing.AutoSize = true;
            this.cTBtnDisablePrivateBrowsing.Location = new System.Drawing.Point(306, 12);
            this.cTBtnDisablePrivateBrowsing.MinimumSize = new System.Drawing.Size(45, 22);
            this.cTBtnDisablePrivateBrowsing.Name = "cTBtnDisablePrivateBrowsing";
            this.cTBtnDisablePrivateBrowsing.OffBackColor = System.Drawing.Color.Gray;
            this.cTBtnDisablePrivateBrowsing.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.cTBtnDisablePrivateBrowsing.OnBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cTBtnDisablePrivateBrowsing.OnToggleColor = System.Drawing.Color.Gainsboro;
            this.cTBtnDisablePrivateBrowsing.Size = new System.Drawing.Size(45, 22);
            this.cTBtnDisablePrivateBrowsing.TabIndex = 4;
            this.cTBtnDisablePrivateBrowsing.Tag = "DisablePrivateBrowsing";
            this.cTBtnDisablePrivateBrowsing.UseVisualStyleBackColor = true;
            this.cTBtnDisablePrivateBrowsing.CheckedChanged += new System.EventHandler(this.cTBtnDisablePrivateBrowsing_CheckedChanged);
            // 
            // pnlDescription
            // 
            this.pnlDescription.Controls.Add(this.crBtnStatus);
            this.pnlDescription.Controls.Add(this.lblDescription);
            this.pnlDescription.Controls.Add(this.lblPolicy);
            this.pnlDescription.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlDescription.Location = new System.Drawing.Point(359, 0);
            this.pnlDescription.MaximumSize = new System.Drawing.Size(335, 0);
            this.pnlDescription.Name = "pnlDescription";
            this.pnlDescription.Padding = new System.Windows.Forms.Padding(5);
            this.pnlDescription.Size = new System.Drawing.Size(335, 521);
            this.pnlDescription.TabIndex = 2;
            // 
            // crBtnStatus
            // 
            this.crBtnStatus.BackColor = System.Drawing.Color.Gray;
            this.crBtnStatus.BackgroundColor = System.Drawing.Color.Gray;
            this.crBtnStatus.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.crBtnStatus.BorderRadius = 10;
            this.crBtnStatus.BorderSize = 0;
            this.crBtnStatus.Enabled = false;
            this.crBtnStatus.FlatAppearance.BorderSize = 0;
            this.crBtnStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.crBtnStatus.Font = new System.Drawing.Font("Microsoft Tai Le", 11.25F, System.Drawing.FontStyle.Bold);
            this.crBtnStatus.ForeColor = System.Drawing.Color.White;
            this.crBtnStatus.Location = new System.Drawing.Point(233, 12);
            this.crBtnStatus.Name = "crBtnStatus";
            this.crBtnStatus.Size = new System.Drawing.Size(90, 25);
            this.crBtnStatus.TabIndex = 0;
            this.crBtnStatus.Text = "Unknown";
            this.crBtnStatus.TextColor = System.Drawing.Color.White;
            this.crBtnStatus.UseVisualStyleBackColor = false;
            // 
            // lblDescription
            // 
            this.lblDescription.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 12F);
            this.lblDescription.ForeColor = System.Drawing.SystemColors.Info;
            this.lblDescription.Location = new System.Drawing.Point(29, 76);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(294, 408);
            this.lblDescription.TabIndex = 1;
            this.lblDescription.Text = "In here you can change Firefox Browser settings.\r\n\r\nPlease select an item to view" +
    " more. ";
            // 
            // lblPolicy
            // 
            this.lblPolicy.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPolicy.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblPolicy.Location = new System.Drawing.Point(8, 12);
            this.lblPolicy.Name = "lblPolicy";
            this.lblPolicy.Size = new System.Drawing.Size(218, 55);
            this.lblPolicy.TabIndex = 0;
            this.lblPolicy.Text = "Firefox Controls";
            // 
            // formFirefoxControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(75)))));
            this.ClientSize = new System.Drawing.Size(694, 521);
            this.Controls.Add(this.pnlControls);
            this.Controls.Add(this.pnlDescription);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formFirefoxControl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "formChromeControls";
            this.Load += new System.EventHandler(this.formFirefoxControl_Load);
            this.pnlControls.ResumeLayout(false);
            this.pnlControls.PerformLayout();
            this.pnlDescription.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlControls;
        private System.Windows.Forms.Label lblDisableDeveloperTools;
        private CustomControls.CustToggleButton cTBtnDisableDeveloperTools;
        private System.Windows.Forms.Label lblInstallAddonsPermission;
        private CustomControls.CustToggleButton cTBtnInstallAddonsPermission;
        private System.Windows.Forms.Label lblDisablePrivateBrowsing;
        private CustomControls.CustToggleButton cTBtnDisablePrivateBrowsing;
        private System.Windows.Forms.Panel pnlDescription;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblPolicy;
        private CustRoundedButton crBtnStatus;
    }
}