using SkyVoteTime.Server.Models;

namespace SkyVoteTime.Server.Service
{
    public interface IEmailService
    {
        void SendEmail(Email request);
    }
}
