using BakeryApp2024.Core.Contracts;
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
			Random r = new Random();
			string randomStringNumber = string.Empty;

			for (int i = 0; i < 9; i++)
			{
				randomStringNumber += r.Next(0, 9).ToString();
			}

			int number = int.Parse(randomStringNumber);

			decimal totalPrice = 0;

			foreach (var item in model.BasketItems)
			{
				totalPrice += item.Price * item.Quantity;
			}

			List<int> ids = new List<int>();

			foreach (var item in model.BasketItems)
			{
				var current = await repository.AllReadOnly<BasketItem>()
					.Where(i => i.ProductName == item.ProductName)
					.FirstOrDefaultAsync();

				if (current != null)
				{
					ids.Add(current.Id);
				}
			}

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
	}
}
