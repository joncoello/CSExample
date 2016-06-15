using System;

namespace CS.Data.Base
{
    public interface IUnitOfWork<T> : IDisposable
    {
        int Save();
        IContext<T> Context { get; }

    }
}