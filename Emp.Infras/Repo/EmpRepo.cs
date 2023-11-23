using Emp.AppCore.Contract.Repo;
using Emp.AppCore.Entity;
using Emp.Infras.Data;
using Emp.Infras.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Emp.Infras.Repo
{
    public class EmpRepo:BaseRepositoryAsync<Emplo>,IEmpRepo
    {
        public EmpRepo(EmpDbContext db):base(db) 
        {
            
        }
    }
}
