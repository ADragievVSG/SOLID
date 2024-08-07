using System.Net.Mail;

namespace SingleResponsibility_Before.Classes
{
    public class UserService
    {
        public void RegisterUser(string email)
        {
            if (string.IsNullOrEmpty(email))
            {
                throw new Exception("Email cannot be empty!");
            }

            // Code to create the user
            Console.WriteLine($"User {email} registered successfully!");

            SmtpClient client = new SmtpClient();
            client.Send(new MailMessage("no-reply@mysite.com", email) { Subject = "Welcome!", Body = "Thank you for registering!" });
        }

        public void DeleteUser(string email)
        {
            // Code to delete the user
            Console.WriteLine($"User {email} deleted successfully!");

            SmtpClient client = new SmtpClient();
            client.Send(new MailMessage("no-reply@mysite.com", email) { Subject = "User deleted!", Body = "Your registration was deleted!" });
        }
    }
}
