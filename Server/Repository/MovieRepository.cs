using Microsoft.EntityFrameworkCore;
using SkyVoteTime.Server.Data;
using SkyVoteTime.Server.Models;

namespace SkyVoteTime.Server.Repository
{
    public class MovieRepository : IRepository<Movie>
    {
        ApplicationDbContext _dbContext;
        public MovieRepository(ApplicationDbContext applicationDbContext)
        {
            _dbContext = applicationDbContext;
        }
        public async Task<Movie> CreateAsync(Movie _object)
        {
            var obj = await _dbContext.Movies.AddAsync(_object);
            _dbContext.SaveChanges();
            return obj.Entity;
        }
        public async Task UpdateAsync(Movie _object)
        {
            _dbContext.Movies.Update(_object);
            await _dbContext.SaveChangesAsync();
        }
        public async Task<List<Movie>> GetAllAsync()
        {
            return await _dbContext.Movies.ToListAsync();
        }
        public async Task<Movie> GetByIdAsync(int id)
        {
            return await _dbContext.Movies.FirstOrDefaultAsync(c => c.Id == id);
        }

        public async Task DeleteAsync(int id)
        {
            var data = _dbContext.Movies
                .Include(m => m.Votes)
                .FirstOrDefault(x => x.Id == id);
            _dbContext.Remove(data);
            await _dbContext.SaveChangesAsync();
        }

        public Task<List<Competition>> GetAllCompWithoutVoteAsync(string email)
        {
            throw new NotImplementedException();
        }
    }
}
