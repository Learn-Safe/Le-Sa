using Le_Sa.Models.Netsh;
using Le_Sa.Structs;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Le_Sa.Settings
{
    public partial class formDNSConfig : Form
    {
        public formDNSConfig()
        {
            InitializeComponent();
        }

        #region Webview Navigation Controls
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
        #endregion

        private void crBtnSetupThisDevice_Click(object sender, EventArgs e)
        {
            foreach (var @interface in NetshHelper.GetInterfaces())
            {
                Console.WriteLine(@interface);
                try
                {
                    NetshHelper.UpdateDnsEntries(@interface, "208.67.222.222", "208.67.220.220");
                }
                catch (Exception dnsError)
                {
                    Console.WriteLine(dnsError.Message);
                }
                wvOpenDNS.CoreWebView2.Navigate("https://welcome.opendns.com/");
            }
        }

        private void crBtnSetupRouter_Click(object sender, EventArgs e)
        {
            wvOpenDNS.CoreWebView2.Navigate("https://support.opendns.com/hc/en-us/sections/206253627");
        }

        private void crBtnResetThisDevice_Click(object sender, EventArgs e)
        {
            foreach (var @interface in NetshHelper.GetInterfaces())
            {
                NetshHelper.ResetDnsEntries(@interface);
            }
            wvOpenDNS.CoreWebView2.Navigate("https://welcome.opendns.com/");
        }

        private void crBtnDNSStatus_Click(object sender, EventArgs e)
        {
            wvOpenDNS.CoreWebView2.Navigate("https://welcome.opendns.com/");
        }
    }
}