﻿using BakeryApp2024.Attributes;
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
