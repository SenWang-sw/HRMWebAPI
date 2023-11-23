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
    public class SubmissionServiceAsync : ISubmissionServiceAsync
    {
        private readonly ISubmissionRepositoryAsync sr;
        private readonly IJobRequirementRepositoryAsync jr;
        private readonly ICandidateRepositoryAsync cr;
        private readonly ISubmissionStatusRepositoryAsync ssr;

        public SubmissionServiceAsync(ISubmissionRepositoryAsync submissionRepositoryAsync,
            IJobRequirementRepositoryAsync jr, ICandidateRepositoryAsync cr, 
            ISubmissionStatusRepositoryAsync ssr)
        {
            sr = submissionRepositoryAsync;
            this.jr = jr;
            this.cr = cr;
            this.ssr = ssr;
        }

        public IJobRequirementRepositoryAsync Jr { get; }
        public ICandidateRepositoryAsync Cr { get; }
        public ISubmissionStatusRepositoryAsync Ssr { get; }

        public async Task<int> AddSubmissionAsync(Submission submission)
        {
            var checkJR = await jr.GetByIdAsync(submission.JobRequirementId);
            var checkCR = await cr.GetByIdAsync(submission.CandidateId);
            var checkSSR = await ssr.GetByIdAsync(submission.SubmissionStatusCode);
            if(checkJR != null && checkCR != null &&checkSSR != null)
            {
               return await sr.InsertAsync(submission);
            }
            else
            {
                return -1;
            }
        }

        public Task<int> DeleteSubmissionAsync(int id)
        {
            return sr.DeleteByIdAsync(id);
        }

        public Task<IEnumerable<Submission>> GetAll()
        {
            return sr.GetAllAsync();
        }

        public async Task<Submission> GetSubmissionByIdAsync(int id)
        {
            var res = await sr.GetByIdAsync(id);
            if(res !=null)
            {
                return res;
            }
            else
            {
                return null;
            }
        }

        public Task<int> UpdateSubmissionAsync(Submission submission)
        {
            return sr.UpdateAsync(submission);
        }
    }
}
