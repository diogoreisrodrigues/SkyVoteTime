using System.ComponentModel.DataAnnotations;

namespace SkyVoteTime.Shared.Models
{
    public class Movie
    {
        
        public int Id { get; set; }

        [Required]
        public string title { get; set; }
        //[Required]
        //public int Year { get; set; }
        //public string Rated { get; set; }
        //[Required]
        //public string Genre { get; set; }
        //public string Director { get; set; }
        //[Required]
        public string overview { get; set; }
        [Required]
        public string poster_path { get; set; }

        public List<Vote>? Votes { get; set; }

    }
}
