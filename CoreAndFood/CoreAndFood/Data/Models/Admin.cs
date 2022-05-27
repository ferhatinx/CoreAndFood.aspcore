﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CoreAndFood.Data.Models
{
    public class Admin
    {
        [Key]
        public int AdminID { get; set; }

        [StringLength(20)]
        public string Username { get; set; }
        [StringLength(20)]
        public string Passaword { get; set; }
        [StringLength(20)]
        public string Role { get; set; }
    }
}
