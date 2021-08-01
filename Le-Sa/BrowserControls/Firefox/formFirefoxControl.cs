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
    public partial class formFirefoxControl : Form
    {
        private readonly RegistryKey BaseFolder = Registry.CurrentUser;
        private string SubFolderPath = @"Software\Policies\Mozilla\Firefox\";
        private readonly string[] invert = { "InstallAddonsPermission" };
        private readonly String[] keyNeeded = { "InstallAddonsPermission" };
        CustToggleButton cTBtn;
        private string keyName;

        #region Description Vars
        private readonly string DisablePrivateBrowsing = "Disabling Incognito Mode will block access to the INCOGNITO MODE.\r\n\r\nEnabling Incognito Mode will allow user to access to the INCOGNITO MODE.\r\n\r\nINCOGNITO MODE doesn't store any data about user activities.";

        private readonly string InstallAddonsPermission = "Blocking Extension Installation will denies user from installing extensions.\r\n\r\nIf this setting disabled, user is allowed to install any extension.";
        private readonly string DisableDeveloperTools = "Disabling DEVELOPER TOOLS will block access to the DEVELOPER TOOLS.\r\n\r\n Enabling DEVELOPER TOOLS will allow user to acess to the DEVELOPER TOOLS.\r\n\r\nDEVELOPER TOOLS let user to see the source code of any web app and more.";
        #endregion

        #region Status Color Vars
        readonly Color statusEnabledBack = Color.FromArgb(49, 193, 70);
        readonly Color statusEnabledFore = Color.FromArgb(11, 98, 13);
        readonly Color statusDisabledBack = Color.FromArgb(244, 84, 80);
        readonly Color statusDisabledFore = Color.FromArgb(121, 4, 7);
        #endregion

        public formFirefoxControl()
        {
            InitializeComponent();
        }

        #region Check Curret Settings
        private void formFirefoxControl_Load(object sender, EventArgs e)
        {
            foreach (var cTBtn in pnlControls.Controls.OfType<CustToggleButton>())
            {
                if (keyNeeded.Any(cTBtn.Tag.ToString().Contains))
                {
                    SubFolderPath = @"Software\Policies\Mozilla\Firefox\" + cTBtn.Tag.ToString();
                    keyName = "Default";
                }
                else
                {
                    SubFolderPath = @"Software\Policies\Mozilla\Firefox\";
                    keyName = cTBtn.Tag.ToString();
                }
                if (ReadWriteRegistry.ReadRegistry(BaseFolder, SubFolderPath, keyName).Item1)
                {
                    if (ReadWriteRegistry.ReadRegistry(BaseFolder, SubFolderPath, keyName).Item2 == "1")
                    {
                        if (invert.Any(cTBtn.Tag.ToString().Contains))
                        {
                            cTBtn.CheckState = CheckState.Unchecked;
                        }
                        else
                        {
                            cTBtn.CheckState = CheckState.Checked;
                        }
                    }
                    else if (ReadWriteRegistry.ReadRegistry(BaseFolder, SubFolderPath, keyName).Item2 == "0")
                    {
                        if (invert.Any(cTBtn.Tag.ToString().Contains))
                        {
                            cTBtn.CheckState = CheckState.Checked;
                        }
                        else
                        {
                            cTBtn.CheckState = CheckState.Unchecked;
                        }
                    }
                    else if (ReadWriteRegistry.ReadRegistry(BaseFolder, SubFolderPath, keyName).Item2 == null)
                    {
                        cTBtn.CheckState = CheckState.Unchecked;
                    }
                }
            }
        }
        #endregion

        #region Checked Changed
        private void CheckedChangedToggleBtn(CustToggleButton currentcTBtn, int checkedValue, int uncheckedValue)
        {
            if (currentcTBtn != null)
            {
                if (keyNeeded.Any(currentcTBtn.Tag.ToString().Contains))
                {
                    SubFolderPath = @"Software\Policies\Mozilla\Firefox\" + currentcTBtn.Tag.ToString();
                    keyName = "Default";
                }
                else
                {
                    SubFolderPath = @"Software\Policies\Mozilla\Firefox\";
                    keyName = currentcTBtn.Tag.ToString();
                }
                if (currentcTBtn.Checked)
                {
                    if (ReadWriteRegistry.WriteRegistry(BaseFolder, SubFolderPath , keyName , checkedValue, RegistryValueKind.DWord) == true)
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
                    if (ReadWriteRegistry.WriteRegistry(BaseFolder, SubFolderPath, keyName , uncheckedValue, RegistryValueKind.DWord) != true)
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
        private void cTBtnDisablePrivateBrowsing_CheckedChanged(object sender, EventArgs e)
        {
            CheckedChangedToggleBtn(cTBtnDisablePrivateBrowsing, 0x00000001, 0x00000000);
            Dis_DisablePrivateBrowsing();
        }

        private void cTBtnInstallAddonsPermission_CheckedChanged(object sender, EventArgs e)
        {
            CheckedChangedToggleBtn(cTBtnInstallAddonsPermission, 0x00000000, 0x00000001);
            Dis_InstallAddonsPermission();
        }

        private void cTBtnDisableDeveloperTools_CheckedChanged(object sender, EventArgs e)
        {
            CheckedChangedToggleBtn(cTBtnDisableDeveloperTools , 0x00000001, 0x00000000);
            Dis_DisableDeveloperTools();
        }
        #endregion

        #region Lables
        private void lblDisableDeveloperTools_Click(object sender, EventArgs e)
        {
            Dis_DisableDeveloperTools();
        }

        private void lblDisablePrivateBrowsing_Click(object sender, EventArgs e)
        {
            Dis_DisablePrivateBrowsing();
        }

        private void lblInstallAddonsPermission_Click(object sender, EventArgs e)
        {
            Dis_InstallAddonsPermission();
        }
        #endregion

        #region Setting Status
        private void Dis_InstallAddonsPermission()
        {
            lblPolicy.Text = lblInstallAddonsPermission.Text;
            lblDescription.Text = InstallAddonsPermission;
            cTBtn = cTBtnInstallAddonsPermission;
            Status();
        }

        private void Dis_DisablePrivateBrowsing()
        {
            lblPolicy.Text = lblDisablePrivateBrowsing.Text;
            lblDescription.Text = DisablePrivateBrowsing;
            cTBtn = cTBtnDisablePrivateBrowsing;
            Status();
        }

        private void Dis_DisableDeveloperTools()
        {
            lblPolicy.Text = lblDisableDeveloperTools.Text;
            lblDescription.Text = DisableDeveloperTools;
            cTBtn = cTBtnDisableDeveloperTools;
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
