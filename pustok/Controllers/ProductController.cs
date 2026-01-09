using Microsoft.AspNetCore.Mvc;

namespace pustok.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Detail(int id)
        {
            return View();
        }
    }
}
