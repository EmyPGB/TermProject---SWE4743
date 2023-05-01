using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using TermProject.Data;
using TermProject.Models;

namespace TermProject.Pages
{
    public class TripsModel : PageModel
    {
        private readonly TermProject.Data.TermProjectContext _context;

        public TripsModel(TermProject.Data.TermProjectContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Trip Trip { get; set; } = default!;
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid || _context.Trips == null || Trip == null)
            {
                return Page();
            }

            _context.Trips.Add(Trip);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
