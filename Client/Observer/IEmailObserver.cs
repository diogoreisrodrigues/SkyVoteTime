using SkyVoteTime.Shared.Models;

namespace SkyVoteTime.Client.Observer
{
    public interface IEmailObserver
    {
        
        void SendEmails(List<string> EmailObservers, Competition competition);

    }
}
