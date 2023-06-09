﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Recruiting.AppCore.Entities
{
    public class Candidate
    {
        public int Id { get; set; }
        [Required]
        [Column(TypeName = "varchar(30)")]
        public string FirstName { get; set; }
        [Required]
        [Column(TypeName = "varchar(30)")]
        public string LastName { get; set; }
        [Required]
        [Column(TypeName = "varchar(150)")]
        public string Email { get; set; }
        
        [Column(TypeName = "varchar(300)")]
        public string ResumeUrl { get; set; }

    }
}
