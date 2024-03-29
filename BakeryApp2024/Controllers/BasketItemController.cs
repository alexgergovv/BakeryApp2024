using BakeryApp2024.Core.Contracts;
using BakeryApp2024.Core.Models.BasketItem;
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
			var items = await basketItemService.MineByIdAsync(User.Id());

			return View(items);
		}

		[HttpGet]
		public async Task<IActionResult> Remove(int id)
		{
			var model = new ItemsDetailsViewModel();

			return View(model);
		}

		[HttpPost]
		public async Task<IActionResult> Remove(ItemsDetailsViewModel model)
		{
			return RedirectToAction(nameof(Mine));
		}
	}
}
