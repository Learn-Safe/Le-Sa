using System;
using System.Security.Cryptography;
using System.Text;


namespace Le_Sa
{
    class Encryptor
    {
        public static string IV = "k2K)86+fa;~g./D*";
        public static string Key = "saty123456789123gdtensbdtemvdt2w";


        public static string Encrypt(string decrypted)
        {
            byte[] textBytes = ASCIIEncoding.ASCII.GetBytes(decrypted);
            AesCryptoServiceProvider endec = new AesCryptoServiceProvider
            {
                BlockSize = 128,
                KeySize = 256,
                IV = ASCIIEncoding.ASCII.GetBytes(IV),
                Key = ASCIIEncoding.ASCII.GetBytes(Key),
                Padding = PaddingMode.PKCS7,
                Mode = CipherMode.CBC
            };
            ICryptoTransform icrypt = endec.CreateEncryptor(endec.Key, endec.IV);
            byte[] enc = icrypt.TransformFinalBlock(textBytes, 0, textBytes.Length);
            icrypt.Dispose();
            return Convert.ToBase64String(enc);
        }

        public static string Decrypted(string encrypted)
        {
            byte[] textbytes = Convert.FromBase64String(encrypted);
            AesCryptoServiceProvider endec = new AesCryptoServiceProvider
            {
                BlockSize = 128,
                KeySize = 256,
                IV = ASCIIEncoding.ASCII.GetBytes(IV),
                Key = ASCIIEncoding.ASCII.GetBytes(Key),
                Padding = PaddingMode.PKCS7,
                Mode = CipherMode.CBC
            };
            ICryptoTransform icrypt = endec.CreateDecryptor(endec.Key, endec.IV);
            byte[] enc = icrypt.TransformFinalBlock(textbytes, 0, textbytes.Length);
            icrypt.Dispose();
            return System.Text.ASCIIEncoding.ASCII.GetString(enc);
        }
    }
}