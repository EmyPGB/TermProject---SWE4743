using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TermProject.Data;
using TermProject.Models;

namespace TermProject.Pages
{
    public class DeleteModel : PageModel
    {
        private readonly TermProject.Data.TermProjectContext _context;

        public DeleteModel(TermProject.Data.TermProjectContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Package Package { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Packages == null)
            {
                return NotFound();
            }

            var package = await _context.Packages.FirstOrDefaultAsync(m => m.ID == id);

            if (package == null)
            {
                return NotFound();
            }
            else 
            {
                Package = package;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Packages == null)
            {
                return NotFound();
            }
            var package = await _context.Packages.FindAsync(id);

            if (package != null)
            {
                Package = package;
                _context.Packages.Remove(Package);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
