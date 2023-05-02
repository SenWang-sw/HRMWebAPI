using Microsoft.EntityFrameworkCore;
using Recruiting.AppCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recruiting.Infras.Data
{
    public class RecruitingDbContext:DbContext
    {
        public RecruitingDbContext(DbContextOptions<RecruitingDbContext>options):base(options)
        {
            
        }
        public DbSet<Candidate> Candidate { get; set; }
        public DbSet<JobRequirement> JobRequirements { get; set; }
        public DbSet<Submission> Submissions { get; set; }
        public DbSet<SubmissionStatus> SubmissionStatus { get; set; }
       
    }
}

