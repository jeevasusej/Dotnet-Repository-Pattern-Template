using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Products.Persistence.Contracts.UnitOfWork
{
    public interface IUnitOfWork
    {
        IUserRepository User { get; }
        IProductRepository Product { get; }
        Task<int> CompleteAsync();
        int Complete();
    }
}
