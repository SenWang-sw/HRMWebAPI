using Recruiting.AppCore.Entities;
using Recruiting.AppCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recruiting.AppCore.Contract.Services
{
    public  interface IJobrequirementServiceAsync
    {
        Task<IEnumerable<JobRequirement>> GetAll();
        //Task<IEnumerable<JobRequirementResponseModel>> GetAll();
        Task<int> AddJobRequirementAsync(JobRequirementRequestModel jobRequirement);
        Task<int> DeleteJobRequirementAsync(int id);
        Task<int> UpdateJobRequirementAsync(JobRequirement jobRequirement);
        Task<JobRequirement> GetJobRequirementByIdAsync(int id);
    }
}
