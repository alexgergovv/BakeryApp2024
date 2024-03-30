using BakeryApp2024.Core.Models.Order;
using BakeryApp2024.Core.Models.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakeryApp2024.Core.Contracts
{
	public interface IOrderService
	{
		public Task CreateAsync(OrderFormModel model, string userId);

		public Task<IEnumerable<OrderViewModel>> GetOrdersByUserIdAsync(string userId);
	}
}
