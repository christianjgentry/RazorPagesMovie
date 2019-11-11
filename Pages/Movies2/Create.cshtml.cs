using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RazorPagesMovie.Models;

namespace RazorPagesMovie.Pages.Movies2
{
    public class CreateModel : PageModel
    {
        private readonly RazorPagesMovie.Models.RazorPagesMovieContext _context;

        public CreateModel(RazorPagesMovie.Models.RazorPagesMovieContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Movie2 Movie2 { get; set; }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {

            string[] title = Movie2.Title.Split();

            List<string> newtitle = new List<string>();
            int counter = 0;

            foreach (var word in title)
            {
                if (counter != 0 || counter != title.Length - 1)
                {

                    newtitle.Add(word);
                    newtitle.Add("+");

                }
                else
                {
                    newtitle.Add(word);
                }

                counter = counter++;
            }




            Movie2 movie = await Backend.Api.GetMovieAsync(Movie2.Title);


            if (!ModelState.IsValid)
            {
                return Page();
            }


            _context.Movie2.Add(movie);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
