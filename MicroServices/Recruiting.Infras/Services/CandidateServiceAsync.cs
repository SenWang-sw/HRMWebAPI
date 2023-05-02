using Recruiting.AppCore.Contract.Repos;
using Recruiting.AppCore.Contract.Services;
using Recruiting.AppCore.Entities;
using Recruiting.Infras.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recruiting.Infras.Services
{
    public class CandidateServiceAsync : ICandidateServiceAsync
    {
        private readonly ICandidateRepositoryAsync candidateRepositoryAsync;

        public CandidateServiceAsync(ICandidateRepositoryAsync candidateRepositoryAsync)
        {
            this.candidateRepositoryAsync = candidateRepositoryAsync;
        }

        public Task<int> AddCandidateAsync(Candidate candidate)
        {
            return candidateRepositoryAsync.InsertAsync(candidate);
        }

        public Task<int> DeleteCandidateAsync(int id)
        {
            return candidateRepositoryAsync.DeleteByIdAsync(id);
        }

        public Task<IEnumerable<Candidate>> GetAll()
        {
            return candidateRepositoryAsync.GetAllAsync();
        }

        public Task<Candidate> GetCandidateByIdAsync(int id)
        {
            return candidateRepositoryAsync.GetByIdAsync(id);
        }

        public Task<int> UpdateCandidateAsync(Candidate candidate)
        {
            return candidateRepositoryAsync.UpdateAsync(candidate);
        }
    }
}
