using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml.Serialization;

namespace Inventory_project
{
    [XmlRoot("Products")]
    [XmlInclude(typeof(PersistentStore))]
    [XmlInclude(typeof(BookProduct))]
    [XmlInclude(typeof(CDProduct))]
    public abstract class Store : StorageCapable
    {
        public List<Product> productList = new List<Product>();
        public static string filepath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Inventory_project.xml");

        public Store()
        {

        }
        private void SaveToXml(Product product)
        {
            using (Stream fs = new FileStream(filepath, FileMode.OpenOrCreate, FileAccess.Write, FileShare.None))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Store));
                serializer.Serialize(fs, this);
            }
        }

        public abstract void storeProduct(Product product);
        protected Product createProduct(string type, string name, int price, int size)
        {
            Product product;
            switch (type.ToLower())
            {
                case "cd":
                    product = new CDProduct(name, price, size);
                    return product;
                case "book":
                    product = new BookProduct(name, price, size);
                    return product;
                default:
                    throw new ArgumentException();
            }
        }

        public List<Product> loadProducts()
        {
            return productList;
        }

        public void store(Product product)
        {
            storeProduct(product);
            SaveToXml(product);

        }

        public List<Product> getAllProduct()
        {
            return productList;

        }

        public void storeCdProduct(string name, int price, int tracks)
        {
            Product product = createProduct("CD", name, price, tracks);
            store(product);
        }

        public void storeBookProduct(string name, int price, int pages)
        {
            Product product = createProduct("Book", name, price, pages);
            store(product);


        }
    }
}
