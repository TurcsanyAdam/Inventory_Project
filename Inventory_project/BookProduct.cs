using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Inventory_project
{
    public class BookProduct : Product
    {
        public int NumOfPages { get; set; }

        public BookProduct()
        {

        }


        public BookProduct(string aName, int aPrice, int aSize)
        {
            name = aName;
            price = aPrice;
            NumOfPages = aSize;
        }

    }
}
