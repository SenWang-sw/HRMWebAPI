using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.AppCore.Entities
{
    public class Intervieww
    {
        [Key]
        public int InterviewId { get; set; }

        [ForeignKey("Recruiter")]
        public int RecruiterId { get; set; }
        public Recruiter Recruiter { get; set; }

        public int SubmissionId { get; set; }

        [ForeignKey("InterviewType")]
        public int InterviewTypeCode { get; set; }
        public InterviewType InterviewType { get; set; }

        public int InterviewRound { get; set; }

        public DateTime ScheduledOn { get; set; }

        [ForeignKey("Interviewer")]
        public int InterviewerId { get; set; }
        public Interviewer Interviewer { get; set; }

        [ForeignKey("Feedback")]
        public int? FeedbackId { get; set; }
        public InterviewFeedback Feedback { get; set; }
    }
}

