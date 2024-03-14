using BakeryApp2024.Core.Models.Baker;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BakeryApp2024.Controllers
{
	[Authorize]
	public class BakerController : Controller
	{
		[HttpGet]
		public async Task<IActionResult> Become()
		{
			var model = new BecomeBakerFormModel();

			return View(model);
		}

		[HttpPost]
		public async Task<IActionResult> Become(BecomeBakerFormModel model)
		{
			return RedirectToAction(nameof(ProductController.All), "Product");
		}
	}
}
