using Microsoft.AspNetCore.Mvc;
using Pustok_Temp.DAL;
using Pustok_Temp.ViewModels;

namespace Pustok_Temp.Controllers
{
    public class HomeController : Controller
    {
        private AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            HomeVM homeVM = new HomeVM()
            {
                Authors = _context.Authors.ToList(),
                Books = _context.Books.ToList(),
                BooksImg = _context.Bookimages.ToList(),
                Categories = _context.Categories.ToList(),
                Sliders = _context.Sliders.ToList(),
            };
            return View(homeVM);
        }
    }
}
