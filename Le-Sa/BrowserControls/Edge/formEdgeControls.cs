﻿using Le_Sa.CustomControls;
using Le_Sa.Models.Registry;
using Microsoft.Win32;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Le_Sa.BrowserControls.Edge
{
    public partial class formEdgeControls : Form
    {
        private readonly RegistryKey BaseFolder = Registry.CurrentUser;
        private readonly string SubFolderPath = @"Software\Policies\Microsoft\Edge\";
        private readonly string[] invert = { "BrowserGuestModeEnabled", "AllowDeletingBrowserHistory", "BrowserAddProfileEnabled" };
        private readonly string[] valeTwo = { "DeveloperToolsAvailability" };
        CustToggleButton cTBtn;
        private string trueValue;
        private string falseValue;

        #region Description Vars
        private readonly string InPrivateModeAvailability = "Disabling InPrivate Mode will block access to the InPrivate MODE.\n\nEnabling this will allow user to access to the InPrivate MODE.\n\nInPrivate MODE doesn't store any data about user activities.";
        private readonly string BrowserGuestModeEnabled = "Disabling Guest Mode will block access to the Guest Mode\n\nEnabling this will allow user to access to the Guest Mode\n\nGuest Mode doesn't store any data about user activities.";
        private readonly string BlockExternalExtensions = "Blocking External Extension will deny user from installing external extensions.\n\nIf this setting is disabled, user is allowed to install any external extension.";
        private readonly string PasswordLeakDetectionEnabled = "Enabling this will notify the user if any saved password has been compromised as a part of a data breach.";
        private readonly string DeveloperToolsAvailability = "Disabling DEVELOPER TOOLS will block access to the DEVELOPER TOOLS.\n\nEnabling this will allow the user to acess the DEVELOPER TOOLS.\n\nDEVELOPER TOOLS lets user to view the source code of any web app and more.";
        private readonly string AllowDeletingBrowserHistory = "Blocking History Deletion will deny user from deleting browser history and download history.\n\nIf this setting is disabled, the user is allowed to delete all BROWSING data.";
        private readonly string BrowserAddProfileEnabled = "Blocking Add new profile will deny user from adding a new user profile to Edge.\n\nIf this setting is disabled, user is allowed to add a new user profile to Edge.\n\n";
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
        private void cTBtnInPrivateMode_CheckedChanged(object sender, EventArgs e)
        {
            CheckedChangedToggleBtn(cTBtnInPrivateMode, 0x00000001, 0x00000000);
            Dis_InPrivateModeAvailability();
        }

        private void cTBtnAddProfile_CheckedChanged(object sender, EventArgs e)
        {
            CheckedChangedToggleBtn(cTBtnAddProfile, 0x00000000, 0x00000001);
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
            CheckedChangedToggleBtn(cTBtnDeveloperToolsAvailability, 0x00000002, 0x00000001);
            Dis_DeveloperToolsAvailability();
        }

        private void cTBtnAllowDeletingBrowserHistory_CheckedChanged(object sender, EventArgs e)
        {
            CheckedChangedToggleBtn(cTBtnAllowDeletingBrowserHistory, 0x00000000, 0x00000001);
            Dis_AllowDeletingBrowserHistory();
        }

        private void cTBtnBrowserAddProfileEnabled_CheckedChanged(object sender, EventArgs e)
        {
            CheckedChangedToggleBtn(cTBtnBrowserAddProfileEnabled, 0x00000000, 0x00000001);
            Dis_BrowserAddProfileEnabled();
        }
        #endregion

        #region Lables
        private void lblDisableInPrivateMode_Click(object sender, EventArgs e)
        {
            Dis_InPrivateModeAvailability();
        }

        private void lblDisableAddProfile_Click(object sender, EventArgs e)
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

        private void lblBrowserAddProfileEnabled_Click(object sender, EventArgs e)
        {
            Dis_BrowserAddProfileEnabled();
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

        private void Dis_BrowserGuestModeEnabled()
        {
            lblPolicy.Text = lblBrowserGuestModeEnabled.Text;
            lblDescription.Text = BrowserGuestModeEnabled;
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

        private void Dis_BrowserAddProfileEnabled()
        {
            lblPolicy.Text = lblBrowserAddProfileEnabled.Text;
            lblDescription.Text = BrowserAddProfileEnabled;
            cTBtn = cTBtnBrowserAddProfileEnabled;
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
