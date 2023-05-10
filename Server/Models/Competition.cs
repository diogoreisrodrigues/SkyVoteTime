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

        // public DateTime StartDate { get; set; }

        public string Description { get; set; }

        public string Type { get; set; }

        public bool isPublic { get; set; }

        public string CategoriesJson { get; set; }

        public string MoviesJson{ get; set; }

        //public ICollection<Movie> Movies { get; set; }
    }
}
