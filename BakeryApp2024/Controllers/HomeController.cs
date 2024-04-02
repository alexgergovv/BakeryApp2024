using BakeryApp2024.Core.Contracts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using NuGet.Versioning;

namespace BakeryApp2024.Controllers
{
	public class HomeController : BaseController
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IProductService productService;
        private readonly IBakerService bakerService;

        public HomeController(ILogger<HomeController> logger,
            IProductService _productService,
            IBakerService _bakerService)
        {
            _logger = logger;
            productService = _productService;
            bakerService = _bakerService;
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
            var bakers = await bakerService.GetAllAsChipModelAsync();

            return View(bakers);
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
