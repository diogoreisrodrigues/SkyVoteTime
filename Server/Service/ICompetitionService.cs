using SkyVoteTime.Server.Models;

namespace SkyVoteTime.Server.Service
{
    public interface ICompetitionService
    {
        Task<Competition> AddCompetition(Competition competition);
        Task<bool> UpdateCompetition(int id, Competition competition);
        Task<bool> DeleteCompetition(int id);
        Task<List<Competition>> GetAllCompetitions();
        Task<Competition> GetCompetition(int id);
    }
}
