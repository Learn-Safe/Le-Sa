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
    public partial class formDesktop : Form
    {
        private CustRoundedButton currentBtn;
        private Form currentChildForm;

        public formDesktop()
        {
            InitializeComponent();
            crBtnHistory.ImageAlign = ContentAlignment.TopCenter;
        }

        readonly String titlebarText = "Le-Sa | ";
        String currentMenuItem = "";

        private struct RGBColors
        {
            public static Color btnDefault = Color.FromArgb(35,46,76);
            public static Color btnDefaultFore = Color.FromArgb(210, 211, 213);
            public static Color btnClicked = Color.FromArgb(45, 54, 76);
            public static Color btnClickedFore = Color.FromArgb(255, 255, 255);
            public static Color btnsnettingsDefaultFore = Color.FromArgb(173,39,29);
            public static Color btnsettingsClickedFore = Color.FromArgb(217,48,37);
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

        private void crBtnDashboard_Click(object sender, EventArgs e)
        {
            currentMenuItem = "Dashboard";
            ActiveButton(sender, RGBColors.btnClickedFore);
            OpenChildForm(new formDashboard());
        }

        private void crBtnHistory_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.btnClickedFore);
            currentMenuItem = "History";
        }

        private void crBtnSettings_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, RGBColors.btnsettingsClickedFore);
            currentMenuItem = "Settings";
        }
        #endregion
    }
}
