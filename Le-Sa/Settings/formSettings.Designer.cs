
namespace Le_Sa
{
    partial class formSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formSettings));
            this.pnlDashboard = new System.Windows.Forms.Panel();
            this.crBtnDNSConfig = new Le_Sa.CustRoundedButton();
            this.pnlDesktop = new System.Windows.Forms.Panel();
            this.pnlDashboard.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDashboard
            // 
            this.pnlDashboard.AutoScroll = true;
            this.pnlDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(75)))));
            this.pnlDashboard.Controls.Add(this.crBtnDNSConfig);
            this.pnlDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDashboard.Location = new System.Drawing.Point(0, 0);
            this.pnlDashboard.Name = "pnlDashboard";
            this.pnlDashboard.Size = new System.Drawing.Size(694, 40);
            this.pnlDashboard.TabIndex = 3;
            // 
            // crBtnDNSConfig
            // 
            this.crBtnDNSConfig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(27)))), ((int)(((byte)(56)))));
            this.crBtnDNSConfig.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(27)))), ((int)(((byte)(56)))));
            this.crBtnDNSConfig.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(91)))), ((int)(((byte)(234)))));
            this.crBtnDNSConfig.BorderRadius = 20;
            this.crBtnDNSConfig.BorderSize = 0;
            this.crBtnDNSConfig.FlatAppearance.BorderSize = 0;
            this.crBtnDNSConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.crBtnDNSConfig.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crBtnDNSConfig.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(211)))), ((int)(((byte)(213)))));
            this.crBtnDNSConfig.Location = new System.Drawing.Point(5, 5);
            this.crBtnDNSConfig.Name = "crBtnDNSConfig";
            this.crBtnDNSConfig.Size = new System.Drawing.Size(122, 30);
            this.crBtnDNSConfig.TabIndex = 0;
            this.crBtnDNSConfig.Text = "DNS Settings";
            this.crBtnDNSConfig.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(211)))), ((int)(((byte)(213)))));
            this.crBtnDNSConfig.UseVisualStyleBackColor = false;
            this.crBtnDNSConfig.Click += new System.EventHandler(this.crBtnDNSConfig_Click);
            // 
            // pnlDesktop
            // 
            this.pnlDesktop.AutoScroll = true;
            this.pnlDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(75)))));
            this.pnlDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDesktop.Location = new System.Drawing.Point(0, 40);
            this.pnlDesktop.Name = "pnlDesktop";
            this.pnlDesktop.Size = new System.Drawing.Size(694, 521);
            this.pnlDesktop.TabIndex = 4;
            // 
            // formSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(694, 561);
            this.Controls.Add(this.pnlDesktop);
            this.Controls.Add(this.pnlDashboard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(694, 561);
            this.Name = "formSettings";
            this.Text = "formSettings";
            this.pnlDashboard.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDashboard;
        private CustRoundedButton crBtnDNSConfig;
        private System.Windows.Forms.Panel pnlDesktop;
    }
}