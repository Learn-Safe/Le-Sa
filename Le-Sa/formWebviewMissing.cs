using Le_Sa.Models.Registry;
using Microsoft.Win32;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace Le_Sa
{
    public partial class formWebviewMissing : Form
    {
        public formWebviewMissing()
        {
            InitializeComponent();
        }

        private void formWebviewMissing_Resize(object sender, EventArgs e)
        {
            lblWarning.Location = new Point(((this.Width / 2) - (lblWarning.Width / 2)), ((this.Height / 2) - (lblWarning.Height / 2) - 70));
            crBtnInstall.Location = new Point(((this.Width / 2) - (crBtnInstall.Width / 2)), ((this.Height / 2) - (crBtnInstall.Height / 2) + 70));
            progBarEdgeDownload.Maximum = this.Width;
        }

        private void crBtnInstall_Click(object sender, EventArgs e)
        {
            try
            {
                crBtnInstall.Visible = false;
                progBarEdgeDownload.Visible = true;
                WebClient edgeWebview = new WebClient();
                edgeWebview.DownloadProgressChanged += EdgeWebview_DownloadProgressChanged;
                edgeWebview.DownloadFileCompleted += EdgeWebview_DownloadFileCompleted;
                edgeWebview.DownloadFileAsync(new Uri("https://go.microsoft.com/fwlink/p/?LinkId=2124703"), Path.GetTempPath() + @"MicrosoftEdgeWebview2Setup.exe");
            }
            catch (Exception downloadError)
            {
                MessageBox.Show(downloadError.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                crBtnInstall.Visible = false;
                progBarEdgeDownload.Visible = false;
                progBarEdgeDownload.Value = 0;
            }
        }

        private void EdgeWebview_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            try
            {
                progBarEdgeDownload.Value = (int)(float)(e.ProgressPercentage * (this.Width/ 100));
            }
            catch (Exception progressError)
            {
                MessageBox.Show(progressError.Message);
            }
        }


        private void EdgeWebview_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            if (File.Exists(Path.GetTempPath()+ @"MicrosoftEdgeWebview2Setup.exe"))
            {
                try
                {
                    var installEdgeWebview = new Process
                    {
                        StartInfo = new ProcessStartInfo
                        {
                            FileName = Path.GetTempPath() + @"MicrosoftEdgeWebview2Setup.exe"
                        }
                    };
                    installEdgeWebview.Start();
                    installEdgeWebview.WaitForExit();
                    progBarEdgeDownload.Visible = false;
                }
                catch (Exception completedError)
                {
                    MessageBox.Show(completedError.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                crBtnInstall.Visible = true;
                progBarEdgeDownload.Visible = false;
                MessageBox.Show("An error occured during the downloading.\r\nMaby your offline.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            (bool, string) edgeWebviewAvailablity = ((bool, string))ReadWriteRegistry.ReadRegistry(Registry.LocalMachine, @"SOFTWARE\WOW6432Node\Microsoft\EdgeUpdate\Clients\{F3017226-FE2A-4295-8BDF-00C3A9A7E4C5}", "pv");
            if (edgeWebviewAvailablity.Item1 == false)
            {
                progBarEdgeDownload.Visible = false;
                crBtnInstall.Visible = true;
                MessageBox.Show("An error occured during the installation.\r\nInstallation aborted!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Edge WebView2 Successfully Installed.", "Installation Successful", MessageBoxButtons.OK, MessageBoxIcon.None);
                lblWarning.Text = " Now you can change DNS Settings.\r\nClick on 'DNS Settings' button.";
                lblWarning.Location = new Point(((this.Width / 2) - (lblWarning.Width / 2)), (this.Height / 2) - (lblWarning.Height / 2));
            }
        }
    }
}
