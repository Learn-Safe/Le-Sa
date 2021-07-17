using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Le_Sa
{
    public partial class formAdminWarning : Form
    {
        public formAdminWarning(string warningMsg)
        {
            InitializeComponent();
            lblWarning.Text = warningMsg;
        }


        private void formAdminWarning_SizeChanged(object sender, EventArgs e)
        {
            lblWarning.Location = new Point(((this.Width / 2) - (lblWarning.Width / 2)), ((this.Height / 2) - (lblWarning.Height / 2) - 70));
            crBtnRestart.Location = new Point(((this.Width / 2) - (crBtnRestart.Width / 2)), ((this.Height / 2) - (crBtnRestart.Height / 2) + 70));
        }

        private void crBtnRestart_Click(object sender, EventArgs e)
        {
            ProcessStartInfo proc = new ProcessStartInfo
            {
                UseShellExecute = true,
                WorkingDirectory = Environment.CurrentDirectory,
                FileName = Application.ExecutablePath,
                Verb = "runas"
            };
            try
            {
                Process.Start(proc);
            }
            catch
            {
                // The user refused the elevation.
                // Do nothing and return directly
                return;
            }
            Application.Exit();  // Quit itself
        }
    }
}
