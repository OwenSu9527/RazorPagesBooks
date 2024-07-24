using Microsoft.EntityFrameworkCore;
using RazorPagesBooks.Data;

namespace RazorPagesBooks.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RazorPagesBooksContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<RazorPagesBooksContext>>()))
            {
                if (context == null || context.Book == null)
                {
                    throw new ArgumentNullException("Null RazorPagesBooksContext");
                }

                // Look for any movies.
                if (context.Book.Any())
                {
                    return;   // DB has been seeded
                }

                context.Book.AddRange(
                    new Book
                    {
                        ProductNo = "X001",
                        ProductName = "BOOK1",
                        Type = "TypeA",
                        PublicationDate = DateTime.Parse("1989-2-12"),
                        Price = 0
                    },

                    new Book
                    {
                        ProductNo = "X002",
                        ProductName = "BOOK2",
                        Type = "TypeB",
                        PublicationDate = DateTime.Parse("1989-2-12"),
                        Price = 0
                    },

                    new Book
                    {
                        ProductNo = "X003",
                        ProductName = "BOOK3",
                        Type = "TypeC",
                        PublicationDate = DateTime.Parse("1989-2-12"),
                        Price = 0
                    },

                    new Book
                    {
                        ProductNo = "X004",
                        ProductName = "BOOK4",
                        Type = "TypeD",
                        PublicationDate = DateTime.Parse("1989-2-12"),
                        Price = 0
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
