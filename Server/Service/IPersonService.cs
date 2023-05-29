using SkyVoteTime.Server.Models;

namespace SkyVoteTime.Server.Service
{
    public interface IPersonService
    {
        Task<bool> DeletePerson(int id);
        Task<bool> UpdatePerson(int id, Person person);
    }
}