using Dapper;
using FirstWebApiModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstWebApi.DAL
{
    public static class ProductDAL
    {
        public static readonly string conString = "Data Source = JAGADEESH;Initial Catalog=SampleDB;User id=jagadeesh;Password=asdfghjk;";
        public static List<product> GetAllProducts()
        {
            List<product> products = new List<product>();

            using (SqlConnection connection = new SqlConnection(conString))
            {
                products = connection.Query<product>("SELECT [Id] ,[ProductName] ,[SupplierId] ,[UnitPrice] ,[Package] ,[IsDiscontinued] FROM [SampleDB].[dbo].[Product]").ToList();
            }
            return products;
        }

        public static bool AddProduct(product Product)
        {
            bool isSuccess = false;
            try
            {
                using (SqlConnection connection = new SqlConnection(conString))
                {
                    string sqlQuery = @"INSERT INTO [dbo].[Product] ([ProductName] ,[SupplierId],[UnitPrice],[Package],[IsDiscontinued])
                                            VALUES (@ProductName,@SupplierId,@UnitPrice,@Package,@IsDiscontinued)";

                    connection.Execute(sqlQuery, new
                    {
                        ProductName = Product.ProductName,
                        SupplierId = Product.SupplierId,
                        UnitPrice = Product.UnitPrice,
                        Package = Product.Package,
                        IsDiscontinued = Product.IsDiscontinued
                    });
                    isSuccess = true;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }


            return isSuccess;
        }
    }
}
