using BakeryApp2024.Core.Models.Order;

namespace BakeryApp2024.Core.Contracts
{
	public interface IOrderService
	{
		public Task CreateAsync(OrderFormModel model, string userId);

		public Task<IEnumerable<OrderViewModel>> GetOrdersByUserIdAsync(string userId);
	}
}
