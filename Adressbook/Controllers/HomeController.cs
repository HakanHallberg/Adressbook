using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Adressbook.Models;
using Adressbook.Interfaces;
using Microsoft.Extensions.Localization;
using Adressbook.Resources;

namespace Adressbook.Controllers
{
    public class HomeController : Controller
    {
        private ITimeProvider timeProvider;
        
        public HomeController(ITimeProvider _timeProvider)
        {
            timeProvider = _timeProvider;
            
        }

        public IActionResult Index()
        {
            ViewBag.Time = timeProvider.Now.ToString();
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
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
