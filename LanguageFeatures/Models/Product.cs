using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanguageFeatures.Models
{
    public class Product
    {
        public Product(bool inStock = true)
        {
            InStock = inStock;
        }
        public string Name { get; set; }
        public decimal? Price { get; set; }
        public bool InStock { get; }
        public string Category { get; set; } = "Water sports";
        public Product Related { get; set; }
        public bool NameBeginsWithS => Name?[0] == 'S';
        public static Product[] GetProducts()
        {
            Product kayak = new Product
            {
                Name = "Kayak", Price = 275M
            };
            Product lifejacket = new Product
            {
                Name = "Lifejacket", Price = 34.32M
            };
            return new Product[] { kayak, lifejacket, null};
        }

    }
}
