using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Blogs.Instrastucture.Interfaces
{
    public  interface IGenericRepositoryAsync<T> where T:class
    {
        Task<IReadOnlyList<T>> GatAllAsync();

        Task<T> GatidByAsync(Expression<Func<T, bool>> expression, IList<string> includes);

        Task<IReadOnlyList<T>> GetPagedListAsync(int pageNumber, int pageSize);
        Task<T> AddAsync(T entity);

        Task UpdateAsync(T entity);

        Task DeleteAsync(T entity);


    }
}
