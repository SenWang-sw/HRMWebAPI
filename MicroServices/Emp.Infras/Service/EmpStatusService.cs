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
    public class EmpStatusService : IEmpStatusService
    {
        private readonly IEmpStatusRepo e;
        public EmpStatusService(IEmpStatusRepo repo)
        {
            e = repo;
        }
        public Task<int> AddAsync(EmpStatus entity)
        {
            return e.InsertAsync(entity);
        }

        public Task<int> DeleteAsync(int id)
        {
            return e.DeleteByIdAsync(id);
        }

        public Task<IEnumerable<EmpStatus>> GetAll()
        {
            return e.GetAllAsync();
        }

        public Task<EmpStatus> GetByIdAsync(int id)
        {
            return e.GetByIdAsync(id);
        }

        public Task<int> UpdateAsync(EmpStatus entity)
        {
            return e.UpdateAsync(entity);
        }
    }
}
