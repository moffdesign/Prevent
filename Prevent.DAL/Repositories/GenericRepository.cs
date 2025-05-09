using Microsoft.EntityFrameworkCore;
using Prevent.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prevent.DAL.Repositories
{
	public class GenericRepository<T> : IGenericRepository<T> where T : class
	{
		private readonly PreventDbContext _databaseContext;
		private readonly DbSet<T> _dbSet;

		public GenericRepository(PreventDbContext context)
		{
			_databaseContext = context;
			_dbSet = context.Set<T>();
		}

		public async Task AddAsync(T entity)
		{
			await _dbSet.AddAsync(entity);
			await SaveAsync();
		}

		public async Task DeleteByIdAsync(int id)
		{
			var entityToDelete = await _dbSet.FindAsync(id);

			if (entityToDelete != null)
			{
				_dbSet.Remove(entityToDelete);
				await SaveAsync();
			}
		}
        public async Task<T?> GetByIdAsync(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async Task<List<T>> GetAllAsync(bool tracked = true)
        {
            IQueryable<T> query = _dbSet;

            if (!tracked)
            {
                query = query.AsNoTracking();
            }

            return await query.ToListAsync();
        }

		public async Task UpdateAsync(T entity)
		{
			_dbSet.Update(entity);
			await SaveAsync();
		}

		public async Task SaveAsync()
		{
			await _databaseContext.SaveChangesAsync();
		}
	}
}
