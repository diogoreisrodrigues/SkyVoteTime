using SkyVoteTime.Server.Models;
using SkyVoteTime.Server.Repository;

namespace SkyVoteTime.Server.Service
{
    public class CompetitionService : ICompetitionService
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
            var data = await _competition.GetByIdAsyncCompetition(id);
            if (data != null)
            {
                data.Name = competition.Name;
                //data.StartDate = competition.StartDate;
                data.Description = competition.Description;
                data.CategoriesJson = competition.CategoriesJson;
                data.State = competition.State;
                data.Persons = competition.Persons;
                data.Movies = competition.Movies;
                data.savedEmailsJson = competition.savedEmailsJson;
                await _competition.UpdateAsync(data);
                return true;
            }
            else
                return false;
        }
        public async Task<bool> DeleteCompetition(int id)
        {
            await _competition.DeleteAsyncCompetition(id);
            return true;
        }
        public async Task<List<Competition>> GetAllCompetitions()
        {
            return await _competition.GetAllAsyncCompetition();
        }
        public async Task<List<Competition>> GetAllHotCompetitions(string email)
        {
            return await _competition.GetAllHotAsyncCompetition(email);
        }
        public async Task<List<Competition>> GetCompetitionsWithoutUserVote(string email)
        {
            return await _competition.GetAllCompWithoutVoteAsync(email);
        }

        public async Task<List<Competition>> GetCompetitionsWithUserVote(string email)
        {
            return await _competition.GetAllCompWithVoteAsync(email);
        }

        public async Task<List<string>> GetAllEmailsFromComp(int id)
        {
            return await _competition.GetAllEmailsFromComp(id);
        }

        public async Task<Competition> GetCompetition(int id)
        {
            return await _competition.GetByIdAsyncCompetition(id);
        }
    }
}
