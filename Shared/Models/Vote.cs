﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkyVoteTime.Shared.Models
{
    public class Vote
    {
        public int Id { get; set; }

        public string email { get; set; }

    }
}
