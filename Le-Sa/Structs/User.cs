using System;
using System.Windows.Forms;

namespace Le_Sa
{
    class User
    {
        public string username { get; set; }
        public string password { get; set; }
        public string email { get; set; }
        public string phone_no { get; set; }
        public bool status { get; set; }
        public string duration { get; set; }
        public string start { get; set; }
        public int login_count { get; set; }

        private static string error = "Username does not exist!";

        public static void ShowError()
        {
            MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static bool IsEqual(User user1, User user2)
        {
            if (user1 == null || user2 == null)
            {
                return false;
            }

            if (user1.username != user2.username)
            {
                error = "Username does not exist!";
                return false;
            }
            else if (user1.password != user2.password)
            {
                error = "Username and password does not match!";
                return false;
            }
            else if (user1.status == false && user1.duration == "temp")
            {
                error = "Your accout (" + user2.username + ") is TEMPORARILY BANNED" + Environment.NewLine + "If you believe this was a mistake, you can submit an appeal to contact.lesafe.soft@gmail.com";
                return false;
            }
            else if (user1.status == false && user1.duration == "perm")
            {
                error = "Your accout (" + user2.username + ") is PERMANENTLY BANNED" + Environment.NewLine + "If you believe this was a mistake, you can submit an appeal to contact.lesafe.soft@gmail.com";
                return false;
            }
            else return true;
        }

        public static bool IsTaken(User user1, User user2)
        {
            if (user1 == null || user2 == null)
            {
                return false;
            }

            if (user1.username == user2.username)
            {
                error = "That username is taken. Try another.";
                return true;
            }
            else
            {
                return true;
            }
        }
        /*error = "An account with this email address already exists." + Environment.NewLine + "Please try another email" + Environment.NewLine + "If you didn't create a account using this email address please submit an appeal to contact.lesafe.soft@gmail.com";*/

        public static string userEmail(User user1 ,User user2)
        {
            if (user1 == null || user2 == null)
            {
                return null;
            }

            if (user1.username != user2.username)
            {
                error = "Username does not exist!";
                return null;
            }
            else
            {
                return user1.email;
            }

        }
    }
}

