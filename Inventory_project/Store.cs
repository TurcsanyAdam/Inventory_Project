using System;
using System.Collections.Generic;
using System.Text;

namespace Inventory_project
{
    abstract class Store
    {
        private void SaveToXml(Product product)
        {

        }

        protected void storeProduct(Product product)
        {

        }
        protected Product createProduct(string type, string name, int price, int size)
        {
            Product product;
            switch (type.ToLower())
            {
                case "cd":
                    product = new CDProduct();
                    return product;
                case "book":
                    product = new BookProduct();
                    return product;
                default:
                    throw new ArgumentException();
            }
        }

        public List<Product> loadProducts()
        {
            List<Product> a = new List<Product>();
            return a;
        }

        public void store(Product product)
        {

        }
    }
}
