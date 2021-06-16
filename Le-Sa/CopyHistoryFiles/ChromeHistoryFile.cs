using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Le_Sa.CopyHistoryFiles
{
    class ChromeHistoryFiles : CopyHistoryFiles
    {
        public ChromeHistoryFiles()
        {
            sourcePath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\Google\Chrome\User Data\Default\History";
            destinationPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"C:\Users\Sathsara\Desktop\hist";
        }
    }
}
