using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesBooks.Data;
using RazorPagesBooks.Models;

namespace RazorPagesBooks.Pages.Books
{
    public class IndexModel : PageModel
    {
        private readonly RazorPagesBooks.Data.RazorPagesBooksContext _context;

        public IndexModel(RazorPagesBooks.Data.RazorPagesBooksContext context)
        {
            _context = context;
        }

        public IList<Book> Book { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Book = await _context.Book.ToListAsync();
        }
    }
}
