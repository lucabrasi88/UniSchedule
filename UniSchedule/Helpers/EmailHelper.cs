using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace UniSchedule.Helpers
{
    public sealed class EmailHelper
    {

        static readonly EmailHelper _instance = new EmailHelper();

        public static EmailHelper Instance
        {
            get
            {
                return _instance;
            }
        }

        EmailHelper()
        {
            // Initialize.
        }

        private string mailSender = "schedulemessenger@gmail.com";
        private string senderPass = "admin123WMI";


        public void SendMailAfterRegistration(string address, string userName, string password)
        {
            MailMessage mailMessage = new MailMessage();
            mailMessage.To.Add(address);
            mailMessage.From = new MailAddress(mailSender);
            mailMessage.Subject = "Aktywacja konta";
            mailMessage.Body = "Witaj " + userName + ". " + "Twoje hasło do systemu to: " + password;
            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
            smtpClient.Credentials = new NetworkCredential(mailSender, senderPass);

            smtpClient.EnableSsl = true;
            smtpClient.Port = 587;

            smtpClient.Send(mailMessage);


        }

    }
}
