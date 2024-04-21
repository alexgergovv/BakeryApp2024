using BakeryApp2024.Core.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace BakeryApp2024.Areas.Admin.Controllers
{
    public class HomeController : AdminBaseController
    {
        private readonly IProductService productService;
        public HomeController(IProductService _productService)
        {
            productService = _productService;
        }

        public IActionResult DashBoard()
        {
            return View();
        }

		public async Task<IActionResult> ForReview()
		{
            var underReview = await productService.GetUnApprovedAsync();
			return View(underReview);
		}
	}
}
