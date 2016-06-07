using System;

namespace CS.Data.Base
{
    public interface IUnitOfWork : IDisposable
    {
        int Save();
        IContext Context { get; }

    }
}