using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.CodeAnalysis.Options;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using TermProject.Data;
using TermProject.Models;



namespace TermProject.Pages
{
    public class ViewPackagesModel : PageModel
    {
        private readonly TermProject.Data.TermProjectContext _context;

        public ViewPackagesModel(TermProject.Data.TermProjectContext context)
        {
            _context = context;
        }

        public IList<Package> Package { get;set; } = new List<Package>();

        public async Task OnGetAsync()
        {
            if (_context.Packages != null)
            {
                Package = await _context.Packages.ToListAsync();
            }
        }

        public float priceSum = 0;

      public float Sum()
        {

            foreach (var item in Package) {

                 priceSum += item.price; 
            }

            return priceSum;
        }

    }


}
