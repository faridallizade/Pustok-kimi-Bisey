using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Pustok_Temp.Areas.Manage.ViewModels.Book;
using Pustok_Temp.DAL;
using Pustok_Temp.Helpers;
using Pustok_Temp.Models;

namespace Pustok_Temp.Areas.Manage.Controllers
{

    [Area("Manage")]
    public class BookController : Controller
    {
        AppDbContext _context;
        private readonly IWebHostEnvironment _environment;


        public BookController(AppDbContext context, IWebHostEnvironment environment)
        {
            _context = context;
            _environment = environment;
        }
        public async Task<IActionResult> Index()
        {
            List<Book> books = await _context.Books
                  .Include(p => p.Authors)
                  .Include(p => p.BookImages)
                  .Include(b => b.BookTags)
                  .ThenInclude(t => t.Tag)
                  .ToListAsync();

            return View(books);

        }
        public async Task<IActionResult> Create()
        {
            List<Book> books = await _context.Books
                  .Include(p => p.Authors)
                  .Include(p => p.BookImages)
                  .Include(b => b.BookTags)
                  .ThenInclude(t => t.Tag).
                  ToListAsync();

            ViewBag.authors = await _context.Authors.ToListAsync();
            ViewBag.tags = await _context.Tags.ToListAsync();
            return View();

        }

        [HttpPost]
        public async Task<IActionResult> Create(CreateBookVM bookVM)
        {

            if (!bookVM.ImageFile.ContentType.Contains("image"))
            {
                ModelState.AddModelError("ImageFile", "You can only upload image file");
                return View();
            }
            if (bookVM.ImageFile.Length > 2097152)
            {
                ModelState.AddModelError("ImageFile", "You cannot upload any image more than 2MB");
                return View();
            }

            bookVM.ImgUrl = bookVM.ImageFile.Upload(_environment.WebRootPath, @"\Upload\BookImage\");

            ViewBag.authors = await _context.Authors.ToListAsync();
            ViewBag.tags = await _context.Tags.ToListAsync();

            if (!ModelState.IsValid)
            {
                return View();
            }

            List<BookTag> bookTags = new();

            foreach (int tagId in bookVM.TagIds)
            {
                Tag tag=await _context.Tags.FirstOrDefaultAsync(t=>t.Id==tagId);

                if(tag != null)
                {
                    BookTag bookTag = new()
                    {
                        Tag = tag
                    };

                    bookTags.Add(bookTag);
                }
            }

            Book book = new()
            {
                Title = bookVM.Title,
                Price = bookVM.Price,
                ImgUrl = bookVM.ImgUrl,
                AuthorId= bookVM.AuthorId,
                BookTags=bookTags
            };


            await _context.Books.AddAsync(book);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }


        public IActionResult Delete(int id)
        {

            Book book = _context.Books.Find(id);

            if (book != null)
            {
                _context.Books.Remove(book);
                _context.SaveChanges();

            }

            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Update(int id)
        {

            Book book = await _context.Books.FindAsync(id);
            return View(book);
        }

        [HttpPost]
        public IActionResult Update(Book newSlider)
        {
            Book oldSlider = _context.Books.Find(newSlider.Id);

            if (!newSlider.ImageFile.ContentType.Contains("image"))
            {
                ModelState.AddModelError("ImageFile", "You can only upload image file");
                return View();
            }



            if (newSlider.ImageFile.Length > 2097152)
            {
                ModelState.
                AddModelError("ImageFile", "You cannort upload image more than 2MB");
                return View();
            }



            FileManager.DeleteFile(oldSlider.ImgUrl, _environment.WebRootPath, @"\Upload\BookImage\");
            newSlider.ImgUrl = newSlider.ImageFile.Upload(_environment.WebRootPath, @"\Upload\BookImage\");
            if (!ModelState.IsValid)
            {
                return View();
            }


            oldSlider.Title = newSlider.Title;
            oldSlider.Price = newSlider.Price;
            oldSlider.ImgUrl = newSlider.ImgUrl;
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}