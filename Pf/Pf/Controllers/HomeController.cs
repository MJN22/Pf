using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Pf.Models;

namespace Pf.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
			//var Person = new Users();

				

			ViewData["x"] = "a wild string has appeared";
			ViewData["user"] = new Users()
			{
				FirstName = "bob",
				LastName = "Johnson",
			};

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
