using Le_Sa.Models.Netsh;
using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Management;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace Le_Sa.Settings
{
    public partial class formDNSConfig : Form
    {
        private static readonly string mainDrive = Path.GetPathRoot(Environment.SystemDirectory);
        private static string currentUserFolder = $@"{mainDrive}Users\{userName()}";
        private static string currentUserTempFolder = $@"{currentUserFolder}\AppData\Local\Temp";

        public formDNSConfig()
        {
            InitializeComponent();
        }

        #region Current User username
        private static string userName()
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT UserName FROM Win32_ComputerSystem");
            ManagementObjectCollection collection = searcher.Get();
            return (collection.Cast<ManagementBaseObject>().First()["UserName"].ToString().Split('\\')[1]);
        }
        #endregion

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

        private void wvOpenDNS_NavigationCompleted(object sender, Microsoft.Web.WebView2.Core.CoreWebView2NavigationCompletedEventArgs e)
        {
            if (wvOpenDNS.CoreWebView2.Source.Contains("dashboard.opendns.com"))
            {
                crBtnYT.Visible = false;
                crBtnClose.Visible = false;
            }
            else
            {
                crBtnYT.Visible = true;
                crBtnClose.Visible = true;
            }

            if (wvOpenDNS.CoreWebView2.Source.Contains("login.opendns.com"))
            {
                wvOpenDNS.CoreWebView2.ExecuteScriptAsync("document.getElementsByClassName('text-link')[3].style.visibility = 'hidden';");
            }
            if (wvOpenDNS.CoreWebView2.Source.Contains("homefree"))
            {
                wvBackColorWhite();
            }
            else if (wvOpenDNS.CoreWebView2.Source.Contains("prosumer"))
            {
                wvBackColorWhite();
            }
            else if (wvOpenDNS.CoreWebView2.Source.Contains("vip-home"))
            {
                wvBackColorWhite();
            }
        }

        private void wvBackColorWhite()
        {
            wvOpenDNS.CoreWebView2.ExecuteScriptAsync("document.getElementsByTagName('BODY')[0].style.backgroundColor = 'white';");
        }

        private void crBtnClose_Click(object sender, EventArgs e)
        {
            crBtnYT.Visible = false;
            crBtnClose.Visible = false;
        }

        private void crBtnYT_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Use these video, which we recommended, until the tutorial video we make is delivered to you as soon as possible","OpenDNS Tutorials",MessageBoxButtons.OK);
            if (System.IO.File.Exists(currentUserTempFolder + @"\tutorielVid.txt"))
            {
                System.IO.File.Delete(currentUserTempFolder + @"\tutorielVid.txt");
            }
            try
            {
                WebClient dataFile = new WebClient();
                dataFile.DownloadFile("https://gist.githubusercontent.com/sathsarabandaraj/c2c3995d09c46de85120babb03658262/raw" , currentUserTempFolder + @"\tutorielVid.txt");
            }
            catch (Exception downErr)
            {
                MessageBox.Show(downErr.Message, "Error");
            }

            if (File.Exists(currentUserTempFolder + @"\tutorielVid.txt"))
            {
                const Int32 BufferSize = 128;
                var fileStream = File.OpenRead(currentUserTempFolder + @"\tutorielVid.txt");
                using (var streamReader = new StreamReader(fileStream, Encoding.UTF8, true, BufferSize))
                {
                    String link;
                    while ((link = streamReader.ReadLine()) != null)
                    {
                        Process.Start(link);
                    }
                }

            }

        }
    }
}