﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RouseMusicianPortfolioSite.Models
{
    public class Subscribe
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }
    }
}
