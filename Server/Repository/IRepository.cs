using SkyVoteTime.Server.Models;

namespace SkyVoteTime.Server.Repository
{
    public interface IRepository<T>
    {
        public Task<T> CreateAsync(T _object);
        public Task UpdateAsync(T _object);
        public Task<List<T>> GetAllAsync();
        public Task<T> GetByIdAsync(int Id);
        public Task DeleteAsync(int id);
        Task<List<Competition>> GetAllCompWithoutVoteAsync(string email);
    }
}
