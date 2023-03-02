using Blogs.Instrastucture.Context;
using Blogs.Instrastucture.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Blogs.Instrastucture.Repositories
{
    public class GenericRepositoryAsync<T> : IGenericRepositoryAsync<T> where T : class
    {
        private readonly ApplicationDbContext _dBContext;

        public GenericRepositoryAsync(ApplicationDbContext dbContext)
        {
            _dBContext = dbContext;
        }
        public virtual  async  Task<T> AddAsync(T entity)
        {
           await _dBContext.Set<T>().AddAsync(entity);
            await SaveChangesAsync();
            return entity;
        }

        public virtual  async  Task DeleteAsync(T entity)
        {
            _dBContext.Remove(entity);

            await SaveChangesAsync();

        }

        public virtual  async  Task<IReadOnlyList<T>> GatAllAsync()
        {
            return await _dBContext.Set<T>().ToListAsync();
        }

        public virtual  async  Task<T> GatidByAsync(Expression<Func<T,bool>> expression,IList<string> includes)
        {
            IQueryable<T> entity = _dBContext.Set<T>();
            foreach (var include in includes)
            {
                entity = entity.Include(include);
            }
            return await entity.FirstOrDefaultAsync(expression);
        }

        public virtual  async  Task<IReadOnlyList<T>> GetPagedListAsync(int pageNumber, int pageSize)
        {
            return await _dBContext.Set<T>()
                .Skip((pageNumber - 1) * pageSize)
                .Take(pageSize)
                .AsNoTracking()
                .ToListAsync();
        }

        public virtual  async  Task UpdateAsync(T entity)
        {
            _dBContext.Entry(entity).State = EntityState.Modified;
            await SaveChangesAsync();
        }
        public async Task<bool> SaveChangesAsync()
        {
           return  await _dBContext.SaveChangesAsync() >=0;
            
        }
    }
}
