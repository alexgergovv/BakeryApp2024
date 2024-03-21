using BakeryApp2024.Core.Models.Product;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BakeryApp2024.Controllers
{
	public class ProductController : BaseController
	{
		[AllowAnonymous]
		[HttpGet]
		public async Task<IActionResult> All()
		{
			var model = new AllProductsQueryModel();

			return View(model);
		}

		[HttpGet]
		public async Task<IActionResult> Details(int id)
		{
			var model = new ProductDetailsViewModel();

			return View(model);
		}

		[HttpGet]
        public async Task<IActionResult> Add()
        {
            return View();
        }

        [HttpPost]
		public async Task<IActionResult> Add(ProductFormModel model)
		{
			return RedirectToAction(nameof(Details), new { id = "1" });
		}

		[HttpGet]
		public async Task<IActionResult> Edit(int id)
		{
			var model = new ProductFormModel();

			return View(model);
		}

		[HttpPost]
		public async Task<IActionResult> Edit(int id, ProductFormModel model)
		{
			return RedirectToAction(nameof(Details), new { id = "1" });
		}


		[HttpGet]
		public async Task<IActionResult> Delete(int id)
		{
			var model = new ProductDetailsViewModel();

			return View(model);
		}

		[HttpPost]
		public async Task<IActionResult> Delete(ProductDetailsViewModel model)
		{
			return RedirectToAction(nameof(Details), new { id = "1" });
		}

		[HttpPost]
		public async Task<IActionResult> Buy(int id)
		{
			return RedirectToAction(nameof(OrderController.Mine), "Order");
		}
	}
}
