using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace Le_Sa.Models.Serialization
{
    class BinarySerialization
    {
        public static void Serialize(object data, string filePath)
        {
            try
            {
                BinaryFormatter bf = new BinaryFormatter();
                if (File.Exists(filePath))
                {
                    FileStream fileStream = new FileStream(filePath, FileMode.Append);
                    bf.Serialize(fileStream, data);
                    fileStream.Close();
                }
                else
                {
                    FileStream fileStream = new FileStream(filePath, FileMode.CreateNew);
                    bf.Serialize(fileStream, data);
                    fileStream.Close();
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static object Deserialize(string filePath)
        {
            object obj = null;
            FileStream fileStream;
            try
            {
                BinaryFormatter bf = new BinaryFormatter();
                if (File.Exists(filePath))
                {
                    fileStream = File.OpenRead(filePath);
                    bf.Deserialize(fileStream);
                    fileStream.Close();
                }
                return obj;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return obj;
            }
        }
    }
}