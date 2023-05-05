using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkyVoteTime.Shared.Models
{
    public class Person
    {
        public string name { get; set; }
        public int id { get; set; }
        public string birthday { get; set; }
        public int gender { get; set; }
        public string biography { get; set; }
        public string place_of_birth { get; set; }
        public string profile_path { get; set; }
        public string known_for_department { get; set; }

    }
}
