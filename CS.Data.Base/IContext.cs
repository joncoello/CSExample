using System;

namespace CS.Data.Base
{
    public interface IContext<T> : IDisposable where T : class
    {
        int SaveChanges();
        void SetModified(object entity);
        void SetAdd(object entity);
    }
}