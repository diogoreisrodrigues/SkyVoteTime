using Microsoft.AspNetCore.Mvc;
using SkyVoteTime.Server.Repository;
using SkyVoteTime.Server.Models;


namespace SkyVoteTime.Server.Service
{
    public class VoteService : IVoteService
    {
        private readonly IRepository<Vote> _vote;
        public VoteService(IRepository<Vote> vote)
        {
            _vote = vote;
        }
        public async Task<bool> DeleteVote(int id)
        {
            await _vote.DeleteAsyncVote(id);
            return true;
        }
    }
}
