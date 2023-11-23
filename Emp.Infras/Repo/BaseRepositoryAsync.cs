using Emp.AppCore.Contract.Repo;
using Emp.Infras.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Emp.Infras.Repos
{
    public class BaseRepositoryAsync<T> : IRepositoryAsync<T> where T : class
    {
        private readonly EmpDbContext db;

        public BaseRepositoryAsync(EmpDbContext _db)
        {
            db = _db;
        }
        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await db.Set<T>().ToListAsync();
        }



        Task<int> IRepositoryAsync<T>.InsertAsync(T entity)
        {
            db.Set<T>().Add(entity);
            return db.SaveChangesAsync();
        }

        Task<int> IRepositoryAsync<T>.UpdateAsync(T entity)
        {
            db.Entry(entity).State = EntityState.Modified;
            return db.SaveChangesAsync();
        }

        async Task<int> IRepositoryAsync<T>.DeleteByIdAsync(int id)
        {
            var entity = await db.Set<T>().FindAsync(id);
            if (entity != null)
            {
                db.Set<T>().Remove(entity);
                return await db.SaveChangesAsync();
            }
            return 0;
        }


        async Task<T> IRepositoryAsync<T>.GetByIdAsync(int id)
        {
            return await db.Set<T>().FindAsync(id);
        }
    }
}
