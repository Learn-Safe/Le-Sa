using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Le_Sa.Models.RandomString
{
    class CheckString
    {
        public static int StrengthScore(string testString, bool upper, bool lower, bool num, bool special)
        {
            int minLength = 8;
            int score = 0;
            const string upperAlp = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            const string lowerAlp = "abcdefghijklmnopqrstuvwxyz";
            const string numeral = "0123456789";
            const string punctuation = @"~!@#$%^&*():;[]{}<>,.?/\|";
            if (testString.Length >= minLength)
            {
                score++;
            }

            if (testString.Length >= 15)
            {
                score++;
            }

            if (upper == true && Contains(testString, upperAlp))
            {
                score++;
            }

            if (lower == true && Contains(testString, lowerAlp))
            {
                score++;
            }

            if (num == true && Contains(testString, numeral))
            {
                score++;
            }

            if (special == true && Contains(testString, punctuation))
            {
                score++;
            }
            return score;
        }

        public static bool Contains(string target, string list)
        {
            return target.IndexOfAny(list.ToCharArray()) != -1;
        }

        public static string StrengthNaming(int score)
        {
            string level;
            if (score == 0 || score == 1)
            {
                level = "None";
            }
            else if (score == 2)
            {
                level = "Weak";
            }
            else if (score == 3)
            {
                level = "Fair";
            }
            else if (score == 4)
            {
                level = "Good";
            }
            else if (score == 5)
            {
                level = "Strong";
            }
            else
            {
                level = "Excellent";
            }
            return level;
        }
    }
}
