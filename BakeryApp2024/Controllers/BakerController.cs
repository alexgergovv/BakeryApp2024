using BakeryApp2024.Attributes;
using BakeryApp2024.Core.Contracts;
using BakeryApp2024.Core.Models.Baker;
using BakeryApp2024.Extensions;
using Microsoft.AspNetCore.Mvc;
using static BakeryApp2024.Core.Constants.MessageConstants;

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
        [NotABaker]
		public IActionResult Become()
		{
			var model = new BecomeBakerFormModel();

			return View(model);
		}

		[HttpPost]
		[NotABaker]
		public async Task<IActionResult> Become(BecomeBakerFormModel model)
		{
			if (await bakerService.UserWithPhoneNumberExistsAsync(model.PhoneNumber))
			{
				ModelState.AddModelError(nameof(model.PhoneNumber), PhoneExists);
			}

            if (ModelState.IsValid == false)
			{
				return View(model);
			}

			await bakerService.CreateAsync(User.Id(), model.Name, model.PhoneNumber);

			return RedirectToAction(nameof(ProductController.All), "Product");
		}
	}
}
