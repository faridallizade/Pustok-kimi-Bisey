using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using Pustok_Temp.Models;

namespace Pustok_Temp.DAL
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<BookImg> Bookimages { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<BookTag> BookTags { get; set; }
        public DbSet<ParentCategory> ParentCategories{ get; set; }


    }
}
