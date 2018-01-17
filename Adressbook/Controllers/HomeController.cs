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
        private readonly IStringLocalizerFactory factory;
        private readonly IStringLocalizer localizer;
        private readonly IStringLocalizer<HomeController> homeLocalizer;

        public HomeController(ITimeProvider _timeProvider, IStringLocalizerFactory factory, IStringLocalizer<HomeController> homeLocalizer)
        {
            this.homeLocalizer = homeLocalizer;

            timeProvider = _timeProvider;

            this.factory = factory;
            localizer = factory.Create(typeof(SharedResources));
        }


        public IActionResult Index()
        {
            ViewBag.Time = timeProvider.Now.ToString();
            return View();
        }



        public IActionResult About()
        {
            ViewData["Message"] = localizer["About"];

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = homeLocalizer["Your contact page."];

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Cool()
        {
            CoolViewModel m = new CoolViewModel { CoolMessage = "Really cool message" };
            return View(m);
        }
    }
}
