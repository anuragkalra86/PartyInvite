using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LanguageFeatures.Models
{
    public static class MyExtensionMethods
    {
        public static decimal GetTotal(this IEnumerable<Product> products)
        {
            decimal total = 0;
            foreach (Product product in products)
            {
                total += product?.Price ?? 0;
            }
            return total;
        }

        public static IEnumerable<Product> FilterByPrice(this IEnumerable<Product> products, decimal minimumPrice)
        {
            foreach (Product product in products)
            {
                if (product?.Price >= minimumPrice)
                {
                    yield return product;
                }
            }
        }

        public static IEnumerable<Product> Filter(this IEnumerable<Product> products, Func<Product, bool> selector)
        {
            foreach (Product product in products)
            {
                if (selector(product))
                {
                    yield return product;
                }
            }
        }
        public static IEnumerable<Product> Filter(this IEnumerable<Product> products, int threshold, Func<Product,int, bool> selector)
        {
            foreach (Product product in products)
            {
                if (selector(product, threshold))
                {
                    yield return product;
                }
            }
        }
    }
}
