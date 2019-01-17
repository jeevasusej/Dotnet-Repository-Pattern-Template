using Products.BL.Contracts;
using Products.DomainModel;
using Products.Persistence.Contracts.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Text;

namespace Products.BL
{
    public class BLProduct : IProduct
    {
        private readonly IUnitOfWork uow;
        public BLProduct(IUnitOfWork uow)
        {
            this.uow = uow;
        }
        public void DeleteProduct(long productId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetProducts()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetUserProducts(long userId)
        {
            throw new NotImplementedException();
        }

        public void UpsertProduct(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
