namespace Pustok_Temp.Models
{
    public class BookImg
    {
        public int Id { get; set; }
        public string? ImgUrl { get; set; }
        public int? BookId { get; set; }
        public Book? Book { get; set; }
    }
}
