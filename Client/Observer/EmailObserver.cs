using SkyVoteTime.Client.Pages;
using SkyVoteTime.Shared.Models;
using System.Net.Http.Json;
using static System.Net.WebRequestMethods;


namespace SkyVoteTime.Client.Observer
{
    public class EmailObserver : IEmailObserver
    {
        private Email emailObj = new Email
        {
            To = "artursf10001@gmail.com",
            Subject = "Closed competition",
            Body = "<p>Hello!</p><p>We are sending this e-mail because the following competition has been closed: Test.</p><p>Check our website to see the results.</p><p>Best regards,<br>SkyVoteTime</p>",
        };
        public HttpClient Http = new HttpClient();

        

        public async void SendEmails(List<string> EmailObservers, Competition competition)
        {
            foreach (var email in EmailObservers)
            {
                Console.WriteLine(email);
                emailObj.To = email;
                emailObj.Body = "<p>Hello!</p><p>We are sending this e-mail because the following competition has been closed: " + competition.Name + ".</p><p>Check our website to see the results.</p><p>Best regards,<br>SkyVoteTime</p>";
                var sender = await Http.PostAsJsonAsync("http://localhost:7164/api/Email", emailObj);
            }
        }
    }
}
