using Interview.AppCore.Contract.Repos;
using Interview.AppCore.Contract.Services;
using Interview.AppCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Infras.Services
{
    public class RecruiterServiceAsync : IRecruiterServiceAsync
    {
        private readonly IRecruiterRepositoryAsync r;
        public RecruiterServiceAsync(IRecruiterRepositoryAsync recruiterRepositoryAsync)
        {
            r = recruiterRepositoryAsync;
        }
        public Task<int> AddRecruiterAsync(Recruiter interviewType)
        {
            return r.InsertAsync(interviewType);
        }

        public Task<int> DeleteRecruiterAsync(int id)
        {
            return r.DeleteByIdAsync(id);
        }

        public Task<IEnumerable<Recruiter>> GetAll()
        {
            return r.GetAllAsync();
        }

        public Task<Recruiter> GetRecruiterByIdAsync(int id)
        {
            return r.GetByIdAsync(id);
        }

        public Task<int> UpdateRecruiterAsync(Recruiter interviewType)
        {
            return r.UpdateAsync(interviewType);
        }
    }
}
