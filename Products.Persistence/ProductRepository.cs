using Products.DomainModel;
using Products.Persistence.Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Products.Persistence
{
    public class ProductRepository : IProductRepository
    {
        private readonly AppDbContext context;

        public ProductRepository(AppDbContext dbContext)
        {
            this.context = dbContext;
        }

        public void AddProduct(Product product)
        {
            context.Products.Add(product);
        }

        public bool DeleteProduct(long productId)
        {
            var removed = false;
            Product product = GetProduct(productId);
            if (product != null)
            {
                removed = true;
                context.Products.Remove(product);
            }

            return removed;
        }

        public Product GetProduct(long id)
        {
            return context.Products.Where(p => p.Id == id).FirstOrDefault();
        }

        public IEnumerable<Product> GetProducts()
        {
            return context.Products;
        }

        public IEnumerable<Product> GetUserProducts(long userId)
        {
            throw new NotImplementedException();
        }
    }
}
