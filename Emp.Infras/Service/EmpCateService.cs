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
    public class EmpCateService : IEmpCateService
    {
        private readonly IEmpCateRepo e;
        public EmpCateService(IEmpCateRepo repo)
        {
            e = repo;
        }
        public Task<int> AddAsync(EmpCate entity)
        {
            return e.InsertAsync(entity);
        }

        public Task<int> DeleteAsync(int id)
        {
            return e.DeleteByIdAsync(id);
        }

        public Task<IEnumerable<EmpCate>> GetAll()
        {
            return e.GetAllAsync();
        }

        public Task<EmpCate> GetByIdAsync(int id)
        {
           return e.GetByIdAsync(id);
        }

        public Task<int> UpdateAsync(EmpCate entity)
        {
            return e.UpdateAsync(entity);
        }
    }
}
