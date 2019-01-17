using Products.DomainModel;
using Products.Persistence.Contracts;
using Products.Persistence.Contracts.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Products.Persistence.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext dbContext;
        public UnitOfWork(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        private IUserRepository _User;

        private IProductRepository _Product;
        public IUserRepository User
        {
            get
            {
                if (this._User == null)
                {
                    this._User = new UserRepository(dbContext);
                }
                return this._User;
            }
        }
        public IProductRepository Product
        {
            get
            {
                if (this._Product == null)
                {
                    this._Product = new ProductRepository(dbContext);
                }
                return this._Product;
            }
        }
        public async Task<int> CompleteAsync()
        {
            return await dbContext.SaveChangesAsync();
        }
        public int Complete()
        {
            return dbContext.SaveChanges();
        }
        public void Dispose() => dbContext.Dispose();

    }
}
