using Interview.AppCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.AppCore.Contract.Services
{
    public interface IInterviewerServiceAsync
    {
        Task<IEnumerable<Interviewer>> GetAll();
        Task<int> AddInterviewerAsync(Interviewer interviewType);
        Task<int> DeleteInterviewerAsync(int id);
        Task<int> UpdateInterviewerAsync(Interviewer interviewType);
        Task<Interviewer> GetInterviewereByIdAsync(int id);
    }
}
