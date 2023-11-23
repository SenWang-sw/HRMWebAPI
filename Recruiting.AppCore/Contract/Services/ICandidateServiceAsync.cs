using Recruiting.AppCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recruiting.AppCore.Contract.Services
{
    public interface ICandidateServiceAsync
    {
        Task<IEnumerable<Candidate>> GetAll();
        Task<int> AddCandidateAsync(Candidate candidate);
        Task<int> DeleteCandidateAsync(int id);
        Task<int> UpdateCandidateAsync(Candidate candidate);
        Task<Candidate> GetCandidateByIdAsync(int id);
    }
}
