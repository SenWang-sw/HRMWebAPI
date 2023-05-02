using Emp.AppCore.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emp.AppCore.Contract.Service
{
    public interface IEmpStatusService
    {
        Task<IEnumerable<EmpStatus>> GetAll();
        //Task<IEnumerable<JobRequirementResponseModel>> GetAll();
        Task<int> AddAsync(EmpStatus entity);
        Task<int> DeleteAsync(int id);
        Task<int> UpdateAsync(EmpStatus entity);
        Task<EmpStatus> GetByIdAsync(int id);
    }
}
