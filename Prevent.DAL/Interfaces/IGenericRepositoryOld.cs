using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Prevent.DAL.Interfaces
{
    public interface IGenericRepositoryOld<T> where T : class
    {
		//Task AddAsync(T entity);
		//Task<T> GetByIdAsync(int id);
		//Task<List<T?>> GetAllAsync(bool tracked = true);
		//Task UpdateAsync(T entity);
		//Task DeleteByIdAsync(int id);


		Task<List<T>> GetAllAsync(Expression<Func<T, bool>>? filter = null, bool tracked = true);
        Task<T> GetAsync(Expression<Func<T, bool>>? filter = null, bool tracked = true);
        Task CreateAsync(T entity);
        Task RemoveAsync(T entity);
		
		Task SaveAsync();
	}


}
