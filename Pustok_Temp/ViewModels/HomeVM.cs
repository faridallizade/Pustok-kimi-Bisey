using Pustok_Temp.Models;

namespace Pustok_Temp.ViewModels
{
    public class HomeVM
    {
        public List<Author> Authors { get; set; }
        public List<Book> Books { get; set; }
        public List<BookImg> BooksImg { get; set;}
        public List<Category> Categories { get; set; }
        public List<Slider> Sliders {  get; set; }

        public List<ParentCategory> ParentCategories { get; set; }

    }
}
