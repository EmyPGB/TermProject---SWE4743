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
    public class ViewTravelersModel : PageModel
    {
        private readonly TermProjectContext _context;

        public ViewTravelersModel(TermProjectContext context)
        {
            _context = context;
        }

        public IList<Traveler> Traveler { get; set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Travelers != null)
            {
                Traveler = await _context.Travelers.ToListAsync();
            }
        }
    }
}
