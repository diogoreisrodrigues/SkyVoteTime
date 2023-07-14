using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace SkyVoteTime.Server.Models
{
    [Table("Competition", Schema = "dbo")]
    public class Competition
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
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
        Finished,
        Voted
    }
}
