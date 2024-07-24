using System.ComponentModel.DataAnnotations;

namespace RazorPagesBooks.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string ProductNo { get; set; }
        public string ProductName { get; set; }
        public string Type { get; set; }
        public int Price { get; set; }
        [DataType(DataType.Date)]
        public DateTime PublicationDate { get; set; }
    }
}
