using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesBooks.Models;

namespace RazorPagesBooks.Data
{
    public class RazorPagesBooksContext : DbContext
    {
        public RazorPagesBooksContext (DbContextOptions<RazorPagesBooksContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesBooks.Models.Book> Book { get; set; } = default!;
    }
}
