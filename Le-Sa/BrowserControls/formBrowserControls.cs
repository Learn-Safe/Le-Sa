using Le_Sa.Models.AdminCheck;
using Le_Sa.Models.Registry;
using Le_Sa.Properties;
using Microsoft.Win32;
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
        private CustRoundedButton currentTBtn;
        private Form currentChildForm;
        private string[] browserList;

        public formBrowserControls()
        {
            InitializeComponent();
        }

        private void formBrowserControls_Load(object sender, EventArgs e)
        {
            if (AdminCheck.IsAdmin() != true)
            {
                pnlDashboard.Enabled = false;
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
                if (Environment.Is64BitOperatingSystem)
                {
                    browserList = ReadWriteRegistry.KeyNames(Registry.LocalMachine, @"SOFTWARE\Clients\StartMenuInternet").Item2;
                    IsBrowserInstalled();
                }
                else
                {
                    browserList = ReadWriteRegistry.KeyNames(Registry.LocalMachine, @"SOFTWARE\WOW6432Node\Clients\StartMenuInternet").Item2;
                    IsBrowserInstalled();
                }
                browserList = ReadWriteRegistry.KeyNames(Registry.CurrentUser, @"SOFTWARE\Clients\StartMenuInternet").Item2;
                IsBrowserInstalled();
            }
        }

        public void IsBrowserInstalled()
        {
            foreach (var crBtn in pnlDashboard.Controls.OfType<CustRoundedButton>())
            {
                if (browserList != null)
                {
                    foreach (string browser in browserList)
                    {
                        if (crBtn.Enabled == false)
                        {
                            if (browser == crBtn.Tag.ToString())
                            {
                                crBtn.Enabled = true;
                            }
                            else if (browser.Substring(0, 5) == crBtn.Tag.ToString().Substring(0, 5))
                            {
                                crBtn.Enabled = true;
                            }
                        }
                    }
                }
            }
        }

        private struct RGBColors
        {
            public static Color btnDefaultBack = Color.FromArgb(21, 27, 56);
            public static Color btnChromeClickedBack = Color.FromArgb(74, 138, 244);
            public static Color btnChromeClickedBorder = Color.FromArgb(26, 91, 234);
            public static Color btnFirefoxClickedBack = Color.FromArgb(255, 93, 52);
            public static Color btnFirefoxClickedBorder = Color.FromArgb(250, 48, 82);
            public static Color btnEdgeClickedBack = Color.FromArgb(51, 192, 237);
            public static Color btnEdgeClickedBorder = Color.FromArgb(10, 76, 141);
            public static Color btnOperaClickedBack = Color.FromArgb(255, 27, 45);
            public static Color btnOperaClickedBorder = Color.FromArgb(255, 27, 45);
            public static Color btnBraveClickedBack = Color.FromArgb(255, 85, 0);
            public static Color btnBraveClickedBorder = Color.FromArgb(255, 31, 0);
            public static Color btnVivaldiClickedBack = Color.FromArgb(255, 97, 100);
            public static Color btnVivaldiClickedBorder = Color.FromArgb(239, 57, 57);
        }

        #region Top Bar
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
        private void ActiveButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button customization
                currentTBtn = (CustRoundedButton)senderBtn;
                currentTBtn.BackColor = color;
                currentTBtn.BorderSize = 2;
                currentTBtn.Font = new Font(Font.FontFamily, 13, FontStyle.Bold);
            }
        }

        private void DisableButton()
        {
            if (currentTBtn != null)
            {
                //Button customization to default
                currentTBtn.BackColor = RGBColors.btnDefaultBack;
                currentTBtn.BorderSize = 0;
                currentTBtn.Font = new Font(Font.FontFamily, 12, FontStyle.Regular);
            }
        }
        #endregion

        private void formBrowserControls_SizeChanged(object sender, EventArgs e)
        {
            lblSelect.Location = new Point(((this.Width / 2) - (lblSelect.Width / 2)), ((this.Height / 2) - (lblSelect.Height / 2) + 70));
        }

        private void crBtnChrome_Click(object sender, EventArgs e)
        {
            OpenChildForm(new formChromeControls());
            ActiveButton(sender, RGBColors.btnChromeClickedBack);
            crBtnChrome.BorderColor = RGBColors.btnChromeClickedBorder;
        }

        private void crBtnFirefox_Click(object sender, EventArgs e)
        {
            OpenChildForm(new formFirefoxControl());
            ActiveButton(sender, RGBColors.btnFirefoxClickedBack);
            crBtnChrome.BorderColor = RGBColors.btnFirefoxClickedBorder;
        }

        private void crBtnEdge_Click(object sender, EventArgs e)
        {
            OpenChildForm(new formEdgeControls());
            ActiveButton(sender, RGBColors.btnEdgeClickedBack);
            crBtnChrome.BorderColor = RGBColors.btnEdgeClickedBorder;
        }
    }
}