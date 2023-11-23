using Interview.AppCore.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Infras.Data
{
    public class InterviewDbContext:DbContext
    {
        public InterviewDbContext(DbContextOptions<InterviewDbContext> options):base(options)
        {
            
        }
        public DbSet<Interviewer> Interviewers { get; set; }
        public DbSet<Intervieww> Intervieww { get; set; }
        public DbSet<InterviewFeedback> InterviewsFeedback { get; set; }
        public DbSet<InterviewType> InterviewsType { get; set; }
        public DbSet<Recruiter> Recruiter { get; set; }

    }
}
