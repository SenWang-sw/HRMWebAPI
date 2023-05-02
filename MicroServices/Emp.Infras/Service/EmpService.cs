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
    public class EmpService: IEmpService
    {
        private readonly IEmpRepo e;
        public EmpService(IEmpRepo repo)
        {
            e = repo;
        }
        public Task<int> AddAsync(Emplo entity)
        {
            return e.InsertAsync(entity);
        }

        public Task<int> DeleteAsync(int id)
        {
            return e.DeleteByIdAsync(id);
        }

        public Task<IEnumerable<Emplo>> GetAll()
        {
            return e.GetAllAsync();
        }

        public Task<Emplo> GetByIdAsync(int id)
        {
            return e.GetByIdAsync(id);
        }

        public Task<int> UpdateAsync(Emplo entity)
        {
            return e.UpdateAsync(entity);
        }
    }
}
