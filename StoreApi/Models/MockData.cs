using System;
namespace StoreApi.Models
{
    public static class MockData
    {

        public static Product GetData(){
            return new Product() { Id = 1, Name = "Amit", Description = "Amit is a smart guy", Price = 500 };
        }

    }
}
