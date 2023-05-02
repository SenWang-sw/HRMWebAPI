using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.AppCore.Contract.Repos
{
    public interface IRepositoryAsync<T> where T : class
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<int>InsertAsync(T entity);
        Task<int> UpdateAsync(T entity);
        Task<int> DeleteByIdAsync(int id);
        Task<T> GetByIdAsync(int id);

    }
}
