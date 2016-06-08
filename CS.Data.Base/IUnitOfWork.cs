using System;

namespace CS.Data.Base
{
    public interface IUnitOfWork<T> : IDisposable where T : class
    {
        int Save();
        IContext<T> Context { get; }

    }
}