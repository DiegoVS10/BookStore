using System;

namespace BookStore.Domain.UoW.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        bool Commit();
    }
}
