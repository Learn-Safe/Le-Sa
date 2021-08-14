
namespace Le_Sa
{
    partial class formWebviewMissing
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
            this.progBarEdgeDownload = new System.Windows.Forms.ProgressBar();
            this.lblWarning = new System.Windows.Forms.Label();
            this.crBtnInstall = new Le_Sa.CustRoundedButton();
            this.pnlDesktop.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDesktop
            // 
            this.pnlDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(75)))));
            this.pnlDesktop.Controls.Add(this.progBarEdgeDownload);
            this.pnlDesktop.Controls.Add(this.crBtnInstall);
            this.pnlDesktop.Controls.Add(this.lblWarning);
            this.pnlDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDesktop.Location = new System.Drawing.Point(0, 0);
            this.pnlDesktop.Name = "pnlDesktop";
            this.pnlDesktop.Size = new System.Drawing.Size(694, 521);
            this.pnlDesktop.TabIndex = 1;
            // 
            // progBarEdgeDownload
            // 
            this.progBarEdgeDownload.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progBarEdgeDownload.Location = new System.Drawing.Point(0, 516);
            this.progBarEdgeDownload.MarqueeAnimationSpeed = 694;
            this.progBarEdgeDownload.Maximum = 694;
            this.progBarEdgeDownload.Name = "progBarEdgeDownload";
            this.progBarEdgeDownload.Size = new System.Drawing.Size(694, 5);
            this.progBarEdgeDownload.TabIndex = 7;
            // 
            // lblWarning
            // 
            this.lblWarning.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWarning.AutoSize = true;
            this.lblWarning.Font = new System.Drawing.Font("Microsoft Tai Le", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarning.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblWarning.Location = new System.Drawing.Point(54, 130);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(587, 80);
            this.lblWarning.TabIndex = 0;
            this.lblWarning.Text = "YOU NEED TO INSTALL EDGE WEBVIEW \r\nTO CHANGE DNS SETTINGS.";
            this.lblWarning.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // crBtnInstall
            // 
            this.crBtnInstall.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(27)))), ((int)(((byte)(56)))));
            this.crBtnInstall.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(27)))), ((int)(((byte)(56)))));
            this.crBtnInstall.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(27)))), ((int)(((byte)(56)))));
            this.crBtnInstall.BorderRadius = 20;
            this.crBtnInstall.BorderSize = 0;
            this.crBtnInstall.FlatAppearance.BorderSize = 0;
            this.crBtnInstall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.crBtnInstall.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crBtnInstall.ForeColor = System.Drawing.Color.White;
            this.crBtnInstall.Location = new System.Drawing.Point(279, 318);
            this.crBtnInstall.Name = "crBtnInstall";
            this.crBtnInstall.Size = new System.Drawing.Size(137, 46);
            this.crBtnInstall.TabIndex = 2;
            this.crBtnInstall.Text = "Install";
            this.crBtnInstall.TextColor = System.Drawing.Color.White;
            this.crBtnInstall.UseVisualStyleBackColor = false;
            this.crBtnInstall.Click += new System.EventHandler(this.crBtnInstall_Click);
            // 
            // formWebviewMissing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 521);
            this.Controls.Add(this.pnlDesktop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formWebviewMissing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formWebviewMissing";
            this.Resize += new System.EventHandler(this.formWebviewMissing_Resize);
            this.pnlDesktop.ResumeLayout(false);
            this.pnlDesktop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDesktop;
        private CustRoundedButton crBtnInstall;
        private System.Windows.Forms.Label lblWarning;
        private System.Windows.Forms.ProgressBar progBarEdgeDownload;
    }
}