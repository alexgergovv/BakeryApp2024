using BakeryApp2024.Core.Contracts;
using BakeryApp2024.Core.Models.BasketItem;
using BakeryApp2024.Infrastructure.Data.Common;
using BakeryApp2024.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace BakeryApp2024.Core.Services
{
	public class BasketItemService : IBasketItemService
	{
		private readonly IRepository repository;
        public BasketItemService(IRepository _repository)
        {
				repository = _repository;
        }

        public async Task AddItemAsync(BasketItem model)
		{
			await repository.AddAsync(model);
			await repository.SaveChangesAsync();
		}

		public Task DeleteAsync(int productId)
		{
			throw new NotImplementedException();
		}

		public async Task<BasketItem> GetByProductIdAsync(int productId)
		{
			return await repository.AllReadOnly<BasketItem>()
				.FirstAsync(i => i.ProductId == productId);
		}

		public async Task IncreaseQuantity(int itemId)
		{
			var item = await repository.GetByIdAsync<BasketItem>(itemId);
			item.Quantity += 1;

			await repository.SaveChangesAsync();
		}

		public async Task<IEnumerable<ItemsDetailsViewModel>> MineByIdAsync(string userId)
		{
			return await repository
				.AllReadOnly<BasketItem>()
				.Where(i => i.UserId == userId)
				.Select(i => new ItemsDetailsViewModel()
				{
					Id = i.Id,
					ProductName = i.Product.Name,
					Price = i.Product.Price,
					ImageUrl = i.Product.ImageUrl,
					Quantity = i.Quantity
				})
				.ToListAsync();
		}

		public async Task<bool> ProductItemExistsByIdAsync(int productId)
		{
			return await repository
				.AllReadOnly<BasketItem>()
				.AnyAsync(i => i.ProductId == productId);
		}
	}
}
