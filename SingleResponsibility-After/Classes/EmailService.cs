using SingleResponsibility_After.Contracts;
using System.Net.Mail;

namespace SingleResponsibility_After.Classes
{
    public class EmailService : IEmailService
    {
        public void SendEmail(string to, string subject, string body)
        {
            SmtpClient client = new SmtpClient();
            client.Send(new MailMessage("no-reply@mysite.com", to) { Subject = subject, Body = body });
        }
    }
}
