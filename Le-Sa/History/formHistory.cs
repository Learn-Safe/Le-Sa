using Le_Sa.Models;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Le_Sa.History
{
    public partial class formHistory : Form
    {
        private CustRoundedButton currentBtn;

        public string sourcePath;
        public string destinationPath;
        public string fileName;

        public formHistory()
        {
            InitializeComponent();
        }

        private string browser;
        private string N;

        private struct RGBColors
        {
            public static Color btnDefaultBack = Color.FromArgb(21, 27, 56);
            public static Color btnChromeClickedBack = Color.FromArgb(74, 138, 244);
            public static Color btnFirefoxClickedBack = Color.FromArgb(255, 93, 52);
            public static Color btnChromeClickedBorder = Color.FromArgb(26, 91, 234);
            public static Color btnFirefoxClickedBorder = Color.FromArgb(250, 48, 82);
        }

        #region Side Menu
        private void ActiveButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //Button customization
                currentBtn = (CustRoundedButton)senderBtn;
                currentBtn.BackColor = color;
                currentBtn.BorderSize = 2;
                currentBtn.Font = new Font(Font.FontFamily, 13, FontStyle.Bold);
            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                //Button customization to default
                currentBtn.BackColor = RGBColors.btnDefaultBack;
                currentBtn.BorderSize = 0;
                currentBtn.Font = new Font(Font.FontFamily, 12, FontStyle.Regular);
            }
        }
        #endregion

        private void crBtnFirefox_Click(object sender, EventArgs e)
        {
            // Assign Data to variables
            browser = "Firefox";
            sourcePath = ReadFirefoxProfile();
            destinationPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\Le-Sa\Data\FData\FHis";
            fileName = "places.sqlite";

            CopyHistory();
            ActiveButton(sender, RGBColors.btnFirefoxClickedBack);
            crBtnFirefox.BorderColor = RGBColors.btnFirefoxClickedBorder;
            FirefoxBrowserHistory history = new FirefoxBrowserHistory();
            dgvBrowserHistory.DataSource = history.GetDataTable();
        }

        private void crBtnChrome_Click(object sender, EventArgs e)
        {
            // Assign Data to variables
            browser = "Chrome";
            sourcePath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\Google\Chrome\User Data\Default";
            destinationPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\Le-Sa\Data\CData\CHis";
            fileName = "History";

            CopyHistory();
            ActiveButton(sender, RGBColors.btnChromeClickedBack);
            crBtnChrome.BorderColor = RGBColors.btnChromeClickedBorder;
            ChromeBrowserHistory history = new ChromeBrowserHistory();
            dgvBrowserHistory.DataSource = history.GetDataTable();
        }

        #region Find Firefox Data Location
        private string ReadFirefoxProfile()
        {
            string mozillaDir = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Mozilla");

            if (Directory.Exists(mozillaDir))
            {
                string firefoxDir = Path.Combine(mozillaDir, "Firefox");

                if (Directory.Exists(firefoxDir))
                {
                    string prof_file = Path.Combine(firefoxDir, "profiles.ini");

                    if (File.Exists(prof_file))
                    {
                        StreamReader rdr = new StreamReader(prof_file);

                        string[] lines = rdr.ReadToEnd().Split(new string[] { "\r\n" }, StringSplitOptions.None);
                        string location = lines.First(x => x.Contains("Default=")).Split(new string[] { "=" }, StringSplitOptions.None)[1];
                        string finalLocation = location.Replace("/", @"\");
                        return Path.Combine(firefoxDir, finalLocation);
                    }
                    else
                    {
                        MessageBox.Show("Unable to recognize firefox account", "Profiles file missing");
                    }
                }
            }
            return "";
        }
        #endregion

        #region Copy History Files
        private void CopyHistory()
        {
            string sourceFile = System.IO.Path.Combine(sourcePath, fileName);
            string destFile = System.IO.Path.Combine(destinationPath, fileName);
            MessageBox.Show(sourceFile + " s file");
            MessageBox.Show(destFile + " d file");


            System.IO.Directory.CreateDirectory(destinationPath);
            if (System.IO.Directory.Exists(sourcePath))
            {
                System.IO.File.Copy(sourceFile, destFile, true);
            }
            else
            {
                MessageBox.Show(browser + "'s history file not found!. If backup system working correctly history will restore automatically","Not found!");
            }
        }
        #endregion

    }
}
