using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Le_Sa
{
    public partial class formLoadingScreen : Form
    {
        public formLoadingScreen()
        {
            InitializeComponent();
        }

        private void timerLoading_Tick(object sender, EventArgs e)
        {
            pnlLoadingFront.Width += 8;
            if (pnlLoadingFront.Width >= 925)
            {
                timerLoading.Stop();
                formDashboard dahsboard = new formDashboard();
                dahsboard.Show();
                this.Hide();
            }
        }
    }
}
