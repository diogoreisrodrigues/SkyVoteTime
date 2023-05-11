using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SkyVoteTime.Server.Models;
using SkyVoteTime.Server.Service;

namespace SkyVoteTime.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompetitionController : ControllerBase
    {
        private readonly ICompetitionService _competitionService;
        public CompetitionController(ICompetitionService competitionService)
        {
            _competitionService = competitionService;
        }
        [HttpGet]
        public async Task<List<Competition>> GetAll()
        {
            return await _competitionService.GetAllCompetitions();
        }
        [HttpGet("{id}")]
        public async Task<Competition> Get(int id)
        {
            return await _competitionService.GetCompetition(id);
        }
        [HttpPost]
        public async Task<Competition> AddCompetition([FromBody] Competition competition)
        {
            Console.WriteLine("Competition: " + competition.Movies.ToString());
            return await _competitionService.AddCompetition(competition);
        }
        [HttpDelete("{id}")]
        public async Task<bool> DeleteCompetition(int id)
        {
            await _competitionService.DeleteCompetition(id);
            return true;
        }
        [HttpPut("{id}")]
        public async Task<bool> UpdateCompetition(int id, [FromBody] Competition Object)
        {
            await _competitionService.UpdateCompetition(id, Object);
            return true;
        }
    }
}
