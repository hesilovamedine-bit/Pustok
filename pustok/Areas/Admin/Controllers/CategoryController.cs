using pustok.DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using pustok.Models.pustok.Models;

namespace pustok.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        private readonly AppDbContext _context;

        public CategoryController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {


            return View(await _context.Categories.ToListAsync());
        }
        public IActionResult Test()
        {
            string result = Guid.NewGuid().ToString();
            return Content(result);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Category category)
        {
            //if (!ModelState.IsValid)
            //{
            //    return View();
            //}

            //bool result = await _context.Categories.AnyAsync(p => p.Name == category.Name);
            //if (result)
            //{
            //    ModelState.AddModelError("Name", "Bu name sistemde var");
            //    return View();
            //}

            //if (!category.Photo.ContentType.Contains("image/"))
            //{
            //    ModelState.AddModelError("Photo", "Siz uygun formatda file elave etmirsiz.");
            //    return View();
            //}

            //if (category.Photo.Length > 2 * 1024 * 1024)
            //{
            //    ModelState.AddModelError("Photo", "Siz duzgun hecmde file elave etmirsiz.");
            //    return View();
            //}

            //string fileName = String.Concat(Guid.NewGuid().ToString(), category.Photo.FileName);
            //string path = "C:\\Users\\USER\\source\\tasklar\\classtask\\classtask\\wwwroot\\assets\\image\\" + fileName;
            //FileStream fileStream = new(path, FileMode.Create);
            //await category.Photo.CopyToAsync(fileStream);
            //fileStream.Close();
            //category.Image = fileName;


            await _context.AddAsync(category);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");

        }

        public async Task<IActionResult> Update(int? id)
        {
            if (id == null || id < 1)
            {
                return BadRequest();
            }

            Category category = await _context.Categories.FirstOrDefaultAsync(c => c.Id == id);


            if (category == null)
            {
                return NotFound();
            }
            return View(category);
        }


        [HttpPost]
        public async Task<IActionResult> Update(int? id, Category category)
        {
            if (id == null || id < 1)
            {
                return BadRequest();
            }

            Category exists = await _context.Categories.FirstOrDefaultAsync(c => c.Id == id);


            if (exists == null)
            {
                return NotFound();
            }

            if (!ModelState.IsValid)
            {
                return View();
            }

            bool result = await _context.Categories.AnyAsync(c => c.Name == category.Name);
            if (result)
            {
                ModelState.AddModelError("Name", "Bu category var artiq");
                return View();
            }

            exists.Name = category.Name;
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");

        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || id < 1)
            {
                return BadRequest();
            }
            Category category = await _context.Categories.FirstOrDefaultAsync(p => p.Id == id);


            if (category == null)
            {
                return NotFound();
            }

            if (!category.IsDeleted)
            {
                category.IsDeleted = true;
            }
            else
            {
                _context.Categories.Remove(category);
            }


            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Detail(int? id)
        {
            if (id == null || id < 1)
            {
                return BadRequest();
            }
            Category category = await _context.Categories.FirstOrDefaultAsync(p => p.Id == id);

            if (category == null)
            {
                return NotFound();
            }
            return View(category);
        }

    }
}