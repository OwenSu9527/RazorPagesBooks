using System.ComponentModel.DataAnnotations;

namespace RazorPagesBooks.Models
{
    public class Book
    {
        public int Id { get; set; }
        [Required]
        [StringLength(20, MinimumLength = 3)]
        public string ProductNo { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 3)]
        public string ProductName { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 3)]
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        public string Type { get; set; }
        [Required]
        [Range(1, 1000000)]
        [DataType(DataType.Currency)]
        public int Price { get; set; }

        [Display(Name = "Publication Date")]
        [DataType(DataType.Date)]
        public DateTime PublicationDate { get; set; }
        [Range(1, 100)]
        public string Rating { get; set; } = string.Empty;
    }
}
