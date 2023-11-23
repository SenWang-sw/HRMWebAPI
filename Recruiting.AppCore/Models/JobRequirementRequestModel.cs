using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recruiting.AppCore.Models
{
    public class JobRequirementRequestModel
    {
        [Required]
        public int NumberOfPositions { get; set; }

        [Required]
        [StringLength(50)]
        public string Title { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        [Required]
        public int HiringManagerId { get; set; }

        [StringLength(100)]
        public string HiringManagerName { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public bool IsActivate { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime? ClosedOn { get; set; }

        [StringLength(500)]
        public string ClosedReason { get; set; }

        [Required]
        public string JobCategory { get; set; }

        [Required]
        public string EmployeeType { get; set; }
    }
}
