﻿//using BakeryApp2024.Core.Models.Home;
using BakeryApp2024.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BakeryApp2024.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            //var model = new IndexViewModel();
            //return View(model);
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
