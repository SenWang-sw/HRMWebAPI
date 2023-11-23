using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.AppCore.Entities
{
    public class Recruiter
    {
            [Key]
            public int RecruiterId { get; set; }

            [Required]
            [MaxLength(128)]
            public string FirstName { get; set; }

            [Required]
            [MaxLength(128)]
            public string LastName { get; set; }

            public int EmployeeId { get; set; }     
    }
}
