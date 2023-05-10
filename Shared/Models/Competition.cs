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

        public string Type { get; set; }

        public bool isPublic { get; set; }

        public string CategoriesJson { get; set; }

        public string MoviesJson { get; set; }

        //public ICollection<Movie> Movies { get; set; }
    }
}
