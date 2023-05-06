using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SkyVoteTime.Server.Service;
using System;

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
        public async Task<Competition> AddPerson([FromBody] Competition competition)
        {
            return await _competitionService.AddPerson(competition);
        }
    }
}
