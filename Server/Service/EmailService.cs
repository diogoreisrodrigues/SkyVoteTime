using MimeKit.Text;
using MimeKit;
using SkyVoteTime.Server.Models;
using System.Net.Mail;
using System.Net;

namespace SkyVoteTime.Server.Service
{
    public class EmailService : IEmailService
    {
        private readonly IConfiguration _config;
        public EmailService(IConfiguration config)
        {
            _config = config;
        }
        public void SendEmail(Email request)
        {
            var email = new MimeMessage();
            email.Body = new TextPart(TextFormat.Html) { Text = request.Body };

            var mailMessage = new System.Net.Mail.MailMessage();
            mailMessage.From = new MailAddress(_config.GetSection("EmailUsername").Value);
            mailMessage.To.Add(new MailAddress(request.To));
            mailMessage.Subject = request.Subject;
            mailMessage.Body = email.Body.ToString();

            using var smtp = new System.Net.Mail.SmtpClient(_config.GetSection("EmailHost").Value, 587)
            {
                EnableSsl = true,
                Credentials = new NetworkCredential(_config.GetSection("EmailUsername").Value, _config.GetSection("EmailPassword").Value)
            };

            smtp.Send(mailMessage);
        }
    }
}
