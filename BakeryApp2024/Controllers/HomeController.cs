using BakeryApp2024.Core.Contracts;
using BakeryApp2024.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BakeryApp2024.Controllers
{
    public class HomeController : BaseController
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IProductService productService;

        public HomeController(ILogger<HomeController> logger,
            IProductService _productService)
        {
            _logger = logger;
            productService = _productService;
        }

        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            var model = await productService.GetThreeProductsAsync();

            return View(model);
        }

        [AllowAnonymous]
        public async Task<IActionResult> Contacts()
        {
            return View();
        }

        [AllowAnonymous]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error(int statusCode)
        {
            if (statusCode == 400)
            {
                return View("Error400");
            }

            if (statusCode == 401)
            {
                return View("Error401");
            }

            return View();
        }
    }
}
