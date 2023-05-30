using SkyVoteTime.Server.Models;
using SkyVoteTime.Server.Repository;



namespace SkyVoteTime.Server.Service
{
    public class PersonService : IPersonService
    {
        private readonly IRepository<Person> _person;
        public PersonService(IRepository<Person> person)
        {
            _person = person;
        }
        public async Task<bool> DeletePerson(int id)
        {
            await _person.DeleteAsyncPersons(id);
            return true;
        }

        public async Task<bool> UpdatePerson(int id, Person person)
        {
            var data = await _person.GetByIdAsyncPerson(id);
            if (data != null)
            {
                data.name = person.name;
                data.Id = person.Id;
                data.profile_path = person.profile_path;
                
                data.Votes = person.Votes;
                await _person.UpdateAsync(data);
                return true;
            }
            else
                return false;
        }

    }
}
