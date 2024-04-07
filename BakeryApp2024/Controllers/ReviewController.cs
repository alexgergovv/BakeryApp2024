using BakeryApp2024.Core.Contracts;
using BakeryApp2024.Core.Models.Review;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace BakeryApp2024.Controllers
{
	public class ReviewController : BaseController
	{
		private readonly IReviewService reviewService;
		public ReviewController(IReviewService _reviewService)
		{
			reviewService = _reviewService;
		}

		[HttpGet]
		public async Task<IActionResult> Add()
		{
			var model = new ReviewFormModel();

			return View(model);
		}

		[HttpPost]
		public async Task<IActionResult> Add(ReviewFormModel model)
		{
			await reviewService.CreateAsync(model, User.Id());

			return RedirectToAction(nameof(All));
		}

		[AllowAnonymous]
		public async Task<IActionResult> All()
		{
			var models = await reviewService.AllAsync();

			return View(models);
		}
	}
}
