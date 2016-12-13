using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult PACKTContact()
        {
            ViewData["Message"] = "PACKT Company Data";

            var viewModel = new Models.PACKTAddress()
            {
                Company = "Packt Publishing Limited",
                Street = "2nd Floor, Livery Place, 35 Livery Street",
                City = "Birmingham",
                Country = "UK"
            };
            return View(viewModel);
        }


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
