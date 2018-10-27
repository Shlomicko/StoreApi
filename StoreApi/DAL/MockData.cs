using System;
using System.Linq;
using System.Collections.Generic;
using StoreApi.DAL;

namespace StoreApi.Data
{
    public class MockData : IDataFetch
    {
        private static int Id { get; set; } = 0;

        private List<IProduct> products = new List<IProduct>();


        public void AddProduct(IProduct product)
        {
            Id++;
            product.Id = Id;
            products.Add(product);
        }

        public IProduct RemoveProduct(IProduct product)
        {
            products.Remove(product);
            return product;
        }

        public bool RemoveProduct(int id)
        {
        
            products.Remove(GetProductById(id));
            return true;
        }


        public IProduct GetProductById(int id)
        {
            IProduct product = products.Where(producta => producta.Id == id).FirstOrDefault();
            return product;
        }


        public List<IProduct> GetData()
        {
            return products;
        }




    }
}
