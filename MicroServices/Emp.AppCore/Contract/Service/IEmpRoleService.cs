using Emp.AppCore.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emp.AppCore.Contract.Service
{
    public interface IEmpRoleService
    {
        Task<IEnumerable<EmpRole>> GetAll();
        //Task<IEnumerable<JobRequirementResponseModel>> GetAll();
        Task<int> AddAsync(EmpRole entity);
        Task<int> DeleteAsync(int id);
        Task<int> UpdateAsync(EmpRole entity);
        Task<EmpRole> GetByIdAsync(int id);
    }
}
