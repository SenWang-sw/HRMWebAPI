﻿using Interview.AppCore.Contract.Repos;
using Interview.AppCore.Entities;
using Interview.Infras.Data;
using Interviewg.Infras.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Infras.Repos
{
    public class RecruiterRepositoryAsync:BaseRepositoryAsync<Recruiter>,IRecruiterRepositoryAsync
    {
        public RecruiterRepositoryAsync(InterviewDbContext db):base(db) 
        {
            
        }
    }
}
