namespace LeadsApi.Domain.Interfaces
{
    public interface IEmailService
    {
        void SendMail(string title, string subject, string email);
    }
}
