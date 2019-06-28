using FirstWebApi.Models;
using FirstWebApi.Service;
using FirstWebApiModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FirstWebApi.Controllers
{
    [RoutePrefix("api/product")]
    public class ProductController : ApiController
    {
        [Route("GetAllProducts")]
        [HttpGet]
        public List<product> GetAllProducts()
        {
            var products = ProductService.GetAllProducts();
            return products;
        }

        [Route("AddProduct")]
        [HttpPost]
        public bool AddProduct([FromBody]product Product)
        {
            return ProductService.AddProduct(Product);
        }

        [Route("GetFirstName")]
        public string GetFirstName()
        {
            return "jagadeesh";
        }
        [Route("GetLastName")]
        public string GetLastName()
        {
            return "Arnepalli";
        }
    }
}
