using Recruiting.AppCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recruiting.AppCore.Contract.Services
{
    public interface ISubmissionStatusServiceAsync
    {
        Task<IEnumerable<SubmissionStatus>> GetAll();
        Task<int> AddSubmissionStatusAsync(SubmissionStatus submission);
        Task<int> DeleteSubmissionStatusAsync(int id);
        Task<int> UpdateSubmissionStatusAsync(SubmissionStatus submission);
        Task<SubmissionStatus> GetSubmissionStatusByIdAsync(int id);
    }
}
