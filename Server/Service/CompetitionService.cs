using SkyVoteTime.Server.Repository;
using System;

namespace SkyVoteTime.Server.Service
{
    public class CompetitionService : ICompetitionService
    {
        private readonly IRepository<Competition> _competition;
        public CompetitionService(IRepository<Competition> competition)
        {
            _competition = competition;
        }

        public async Task<Competition> AddPerson(Competition competition)
        {
            return await _competition.CreateAsync(competition);
        }

        public async Task<List<Competition>> GetAllCompetitions()
        {
            return await _competition.GetAllAsync();
        }
        public async Task<Competition> GetCompetition(int id)
        {
            return await _competition.GetByIdAsync(id);
        }
    }
}
