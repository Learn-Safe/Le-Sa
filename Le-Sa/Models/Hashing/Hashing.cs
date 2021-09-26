using System.Security.Cryptography;
using System.Text;

namespace Le_Sa.Models.Hashing
{
    public static class Hashing
    {
        public static string ToSHA512(string input)
        {
            var sha256 = SHA512.Create();
            byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(input));

            var output = new StringBuilder();
            for (int i = 0; i < bytes.Length; i++)
            {
                output.Append(bytes[i].ToString("X2"));
            }
            return output.ToString();
        }
    }
}
