using System.ComponentModel.DataAnnotations;

namespace SkyVoteTime.Server.Models
{
    public class Movie
    {
        [Required]
        public string Title { get; set; }
        [Required]
        public int Year { get; set; }
        public string Rated { get; set; }
        [Required]
        public string Genre { get; set; }
        public string Director { get; set; }
        [Required]
        public string Plot { get; set; }
        [Required]
        public string PosterUrl { get; set; }
    }
}
