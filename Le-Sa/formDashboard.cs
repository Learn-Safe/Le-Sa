using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Le_Sa
{
    public partial class formDashboard : Form
    {

        public formDashboard()
        {
            InitializeComponent();
        }

        //Draggable form
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
                         int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void pnlTitleBar_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        //Draggable form end

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
