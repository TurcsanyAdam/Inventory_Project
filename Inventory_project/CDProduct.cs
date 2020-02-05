using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;


namespace Inventory_project
{
    public class CDProduct : Product
    {
        public int NumOfTracks { get; set; }

        public CDProduct()
        {

        }

        public CDProduct(string aName, int aPrice, int aSize)
        {
            name = aName;
            price = aPrice;
            NumOfTracks = aSize;
        }

    }
}
