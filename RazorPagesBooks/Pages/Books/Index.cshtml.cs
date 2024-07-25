using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
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

        [BindProperty(SupportsGet = true)]
        public string? SearchString { get; set; }

        public SelectList? Types { get; set; }

        [BindProperty(SupportsGet = true)]
        public string? BookType { get; set; }

        public async Task OnGetAsync()
        {
            //var books = from m in _context.Book
            //            select m;
            //if (!string.IsNullOrEmpty(SearchString))
            //{
            //    books = books.Where(s => s.Type.Contains(SearchString));
            //}

            //Book = await books.ToListAsync();


            //Use LINQ to get list of types.

            IQueryable<string> typeQuery = from m in _context.Book
                                           orderby m.Type
                                           select m.Type;

            var books = from m in _context.Book
                        select m;

            if (!string.IsNullOrEmpty(SearchString))
            {
                books = books.Where(s => s.Type.Contains(SearchString));
            }

            if (!string.IsNullOrEmpty(BookType))
            {
                books = books.Where(x => x.Type == BookType);
            }
            Types = new SelectList(await typeQuery.Distinct().ToListAsync());
            Book = await books.ToListAsync();
        }
    }
}
