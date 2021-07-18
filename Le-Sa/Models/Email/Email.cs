using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Le_Sa.Models.Email
{
    class Email
    {
        public static bool SendMsg(string to ,string from, string message)
        {
            try
            {
                using (SmtpClient client = new SmtpClient("smtp.gmail.com", 587))
                {
                    client.EnableSsl = true;
                    client.DeliveryMethod = SmtpDeliveryMethod.Network;
                    client.UseDefaultCredentials = false;
                    client.Credentials = new NetworkCredential("lesafe.soft@gmail.com", "znvxqikozbjqhere");
                    MailMessage msgObj = new MailMessage();
                    msgObj.To.Add(to);
                    msgObj.From = new MailAddress("lesafe.soft@gmail.com", from);
                    msgObj.Subject = "OTP";
                    msgObj.Body = message;
                    client.Send(msgObj);
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
