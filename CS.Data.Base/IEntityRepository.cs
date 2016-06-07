using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace CS.Data.Base
{
    public interface IEntityRepository<T> : IDisposable
    {
        Task<IEnumerable<T>> AllAsync();
        IQueryable<T> AllIncluding(params Expression<Func<T, object>>[] includeProperties);
        Task<T> Find(int id);
        void InsertOrUpdate(T entity);
        void Delete(int id);
    }
}