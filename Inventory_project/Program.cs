using System;

namespace Inventory_project
{
    class Program
    {
        static void Main(string[] args)
        {
            StorageCapable storageCapable = new CsvStore();

            StoreManager storeManager = new StoreManager();
            storeManager.addStorage(storageCapable);
            storeManager.addCDProduct("ABC", 20, 20);
            storeManager.addCDProduct("ABCfawfawf", 10, 10);
            storeManager.addBookProduct("ABCcacac", 200, 200);
            storeManager.addBookProduct("ABCacaw", 203, 203);
            Console.WriteLine(storeManager.GetTotalProductPrice());
        }
    }
}
