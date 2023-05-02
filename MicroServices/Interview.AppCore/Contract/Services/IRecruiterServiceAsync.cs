using Interview.AppCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.AppCore.Contract.Services
{
    public interface IRecruiterServiceAsync
    {
        Task<IEnumerable<Recruiter>> GetAll();
        Task<int> AddRecruiterAsync(Recruiter interviewType);
        Task<int> DeleteRecruiterAsync(int id);
        Task<int> UpdateRecruiterAsync(Recruiter interviewType);
        Task<Recruiter> GetRecruiterByIdAsync(int id);
    }
}
