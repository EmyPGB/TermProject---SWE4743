using Microsoft.AspNetCore.Mvc;
using TermProject.Models;

namespace TermProject.Data
{
    public class DbInitiliazer
    {
        public static void Initialize(TermProjectContext context)
        {
            var agents = new Agent[]
            {
                new Agent { FirstName = "Emely", LastName = "Guerrero", MobilePhone = "888-654-321" },
                new Agent { FirstName = "Bill", LastName = "Bryson", MobilePhone = "55-123-1234" },

            };

           


            // Look for any Packages.
            if (context.Packages.Any())
            {
                return;   // DB has been seeded
            }

            if (context.Agents.Any())
            {
                return;   // DB has been seeded
            }

        }
    }
}
