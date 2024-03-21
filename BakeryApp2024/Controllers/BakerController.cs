using BakeryApp2024.Core.Contracts;
using BakeryApp2024.Core.Models.Baker;
using Microsoft.AspNetCore.Mvc;

namespace BakeryApp2024.Controllers
{
    public class BakerController : BaseController
	{

		private readonly IBakerService bakerService;

        public BakerController(IBakerService _bakerService)
        {
				bakerService = _bakerService;
        }

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
