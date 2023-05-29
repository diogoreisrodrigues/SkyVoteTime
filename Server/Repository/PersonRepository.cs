using Microsoft.EntityFrameworkCore;
using SkyVoteTime.Server.Data;
using SkyVoteTime.Server.Models;

namespace SkyVoteTime.Server.Repository
{
    public class PersonRepository : IRepository<Person>
    {
        ApplicationDbContext _dbContext;

        public PersonRepository(ApplicationDbContext applicationDbContext)
        {
            _dbContext = applicationDbContext;
        }
        public Task<Person> CreateAsync(Person _object)
        {
            throw new NotImplementedException();
        }

        public async Task DeleteAsync(int id)
        {
            var data = _dbContext.Persons
                .Include(m => m.Votes)
                .FirstOrDefault(x => x.Id == id);
            _dbContext.Remove(data);
            await _dbContext.SaveChangesAsync();
        }

        public Task<List<Person>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<List<Competition>> GetAllCompWithoutVoteAsync(string email)
        {
            throw new NotImplementedException();
        }

        public async Task<Person> GetByIdAsync(int Id)
        {
            return await _dbContext.Persons.FirstOrDefaultAsync(c => c.Id == Id);
        }

        public async Task UpdateAsync(Person _object)
        {
            _dbContext.Persons.Update(_object);
            await _dbContext.SaveChangesAsync();
        }
    }
}
