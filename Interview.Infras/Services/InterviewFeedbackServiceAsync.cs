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
    public class InterviewFeedbackServiceAsync : IInterviewFeedbackServiceAsync
    {
        private readonly IInterviewFeedbackRepositoryAsync ifb;

        public InterviewFeedbackServiceAsync(IInterviewFeedbackRepositoryAsync interviewFeedbackRepositoryAsync)
        {
            ifb = interviewFeedbackRepositoryAsync;
        }
        public Task<int> AddInterviewFeedbackAsync(InterviewFeedback interviewType)
        {
            return ifb.InsertAsync(interviewType);
        }

        public Task<int> DeleteInterviewFeedbackAsync(int id)
        {
            return ifb.DeleteByIdAsync(id);
        }

        public Task<IEnumerable<InterviewFeedback>> GetAll()
        {
            return ifb.GetAllAsync();
        }

        public Task<InterviewFeedback> GetInterviewFeedbackByIdAsync(int id)
        {
            return ifb.GetByIdAsync(id);
        }

        public Task<int> UpdateInterviewFeedbackAsync(InterviewFeedback interviewType)
        {
            return ifb.UpdateAsync(interviewType);
        }
    }
}
