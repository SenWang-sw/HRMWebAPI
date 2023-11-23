using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recruiting.AppCore.Entities
{
    public class Submission
    {
        [Key]
        public int SubmissionId { get; set; }

        [Required]
        [ForeignKey("JobRequirement")]
        public int JobRequirementId { get; set; }

        [Required]
        [ForeignKey("Candidate")]
        public int CandidateId { get; set; }

        [Required]
        public DateTime SubmittedOn { get; set; }

        [Required]
        [ForeignKey("SubmissionStatus")]
        public int SubmissionStatusCode { get; set; }

        public DateTime? ConfirmedOn { get; set; }

        public DateTime? RejectedOn { get; set; }
    }
}
