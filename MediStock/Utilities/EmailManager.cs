using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace MediStockWeb.Utilities
{
    public class EmailManager
    {
        public void SendEmail(string From, string Subject, string Body, string To, string Id, string Password, string SMTPPort, string Host)
        {
            using (MailMessage mail = new MailMessage())
            {
                mail.To.Add(To);
                mail.From = new MailAddress(From);
                mail.Subject = Subject;
                mail.Body = Body;

                using (SmtpClient smtp = new SmtpClient())
                {
                    smtp.Host = Host;
                    smtp.Port = Convert.ToInt16(SMTPPort);
                    smtp.Credentials = new NetworkCredential(Id , Password);
                    smtp.EnableSsl = true;

                    // use this to resolve the error of authentication : https://myaccount.google.com/lesssecureapps?pli=1
                    smtp.Send(mail);
                }
            }
        }

    }
}
