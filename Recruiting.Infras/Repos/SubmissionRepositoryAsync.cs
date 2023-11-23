using Recruiting.AppCore.Contract.Repos;
using Recruiting.AppCore.Entities;
using Recruiting.Infras.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recruiting.Infras.Repos
{
    public class SubmissionRepositoryAsync:BaseRepositoryAsync<Submission>,ISubmissionRepositoryAsync
    {
        private readonly RecruitingDbContext _db;

        public SubmissionRepositoryAsync(RecruitingDbContext db):base(db)
        {
            _db = db;
        }
    }
}
