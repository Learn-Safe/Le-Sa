using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FontAwesome.Sharp;
using Le_Sa.Settings;
using System.Windows.Forms;

namespace Le_Sa
{
    public partial class formSettings : Form
    {

        private IconButton currentBtn;
        private Form currentChildForm;

        public formSettings()
        {
            InitializeComponent();
        }

        private struct RGBColors
        {
            public static Color desktopBackDefault = Color.FromArgb(34, 40, 74);
            public static Color normal = Color.FromArgb(52, 152, 219);
            public static Color settings = Color.FromArgb(231, 76, 60);
            public static Color menuItemDefault = Color.FromArgb(255,255,255);
        }

        #region Open Child Form
        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlDesktop.Controls.Add(childForm);
            pnlDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        #endregion  

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
                currentBtn.IconColor = RGBColors.menuItemDefault;
                currentBtn.ForeColor = RGBColors.menuItemDefault;
            }
        }

        private void ibtnBrowser_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.normal);
            OpenChildForm(new fromSettingsBrowser());
        }

        private void ibtnBlackList_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.normal);
            OpenChildForm(new formSettingsBlacklist());
        }
        #endregion
    }
}
