using SkyVoteTime.Shared.Models;
using System.ComponentModel.DataAnnotations;

namespace SkyVoteTime.Shared.Models
{
    
    
    public class Competition
    {
        public int Id { get; set; }

        public string Name { get; set; }

        //public DateTime StartDate { get; set; }

        public string Description { get; set; }

        public CompetitionState State { get; set; }

        public string? CategoriesJson { get; set; }

        public List<Movie>? Movies { get; set; }
        public List<Person>? Persons { get; set; }

        public string Type { get; set; }

        public string ? ImageUrl { get; set; }

    }
    public enum CompetitionState
    {
        Private,
        Public,
        Finished
    }

}
