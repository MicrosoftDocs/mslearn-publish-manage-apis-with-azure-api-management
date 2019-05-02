using Models.ShoeCompanyTypes;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Threading;

namespace ShoeCompany.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        /// <summary>
        /// Retrieve the details of every product sold 
        /// </summary>
        // GET: api/products
        [HttpGet(Name = "GetProducts")]
        public IEnumerable<Product> Get()
        {
            Product[] data = new Product[100];

            // Return dummy data
            for (int i = 0; i < 100; i++)
            {
                data[i] = new Product();
            }
            return data;
        }

        /// <summary>
        /// Find the details of the specified product
        /// </summary>
        // GET: api/products/productid
        [HttpGet("{productid}", Name = "GetProductDetails")]
        public Product Get(int productid)
        {
            // Return dummy data
            return new Product();
        }
    }
}
