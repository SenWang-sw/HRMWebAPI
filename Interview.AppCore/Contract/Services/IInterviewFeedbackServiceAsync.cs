using Interview.AppCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.AppCore.Contract.Services
{
    public interface IInterviewFeedbackServiceAsync
    {
        Task<IEnumerable<InterviewFeedback>> GetAll();
        Task<int> AddInterviewFeedbackAsync(InterviewFeedback interviewType);
        Task<int> DeleteInterviewFeedbackAsync(int id);
        Task<int> UpdateInterviewFeedbackAsync(InterviewFeedback interviewType);
        Task<InterviewFeedback> GetInterviewFeedbackByIdAsync(int id);
    }
}
