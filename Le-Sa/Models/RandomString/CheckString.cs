using System;
using System.Collections.Generic;
using System.Drawing;
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

            if (testString.Length <= 4)
            {
                score -= 3;
            }
            if (testString.Length >= minLength)
            {
                score+= 2;
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

        public static (string, Color) StrengthNaming(int score)
        {
            (string, Color) level;
            if (score <= 1)
            {
                level = ("None", Color.FromArgb(255, 133, 133));
            }
            else if (score == 2)
            {
                level = ("Weak", Color.FromArgb(255,153,153));
            }
            else if (score == 3)
            {
                level = ("Fair", Color.FromArgb(255,204,153));
            }
            else if (score == 4)
            {
                level = ("Good",Color.FromArgb(255,255,153));
            }
            else if (score == 5)
            {
                level = ("Strong", Color.FromArgb(169, 201, 146));
            }
            else
            {
                level = ("Excellent", Color.FromArgb(155,255,65));
            }
            return level;
        }
    }
}
