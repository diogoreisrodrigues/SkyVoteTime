namespace SkyVoteTime.Server.Service
{
    public interface IVoteService
    {
        public Task<bool> DeleteVote(int id);

    }
}