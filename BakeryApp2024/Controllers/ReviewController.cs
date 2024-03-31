using BakeryApp2024.Core.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace BakeryApp2024.Controllers
{
	public class ReviewController : BaseController
	{
		private readonly IReviewService reviewService;
		public ReviewController(IReviewService _reviewService) 
		{
			reviewService = _reviewService;
		}

		public async Task<IActionResult> All()
		{
			var models = await reviewService.AllAsync();

			return View(models);
		}
	}
}
