using Le_Sa.CustomControls;
using Le_Sa.Models.Registry;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Le_Sa.BrowserControls
{
    public partial class formEdgeControls : Form
    {
        private readonly RegistryKey BaseFolder = Registry.CurrentUser;
        private readonly string SubFolderPath = @"Software\Policies\Microsoft\Edge\";
        private readonly string[] invert = { "BrowserAddProfileEnabled", "AllowDeletingBrowserHistory", "BrowserAddPersonEnabled" };
        private readonly string[] valeTwo = { "DeveloperToolsAvailability" };
        CustToggleButton cTBtn;
        private string trueValue;
        private string falseValue;

        #region Description Vars
        private readonly string InPrivateModeAvailability = "Disabling InPrivate Mode will block access to the InPrivate MODE.\r\n\r\nEnabling InPrivate Mode will allow user to access to the InPrivate MODE.\r\n\r\nInPrivate MODE doesn't store any data about user activities.";
        private readonly string BrowserAddProfileEnabled = "Disabling Add Profile will block access to the Add Profile.\r\n\r\nEnabling Add Profile will allow user to access to the Add Profile\r\n\r\nAdd Profile doesn't store any data about user activities.";
        private readonly string BlockExternalExtensions = "Blocking External Extension will denies user from installing external extensions.\r\n\r\nIf this setting disabled, user is allowed to install any external extension.";
        private readonly string PasswordLeakDetectionEnabled = "Enabling Password Leak Detection will notify the user if any saved password has been compromised as part of a data breach.";
        private readonly string DeveloperToolsAvailability = "Disabling DEVELOPER TOOLS will block access to the DEVELOPER TOOLS.\r\n\r\n Enabling DEVELOPER TOOLS will allow user to acess to the DEVELOPER TOOLS.\r\n\r\nDEVELOPER TOOLS let user to see the source code of any web app and more.";
        private readonly string AllowDeletingBrowserHistory = "Blocking History Deletion will denies user from delete BROWSING history and DOWNLOAD history.\r\n\r\nIf this setting disabled, user is allowed to delete all BROWSING data.";
        private readonly string BrowserAddPersonEnabled = "Blocking Add new person will denies user to add new user profile to Edge.\r\n\r\nIf this setting is disabled, user is allowed to add new user profile to Edge.\r\n\r\n";
        #endregion

        #region Status Color Vars
        readonly Color statusEnabledBack = Color.FromArgb(49, 193, 70);
        readonly Color statusEnabledFore = Color.FromArgb(11, 98, 13);
        readonly Color statusDisabledBack = Color.FromArgb(244, 84, 80);
        readonly Color statusDisabledFore = Color.FromArgb(121, 4, 7);
        #endregion

        public formEdgeControls()
        {
            InitializeComponent();
        }

        #region Check Curret Settings
        private void formEdgeControls_Load(object sender, EventArgs e)
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
                    if (ReadWriteRegistry.ReadRegistry(BaseFolder, SubFolderPath, cTBtn.Tag.ToString()).Item2 == trueValue)
                    {
                        cTBtn.CheckState = CheckState.Checked;

                    }
                    else if (ReadWriteRegistry.ReadRegistry(BaseFolder, SubFolderPath, cTBtn.Tag.ToString()).Item2 == falseValue)
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
        private void cTBtnInPrivateMode_CheckedChanged(object sender, EventArgs e)
        {
            CheckedChangedToggleBtn(cTBtnInPrivateMode, 0x00000001, 0x00000000);
            Dis_InPrivateModeAvailability();
        }

        private void cTBtnAddProfile_CheckedChanged(object sender, EventArgs e)
        {
            CheckedChangedToggleBtn(cTBtnAddProfile, 0x00000000, 0x00000001);
            Dis_BrowserAddProfileEnabled();
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
            CheckedChangedToggleBtn(cTBtnDeveloperToolsAvailability, 0x00000002, 0x00000001);
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
        private void lblDisableInPrivateMode_Click(object sender, EventArgs e)
        {
            Dis_InPrivateModeAvailability();
        }

        private void lblDisableAddProfile_Click(object sender, EventArgs e)
        {
            Dis_BrowserAddProfileEnabled();
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
        private void Dis_InPrivateModeAvailability()
        {
            lblPolicy.Text = lblDisableInPrivateMode.Text;
            lblDescription.Text = InPrivateModeAvailability;
            cTBtn = cTBtnInPrivateMode;
            Status();
        }

        private void Dis_BrowserAddProfileEnabled()
        {
            lblPolicy.Text = lblDisableAddProfile.Text;
            lblDescription.Text = BrowserAddProfileEnabled;
            cTBtn = cTBtnAddProfile;
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
            else if (cTBtn.CheckState == CheckState.Unchecked)
            {
                crBtnStatus.BackColor = statusDisabledBack;
                crBtnStatus.Text = "Disabled";
                crBtnStatus.ForeColor = statusDisabledFore;
            }
        }
        #endregion
    }
}
