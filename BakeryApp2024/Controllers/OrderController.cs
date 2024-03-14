using BakeryApp2024.Core.Models.Order;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BakeryApp2024.Controllers
{
	[Authorize]
	public class OrderController : Controller
	{
		public async Task<IActionResult> Mine()
		{
			var model = new MyOrdersQueryModel();

			return View(model);
		}
		[HttpGet]
		public async Task<IActionResult> Cancel(int id)
		{
			var model = new OrderDetailsViewModel();

			return View(model);
		}

		[HttpPost]
		public async Task<IActionResult> Cancel(OrderDetailsViewModel model)
		{
			return RedirectToAction(nameof(Mine));
		}
	}
}
