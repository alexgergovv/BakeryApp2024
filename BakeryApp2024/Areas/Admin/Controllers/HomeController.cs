using Microsoft.AspNetCore.Mvc;

namespace BakeryApp2024.Areas.Admin.Controllers
{
    public class HomeController : AdminBaseController
    {
        public IActionResult DashBoard()
        {
            return View();
        }

		public async Task<IActionResult> ForReview()
		{
			return View();
		}
	}
}
