using StoreApi.DAL;
using System;
namespace StoreApi.Models
{
    public class Product :IProduct
    {
        public string Name
        {
            get;
            set;
        }


        public int Id
        {
            get;
            set;
        }

        public int Price
        {
            get;
            set;
        }


        public string Description
        {
            get;
            set;
        }


       

        public Product()
        {
        }
    }
}
