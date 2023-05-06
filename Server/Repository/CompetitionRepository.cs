using Microsoft.EntityFrameworkCore;
using SkyVoteTime.Server.Data;
using System;

namespace SkyVoteTime.Server.Repository
{
    public class CompetitionRepository : IRepository<Competition>
    {
        ApplicationDbContext _dbContext;
        public CompetitionRepository(ApplicationDbContext applicationDbContext)
        {
            _dbContext = applicationDbContext;
        }
        public async Task<Competition> CreateAsync(Competition _object)
        {
            var obj = await _dbContext.Competitions.AddAsync(_object);
            _dbContext.SaveChanges();
            return obj.Entity;
        }

        public async Task<List<Competition>> GetAllAsync()
        {
            return await _dbContext.Competitions.ToListAsync();
        }
        public async Task<Competition> GetByIdAsync(int Id)
        {
            return await _dbContext.Competitions.FirstOrDefaultAsync(x => x.Id == Id);
        }
    }
}
