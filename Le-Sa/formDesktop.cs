using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FontAwesome.Sharp;
using System.Windows.Forms;
 
namespace Le_Sa
{
    public partial class formDesktop : Form
    {

        private IconButton currentBtn;


        public formDesktop()
        {
            InitializeComponent();
        }

        readonly String titlebarText = "Le-Sa | ";
        String currentMenuItem = "";

        private struct RGBColors
        {
            public static Color desktopBackDefault = Color.FromArgb(34, 40, 74);
            public static Color normal = Color.FromArgb(52, 152, 219);
            public static Color settings = Color.FromArgb(231, 76, 60);
            public static Color menuBackDefault = Color.FromArgb(24, 30, 54);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, ClientRectangle, Color.Gold, ButtonBorderStyle.Solid);
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
                this.Text = titlebarText + currentMenuItem;
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
            currentMenuItem = "Dashboard";
            ActiveButton(sender, RGBColors.normal);
        }

        private void ibtnRports_Click(object sender, EventArgs e)
        {
            currentMenuItem = "Report";
            ActiveButton(sender, RGBColors.normal);
        }

        private void ibtnInfo_Click(object sender, EventArgs e)
        {
            currentMenuItem = "Info";
            ActiveButton(sender, RGBColors.normal);
        }

        private void ibtnSettings_Click(object sender, EventArgs e)
        {
            currentMenuItem = "Settings";
            ActiveButton(sender, RGBColors.settings);
        }
        #endregion
    }
}
