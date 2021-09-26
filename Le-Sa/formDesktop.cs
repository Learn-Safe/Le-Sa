using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Le_Sa.History;
using System.Windows.Forms;
using Le_Sa.BrowserControls;
using System.IO;

namespace Le_Sa
{
    public partial class formDesktop : Form
    {
        private CustRoundedButton currentBtn;
        private Form currentChildForm;
        private string ImageLoc = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\Le-Sa\User Data\DP\DP";
        string DPLoc;

        public formDesktop()
        {
            InitializeComponent();
            crBtnHistory.ImageAlign = ContentAlignment.TopCenter;
        }

        readonly String titlebarText = "Le-Sa | ";
        String currentMenuItem = "";

        private void formDesktop_Load(object sender, EventArgs e)
        {
        lblUserName.Text = Properties.Settings.Default.username;
            lblUserName.Location = new Point(((pnlUser.Width / 2) - (lblUserName.Width / 2)), ((pnlUser.Height / 2) - (lblUserName.Height / 2) + 87));

            try
            {
                if (File.Exists(ImageLoc))
                {
                    cRPBDP.Image = new Bitmap(ImageLoc);
                }
                else
                {
                    cRPBDP.Image = Properties.Resources.user_90px;
                }
            }
            catch
            {
                cRPBDP.Image = Properties.Resources.user_90px;
            }

        }

        private void formDesktop_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private struct RGBColors
        {
            public static Color btnDefault = Color.FromArgb(35,46,76);
            public static Color btnDefaultFore = Color.FromArgb(210, 211, 213);
            public static Color btnClicked = Color.FromArgb(45, 54, 76);
            public static Color btnClickedFore = Color.FromArgb(255, 255, 255);
            public static Color btnsnettingsDefaultFore = Color.FromArgb(173,39,29);
            public static Color btnsettingsClickedFore = Color.FromArgb(217,48,37);
        }

        #region Side Menu
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
                currentBtn = (CustRoundedButton)senderBtn;
                currentBtn.BackColor = RGBColors.btnClicked;
                currentBtn.ForeColor = color;
                this.Text = titlebarText + currentMenuItem;
            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                //Button customization to default
                currentBtn.BackColor = RGBColors.btnDefault;
                currentBtn.ForeColor = RGBColors.btnDefaultFore;
                crBtnSettings.ForeColor = RGBColors.btnsnettingsDefaultFore;
            }
        }

        private void crBtnHistory_Click(object sender, EventArgs e)
        {
            currentMenuItem = "History";
            ActiveButton(sender, RGBColors.btnClickedFore);
            OpenChildForm(new formHistory());
        }

        private void crBtnBrowserControls_Click(object sender, EventArgs e)
        {
            currentMenuItem = "Browser Control";
            ActiveButton(sender, RGBColors.btnClickedFore);
            OpenChildForm(new formBrowserControls());
        }

        private void crBtnSettings_Click(object sender, EventArgs e)
        {
            currentMenuItem = "Settings";
            ActiveButton(sender, RGBColors.btnsettingsClickedFore);
            OpenChildForm(new formSettings());
        }
        #endregion
    }
}
