using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkyVoteTime.Server.Models
{
    public class Person
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string name { get; set; }

        public string known_for_department { get; set; }
        public int gender { get; set; }

        public string profile_path { get; set; }

        public List<Vote>? Votes { get; set; }
    }
}

