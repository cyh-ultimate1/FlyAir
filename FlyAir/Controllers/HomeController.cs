using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FlyAir.Models;
using FlyAir.Data.IRepositories;
using FlyAir.Models.SearchModels;
using Serilog;

namespace FlyAir.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICountryRepo _countryRepo;

        public HomeController(ICountryRepo countryRepo)
        {
            _countryRepo = countryRepo;
        }

        public IActionResult Index()
        {
            HttpContext.Session.Remove("searchFlightTemp");
            var vm = new SearchFlight
            {
                DepartDate = DateTime.Today,
                ReturnDate = DateTime.Today
            };
            return View(vm);
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
