using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using TermProject.Models;
using System.Drawing;

namespace TermProject.Pages
{
    public class ProcessPaymentModel : PageModel
    {
        private readonly TermProject.Data.TermProjectContext _context;

        public ProcessPaymentModel(TermProject.Data.TermProjectContext context)
        {
            _context = context;
        }

        public IList<Package> Packages { get; set; } = new List<Package>();

        public async Task OnGetAsync()
        {
            if (_context.Packages != null)
            {
                Packages = await _context.Packages.ToListAsync();
            }
        }

        public float priceSum = 0;

        public float Sum()
        {

            foreach (var item in Packages)
            {

                priceSum += item.price;
            }

            return priceSum;
        }




    }
}
