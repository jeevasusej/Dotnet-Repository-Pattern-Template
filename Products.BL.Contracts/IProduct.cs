using Products.DomainModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace Products.BL.Contracts
{
    public interface IProduct
    {
        void UpsertProduct(Product product);
        IEnumerable<Product> GetProducts();
        void DeleteProduct(long productId);
        IEnumerable<Product> GetUserProducts(long userId);
    }
}
