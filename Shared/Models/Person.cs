﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkyVoteTime.Shared.Models
{
    public class Person
    {

        public int Id { get; set; }
        public string name { get; set; }

        public string known_for_department { get; set; }
        public int gender { get; set; }

        public string profile_path { get; set; }

        public List<Vote>? Votes { get; set; }
    }
}