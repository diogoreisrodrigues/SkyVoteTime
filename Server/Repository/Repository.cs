using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SkyVoteTime.Server.Data;
using SkyVoteTime.Server.Models;

namespace SkyVoteTime.Server.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        ApplicationDbContext _dbContext;
        public Repository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<T> CreateAsync(T entity)
        {
            var obj = await _dbContext.Set<T>().AddAsync(entity);
            await _dbContext.SaveChangesAsync();
            return obj.Entity;
        }
        public async Task UpdateAsync(T entity)
        {
            _dbContext.Set<T>().Update(entity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<List<Competition>> GetAllAsyncCompetition()
        {
            return await _dbContext.Competitions
                .Include(c => c.Movies)
                .Include(c => c.Persons)
                .AsNoTracking()
                .ToListAsync();
        }

        public async Task<List<Movie>> GetAllAsyncMovie()
        {
            return await _dbContext.Movies.ToListAsync();
        }

        public async Task<Competition> GetByIdAsyncCompetition(int id)
        {
            return await _dbContext.Competitions
                .Include(c => c.Movies)
                .ThenInclude(m => m.Votes)
                .Include(c => c.Persons)
                .ThenInclude(p => p.Votes)
                .AsNoTracking()
                .FirstOrDefaultAsync(c => c.Id == id);
        }
        public async Task<Movie> GetByIdAsyncMovie(int id)
        {
            return await _dbContext.Movies.FirstOrDefaultAsync(c => c.Id == id);
        }
        public async Task<Person> GetByIdAsyncPerson(int Id)
        {
            return await _dbContext.Persons.FirstOrDefaultAsync(c => c.Id == Id);
        }

        public async Task DeleteAsyncCompetition(int id)
        {
            var data = _dbContext.Competitions
                .Include(c => c.Movies)
                .Include(c => c.Persons)
                .FirstOrDefault(x => x.Id == id);
            _dbContext.Remove(data);
            await _dbContext.SaveChangesAsync();
        }
        public async Task DeleteAsyncMovies(int id)
        {
            var data = _dbContext.Movies
                .Include(m => m.Votes)
                .FirstOrDefault(x => x.Id == id);
            _dbContext.Remove(data);
            await _dbContext.SaveChangesAsync();
        }
        public async Task DeleteAsyncPersons(int id)
        {
            var data = _dbContext.Persons
                .Include(m => m.Votes)
                .FirstOrDefault(x => x.Id == id);
            _dbContext.Remove(data);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteAsyncVote(int id)
        {
            var data = _dbContext.Votes
                .FirstOrDefault(x => x.Id == id);
            _dbContext.Remove(data);
            await _dbContext.SaveChangesAsync();
        }
        public async Task<List<Competition>> GetAllCompWithoutVoteAsync(string userEmail)
        {
            var competitionsWithoutVote = await _dbContext.Competitions
            .Include(c => c.Movies)
            .Include(c => c.Persons)
            .Where(c => (c.State == CompetitionState.Public &&
                         !c.Movies.Any(m => m.Votes.Any(v => v.email == userEmail)) &&
                         !c.Persons.Any(p => p.Votes.Any(v => v.email == userEmail))) ||
                        c.State == CompetitionState.Finished)
            .ToListAsync();

            return competitionsWithoutVote;
        }

        public async Task<List<string>> GetAllEmailsFromComp(int id)
        {
            var emailsFromComp = _dbContext.Competitions
                .Where(c => c.Id == id)
                .SelectMany(c => c.Movies.SelectMany(m => m.Votes.Select(v => v.email)))
                .Union(_dbContext.Persons.SelectMany(p => p.Votes.Select(v => v.email)))
                .Distinct()
                .ToList();

            return emailsFromComp;
        }
    }

}