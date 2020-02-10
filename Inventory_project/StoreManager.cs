using System;
using System.Collections.Generic;
using System.Text;

namespace Inventory_project
{
    class StoreManager
    {
        StorageCapable storageCapable;

        public void addStorage(StorageCapable storage)
        {
            storageCapable = storage;
        }

        public void addCDProduct(string name, int price, int tracks)
        {
            storageCapable.storeCdProduct(name, price, tracks);
        }        
        public void addBookProduct(string name, int price, int pages)
        {
            storageCapable.storeCdProduct(name, price, pages);

        }
        public void listProducts()
        {
            foreach(Product product in storageCapable.getAllProduct())
            {
                Console.WriteLine(product);
            }
        }

        public int GetTotalProductPrice()
        {
            int result = 0;
            foreach(Product product in storageCapable.getAllProduct())
            {
                result += product.price;
            }
            return result;
        }
    }
}
