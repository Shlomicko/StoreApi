using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreApi.DAL
{
    public interface IProduct
    {
        string Name
        {
            get;
            set;
        }


        int Id
        {
            get;
            set;
        }

        int Price
        {
            get;
            set;
        }


        string Description
        {
            get;
            set;
        }

    }
}
