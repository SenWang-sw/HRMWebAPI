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
    public class InterviewServiceAsync:IInterviewServiceAsync
    {
        private readonly IInterviewRepositoryAsync iww;

        public InterviewServiceAsync(IInterviewRepositoryAsync interviewRepositoryAsync)
        {
            iww = interviewRepositoryAsync;
        }

        public Task<int> AddInterviewAsync(Intervieww interviewType)
        {
            return iww.InsertAsync(interviewType);
        }

        public Task<int> DeleteInterviewAsync(int id)
        {
            return iww.DeleteByIdAsync(id);
        }

        public Task<IEnumerable<Intervieww>> GetAll()
        {
            return iww.GetAllAsync();
        }

        public Task<Intervieww> GetInterviewByIdAsync(int id)
        {
            return iww.GetByIdAsync(id);
        }

        public Task<int> UpdateInterviewAsync(Intervieww interviewType)
        {
            return iww.UpdateAsync(interviewType);
        }
    }
}
