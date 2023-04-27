using Microsoft.AspNetCore.Mvc;
using TermProject.Models;


namespace TermProject.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Update (Agent model)
        {

            var Fname = model.FirstName;

            return RedirectToAction("Index");
        }


    }
}
