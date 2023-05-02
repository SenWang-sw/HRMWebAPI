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
    public class InterviewerServiceAsync : IInterviewerServiceAsync
    {
        private readonly IInterviewerRepositoryAsync ie;

        public InterviewerServiceAsync(IInterviewerRepositoryAsync interviewerRepositoryAsync)
        {
            ie = interviewerRepositoryAsync;
        }
        public Task<int> AddInterviewerAsync(Interviewer interviewType)
        {
            return ie.InsertAsync(interviewType);
        }

        public Task<int> DeleteInterviewerAsync(int id)
        {
            return ie.DeleteByIdAsync(id);
        }

        public Task<IEnumerable<Interviewer>> GetAll()
        {
            return ie.GetAllAsync();
        }

        public Task<Interviewer> GetInterviewereByIdAsync(int id)
        {
            return ie.GetByIdAsync(id);
        }

        public Task<int> UpdateInterviewerAsync(Interviewer interviewType)
        {
            return ie.UpdateAsync(interviewType);
        }
    }
}
