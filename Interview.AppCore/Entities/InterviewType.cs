﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.AppCore.Entities
{
    public class InterviewType
    {
        [Key]
        public int LookupCode { get; set; }

        [Required]
        [MaxLength(128)]
        public string Description { get; set; }
    }
}
