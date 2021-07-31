using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Le_Sa.Models.Registry
{
    class ReadWriteRegistry
    {
        public static bool WriteRegistry(RegistryKey BaseFolder, string SubFolder, string KeyName, object Value, RegistryValueKind ValueKind)
        {
            try
            {
                RegistryKey RegistryKey = BaseFolder.CreateSubKey(SubFolder);
                RegistryKey.SetValue(KeyName, Value, ValueKind);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static (bool, string) ReadRegistry(RegistryKey BaseFolder, string SubFolder, string keyName)
        {
            try
            {
                RegistryKey subKey = BaseFolder.OpenSubKey(SubFolder);
                return (true, subKey.GetValue(keyName).ToString());
            }
            catch
            {
                return (false, null);
            }
        }

        public static (bool, string[]) KeyNames(RegistryKey BaseFolder, string SubFolder)
        {
            try
            {
                RegistryKey keyName = BaseFolder.OpenSubKey(SubFolder);
                if (keyName != null)
                {
                    return (true, keyName.GetSubKeyNames());
                }
                else
                {
                    return (false, null);
                }
            }
            catch
            {
                return (false, null);
            }
        }
    }
}
