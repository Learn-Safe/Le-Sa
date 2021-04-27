using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Le_Sa
{
    public partial class formDashboard : Form
    {
        /*[DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
            (
            int nLeftReact,
            int nTopReact,
            int nRightReact,
            int nBottomReact,
            int nWidthEllipse,
            int nHeightEllipse
            );*/

        public formDashboard()
        {
            InitializeComponent();
            //Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        private void formDashboard_Load(object sender, EventArgs e)
        {

        }

        private void ibtnDashboard_Click(object sender, EventArgs e)
        {
            ibtnDashboard.BackColor = Color.FromArgb(255, 255, 255);
        }

        private void ibtnRports_Click(object sender, EventArgs e)
        {
            ibtnRports.BackColor = Color.FromArgb(255, 255, 255);
            ibtnDashboard.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void ibtnInfo_Click(object sender, EventArgs e)
        {
            ibtnInfo.BackColor = Color.FromArgb(255, 255, 255);
            ibtnDashboard.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void ibtnSettings_Click(object sender, EventArgs e)
        {
            ibtnSettings.BackColor = Color.FromArgb(255, 255, 255);
            ibtnDashboard.BackColor = Color.FromArgb(24, 30, 54);

        }

        private void ibtnDashboard_Leave(object sender, EventArgs e)
        {
            ibtnSettings.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void ibtnRports_Leave(object sender, EventArgs e)
        {
            ibtnRports.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void ibtnInfo_Leave(object sender, EventArgs e)
        {
            ibtnInfo.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void ibtnSettings_Leave(object sender, EventArgs e)
        {
            ibtnSettings.BackColor = Color.FromArgb(24, 30, 54);

        }
    }
}
