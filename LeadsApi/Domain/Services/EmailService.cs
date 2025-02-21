using LeadsApi.Domain.Interfaces;

namespace LeadsApi.Domain.Services
{
    public class EmailService : IEmailService
    {
        private readonly string _emailDirectory = "Emails";

        public EmailService()
        {
            if (!Directory.Exists(_emailDirectory))
            {
                Directory.CreateDirectory(_emailDirectory);
            }
        }

        public void SendMail(string title, string subject, string email)
        {
            string fileName = $"{_emailDirectory}/Email_{DateTime.Now:yyyyMMdd_HHmmss}.txt";

            string content = $"Title: {title}\nSubject: {subject}\nEmail: {email}";

            File.WriteAllText(fileName, content);
        }
    }
}
