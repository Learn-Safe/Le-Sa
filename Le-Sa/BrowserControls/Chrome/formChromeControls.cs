using Le_Sa.CustomControls;
using Le_Sa.Models.Registry;
using Microsoft.Win32;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Le_Sa.BrowserControls.Chrome
{
    public partial class formChromeControls : Form
    {
        private readonly RegistryKey BaseFolder = Registry.CurrentUser;
        private readonly string SubFolderPath = @"Software\Policies\Google\Chrome\";
        private readonly string[] invert = { "BrowserGuestModeEnabled", "AllowDeletingBrowserHistory", "BrowserAddPersonEnabled" };
        private readonly string[] valeTwo = { "DeveloperToolsAvailability" };
        CustToggleButton cTBtn;
        private string trueValue;
        private string falseValue;

        #region Description Vars
        private readonly string IncognitoModeAvailability = "Disabling Incognito Mode will block access to the INCOGNITO MODE.\n\nEnabling this will allow user to access to the INCOGNITO MODE.\n\nINCOGNITO MODE doesn't store any data about user activities.";
        private readonly string BrowserGuestModeEnabled = "Disabling Guest Mode will block access to the GUEST MODE.\n\nEnabling this will allow user to access to the GUEST MODE\n\nGUEST MODE doesn't store any data about user activities.";
        private readonly string BlockExternalExtensions = "Blocking External Extension will deny user from installing external extensions.\n\nIf this setting disabled, user is allowed to install any external extension.";
        private readonly string PasswordLeakDetectionEnabled = "Enabling Password Leak Detection will notify the user if any saved password has been compromised as part of a data breach.";
        private readonly string DeveloperToolsAvailability = "Disabling DEVELOPER TOOLS will block access to the DEVELOPER TOOLS.\n\nEnabling this will allow user to acess to the DEVELOPER TOOLS.\n\nDEVELOPER TOOLS lets the user to view the source code of any web app and more.";
        private readonly string AllowDeletingBrowserHistory = "Blocking History Deletion will deny the user from deleting BROWSER history and DOWNLOAD history.\n\nIf this setting disabled, the user is allowed to delete all BROWSING data.";
        private readonly string BrowserAddPersonEnabled = "Blocking Add new person will deny user to add new user profile to Chrome.\n\nIf this setting is disabled, user is allowed to add new user profile to Chrome.\n\n";
        #endregion

        #region Status Color Vars
        readonly Color statusEnabledBack = Color.FromArgb(49, 193, 70);
        readonly Color statusEnabledFore = Color.FromArgb(11, 98, 13);
        readonly Color statusDisabledBack = Color.FromArgb(244, 84, 80);
        readonly Color statusDisabledFore = Color.FromArgb(121, 4, 7);
        #endregion

        public formChromeControls()
        {
            InitializeComponent();
        }

        #region Check Curret Settings
        private void formChromeControls_Load(object sender, EventArgs e)
        {
            foreach (var cTBtn in pnlControls.Controls.OfType<CustToggleButton>())
            {
                if (invert.Any(cTBtn.Tag.ToString().Contains) && valeTwo.Any(cTBtn.Tag.ToString().Contains))
                {
                    trueValue = "1";
                    falseValue = "2";
                }
                if (valeTwo.Any(cTBtn.Tag.ToString().Contains))
                {
                    trueValue = "2";
                    falseValue = "1";
                }
                else if (invert.Any(cTBtn.Tag.ToString().Contains))
                {
                    trueValue = "0";
                    falseValue = "1";
                }
                else
                {
                    trueValue = "1";
                    falseValue = "0";
                }
                if (ReadWriteRegistry.ReadRegistry(BaseFolder, SubFolderPath, cTBtn.Tag.ToString()).Item1)
                {
                    if (ReadWriteRegistry.ReadRegistry(BaseFolder, SubFolderPath, cTBtn.Tag.ToString()).Item2.ToString() == trueValue)
                    {
                        cTBtn.CheckState = CheckState.Checked;

                    }
                    else if (ReadWriteRegistry.ReadRegistry(BaseFolder, SubFolderPath, cTBtn.Tag.ToString()).Item2.ToString() == falseValue)
                    {
                        cTBtn.CheckState = CheckState.Unchecked;
                    }
                    else if (ReadWriteRegistry.ReadRegistry(BaseFolder, SubFolderPath, cTBtn.Tag.ToString()).Item2 == null)
                    {
                        cTBtn.CheckState = CheckState.Unchecked;
                    }
                }
            }
        }
        #endregion

        #region Checked Change
        private void CheckedChangedToggleBtn(CustToggleButton currentcTBtn, int checkedValue, int UncheckedValue)
        {
            if (currentcTBtn != null)
            {
                if (currentcTBtn.Checked)
                {
                    if (ReadWriteRegistry.WriteRegistry(BaseFolder, SubFolderPath, currentcTBtn.Tag.ToString(), checkedValue, RegistryValueKind.DWord) == true)
                    {
                        currentcTBtn.CheckState = CheckState.Checked;
                    }
                    else
                    {
                        currentcTBtn.CheckState = CheckState.Unchecked;
                    }
                }
                else
                {
                    if (ReadWriteRegistry.WriteRegistry(BaseFolder, SubFolderPath, currentcTBtn.Tag.ToString(), UncheckedValue, RegistryValueKind.DWord) != true)
                    {
                        currentcTBtn.CheckState = CheckState.Checked;
                    }
                    else
                    {
                        currentcTBtn.CheckState = CheckState.Unchecked;
                    }
                }
            }
        }
        #endregion

        #region Toggle Buttons
        private void cTBtnIncognitoMode_CheckedChanged(object sender, EventArgs e)
        {
            CheckedChangedToggleBtn(cTBtnIncognitoMode, 0x00000001, 0x00000000);
            Dis_IncognitoModeAvailability();
        }

        private void cTBtnGuestMode_CheckedChanged(object sender, EventArgs e)
        {
            CheckedChangedToggleBtn(cTBtnGuestMode, 0x00000000, 0x00000001);
            Dis_BrowserGuestModeEnabled();
        }

        private void cTBtnBlockExternalExtensions_CheckedChanged(object sender, EventArgs e)
        {
            CheckedChangedToggleBtn(cTBtnBlockExternalExtensions, 0x00000001, 0x00000000);
            Dis_BlockExternalExtensions();
        }

        private void cTBtnPasswordLeakDetectionEnabled_CheckedChanged(object sender, EventArgs e)
        {
            CheckedChangedToggleBtn(cTBtnPasswordLeakDetectionEnabled, 0x00000001, 0x00000000);
            Dis_PasswordLeakDetectionEnabled();
        }

        private void cTBtnDeveloperToolsAvailability_CheckedChanged(object sender, EventArgs e)
        {
            CheckedChangedToggleBtn(cTBtnDeveloperToolsAvailability, 0x00000002, 0x00000000);
            Dis_DeveloperToolsAvailability();
        }

        private void cTBtnAllowDeletingBrowserHistory_CheckedChanged(object sender, EventArgs e)
        {
            CheckedChangedToggleBtn(cTBtnAllowDeletingBrowserHistory, 0x00000000, 0x00000001);
            Dis_AllowDeletingBrowserHistory();
        }

        private void cTBtnBrowserAddPersonEnabled_CheckedChanged(object sender, EventArgs e)
        {
            CheckedChangedToggleBtn(cTBtnBrowserAddPersonEnabled, 0x00000000, 0x00000001);
            Dis_BrowserAddPersonEnabled();
        }
        #endregion

        #region Lables
        private void lblDisableIncognitoMode_Click(object sender, EventArgs e)
        {
            Dis_IncognitoModeAvailability();
        }

        private void lblDisableGuestMode_Click(object sender, EventArgs e)
        {
            Dis_BrowserGuestModeEnabled();
        }

        private void lblBlockExternalExtensions_Click(object sender, EventArgs e)
        {
            Dis_BlockExternalExtensions();
        }

        private void lblPasswordLeakDetectionEnabled_Click(object sender, EventArgs e)
        {
            Dis_PasswordLeakDetectionEnabled();
        }

        private void lblDeveloperToolsAvailability_Click(object sender, EventArgs e)
        {
            Dis_DeveloperToolsAvailability();
        }

        private void lblAllowDeletingBrowserHistory_Click(object sender, EventArgs e)
        {
            Dis_AllowDeletingBrowserHistory();
        }

        private void lblBrowserAddPersonEnabled_Click(object sender, EventArgs e)
        {
            Dis_BrowserAddPersonEnabled();
        }
        #endregion

        #region Setting Status
        private void Dis_IncognitoModeAvailability()
        {
            lblPolicy.Text = lblDisableIncognitoMode.Text;
            lblDescription.Text = IncognitoModeAvailability;
            cTBtn = cTBtnIncognitoMode;
            Status();
        }

        private void Dis_BrowserGuestModeEnabled()
        {
            lblPolicy.Text = lblDisableGuestMode.Text;
            lblDescription.Text = BrowserGuestModeEnabled;
            cTBtn = cTBtnGuestMode;
            Status();
        }

        private void Dis_BlockExternalExtensions()
        {
            lblPolicy.Text = lblBlockExternalExtensions.Text;
            lblDescription.Text = BlockExternalExtensions;
            cTBtn = cTBtnBlockExternalExtensions;
            Status();
        }

        private void Dis_PasswordLeakDetectionEnabled()
        {
            lblPolicy.Text = lblPasswordLeakDetectionEnabled.Text;
            lblDescription.Text = PasswordLeakDetectionEnabled;
            cTBtn = cTBtnPasswordLeakDetectionEnabled;
            Status();
        }

        private void Dis_DeveloperToolsAvailability()
        {
            lblPolicy.Text = lblDeveloperToolsAvailability.Text;
            lblDescription.Text = DeveloperToolsAvailability;
            cTBtn = cTBtnDeveloperToolsAvailability;
            Status();
        }

        private void Dis_AllowDeletingBrowserHistory()
        {
            lblPolicy.Text = lblAllowDeletingBrowserHistory.Text;
            lblDescription.Text = AllowDeletingBrowserHistory;
            cTBtn = cTBtnAllowDeletingBrowserHistory;
            Status();
        }

        private void Dis_BrowserAddPersonEnabled()
        {
            lblPolicy.Text = lblBrowserAddPersonEnabled.Text;
            lblDescription.Text = BrowserAddPersonEnabled;
            cTBtn = cTBtnBrowserAddPersonEnabled;
            Status();
        }

        private void Status()
        {
            if (cTBtn.CheckState == CheckState.Checked)
            {
                crBtnStatus.BackColor = statusEnabledBack;
                crBtnStatus.Text = "Enabled";
                crBtnStatus.ForeColor = statusEnabledFore;
            }
            else if (cTBtn. CheckState == CheckState.Unchecked)
            {
                crBtnStatus.BackColor = statusDisabledBack;
                crBtnStatus.Text = "Disabled";
                crBtnStatus.ForeColor = statusDisabledFore;
            }
        }
        #endregion
    }
}