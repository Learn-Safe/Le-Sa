
namespace Le_Sa.History
{
    partial class formHistory
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
            this.pnlDashboard = new System.Windows.Forms.Panel();
            this.pnlDesktop = new System.Windows.Forms.Panel();
            this.dgvBrowserHistory = new System.Windows.Forms.DataGridView();
            this.crBtnBrave = new Le_Sa.CustRoundedButton();
            this.crBtnOpera = new Le_Sa.CustRoundedButton();
            this.crBtnEdge = new Le_Sa.CustRoundedButton();
            this.crBtnFirefox = new Le_Sa.CustRoundedButton();
            this.crBtnCommonSettings = new Le_Sa.CustRoundedButton();
            this.pnlDashboard.SuspendLayout();
            this.pnlDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBrowserHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDashboard
            // 
            this.pnlDashboard.AutoScroll = true;
            this.pnlDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(75)))));
            this.pnlDashboard.Controls.Add(this.crBtnBrave);
            this.pnlDashboard.Controls.Add(this.crBtnOpera);
            this.pnlDashboard.Controls.Add(this.crBtnEdge);
            this.pnlDashboard.Controls.Add(this.crBtnFirefox);
            this.pnlDashboard.Controls.Add(this.crBtnCommonSettings);
            this.pnlDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlDashboard.Location = new System.Drawing.Point(0, 0);
            this.pnlDashboard.Name = "pnlDashboard";
            this.pnlDashboard.Size = new System.Drawing.Size(694, 40);
            this.pnlDashboard.TabIndex = 1;
            // 
            // pnlDesktop
            // 
            this.pnlDesktop.AutoScroll = true;
            this.pnlDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(75)))));
            this.pnlDesktop.Controls.Add(this.dgvBrowserHistory);
            this.pnlDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDesktop.Location = new System.Drawing.Point(0, 40);
            this.pnlDesktop.Name = "pnlDesktop";
            this.pnlDesktop.Size = new System.Drawing.Size(694, 521);
            this.pnlDesktop.TabIndex = 2;
            // 
            // dgvBrowserHistory
            // 
            this.dgvBrowserHistory.AllowUserToAddRows = false;
            this.dgvBrowserHistory.AllowUserToDeleteRows = false;
            this.dgvBrowserHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBrowserHistory.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(39)))), ((int)(((byte)(75)))));
            this.dgvBrowserHistory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvBrowserHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBrowserHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBrowserHistory.Location = new System.Drawing.Point(0, 0);
            this.dgvBrowserHistory.Name = "dgvBrowserHistory";
            this.dgvBrowserHistory.RowHeadersVisible = false;
            this.dgvBrowserHistory.Size = new System.Drawing.Size(694, 521);
            this.dgvBrowserHistory.TabIndex = 0;
            // 
            // crBtnBrave
            // 
            this.crBtnBrave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(27)))), ((int)(((byte)(56)))));
            this.crBtnBrave.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(27)))), ((int)(((byte)(56)))));
            this.crBtnBrave.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(27)))), ((int)(((byte)(45)))));
            this.crBtnBrave.BorderRadius = 20;
            this.crBtnBrave.BorderSize = 0;
            this.crBtnBrave.FlatAppearance.BorderSize = 0;
            this.crBtnBrave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.crBtnBrave.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crBtnBrave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(211)))), ((int)(((byte)(213)))));
            this.crBtnBrave.Location = new System.Drawing.Point(353, 5);
            this.crBtnBrave.Name = "crBtnBrave";
            this.crBtnBrave.Size = new System.Drawing.Size(77, 30);
            this.crBtnBrave.TabIndex = 4;
            this.crBtnBrave.Text = "Brave";
            this.crBtnBrave.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(211)))), ((int)(((byte)(213)))));
            this.crBtnBrave.UseVisualStyleBackColor = false;
            this.crBtnBrave.Click += new System.EventHandler(this.crBtnBrave_Click);
            // 
            // crBtnOpera
            // 
            this.crBtnOpera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(27)))), ((int)(((byte)(56)))));
            this.crBtnOpera.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(27)))), ((int)(((byte)(56)))));
            this.crBtnOpera.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(27)))), ((int)(((byte)(45)))));
            this.crBtnOpera.BorderRadius = 20;
            this.crBtnOpera.BorderSize = 0;
            this.crBtnOpera.FlatAppearance.BorderSize = 0;
            this.crBtnOpera.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.crBtnOpera.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crBtnOpera.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(211)))), ((int)(((byte)(213)))));
            this.crBtnOpera.Location = new System.Drawing.Point(270, 5);
            this.crBtnOpera.Name = "crBtnOpera";
            this.crBtnOpera.Size = new System.Drawing.Size(77, 30);
            this.crBtnOpera.TabIndex = 3;
            this.crBtnOpera.Text = "Opera";
            this.crBtnOpera.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(211)))), ((int)(((byte)(213)))));
            this.crBtnOpera.UseVisualStyleBackColor = false;
            this.crBtnOpera.Click += new System.EventHandler(this.crBtnOpera_Click);
            // 
            // crBtnEdge
            // 
            this.crBtnEdge.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(27)))), ((int)(((byte)(56)))));
            this.crBtnEdge.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(27)))), ((int)(((byte)(56)))));
            this.crBtnEdge.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(76)))), ((int)(((byte)(141)))));
            this.crBtnEdge.BorderRadius = 20;
            this.crBtnEdge.BorderSize = 0;
            this.crBtnEdge.FlatAppearance.BorderSize = 0;
            this.crBtnEdge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.crBtnEdge.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crBtnEdge.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(211)))), ((int)(((byte)(213)))));
            this.crBtnEdge.Location = new System.Drawing.Point(187, 5);
            this.crBtnEdge.Name = "crBtnEdge";
            this.crBtnEdge.Size = new System.Drawing.Size(77, 30);
            this.crBtnEdge.TabIndex = 2;
            this.crBtnEdge.Text = "Edge";
            this.crBtnEdge.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(211)))), ((int)(((byte)(213)))));
            this.crBtnEdge.UseVisualStyleBackColor = false;
            this.crBtnEdge.Click += new System.EventHandler(this.crBtnEdge_Click);
            // 
            // crBtnFirefox
            // 
            this.crBtnFirefox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(27)))), ((int)(((byte)(56)))));
            this.crBtnFirefox.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(27)))), ((int)(((byte)(56)))));
            this.crBtnFirefox.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(48)))), ((int)(((byte)(82)))));
            this.crBtnFirefox.BorderRadius = 20;
            this.crBtnFirefox.BorderSize = 0;
            this.crBtnFirefox.FlatAppearance.BorderSize = 0;
            this.crBtnFirefox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.crBtnFirefox.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crBtnFirefox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(211)))), ((int)(((byte)(213)))));
            this.crBtnFirefox.Location = new System.Drawing.Point(101, 5);
            this.crBtnFirefox.Name = "crBtnFirefox";
            this.crBtnFirefox.Size = new System.Drawing.Size(80, 30);
            this.crBtnFirefox.TabIndex = 1;
            this.crBtnFirefox.Text = "Firefox";
            this.crBtnFirefox.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(211)))), ((int)(((byte)(213)))));
            this.crBtnFirefox.UseVisualStyleBackColor = false;
            this.crBtnFirefox.Click += new System.EventHandler(this.crBtnFirefox_Click);
            // 
            // crBtnCommonSettings
            // 
            this.crBtnCommonSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(27)))), ((int)(((byte)(56)))));
            this.crBtnCommonSettings.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(27)))), ((int)(((byte)(56)))));
            this.crBtnCommonSettings.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(91)))), ((int)(((byte)(234)))));
            this.crBtnCommonSettings.BorderRadius = 20;
            this.crBtnCommonSettings.BorderSize = 0;
            this.crBtnCommonSettings.FlatAppearance.BorderSize = 0;
            this.crBtnCommonSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.crBtnCommonSettings.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crBtnCommonSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(211)))), ((int)(((byte)(213)))));
            this.crBtnCommonSettings.Location = new System.Drawing.Point(5, 5);
            this.crBtnCommonSettings.Name = "crBtnCommonSettings";
            this.crBtnCommonSettings.Size = new System.Drawing.Size(90, 30);
            this.crBtnCommonSettings.TabIndex = 0;
            this.crBtnCommonSettings.Text = "Chrome";
            this.crBtnCommonSettings.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(211)))), ((int)(((byte)(213)))));
            this.crBtnCommonSettings.UseVisualStyleBackColor = false;
            this.crBtnCommonSettings.Click += new System.EventHandler(this.crBtnChrome_Click);
            // 
            // formHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 561);
            this.Controls.Add(this.pnlDesktop);
            this.Controls.Add(this.pnlDashboard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(694, 561);
            this.Name = "formHistory";
            this.Text = "formHistory";
            this.pnlDashboard.ResumeLayout(false);
            this.pnlDesktop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBrowserHistory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDashboard;
        private CustRoundedButton crBtnCommonSettings;
        private CustRoundedButton crBtnFirefox;
        private System.Windows.Forms.Panel pnlDesktop;
        private System.Windows.Forms.DataGridView dgvBrowserHistory;
        private CustRoundedButton crBtnEdge;
        private CustRoundedButton crBtnOpera;
        private CustRoundedButton crBtnBrave;
    }
}