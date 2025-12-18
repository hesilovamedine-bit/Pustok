using Microsoft.AspNetCore.Mvc;

namespace pustok.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
