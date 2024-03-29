﻿using SkyVoteTime.Server.Models;

namespace SkyVoteTime.Server.Service
{
    public interface ICompetitionService
    {
        Task<Competition> AddCompetition(Competition competition);
        Task<bool> UpdateCompetition(int id, Competition competition);
        Task<bool> DeleteCompetition(int id);
        Task<List<Competition>> GetAllCompetitions();
        Task<List<Competition>> GetAllHotCompetitions(string email);
        Task<Competition> GetCompetition(int id);
        Task<List<Competition>> GetCompetitionsWithoutUserVote(string email);
        Task<List<string>> GetAllEmailsFromComp(int id);
        Task<List<Competition>> GetCompetitionsWithUserVote(string email);
    }
}
