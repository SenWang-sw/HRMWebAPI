using Recruiting.AppCore.Contract.Repos;
using Recruiting.AppCore.Contract.Services;
using Recruiting.AppCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recruiting.Infras.Services
{
    public class SubmissionStatusServiceAsync : ISubmissionStatusServiceAsync
    {
        private readonly ISubmissionStatusRepositoryAsync ssr;

        public SubmissionStatusServiceAsync(ISubmissionStatusRepositoryAsync submissionStatusRepositoryAsync)
        {
            ssr = submissionStatusRepositoryAsync;
        }
        public Task<int> AddSubmissionStatusAsync(SubmissionStatus submission)
        {
            return ssr.InsertAsync(submission);
        }

        public Task<int> DeleteSubmissionStatusAsync(int id)
        {
            return ssr.DeleteByIdAsync(id);
        }

        public Task<IEnumerable<SubmissionStatus>> GetAll()
        {
            return ssr.GetAllAsync();
        }

        public Task<SubmissionStatus> GetSubmissionStatusByIdAsync(int id)
        {
            return ssr.GetByIdAsync(id);
        }

        public Task<int> UpdateSubmissionStatusAsync(SubmissionStatus submission)
        {
            return ssr.UpdateAsync(submission);
        }
    }
}
