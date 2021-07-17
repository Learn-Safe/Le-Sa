using Le_Sa.Models.AdminCheck;
using Le_Sa.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Le_Sa.BrowserControls
{
    public partial class formBrowserControls : Form
    {
        public formBrowserControls()
        {
            InitializeComponent();
        }

        private void formBrowserControls_Load(object sender, EventArgs e)
        {
            if (AdminCheck.IsAdmin() != true)
            {
                Form warning = new formAdminWarning("PLEASE RESTART THE APPLICATION WITH\r\nADMINISTRATOR PRIVILEGES \r\nTO CHANGE BROWSER CONTROLS")
                {
                    TopLevel = false,
                    AutoScroll = true,
                    FormBorderStyle = FormBorderStyle.None,
                    Dock = DockStyle.Fill,
                };
                pnlDesktop.Controls.Add(warning);
                warning.BringToFront();
                warning.Show();
            }
            else
            {
                return;
            }
        }

        private void formBrowserControls_SizeChanged(object sender, EventArgs e)
        {
            lblSelect.Location = new Point(((this.Width / 2) - (lblSelect.Width / 2)), ((this.Height / 2) - (lblSelect.Height / 2) + 70));
        }
    }
}
