using BakeryApp2024.Core.Contracts;
using BakeryApp2024.Core.Models.BasketItem;
using BakeryApp2024.Core.Models.Order;
using BakeryApp2024.Infrastructure.Data.Common;
using BakeryApp2024.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakeryApp2024.Core.Services
{
	public class OrderService: IOrderService
	{
		private readonly IRepository repository;

        public OrderService(IRepository _repository)
        {
            repository = _repository;
        }

		public async Task CreateAsync(OrderFormModel model, string userId)
		{
			int number = GetRandomNumber();
			decimal totalPrice = GetTotalPrice(model.BasketItems);
			List<int> ids = await GetIds(model.BasketItems, userId);

			Order order = new Order()
			{
				Number = number,
				CustomerName = model.CustomerName,
				CustomerAddress = model.CustomerAddress,
				CustomerEmail = model.CustomerEmail,
				City = model.City,
				Country = model.Country,
				ZipCode = model.ZipCode,
				TotalPrice = totalPrice,
				Date = DateTime.Now,
				Status = "Pending",
				UserId = userId,
				BasketItemIds = string.Join(",", ids)
			};

			await repository.AddAsync(order);
			await repository.SaveChangesAsync();
		}


		public async Task<IEnumerable<OrderViewModel>> GetOrdersByUserIdAsync(string userId)
        {
            var orders = await repository.AllReadOnly<Order>()
                .Where(o => o.UserId == userId)
                .OrderByDescending(o => o.Date)
                .Select(o => new OrderViewModel()
                {
                    CustomerName = o.CustomerName,
                    Number = o.Number,
                    Date = o.Date.ToShortDateString(),
                    TotalPrice = o.TotalPrice,
					OrderStatus = o.Status
                })
                .ToListAsync();

            await SeedBasketItems(orders);

			return orders;
        }

        private async Task SeedBasketItems(List<OrderViewModel> orders)
        {
            foreach (var order in orders)
            {
                var current = await repository.AllReadOnly<Order>()
                    .Where(o => o.Number == order.Number)
                    .FirstOrDefaultAsync();

                if (current != null)
                {
                    List<int> ids = current.BasketItemIds
                        .Split(",", StringSplitOptions.RemoveEmptyEntries)
                        .Select(int.Parse)
                        .ToList();

                    foreach (int id in ids)
                    {
                        var basketItem = await repository.AllReadOnly<BasketItem>()
                            .Where(i => i.Id == id)
                            .Select(i => new ItemFormModel()
                            {
                                ProductName = i.ProductName,
                                Quantity = i.Quantity,
                                Price = i.Price,
								ImageUrl = i.ImageUrl
                            })
                            .FirstOrDefaultAsync();

                        if (basketItem != null)
                        {
                            order.BasketItems.Add(basketItem);
                        }
                    }
                }
            }
        }

		private async Task<List<int>> GetIds(IEnumerable<ItemFormModel> items, string userId)
		{
			List<int> ids = new List<int>();

			foreach (var item in items)
			{
				var current = await repository.AllReadOnly<BasketItem>()
					.Where(i => i.UserId == userId && i.ProductName == item.ProductName)
					.FirstOrDefaultAsync();

				if (current != null)
				{
					ids.Add(current.Id);
				}
			}

			return ids;
		}

		private static decimal GetTotalPrice(IEnumerable<ItemFormModel> items)
		{
			decimal totalPrice = 0;

			foreach (var item in items)
			{
				totalPrice += item.Price * item.Quantity;
			}

			return totalPrice;
		}

		private static int GetRandomNumber()
		{
			Random r = new Random();
			string randomStringNumber = string.Empty;

			for (int i = 0; i < 9; i++)
			{
				randomStringNumber += r.Next(0, 9).ToString();
			}

			int number = int.Parse(randomStringNumber);
			return number;
		}
    }
}
