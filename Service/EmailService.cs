 /* using MailKit.Net.Smtp;
using MimeKit;

namespace PearlPineproject.Service
{
    public class EmailService
    {
            public void SendOtpEmail(string toEmail, string otp)
            {
                var email = new MimeMessage();

                email.From.Add(new MailboxAddress("Pearl & Pine", "yourgmail@gmail.com"));
                email.To.Add(new MailboxAddress("", toEmail));

                email.Subject = "OTP Verification";

                email.Body = new TextPart("plain")
                {
                    Text = $"Your OTP is: {otp}"
                };

                using (var smtp = new SmtpClient())
                {
                    smtp.Connect("smtp.gmail.com", 587, false);

                    smtp.Authenticate("severussnapedubey@gmail.com", "xnzv gfjp yypj gwoy");

                    smtp.Send(email);
                    smtp.Disconnect(true);
                }
            }
        }
    }

*/
