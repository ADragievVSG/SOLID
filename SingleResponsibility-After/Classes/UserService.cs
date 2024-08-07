using SingleResponsibility_After.Contracts;

namespace SingleResponsibility_After.Classes
{
    public class UserService
    {
        private readonly IEmailService _emailService;

        public UserService(IEmailService emailService)
        {
            _emailService = emailService;
        }

        public void RegisterUser(string email)
        {
            if (string.IsNullOrEmpty(email))
            {
                throw new Exception("Email cannot be empty!");
            }

            // Code to create the user
            Console.WriteLine($"User {email} registered successfully!");

            _emailService.SendEmail(email, "Welcome!", "Thank you for registering!");
        }

        public void DeleteUser(string email)
        {
            // Code to delete the user
            Console.WriteLine($"User {email} deleted successfully!");

            _emailService.SendEmail(email, "User deleted!", "Your registration was deleted!");
        }
    }
}
