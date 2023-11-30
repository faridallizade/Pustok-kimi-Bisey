using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Contracts;
using Pustok_Temp.Models;
using Microsoft.AspNetCore.Identity;

namespace Pustok_Temp.Areas.Manage.ViewModels.Book
{
    public class CreateBookVM
    {

        public string? Title { get; set; }


        [StringLength(maximumLength: 100)]
        public string? ImgUrl { get; set; }

        public double? Price { get; set; }
        public int? AuthorId { get; set; }
        public Author? author { get; set; }
        public IFormFile? ImageFile { get; set; }
        public List<int> TagIds { get; set; }
        [Required]
        public IFormFile? MainPhoto {  get; set; }
        [Required]
        public IFormFile? HoverPhoto { get; set; }
        public List<IFormFile>? Photos {  get; set; }
        

    }
}
