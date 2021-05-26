namespace Le_Sa
{
    partial class formLoadingScreen
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
            this.components = new System.ComponentModel.Container();
            this.lblCreator = new System.Windows.Forms.Label();
            this.lblSlogan = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.pnlLoadingBack = new System.Windows.Forms.Panel();
            this.pnlLoadingFront = new System.Windows.Forms.Panel();
            this.timerLoading = new System.Windows.Forms.Timer(this.components);
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.pnlLoadingBack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCreator
            // 
            this.lblCreator.AutoSize = true;
            this.lblCreator.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreator.ForeColor = System.Drawing.Color.White;
            this.lblCreator.Location = new System.Drawing.Point(350, 468);
            this.lblCreator.Name = "lblCreator";
            this.lblCreator.Size = new System.Drawing.Size(218, 14);
            this.lblCreator.TabIndex = 14;
            this.lblCreator.Text = "SATHSARA BANDARA JAYASUNDARA 2021";
            // 
            // lblSlogan
            // 
            this.lblSlogan.AutoSize = true;
            this.lblSlogan.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSlogan.ForeColor = System.Drawing.Color.White;
            this.lblSlogan.Location = new System.Drawing.Point(161, 110);
            this.lblSlogan.Name = "lblSlogan";
            this.lblSlogan.Size = new System.Drawing.Size(111, 16);
            this.lblSlogan.TabIndex = 13;
            this.lblSlogan.Text = "Focus on learning";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("ShureTechMono NF", 65.24999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblProductName.Location = new System.Drawing.Point(138, 12);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(277, 98);
            this.lblProductName.TabIndex = 12;
            this.lblProductName.Text = "Le-Sa";
            // 
            // pnlLoadingBack
            // 
            this.pnlLoadingBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(74)))));
            this.pnlLoadingBack.Controls.Add(this.pnlLoadingFront);
            this.pnlLoadingBack.Location = new System.Drawing.Point(0, 445);
            this.pnlLoadingBack.Name = "pnlLoadingBack";
            this.pnlLoadingBack.Size = new System.Drawing.Size(919, 7);
            this.pnlLoadingBack.TabIndex = 11;
            // 
            // pnlLoadingFront
            // 
            this.pnlLoadingFront.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(173)))), ((int)(((byte)(15)))));
            this.pnlLoadingFront.Location = new System.Drawing.Point(0, 0);
            this.pnlLoadingFront.Name = "pnlLoadingFront";
            this.pnlLoadingFront.Size = new System.Drawing.Size(1, 10);
            this.pnlLoadingFront.TabIndex = 2;
            // 
            // timerLoading
            // 
            this.timerLoading.Enabled = true;
            this.timerLoading.Interval = 10;
            this.timerLoading.Tick += new System.EventHandler(this.timerLoading_Tick);
            // 
            // pbLogo
            // 
            this.pbLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbLogo.Location = new System.Drawing.Point(12, 12);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(120, 120);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 15;
            this.pbLogo.TabStop = false;
            // 
            // formLoadingScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(919, 490);
            this.Controls.Add(this.lblCreator);
            this.Controls.Add(this.lblSlogan);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.pnlLoadingBack);
            this.Controls.Add(this.pbLogo);
            this.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formLoadingScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Le-Sa";
            this.pnlLoadingBack.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCreator;
        private System.Windows.Forms.Label lblSlogan;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Panel pnlLoadingBack;
        private System.Windows.Forms.Panel pnlLoadingFront;
        private System.Windows.Forms.Timer timerLoading;
        private System.Windows.Forms.PictureBox pbLogo;
    }
}