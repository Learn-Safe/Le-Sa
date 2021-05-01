using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FontAwesome.Sharp;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Le_Sa
{
    public partial class formDashboard : Form
    {

        private IconButton currentBtn;

        public formDashboard()
        {
            InitializeComponent();
        }

        private struct RGBColors
        {
            public static Color desktopBackDefault = Color.FromArgb(34, 40, 74);
            public static Color normal = Color.FromArgb(52, 152, 219);
            public static Color settings = Color.FromArgb(231, 76, 60);
            public static Color menuBackDefault = Color.FromArgb(24, 30, 54);
        }

        #region Side Menu
        private void ActiveButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button customization
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = RGBColors.desktopBackDefault;
                currentBtn.IconColor = color;
                currentBtn.ForeColor = color;

            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                //Button customization to default
                currentBtn.BackColor = RGBColors.menuBackDefault;
                currentBtn.IconColor = RGBColors.normal;
                currentBtn.ForeColor = RGBColors.normal;
            }
        }

        private void ibtnDashboard_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.normal);
        }

        private void ibtnRports_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.normal);
        }

        private void ibtnInfo_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.normal);
        }

        private void ibtnSettings_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.settings);
        }
        #endregion

        #region Resizability 
        //Resizable form
        private const int cGrip = 16;

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x84)
            {
                Point pos = new Point(m.LParam.ToInt32());
                pos = this.PointToScreen(pos);
                if (pos.X >= ClientSize.Width - cGrip && pos.Y >= ClientSize.Height - cGrip)
                {
                    m.Result = (IntPtr)17;
                    return;
                }
            }
            base.WndProc(ref m);
        }
        //Resizable form end
        #endregion

        #region Draggability
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
        #endregion

        #region Ttitle bar control buttons

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();  //close event
        }
        private void btnClose_MouseDown(object sender, MouseEventArgs e)
        {
            btnClose.BackgroundImage = Properties.Resources.close_click20px;
        }
        private void btnClose_MouseHover(object sender, EventArgs e)
        {
            btnClose.BackgroundImage = Properties.Resources.close_20px;
        }
        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.BackgroundImage = Properties.Resources.filled_close_20px;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized; //minimize events
        }

        private void btnMinimize_MouseDown(object sender, MouseEventArgs e)
        {
            btnMinimize.BackgroundImage = Properties.Resources.minimize_click20px;
        }

        private void btnMinimize_MouseHover(object sender, EventArgs e)
        {
            btnMinimize.BackgroundImage = Properties.Resources.minimize_20px;
        }

        private void btnMinimize_MouseLeave(object sender, EventArgs e)
        {
            btnMinimize.BackgroundImage = Properties.Resources.filled_minimize_20px;
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal) //check window state
            {
                this.MaximumSize = Screen.PrimaryScreen.WorkingArea.Size;
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void btnMaximize_MouseDown(object sender, MouseEventArgs e)
        {
            btnMaximize.BackgroundImage = Properties.Resources.maximize_click_20px;
        }
        private void btnMaximize_MouseHover(object sender, EventArgs e)
        {
            btnMaximize.BackgroundImage = Properties.Resources.maximize_20px;
        }
        private void btnMaximize_MouseLeave(object sender, EventArgs e)
        {
            btnMaximize.BackgroundImage = Properties.Resources.maximize_filled_20px;
        }
        #endregion

    }
}
