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
    public class SubmissionStatusRepositoryAsync:BaseRepositoryAsync<SubmissionStatus>,ISubmissionStatusRepositoryAsync
    {
        public SubmissionStatusRepositoryAsync(RecruitingDbContext _db):base(_db)
        {
            
        }
    }
}
