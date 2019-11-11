using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesMovie.Backend;

namespace RazorPagesMovie.Pages
{
    public class apitest : PageModel
    {

        public IActionResult OnGet()
        {

            return Page();

        }


        private readonly Models.RazorPagesMovieContext _context;

        public apitest(Models.RazorPagesMovieContext context)
        {
            _context = context;
        }


        public async Task<IActionResult> OnPostAsync()
        {


            Models.Movie2 movie = await Backend.Api.GetMovieAsync("Joker");

            /*
            if (!ModelState.IsValid)
            {
                return Page();
            }
            */

            _context.Movie2.Add(movie);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }

    }
}
