namespace Pustok_Temp.Models
{
    public class Tags
    {
        public int id { get; set; }
        public string Name { get; set; }
        public List<BookTags>? BookTags { get; set; }
    }
}
