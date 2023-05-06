using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SkyVoteTime.Shared.Models
{
    public class Competition
    {
      
        public int Id { get; set; }

        
		[Display(Name = "Name")]
		public string Name { get; set; }

        
		[Display(Name = "Start Date")]
		public DateTime StartDate { get; set; }

        
		[Display(Name = "Description")]
		public string Description { get; set; }

        //[NotMapped]
        //public List<string> CategoryList { get; set; } = new List<string>();

        
		[Display(Name = "Type")]
		public string Type { get; set; }

		
		[Display(Name = "isPublic")]
		public Boolean isPublic{ get; set; }


		public ICollection<Movie> Movies { get; set; }
    }
}
