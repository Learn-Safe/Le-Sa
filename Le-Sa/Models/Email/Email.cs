using System;
using System.Net;
using System.Net.Mail;
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
                    client.Credentials = new NetworkCredential("contact.lesafe.soft@gmail.com", "czyoduvstcrfriss");
                    MailMessage msgObj = new MailMessage();
                    msgObj.To.Add(to);
                    msgObj.From = new MailAddress("contact.lesafe.soft@gmail.com", from);
                    msgObj.Subject = "OTP";
                    msgObj.Body = message;
                    client.Send(msgObj);
                }
                return true;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message + Environment.NewLine + "Please try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
