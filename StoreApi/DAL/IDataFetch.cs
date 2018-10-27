using StoreApi.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreApi.Data
{
    interface IDataFetch
    {
        void AddProduct(IProduct product);
        IProduct RemoveProduct(IProduct product);
        bool RemoveProduct(int id);
        IProduct GetProductById(int id);
        List<IProduct> GetData();
    }
}
