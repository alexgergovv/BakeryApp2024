using BakeryApp2024.Attributes;
using BakeryApp2024.Core.Contracts;
using BakeryApp2024.Core.Extensions;
using BakeryApp2024.Core.Models.Product;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace BakeryApp2024.Controllers
{
	public class ProductController : BaseController
	{
		private readonly IProductService productService;

		private readonly IBakerService bakerService;

		private readonly IBasketItemService basketItemService;

		public ProductController(IProductService _productService,
			IBakerService _bakerService,
			IBasketItemService _basketItemService)
		{
			productService = _productService;
			bakerService = _bakerService;
			basketItemService = _basketItemService;
		}

		[AllowAnonymous]
		[HttpGet]
		public async Task<IActionResult> All([FromQuery] AllProductsQueryModel model)
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
		public async Task<IActionResult> Details(int id, string information)
		{
			if (await productService.ExistsAsync(id) == false)
			{
                return RedirectToAction("Error", "Home", new { statusCode = 400 });
            }

			var model = await productService.ProductDetailsByIdAsync(id);

			if (information != model.GetName())
			{
				return RedirectToAction("Error", "Home", new { statusCode = 400 });
			}

			return View(model);
		}

		[HttpPost]
		public async Task<IActionResult> Buy(int id)
		{
			if (await productService.ExistsAsync(id) == false)
			{
				return RedirectToAction("Error", "Home", new { statusCode = 400 });
			}

			var product = await productService.GetByIdAsync(id);

			if (await basketItemService.ProductItemExistsByIdAsync(product.Id, User.Id()) == false)
			{
				await basketItemService.AddItemAsync(product, User.Id());
			}
			else
			{
				var item = await basketItemService.GetByProductIdAsync(product.Id, User.Id());

				await basketItemService.IncreaseQuantity(item.Id);
			}

			return RedirectToAction(nameof(BasketItemController.Mine), "BasketItem");
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
				ModelState.AddModelError(nameof(model.CategoryId), "Category does not exist");
			}

			if (ModelState.IsValid == false)
			{
				model.Categories = await productService.AllCategoriesAsync();

				return View(model);
			}

			int? agentId = await bakerService.GetBakerIdAsync(User.Id());

			int newHouseId = await productService.CreateAsync(model, agentId ?? 0);

			return RedirectToAction(nameof(Details), new { id = newHouseId, Information = model.GetName() });
		}

		[HttpGet]
		public async Task<IActionResult> Edit(int id)
		{
			if (await productService.ExistsAsync(id) == false)
			{
                return RedirectToAction("Error", "Home", new { statusCode = 400 });
            }

			if (await productService.HasBakerWithIdAsync(id, User.Id()) == false)
			{
                return RedirectToAction("Error", "Home", new { statusCode = 401 });
            }

			var model = await productService.GetProductFormModelByIdAsync(id);

			return View(model);
		}

		[HttpPost]
		public async Task<IActionResult> Edit(int id, ProductFormModel model)
		{
			if (await productService.ExistsAsync(id) == false)
			{
                return RedirectToAction("Error", "Home", new { statusCode = 400 });
            }

			if (await productService.HasBakerWithIdAsync(id, User.Id()) == false)
			{
                return RedirectToAction("Error", "Home", new { statusCode = 401 });
            }

			if (await productService.CategoryExistsAsync(model.CategoryId) == false)
			{
				ModelState.AddModelError(nameof(model.CategoryId), "Category does not exist");
			}

			if (ModelState.IsValid == false)
			{
				model.Categories = await productService.AllCategoriesAsync();

				return View(model);
			}

			await productService.EditAsync(id, model);

			return RedirectToAction(nameof(Details), new { id, Information = model.GetName() });
		}


		[HttpGet]
		public async Task<IActionResult> Delete(int id)
		{
            if (await productService.ExistsAsync(id) == false)
            {
                return RedirectToAction("Error", "Home", new { statusCode = 400 });
            }

            if (await productService.HasBakerWithIdAsync(id, User.Id()) == false)
            {
				return RedirectToAction("Error", "Home", new { statusCode = 401 });
            }

			var product = await productService.ProductDetailsByIdAsync(id);

			var model = new ProductDetailsViewModel()
			{
				Id = id,
				Name = product.Name,
				Description = product.Description,
				ImageUrl = product.ImageUrl
			};

            return View(model);
		}

		[HttpPost]
		public async Task<IActionResult> Delete(ProductDetailsServiceModel model)
		{
            if (await productService.ExistsAsync(model.Id) == false)
            {
                return RedirectToAction("Error", "Home", new { statusCode = 400 });
            }

            if (await productService.HasBakerWithIdAsync(model.Id, User.Id()) == false)
            {
                return RedirectToAction("Error", "Home", new { statusCode = 401 });
            }

			await productService.DeleteAsync(model.Id);

            return RedirectToAction(nameof(All));
		}
	}
}
