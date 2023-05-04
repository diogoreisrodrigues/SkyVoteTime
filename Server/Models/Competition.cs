using System.ComponentModel.DataAnnotations;

namespace SkyVoteTime.Server.Models
{
    public class Competition
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public DateTime StartDate { get; set; }
        [Required]
        public string Description { get; set; }
        
        public ICollection<Movie> Movies { get; set; }
    }
}
