using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using DiabsolutTestProject.ViewModels;

namespace DiabsolutTestProject.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "ASP.NET 5 Rocks!";

            var serverInfo = new ServerInfoViewModel() {
                Name = Environment.MachineName,
                Software = Environment.OSVersion.ToString()
            };

            return View(serverInfo);
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact pagegagagagaga.";

            return View();
        }

        public IActionResult Error()
        {
            return View("~/Views/Shared/Error.cshtml");
        }
    }
}
