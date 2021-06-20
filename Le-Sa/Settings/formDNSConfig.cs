using System;
using System.Windows.Forms;
using CefSharp;

namespace Le_Sa.Settings
{
    public partial class formDNSConfig : Form
    {
        public formDNSConfig()
        {
            InitializeComponent();
        }
        public CefSharp.WinForms.ChromiumWebBrowser browser;

        private void formDNSConfig_Load(object sender, EventArgs e)
        {
            browser = new CefSharp.WinForms.ChromiumWebBrowser("https://signup.opendns.com/homefree/")
            {
                Dock = DockStyle.Fill
            };
            this.panel1.Controls.Add(browser);
        }
    }
}
