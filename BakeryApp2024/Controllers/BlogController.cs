using BakeryApp2024.Core.Models.Blog;
using BakeryApp2024.Core.Models.Order;
using BakeryApp2024.Core.Models.Product;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BakeryApp2024.Controllers
{
	[Authorize]
	public class BlogController : Controller
	{
		[AllowAnonymous]
		[HttpGet]
		public async Task<IActionResult> All()
		{
			var model = new AllBlogsQueryModel();

			return View(model);
		}

		[HttpGet]
		public async Task<IActionResult> Details(int id)
		{
			var model = new BlogDetailsViewModel();

			return View(model);
		}

		[HttpGet]
		public async Task<IActionResult> Add()
		{
			return View();
		}

		[HttpPost]
		public async Task<IActionResult> Add(BlogFormModel model)
		{
			return RedirectToAction(nameof(Details), new { id = "1" });
		}

		[HttpGet]
		public async Task<IActionResult> Edit(int id)
		{
			var model = new BlogFormModel();

			return View(model);
		}

		[HttpPost]
		public async Task<IActionResult> Edit(int id, BlogFormModel model)
		{
			return RedirectToAction(nameof(Details), new { id = "1" });
		}


		[HttpGet]
		public async Task<IActionResult> Delete(int id)
		{
			var model = new BlogDetailsViewModel();

			return View(model);
		}

		[HttpPost]
		public async Task<IActionResult> Delete(BlogDetailsViewModel model)
		{
			return RedirectToAction(nameof(Details), new { id = "1" });
		}

		[HttpGet]
		public async Task<IActionResult> Like(int id)
		{
            return RedirectToAction(nameof(Liked));
        }

		[HttpGet]
		public async Task<IActionResult> Liked()
		{
            var model = new LikedBlogsQueryModel();

            return View(model);
        }
	}
}
