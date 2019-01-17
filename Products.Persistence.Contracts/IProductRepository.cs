using Products.DomainModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Products.Persistence.Contracts
{
    public interface IProductRepository
    {
        void AddProduct(Product product);
        Product GetProduct(long id);
        IEnumerable<Product> GetProducts();
        bool DeleteProduct(long productId);
        IEnumerable<Product> GetUserProducts(long userId);
    }
}
