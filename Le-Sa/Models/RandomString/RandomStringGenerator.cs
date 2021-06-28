using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Le_Sa.Models.RandomString
{
    class RandomStringGenerator
    {
        public static string GenerateRandomString(int length, bool upper, bool lower, bool num, bool special)
        {
            const string upperAlp = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            const string lowerAlp = "abcdefghijklmnopqrstuvwxyz";
            const string numeral = "0123456789";
            const string punctuation = @"~!@#$%^&*():;[]{}<>,.?/\|";

            string chars = null;

            if (upper == true) { chars += upperAlp; }
            if (lower == true) { chars += lowerAlp; }
            if (num == true) { chars += numeral; }
            if (special == true) { chars += punctuation; }

            var random = new Random();
            var randomString = new string(Enumerable.Repeat(chars, length).Select(s => s[random.Next(s.Length)]).ToArray());
            return randomString;
        }
    }
}
