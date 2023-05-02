using Interview.AppCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.AppCore.Contract.Services
{
    public interface IInterviewServiceAsync
    {
        Task<IEnumerable<Intervieww>> GetAll();
        Task<int> AddInterviewAsync(Intervieww interviewType);
        Task<int> DeleteInterviewAsync(int id);
        Task<int> UpdateInterviewAsync(Intervieww interviewType);
        Task<Intervieww> GetInterviewByIdAsync(int id);
    }
}
