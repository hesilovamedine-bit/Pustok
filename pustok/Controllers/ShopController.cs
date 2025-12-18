using Microsoft.AspNetCore.Mvc;

namespace pustok.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
