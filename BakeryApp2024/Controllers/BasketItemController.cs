using BakeryApp2024.Core.Contracts;
using BakeryApp2024.Core.Models.BasketItem;
using BakeryApp2024.Core.Services;
using BakeryApp2024.Extensions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BakeryApp2024.Controllers
{
	[Authorize]
	public class BasketItemController : Controller
	{
		private readonly IBasketItemService basketItemService;
        public BasketItemController(IBasketItemService _basketItemService)
        {
            basketItemService = _basketItemService;
        }

        public async Task<IActionResult> Mine()
		{
			var items = await basketItemService.MineByUserIdAsync(User.Id());

			return View(items);
		}

		[HttpGet]
		public async Task<IActionResult> Remove(int id)
		{
			await basketItemService.DeleteAsync(id);

			return RedirectToAction("Mine");
		}

		[HttpGet]
		public async Task<IActionResult> Edit(int id)
		{
            if (await basketItemService.ExistsAsync(id) == false)
            {
                return RedirectToAction("Error", "Home", new { statusCode = 400 });
            }

			var model = await basketItemService.GetItemFormModelByIdAsync(id);

            return View(model);
        }

		[HttpPost]
		public async Task<IActionResult> Edit(int id, ItemFormModel model)
		{
			if (await basketItemService.ExistsAsync(id) == false)
			{
				return RedirectToAction("Error", "Home", new { statusCode = 400 });
			}

            await basketItemService.EditAsync(id, model);

            return RedirectToAction(nameof(Mine));
        }
	}
}
