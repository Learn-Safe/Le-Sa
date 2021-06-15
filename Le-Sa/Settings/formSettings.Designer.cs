
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
            this.pnlDesktop = new System.Windows.Forms.Panel();
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.ibtnBlackList = new FontAwesome.Sharp.IconButton();
            this.ibtnBrowser = new FontAwesome.Sharp.IconButton();
            this.pnlMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDesktop
            // 
            this.pnlDesktop.AutoScroll = true;
            this.pnlDesktop.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlDesktop.Location = new System.Drawing.Point(180, 0);
            this.pnlDesktop.Name = "pnlDesktop";
            this.pnlDesktop.Size = new System.Drawing.Size(514, 561);
            this.pnlDesktop.TabIndex = 0;
            // 
            // pnlMenu
            // 
            this.pnlMenu.AutoScroll = true;
            this.pnlMenu.Controls.Add(this.ibtnBlackList);
            this.pnlMenu.Controls.Add(this.ibtnBrowser);
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(182, 561);
            this.pnlMenu.TabIndex = 1;
            // 
            // ibtnBlackList
            // 
            this.ibtnBlackList.AutoSize = true;
            this.ibtnBlackList.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtnBlackList.FlatAppearance.BorderSize = 0;
            this.ibtnBlackList.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(49)))), ((int)(((byte)(90)))));
            this.ibtnBlackList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnBlackList.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnBlackList.ForeColor = System.Drawing.SystemColors.Window;
            this.ibtnBlackList.IconChar = FontAwesome.Sharp.IconChar.Ban;
            this.ibtnBlackList.IconColor = System.Drawing.SystemColors.Window;
            this.ibtnBlackList.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnBlackList.IconSize = 30;
            this.ibtnBlackList.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.ibtnBlackList.Location = new System.Drawing.Point(0, 40);
            this.ibtnBlackList.Name = "ibtnBlackList";
            this.ibtnBlackList.Size = new System.Drawing.Size(182, 40);
            this.ibtnBlackList.TabIndex = 7;
            this.ibtnBlackList.Text = "Blacklist";
            this.ibtnBlackList.UseVisualStyleBackColor = true;
            this.ibtnBlackList.Click += new System.EventHandler(this.ibtnBlackList_Click);
            // 
            // ibtnBrowser
            // 
            this.ibtnBrowser.AutoSize = true;
            this.ibtnBrowser.Dock = System.Windows.Forms.DockStyle.Top;
            this.ibtnBrowser.FlatAppearance.BorderSize = 0;
            this.ibtnBrowser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(49)))), ((int)(((byte)(90)))));
            this.ibtnBrowser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ibtnBrowser.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ibtnBrowser.ForeColor = System.Drawing.SystemColors.Window;
            this.ibtnBrowser.IconChar = FontAwesome.Sharp.IconChar.GlobeAsia;
            this.ibtnBrowser.IconColor = System.Drawing.SystemColors.Window;
            this.ibtnBrowser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ibtnBrowser.IconSize = 30;
            this.ibtnBrowser.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.ibtnBrowser.Location = new System.Drawing.Point(0, 0);
            this.ibtnBrowser.Name = "ibtnBrowser";
            this.ibtnBrowser.Size = new System.Drawing.Size(182, 40);
            this.ibtnBrowser.TabIndex = 6;
            this.ibtnBrowser.Text = "Browser ";
            this.ibtnBrowser.UseVisualStyleBackColor = true;
            this.ibtnBrowser.Click += new System.EventHandler(this.ibtnBrowser_Click);
            // 
            // formSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(694, 561);
            this.Controls.Add(this.pnlMenu);
            this.Controls.Add(this.pnlDesktop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(694, 561);
            this.Name = "formSettings";
            this.Text = "formSettings";
            this.pnlMenu.ResumeLayout(false);
            this.pnlMenu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDesktop;
        private System.Windows.Forms.Panel pnlMenu;
        private FontAwesome.Sharp.IconButton ibtnBrowser;
        private FontAwesome.Sharp.IconButton ibtnBlackList;
    }
}