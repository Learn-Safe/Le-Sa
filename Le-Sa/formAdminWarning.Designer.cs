
namespace Le_Sa
{
    partial class formAdminWarning
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formAdminWarning));
            this.pnlDesktop = new System.Windows.Forms.Panel();
            this.crBtnRestart = new Le_Sa.CustRoundedButton();
            this.lblWarning = new System.Windows.Forms.Label();
            this.pnlDesktop.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDesktop
            // 
            this.pnlDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(75)))));
            this.pnlDesktop.Controls.Add(this.crBtnRestart);
            this.pnlDesktop.Controls.Add(this.lblWarning);
            this.pnlDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDesktop.Location = new System.Drawing.Point(0, 0);
            this.pnlDesktop.Name = "pnlDesktop";
            this.pnlDesktop.Size = new System.Drawing.Size(694, 521);
            this.pnlDesktop.TabIndex = 0;
            // 
            // crBtnRestart
            // 
            this.crBtnRestart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(27)))), ((int)(((byte)(56)))));
            this.crBtnRestart.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(27)))), ((int)(((byte)(56)))));
            this.crBtnRestart.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(27)))), ((int)(((byte)(56)))));
            this.crBtnRestart.BorderRadius = 20;
            this.crBtnRestart.BorderSize = 0;
            this.crBtnRestart.FlatAppearance.BorderSize = 0;
            this.crBtnRestart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.crBtnRestart.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crBtnRestart.ForeColor = System.Drawing.Color.White;
            this.crBtnRestart.Location = new System.Drawing.Point(237, 295);
            this.crBtnRestart.Name = "crBtnRestart";
            this.crBtnRestart.Size = new System.Drawing.Size(221, 70);
            this.crBtnRestart.TabIndex = 2;
            this.crBtnRestart.Text = "Restart the application with admin privileges";
            this.crBtnRestart.TextColor = System.Drawing.Color.White;
            this.crBtnRestart.UseVisualStyleBackColor = false;
            this.crBtnRestart.Click += new System.EventHandler(this.crBtnRestart_Click);
            // 
            // lblWarning
            // 
            this.lblWarning.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblWarning.AutoSize = true;
            this.lblWarning.Font = new System.Drawing.Font("Microsoft Tai Le", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarning.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblWarning.Location = new System.Drawing.Point(41, 130);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(613, 120);
            this.lblWarning.TabIndex = 0;
            this.lblWarning.Text = "PLEASE RESTART THE APPLICATION WITH\r\nADMINISTRATOR PRIVILEGES \r\nTO";
            this.lblWarning.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // formAdminWarning
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(75)))));
            this.ClientSize = new System.Drawing.Size(694, 521);
            this.Controls.Add(this.pnlDesktop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formAdminWarning";
            this.Text = "formAdminWarning";
            this.SizeChanged += new System.EventHandler(this.formAdminWarning_SizeChanged);
            this.pnlDesktop.ResumeLayout(false);
            this.pnlDesktop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDesktop;
        private System.Windows.Forms.Label lblWarning;
        private CustRoundedButton crBtnRestart;
    }
}