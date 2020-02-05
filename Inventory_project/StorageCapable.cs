using System;
using System.Collections.Generic;
using System.Text;

namespace Inventory_project
{
    interface StorageCapable
    {
        List<Product> getAllProduct();
        void storeCdProduct(string name, int price, int tracks);
        void storeBookProduct(string name, int price, int pages);

    }
}
