using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Web.WebView2.Core;
using System.Windows.Forms;

namespace Le_Sa.Settings
{
    public partial class formDNSConfig : Form
    {
        public formDNSConfig()
        {
            InitializeComponent();
        }

        private void crBtnBack_Click(object sender, EventArgs e)
        {
            wvOpenDNS.GoBack();
        }

        private void crBtnForward_Click(object sender, EventArgs e)
        {
            wvOpenDNS.GoForward();
        }

        private void crBtnReload_Click(object sender, EventArgs e)
        {
            wvOpenDNS.Reload();
        }

        private void crBtnHome_Click(object sender, EventArgs e)
        {
            wvOpenDNS.CoreWebView2.Navigate(@"https://login.opendns.com/?return_to=https://dashboard.opendns.com/");
        }

        private void crBtnSignUp_Click(object sender, EventArgs e)
        {
            wvOpenDNS.CoreWebView2.Navigate(@"https://www.opendns.com/home-internet-security#parental-controls");
        }
    }
}