using FirstWebApi.DAL;
using FirstWebApiModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstWebApi.Service
{
    public static class ProductService
    {

        public static List<product> GetAllProducts()
        {
            return ProductDAL.GetAllProducts();
        }

        public static bool AddProduct(product Product)
        {
            return ProductDAL.AddProduct(Product);
        }
    }
}
