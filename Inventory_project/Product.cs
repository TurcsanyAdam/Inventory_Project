using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using System.Xml.Serialization;

namespace Inventory_project
{
    public abstract class Product
    {
        public string name { get; set; }
        public int price { get; set; }


    }
}
