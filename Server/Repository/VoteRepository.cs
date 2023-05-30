using Microsoft.EntityFrameworkCore;
using SkyVoteTime.Server.Data;
using SkyVoteTime.Server.Models;

namespace SkyVoteTime.Server.Repository
{
    public class VoteRepository : IRepository<Vote>
    {
        ApplicationDbContext _dbContext;
        public VoteRepository(ApplicationDbContext applicationDbContext)
        {
            _dbContext = applicationDbContext;
        }
        public Task<Vote> CreateAsync(Vote _object)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Vote>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<List<Competition>> GetAllCompWithoutVoteAsync(string email)
        {
            throw new NotImplementedException();
        }

        public Task<List<string>> GetAllEmailsFromComp(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Vote> GetByIdAsync(int Id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Vote _object)
        {
            throw new NotImplementedException();
        }
    }
}
