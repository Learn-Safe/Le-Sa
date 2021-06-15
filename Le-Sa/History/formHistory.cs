using Le_Sa.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Le_Sa.History
{
    public partial class formHistory : Form
    {
        private CustRoundedButton currentBtn;
        private Form currentChildForm;

        public formHistory()
        {
            InitializeComponent();
        }

        private string browser;
        readonly String titlebarText = "Le-Sa | History | ";

        private struct RGBColors
        {
            public static Color btnDefault = Color.FromArgb(35, 46, 76);
            public static Color btnDefaultFore = Color.FromArgb(210, 211, 213);
            public static Color btnClicked = Color.FromArgb(45, 54, 76);
            public static Color btnClickedFore = Color.FromArgb(255, 255, 255);
            public static Color btnsnettingsDefaultFore = Color.FromArgb(173, 39, 29);
            public static Color btnsettingsClickedFore = Color.FromArgb(217, 48, 37);
        }

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
            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                //Button customization to default
                currentBtn.BackColor = RGBColors.btnDefault;
                currentBtn.ForeColor = RGBColors.btnDefaultFore;
            }
        }
        #endregion


        private void crBtnChrome_Click(object sender, EventArgs e)
        {
            browser = "Chrome";
            ChromeBrowserHistory history = new ChromeBrowserHistory();
            dgvBrowserHistory.DataSource = history.GetDataTable();
        }

        private void crBtnFirefox_Click(object sender, EventArgs e)
        {
            browser = "Firefox";
            FirefoxBrowserHistory history = new FirefoxBrowserHistory();
            dgvBrowserHistory.DataSource = history.GetDataTable();
            this.Text = titlebarText + browser;
        }
    }
}
