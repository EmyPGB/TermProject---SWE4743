﻿using System;
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
    public class IndexModel : PageModel
    {
        private readonly TermProject.Data.TermProjectContext _context;

        public IndexModel(TermProject.Data.TermProjectContext context)
        {
            _context = context;
        }

        public IList<Agent> Agent { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Agents != null)
            {
                Agent = await _context.Agents.ToListAsync();
            }
        }
    }
}
