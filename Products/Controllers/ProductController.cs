using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Products.BL.Contracts;
using Products.DomainModel;
using Products.Model;

namespace Products.Controllers
{
    [Route("api/Product")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IMapper mapper;
        private readonly IProduct blProduct;

        public ProductController(IMapper mapper, IProduct product)
        {
            this.mapper = mapper;
            this.blProduct = product;
        }

        // GET: api/Product
        [HttpGet]
        public IEnumerable<ProductModel> Get()
        {
            var products = blProduct.GetProducts();
            return mapper.Map<IEnumerable<Product>, IEnumerable<ProductModel>>(products);
        }

        // GET: api/Product/5
        [HttpGet("{id}")]
        public IEnumerable<ProductModel> Get(int userId)
        {
            var products = blProduct.GetUserProducts(userId);
            return mapper.Map<IEnumerable<Product>, IEnumerable<ProductModel>>(products);
        }

        // POST: api/Product
        [HttpPost]
        public void Post([FromBody] ProductModel product)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
