using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using pustok.DAL;
using pustok.Models;
using pustok.ViewModels;
using pustok.DAL;
using pustok.ViewModels;

namespace pustok.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly AppDbContext _context;


        public HomeController(
            ILogger<HomeController> logger,
            AppDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            HomeVM vm = new HomeVM()
            {
                Products = await _context.Products.ToListAsync()
            };
            return View(vm);
        }

    }
}