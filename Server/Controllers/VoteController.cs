using Microsoft.AspNetCore.Mvc;
using SkyVoteTime.Server.Service;

namespace SkyVoteTime.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VoteController : ControllerBase
    {
        private readonly IVoteService _voteService;
        public VoteController(IVoteService voteService)
        {
            _voteService = voteService;
        }

        [HttpDelete("{id}")]
        public async Task<bool> DeleteVote(int id)
        {
            await _voteService.DeleteVote(id);
            return true;
        }
    }
}
