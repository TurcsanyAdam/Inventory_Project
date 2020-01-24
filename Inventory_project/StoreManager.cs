using System;
using System.Collections.Generic;
using System.Text;

namespace Inventory_project
{
    class StoreManager : StorageCapable
    {
        StorageCapable storageCapable;
        public StoreManager()
        {
            
        }

        public void addStorage(StorageCapable storage)
        {
            storageCapable = storage;
        }

        public void addCDProduct(string name, int price, int tracks)
        {

        }        
        public void addBookProduct(string name, int price, int pages)
        {

        }
        public string listProducts()
        {
            return "";
        }

        public int GetTotalProductPrice()
        {
            return 0;
        }
    }
}
