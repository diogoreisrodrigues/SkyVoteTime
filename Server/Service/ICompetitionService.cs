using System;

namespace SkyVoteTime.Server.Service
{
    public interface ICompetitionService
    {
        Task<Competition> AddPerson(Competition competition);
        Task<List<Competition>> GetAllCompetitions();
        Task<Competition> GetCompetition(int id);
    }
}
