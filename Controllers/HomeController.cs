using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebDevFinal.Models;

namespace WebDevFinal.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "This is me";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Contact Me";

            return View();
        }

        public IActionResult Games()
        {
            ViewData["Message"] = "List of Games";

            return View();
        }

        public IActionResult Design()
        {
            ViewData["Message"] = "My Design Rational";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
