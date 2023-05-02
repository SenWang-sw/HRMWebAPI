using Interview.AppCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.AppCore.Contract.Services
{
    public interface IInterviewTypeServiceAsync
    {
        Task<IEnumerable<InterviewType>> GetAll();
        Task<int> AddInterviewTypeAsync(InterviewType interviewType);
        Task<int> DeleteInterviewTypeAsync(int id);
        Task<int> UpdateInterviewTypeAsync(InterviewType interviewType);
        Task<InterviewType> GetInterviewTypeByIdAsync(int id);
    }
}
