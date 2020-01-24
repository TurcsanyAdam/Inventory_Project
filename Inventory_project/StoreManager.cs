using System;
using System.Collections.Generic;
using System.Text;

namespace Inventory_project
{
    class StoreManager : StorageCapable
    {
        StorageCapable storageCapable;
        public StoreManager(StorageCapable storageCapable)
        {
            this.storageCapable = storageCapable;
        }
    }
}
