using System;
using System.Windows.Forms;
using System.IO;

namespace Le_Sa.Models.Copy
{
    class Copy
    {
        private static string source;

        public static void CopyFile(string sourcePath, string sourceFile, string destinationPath, string destFile )
        {
            if (sourcePath != null) {
                source = Path.Combine(sourcePath, sourceFile);
            }
            else
            {
                source = sourceFile;
            }
             string dest = Path.Combine(destinationPath, destFile);
            Directory.CreateDirectory(destinationPath);
            try
            {
                File.Copy(source, dest, true);
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
