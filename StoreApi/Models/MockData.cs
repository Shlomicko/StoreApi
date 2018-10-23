using System;
using System.Linq;
using System.Collections.Generic;

namespace StoreApi.Models
{
    public static class MockData
    {
        private static int Id { get; set; } = 0;

        private static List<Product> products = new List<Product>();


        public static void AddProduct(Product product)
        {
            Id++;
            product.Id = Id;
            products.Add(product);
        }

        public static Product RemoveProduct(Product product)
        {
            products.Remove(product);
            return product;
        }

        public static bool RemoveProduct(int id)
        {
        
            products.Remove(GetProductById(id));
            return true;
        }


        public static Product GetProductById(int id)
        {
            Product product = products.Where(producta => producta.Id == id).FirstOrDefault();
            return product;
        }


        public static List<Product> GetData()
        {
            return products;
        }




    }
}
