﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.AppCore.Entities
{
    public class InterviewFeedback
    {
        [Key]
        public int InterviewFeedbackId { get; set; }

        [Required]
        public int Rating { get; set; }

        public string Comment { get; set; }
    }
}
