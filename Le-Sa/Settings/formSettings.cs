using System;
using System.Drawing;
using Le_Sa.Settings;
using System.Windows.Forms;
using Le_Sa.Models.Registry;
using Microsoft.Win32;

namespace Le_Sa
{
    public partial class formSettings : Form
    {

        private CustRoundedButton currentBtn;
        private Form currentChildForm;

        public formSettings()
        {
            InitializeComponent();
        }

        private struct RGBColors
        {
            public static Color btnDefault = Color.FromArgb(21, 27, 56);
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

        #region Top Menu
        private void ActiveButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button customization
                currentBtn = (CustRoundedButton)senderBtn;
                currentBtn.BackColor = RGBColors.desktopBackDefault;
                currentBtn.ForeColor = color;
            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                //Button customization to default
                currentBtn.ForeColor = RGBColors.menuItemDefault;
                currentBtn.BackColor = RGBColors.btnDefault;
            }
        }

        private void crBtnDNSConfig_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.normal);
            (bool, string) edgeWebviewAvailablity = ((bool, string))ReadWriteRegistry.ReadRegistry(Registry.LocalMachine, @"SOFTWARE\WOW6432Node\Microsoft\EdgeUpdate\Clients\{F3017226-FE2A-4295-8BDF-00C3A9A7E4C5}", "pv");
            if (edgeWebviewAvailablity.Item1 == false)
            {
                OpenChildForm(new formWebviewMissing());
            }
            else
            {
                OpenChildForm(new formDNSConfig());
            }
        }

        private void crBtnAccountSettings_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.normal);
            OpenChildForm(new formAccountSettings());
        }
        #endregion
    }
}
