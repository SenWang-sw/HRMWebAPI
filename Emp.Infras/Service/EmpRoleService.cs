using Emp.AppCore.Contract.Repo;
using Emp.AppCore.Contract.Service;
using Emp.AppCore.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emp.Infras.Service
{
    public class EmpRoleService : IEmpRoleService
    {
        private readonly IEmpRoleRepo e;
        public EmpRoleService(IEmpRoleRepo repo)
        {
            e = repo;
        }
        public Task<int> AddAsync(EmpRole entity)
        {
            return e.InsertAsync(entity);
        }

        public Task<int> DeleteAsync(int id)
        {
            return e.DeleteByIdAsync(id);
        }

        public Task<IEnumerable<EmpRole>> GetAll()
        {
            return e.GetAllAsync();
        }

        public Task<EmpRole> GetByIdAsync(int id)
        {
            return e.GetByIdAsync(id);
        }

        public Task<int> UpdateAsync(EmpRole entity)
        {
            return e.UpdateAsync(entity);
        }
    }
}
