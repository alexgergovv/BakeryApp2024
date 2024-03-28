using BakeryApp2024.Attributes;
using BakeryApp2024.Core.Contracts;
using BakeryApp2024.Core.Models.Product;
using BakeryApp2024.Extensions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BakeryApp2024.Controllers
{
	public class ProductController : BaseController
	{
		private readonly IProductService productService;

		private readonly IBakerService bakerService;

		public ProductController(IProductService _productService, IBakerService _bakerService)
		{
			productService = _productService;
			bakerService = _bakerService;
		}

		[AllowAnonymous]
		[HttpGet]
		public async Task<IActionResult> All([FromQuery]AllProductsQueryModel model)
		{
			var products = await productService.AllAsync(
				model.Category,
				model.SearchTerm,
				model.Sorting,
				model.CurrentPage,
				model.ProductsPerPage
				);

			model.TotalProductsCount = products.TotalProductsCount;
			model.Products = products.Products;
			model.Categories = await productService.AllCategoriesNamesAsync();

			return View(model);
		}

		[HttpGet]
		public async Task<IActionResult> Details(int id)
		{
			if (await productService.ExistsAsync(id) == false)
			{
				return BadRequest();
			}

			var model = await productService.ProductDetailsByIdAsync(id);

			return View(model);
		}



        //[HttpPost]
        //public async Task<IActionResult> Buy(int Id)
        //{
        //	return RedirectToAction(nameof(OrderController.Mine), "Order");
        //}


        [HttpGet]
        [MustBeBaker]
        public async Task<IActionResult> Add()
		{
			var model = new ProductFormModel()
			{
				Categories = await productService.AllCategoriesAsync()
			};

			return View(model);
		}

		[HttpPost]
		public async Task<IActionResult> Add(ProductFormModel model)
		{
			if (await productService.CategoryExistsAsync(model.CategoryId) == false)
			{
				ModelState.AddModelError(nameof(model.CategoryId), "");
			}

			if (ModelState.IsValid == false)
			{
				model.Categories = await productService.AllCategoriesAsync();

				return View(model);
			}

			int? agentId = await bakerService.GetBakerIdAsync(User.Id());

			int newHouseId = await productService.CreateAsync(model, agentId ?? 0);

			return RedirectToAction(nameof(Details), new { id = newHouseId });
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
			var model = new ProductDetailsServiceModel();

			return View(model);
		}

		[HttpPost]
		public async Task<IActionResult> Delete(ProductDetailsServiceModel model)
		{
			return RedirectToAction(nameof(Details), new { id = "1" });
		}
	}
}
