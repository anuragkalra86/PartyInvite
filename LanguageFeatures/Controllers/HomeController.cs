using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LanguageFeatures.Models;
using Microsoft.AspNetCore.Mvc;

namespace LanguageFeatures.Controllers
{
    public class HomeController : Controller
    {
        //public IActionResult Index()
        //{
        //    ShoppingCart cart = new ShoppingCart {Products = Product.GetProducts()};
        //    Product[] productArray =
        //    {
        //        new Product {Name = "Kayak", Price = 258M},
        //        new Product {Name = "Lifejavaket", Price = 40M}
        //    };
        //    Func<Product, bool> filterByName = delegate(Product product)
        //    {
        //        if (product?.Name?[0] == 'L')
        //        {
        //            return true;
        //        }
        //        return false;
        //    };
        //    decimal cartTotal = cart.GetTotal();
        //    decimal arrayTotal = productArray.GetTotal();
        //    int minThreshold = 50;
        //    decimal expensiveTotal = productArray.Filter(s => (s?.Price??0) > minThreshold).GetTotal();
        //    decimal namedTotal = productArray.Filter(filterByName).GetTotal();

        //    return View("Index", new string[] {$"Cart total: {cartTotal:C2}", $"Array total: {arrayTotal:C2}", $"Expensive total: {expensiveTotal:C2}", $"Namd total: {namedTotal:C2}" });
        //}
        public async Task<IActionResult> Index()
        {
            ShoppingCart cart = new ShoppingCart { Products = Product.GetProducts() };
            Product[] productArray =
            {
                    new Product {Name = "Kayak", Price = 258M},
                    new Product {Name = "Lifejavaket", Price = 40M}
            };
            return View("Index", productArray.Select(p => $"Product {nameof(p.Name)}: {p.Name}, Price: {p.Price}"));
        }

        private bool FilterByPrice(Product product)
        {
            if ((product?.Price ?? 0) > 50M)
            {
                return true;
            }

            return false;
        }
    }
}