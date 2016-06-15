using System;

namespace CS.Data.Base
{
    public interface IContext<T> : IDisposable
    {
        int SaveChanges();
        void SetModified(object entity);
        void SetAdd(object entity);
    }
}