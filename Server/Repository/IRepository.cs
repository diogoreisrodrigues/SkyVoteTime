using SkyVoteTime.Server.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SkyVoteTime.Server.Repository
{
    public interface IRepository<T>
    {
        public Task<T> CreateAsync(T _object);
        
        public Task UpdateAsync(T _object);
        //public Task<List<T>> GetAllAsync();
        public Task<List<Competition>> GetAllAsyncCompetition();
        public Task<List<Movie>> GetAllAsyncMovie();
        // public Task<T> GetByIdAsync(int Id);
        public Task<Competition> GetByIdAsyncCompetition(int id);
        public Task<Movie> GetByIdAsyncMovie(int id);
        public Task<Person> GetByIdAsyncPerson(int Id);
        //public Task DeleteAsync(int id);
        public Task DeleteAsyncCompetition(int id);
        public Task DeleteAsyncMovies(int id);
        public Task DeleteAsyncPersons(int id);
        Task<List<Competition>> GetAllCompWithoutVoteAsync(string email);
        Task<List<string>> GetAllEmailsFromComp(int id);
    }
}
