using BakeryApp2024.Controllers;
using BakeryApp2024.Core.Contracts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Security.Claims;

namespace BakeryApp2024.Attributes
{
	public class MustBeBakerAttribute : ActionFilterAttribute
	{
		public override void OnActionExecuting(ActionExecutingContext context)
		{
			base.OnActionExecuting(context);

			IBakerService? bakerService = context.HttpContext.RequestServices.GetService<IBakerService>();

			if (bakerService == null)
			{
				context.Result = new StatusCodeResult(StatusCodes.Status500InternalServerError);
			}

			if (bakerService != null && 
				bakerService.ExistsByIdAsync(context.HttpContext.User.Id()).Result == false)
			{
				context.Result = new RedirectToActionResult(nameof(BakerController.Become), "Baker", null);
			}
		}
	}
}
