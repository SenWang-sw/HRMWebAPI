using Recruiting.AppCore.Contract.Repos;
using Recruiting.AppCore.Contract.Services;
using Recruiting.AppCore.Entities;
using Recruiting.AppCore.Models;
using Recruiting.Infras.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recruiting.Infras.Services
{
    public class JobRequirementServiceAsync:IJobrequirementServiceAsync
    {
        private readonly IJobRequirementRepositoryAsync jr;

        public JobRequirementServiceAsync(IJobRequirementRepositoryAsync jobRequirementRepositoryAsync)
        {
            jr = jobRequirementRepositoryAsync;
        }
        public Task<int> AddJobRequirementAsync(JobRequirementRequestModel model)
        {
            JobRequirement jobRequirement = new JobRequirement();
            if (model != null)
            {
                jobRequirement.NumberOfPositions = model.NumberOfPositions;
                jobRequirement.Title = model.Title;
                jobRequirement.Description = model.Description;
                jobRequirement.HiringManagerId = model.HiringManagerId;
                jobRequirement.HiringManagerName = model.HiringManagerName;
                jobRequirement.StartDate = model.StartDate;
                jobRequirement.IsActivate = model.IsActivate;
                jobRequirement.ClosedOn = model.ClosedOn;
                jobRequirement.ClosedReason = model.ClosedReason;
                jobRequirement.CreatedOn = model.CreatedOn;
                jobRequirement.JobCategory = model.JobCategory;
                jobRequirement.EmployeeType = model.EmployeeType;
            }
            //returns number of rows affected, typically 1
            return jr.InsertAsync(jobRequirement);
        }


        public Task<int> DeleteJobRequirementAsync(int id)
        {
            return jr.DeleteByIdAsync(id);
        }

        public Task<IEnumerable<JobRequirement>> GetAll()
        {
            
           return jr.GetAllAsync();
        }


        public Task<JobRequirement> GetJobRequirementByIdAsync(int id)
        {
            return jr.GetByIdAsync(id);
        }


        public Task<int> UpdateJobRequirementAsync(JobRequirement jobRequirement)
        {
            return jr.UpdateAsync(jobRequirement);
        }

    }
}
