using SkyVoteTime.Server.Models;
using SkyVoteTime.Server.Repository;

namespace SkyVoteTime.Server.Service
{
    public class CompetitionService: ICompetitionService
    {
        private readonly IRepository<Competition> _competition;
        public CompetitionService(IRepository<Competition> competition)
        {
            _competition = competition;
        }
        public async Task<Competition> AddCompetition(Competition competition)
        {
            return await _competition.CreateAsync(competition);
        }
        public async Task<bool> UpdateCompetition(int id, Competition competition)
        {
            var data = await _competition.GetByIdAsync(id);
            if (data != null)
            {
                data.Name = competition.Name;
                //data.StartDate = competition.StartDate;
                data.Description = competition.Description;
                //data.Movies = competition.Movies;
                await _competition.UpdateAsync(data);
                return true;
            }
            else
                return false;
        }
        public async Task<bool> DeleteCompetition(int id)
        {
            await _competition.DeleteAsync(id);
            return true;
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
