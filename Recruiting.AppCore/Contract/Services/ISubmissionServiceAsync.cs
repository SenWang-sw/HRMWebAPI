using Recruiting.AppCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recruiting.AppCore.Contract.Services
{
    public interface ISubmissionServiceAsync
    {
        Task<IEnumerable<Submission>> GetAll();
        Task<int> AddSubmissionAsync(Submission submission);
        Task<int> DeleteSubmissionAsync(int id);
        Task<int> UpdateSubmissionAsync(Submission submission);
        Task<Submission> GetSubmissionByIdAsync(int id);
    }
}
