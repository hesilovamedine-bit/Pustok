using Microsoft.AspNetCore.Mvc;
using pustok.ViewModels;
using pustok.Controllers;
using pustok.Models;

namespace pustok.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {

            List<Featured> Feature = new List<Featured>();
            {
                new Featured()
                {
                    Id = 1,
                    Author = "Apple",
                    Details = "Lorem ipsun dolar",
                    Image = "product-1.jpg",
                    Price = 500,
                    PriceOld = 800,
                    PriceDiscount = 30
                };
                new Featured()
                {
                    Id = 2,
                    Author = "wpple",
                    Details = "Lorem ipsun dolar",
                    Image = "product-2.jpg",
                    Price = 500,
                    PriceOld = 800,
                    PriceDiscount = 30
                };
                new Featured()
                {
                    Id = 3,
                    Author = "epple",
                    Details = "Lorem ipsun dolar",
                    Image = "product-3.jpg",
                    Price = 500,
                    PriceOld = 800,
                    PriceDiscount = 30
                };
                new Featured()
                {
                    Id = 4,
                    Author = "tpple",
                    Details = "Lorem ipsun dolar",
                    Image = "product-4.jpg",
                    Price = 500,
                    PriceOld = 800,
                    PriceDiscount = 30
                };
                new Featured()
                {
                    Id = 5,
                    Author = "ypple",
                    Details = "Lorem ipsun dolar",
                    Image = "product-5.jpg",
                    Price = 500,
                    PriceOld = 800,
                    PriceDiscount = 30
                };
                
            }
            HomeVM vm = new HomeVM()
            {
                Featureds = Feature
            };
            return View(vm);

        }
    }
}