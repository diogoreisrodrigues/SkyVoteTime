using Microsoft.EntityFrameworkCore;
using SkyVoteTime.Server.Data;
using SkyVoteTime.Server.Models;

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
        public async Task UpdateAsync(Competition _object)
        {
            _dbContext.ChangeTracker.Clear();
            _dbContext.Competitions.Update(_object);
            await _dbContext.SaveChangesAsync();
        }
        public async Task<List<Competition>> GetAllAsync()
        {
            return await _dbContext.Competitions
                .Include(c => c.Movies)
                .ToListAsync();
        }
        public async Task<Competition> GetByIdAsync(int id)
        {
            return await _dbContext.Competitions
                .Include(c => c.Movies)
                .FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task DeleteAsync(int id)
        {
            var data = _dbContext.Competitions.FirstOrDefault(x => x.Id == id);
            _dbContext.Remove(data);
            await _dbContext.SaveChangesAsync();
        }
    }
}
