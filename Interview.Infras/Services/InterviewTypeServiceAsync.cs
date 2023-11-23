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
    public class InterviewTypeServiceAsync:IInterviewTypeServiceAsync
    {
        private readonly IInterviewTypeRepositoryAsync it;

        public InterviewTypeServiceAsync(IInterviewTypeRepositoryAsync interviewTypeRepositoryAsync)
        {
            it = interviewTypeRepositoryAsync;
        }

        public Task<int> AddInterviewTypeAsync(InterviewType interviewType)
        {
            return it.InsertAsync(interviewType);
        }

        public Task<int> DeleteInterviewTypeAsync(int id)
        {
            return it.DeleteByIdAsync(id);
        }

        public Task<IEnumerable<InterviewType>> GetAll()
        {
            return it.GetAllAsync();
        }

        public Task<InterviewType> GetInterviewTypeByIdAsync(int id)
        {
            return it.GetByIdAsync(id);
        }

        public Task<int> UpdateInterviewTypeAsync(InterviewType interviewType)
        {
            return it.UpdateAsync(interviewType);
        }
    }
}
