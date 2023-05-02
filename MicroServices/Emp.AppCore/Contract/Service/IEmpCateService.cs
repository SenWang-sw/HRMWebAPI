using Emp.AppCore.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emp.AppCore.Contract.Service
{
    public interface IEmpCateService
    {
        Task<IEnumerable<EmpCate>> GetAll();
        //Task<IEnumerable<JobRequirementResponseModel>> GetAll();
        Task<int> AddAsync(EmpCate entity);
        Task<int> DeleteAsync(int id);
        Task<int> UpdateAsync(EmpCate entity);
        Task<EmpCate> GetByIdAsync(int id);
    }
}
