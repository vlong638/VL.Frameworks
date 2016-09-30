using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Mvc;

namespace VL.WebAPI.Controllers
{
    public class ProductController : ApiController
    {
        Product[] products = new Product[]{
            new Product { Id = 1, Name = "Tomato Soup", Category = "Groceries", Price = 1 },
            new Product { Id = 2, Name = "Yo-yo", Category = "Toys", Price = 3.75M },
            new Product { Id = 3, Name = "Hammer", Category = "Hardware", Price = 16.99M }
        };

        public IEnumerable<Product> Get()//GetAllProducts
        {
            return products;
        }

        public Product Get(int id)//GetProduct
        {
            var product = products.FirstOrDefault((p) => p.Id == id);
            if (product == null)
            {
                throw new NotImplementedException("Not Found");
            }
            return product;
        }

        public class Product
        {
            public string Category { get; internal set; }
            public int Id { get; internal set; }
            public string Name { get; internal set; }
            public decimal Price { get; internal set; }
        }
    }
}