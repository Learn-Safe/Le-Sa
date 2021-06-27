using Le_Sa.Models;
using Le_Sa.Models.Copy;
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

        public formHistory()
        {
            InitializeComponent();
        }

        string sourcePath;
        string sourceFile;
        string destinationPath;
        string destinationFile = "History";

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

        #region Browsers List

        #region Chrome
        private void crBtnChrome_Click(object sender, EventArgs e)
        {
            //Button Customization
            ActiveButton(sender, RGBColors.btnChromeClickedBack);
            crBtnCommonSettings.BorderColor = RGBColors.btnChromeClickedBorder;

            // Assign Data to variables
            sourcePath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\Google\Chrome\User Data\Default";
            sourceFile = "History";
            destinationPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\Le-Sa\Data\CData\CHis";

            Copy.CopyFile(sourcePath, sourceFile, destinationPath, destinationFile);
            ChromeBrowserHistory history = new ChromeBrowserHistory();
            dgvBrowserHistory.DataSource = history.GetDataTable();
        }
        #endregion

        #region Firefox
        private void crBtnFirefox_Click(object sender, EventArgs e)
        {
            //Button Customization
            ActiveButton(sender, RGBColors.btnFirefoxClickedBack);
            crBtnFirefox.BorderColor = RGBColors.btnFirefoxClickedBorder;

            // Assign Data to variables
            sourcePath = ReadFirefoxProfile();
            sourceFile = "places.sqlite";
            destinationPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\Le-Sa\Data\FData\FHis";

            Copy.CopyFile(sourcePath, sourceFile, destinationPath, destinationFile);
            FirefoxBrowserHistory history = new FirefoxBrowserHistory();
            dgvBrowserHistory.DataSource = history.GetDataTable();
        }
        #endregion

        #region Edge(Chromium Based)
        private void crBtnEdge_Click(object sender, EventArgs e)
        {
            //Button Customization
            ActiveButton(sender, RGBColors.btnEdgeClickedBack);
            crBtnEdge.BorderColor = RGBColors.btnEdgeClickedBorder;

            // Assign Data to variables
            sourcePath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\Microsoft\Edge\User Data\Default";
            sourceFile = "History";
            destinationPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\Le-Sa\Data\EData\EHis";

            Copy.CopyFile(sourcePath, sourceFile, destinationPath, destinationFile);
            EdgeBrowserHistory history = new EdgeBrowserHistory();
            dgvBrowserHistory.DataSource = history.GetDataTable();
        }
        #endregion

        #region Opera
        private void crBtnOpera_Click(object sender, EventArgs e)
        {
            //Button Customization
            ActiveButton(sender, RGBColors.btnOperaClickedBack);
            crBtnCommonSettings.BorderColor = RGBColors.btnOperaClickedBorder;

            // Assign Data to variables
            sourcePath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\Opera Software\Opera Stable";
            sourceFile = "History";
            destinationPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\Le-Sa\Data\OData\OHis";

            Copy.CopyFile(sourcePath, sourceFile, destinationPath, destinationFile);
            OperaBrowserHistory history = new OperaBrowserHistory();
            dgvBrowserHistory.DataSource = history.GetDataTable();
        }
        #endregion

        #region Brave
        private void crBtnBrave_Click(object sender, EventArgs e)
        {            
            //Button Customization
            ActiveButton(sender, RGBColors.btnBraveClickedBack);
            crBtnCommonSettings.BorderColor = RGBColors.btnBraveClickedBorder;

            // Assign Data to variables
            sourcePath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\BraveSoftware\Brave-Browser\User Data\Default";
            sourceFile = "History";
            destinationPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\Le-Sa\Data\BData\BHis";

            Copy.CopyFile(sourcePath, sourceFile, destinationPath, destinationFile);
            BraveBrowserHistory history = new BraveBrowserHistory();
            dgvBrowserHistory.DataSource = history.GetDataTable();
        }
        #endregion

        #endregion

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
    }
}
