﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Inventory_project
{
    public class CsvStore : Store
    {
        public override void storeProduct(Product product)
        {
            productList.Add(product);
        }
    }
}
