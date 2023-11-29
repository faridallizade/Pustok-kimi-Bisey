using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Pustok_Temp.DAL;
using Pustok_Temp.Models;

namespace Pustok_Temp.Areas.Manage.Controllers
{
    [Area("Manage")]
    public class CategoryController : Controller
    {
        AppDbContext _context;

        public CategoryController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            List<Category> Categories = await _context.Categories.Include(p => p.ParentCategory).ToListAsync();

            return View(Categories);
        }

        public IActionResult Create()
        {

            return View();

        }


        [HttpPost]
        public async Task<IActionResult> Create(Category category)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            await _context.Categories.AddAsync(category);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");

        }

        public IActionResult Update(int id)
        {

            Category category = _context.Categories.Find(id);
            return View(category);
        }

        [HttpPost]
        public IActionResult Update(Category newcategory)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            Category oldcategory = _context.Categories.Find(newcategory.Id);
            if (oldcategory == null)
            {
                return View();
            }
            oldcategory.Name = newcategory.Name;
            oldcategory.ParentCategoryId = newcategory.ParentCategoryId;
            _context.SaveChanges();


            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Delete(int id)
        {

            Category category = _context.Categories.Find(id);

            if (category != null)
            {
                _context.Categories.Remove(category);
                _context.SaveChanges();

            }

            return RedirectToAction("Index");
        }
    }
}