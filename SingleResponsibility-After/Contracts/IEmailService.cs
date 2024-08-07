namespace SingleResponsibility_After.Contracts
{
    public interface IEmailService
    {
        void SendEmail(string to, string subject, string body);
    }
}
