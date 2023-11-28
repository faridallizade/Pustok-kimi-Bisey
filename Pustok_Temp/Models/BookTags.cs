namespace Pustok_Temp.Models
{
    public class BookTags
    {
        public int Id { get; set; }
        public int TagId { get; set; }
        public Tags tags { get; set; }
        public int BookId { get; set; }
        public Book book { get; set; }

    }
}
