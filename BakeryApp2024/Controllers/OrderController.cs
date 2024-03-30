using BakeryApp2024.Core.Contracts;
using BakeryApp2024.Extensions;
using Microsoft.AspNetCore.Mvc;

namespace BakeryApp2024.Controllers
{
	public class OrderController: BaseController
	{
        private readonly IOrderService orderService;
        public OrderController(IOrderService _orderService)
        {
              orderService = _orderService;
        }

        [HttpGet]
        public async Task<IActionResult> History()
        {
            var orders = await orderService.GetOrdersByUserIdAsync(User.Id());

            return View(orders);
        }
    }
}
