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
    public class TripsModel : PageModel
    {
        private readonly TermProject.Data.TermProjectContext _context;

        public TripsModel(TermProject.Data.TermProjectContext context)
        {
            _context = context;
        }

        public IList<Trip> Trip { get; set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Trips != null)
            {
                Trip = await _context.Trips.ToListAsync();
            }
        }

    }
}
