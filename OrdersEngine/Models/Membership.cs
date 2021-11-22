using OrdersEngine.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace OrdersEngine.Models
{
    public class Membership : IMembership
    {
        public Guid Id { get; set; }
        public PaymentResultEnum Goal { get; set; }
        public string Content { get; set; }

        public Membership(PaymentResultEnum goal)
        {
            Id = Guid.NewGuid();
            Goal = goal;
        }

        public IPaymentResult Execute(string email)
        {
            switch (Goal)
            {
                case PaymentResultEnum.Activate:
                    break;
                case PaymentResultEnum.Upgrade:
                    break;
            }

            SendEmail(email);

            return this;
        }

        public void SendEmail(string email)
        {
            try
            {

                var mySmtpClient = new SmtpClient("my.smtp.exampleserver.net");

                // set smtp-client with basicAuthentication
                mySmtpClient.UseDefaultCredentials = false;
                System.Net.NetworkCredential basicAuthenticationInfo = new
                   System.Net.NetworkCredential("username", "password");
                mySmtpClient.Credentials = basicAuthenticationInfo;

                // add from,to mailaddresses
                MailAddress from = new MailAddress("test@example.com", "TestFromName");
                MailAddress to = new MailAddress(email, "TestToName");
                MailMessage myMail = new MailMessage(from, to);

                // set subject and encoding
                myMail.Subject = "Membership";
                myMail.SubjectEncoding = Encoding.UTF8;

                // set body-message and encoding
                myMail.Body = $"<b>Your membership was {Goal}ed </b>.";
                myMail.BodyEncoding = Encoding.UTF8;
                // text or html
                myMail.IsBodyHtml = true;

                mySmtpClient.Send(myMail);
            }
            catch (Exception)
            {
            }
        }
    }
}
