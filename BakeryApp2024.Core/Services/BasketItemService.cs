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

        public async Task AddItemAsync(Product product, string userId)
        {
			var item = new BasketItem()
			{
				ImageUrl = product.ImageUrl,
				Price = product.Price,
				ProductName = product.Name,
				ProductId = product.Id,
				UserId = userId,
				Quantity = 1,
                IsDeleted = false
			};

			await repository.AddAsync(item);
            await repository.SaveChangesAsync();
        }

        public async Task DeleteAsync(int itemId)
        {
            var item = await repository.GetByIdAsync<BasketItem>(itemId);
            item.IsDeleted = true;
            await repository.SaveChangesAsync();
        }

        public async Task DeleteByUserIdAsync(string userId)
        {
            var items = await repository.AllReadOnly<BasketItem>()
                .Where(i => i.UserId == userId && i.IsDeleted == false)
                .ToListAsync();

            for (int i = 0; i < items.Count; i++)
            {
                var item = await repository.GetByIdAsync<BasketItem>(items[i].Id);
                item.IsDeleted = true;
                await repository.SaveChangesAsync();
            }
        }

        public async Task EditAsync(int itemId, ItemFormModel model)
        {
            var item = await repository.GetByIdAsync<BasketItem>(itemId);

            if (item != null)
            {
                item.Quantity = model.Quantity;

                await repository.SaveChangesAsync();
            }
        }

        public async Task<bool> ExistsAsync(int id)
        {
            return await repository
               .AllReadOnly<BasketItem>()
               .AnyAsync(i => i.Id == id && i.IsDeleted == false);
        }

        public async Task<BasketItem> GetByProductIdAsync(int productId, string userId)
        {
            return await repository.AllReadOnly<BasketItem>()
                .OrderByDescending(i => i.Id)
                .FirstAsync(i => i.ProductId == productId && i.UserId == userId && i.IsDeleted == false);
        }

        public async Task<ItemFormModel?> GetItemFormModelByIdAsync(int id)
        {
            return await repository.AllReadOnly<BasketItem>()
                 .Where(i => i.Id == id && i.IsDeleted == false)
                 .Select(i => new ItemFormModel()
                 {
                     ProductName = i.ProductName,
                     Price = i.Price,
                     ImageUrl = i.ImageUrl,
                     Quantity = i.Quantity,
                 })
                 .FirstOrDefaultAsync();
        }

        public async Task IncreaseQuantity(int itemId)
        {
            var item = await repository.GetByIdAsync<BasketItem>(itemId);
            item.Quantity += 1;

            await repository.SaveChangesAsync();
        }

        public async Task<IEnumerable<ItemsDetailsViewModel>> MineByUserIdAsync(string userId)
        {
            return await repository
                .AllReadOnly<BasketItem>()
                .Where(i => i.UserId == userId && i.IsDeleted == false)
                .Select(i => new ItemsDetailsViewModel()
                {
                    Id = i.Id,
                    ProductName = i.Product.Name,
                    Price = i.Product.Price,
                    ImageUrl = i.Product.ImageUrl,
                    Quantity = i.Quantity,
                    ProductId = i.ProductId
                })
                .ToListAsync();
        }

        public async Task<bool> ProductItemExistsByIdAsync(int productId, string userId)
        {
            return await repository
                .AllReadOnly<BasketItem>()
                .Where (i => i.UserId == userId && i.IsDeleted == false)
                .AnyAsync(i => i.ProductId == productId);
        }

        public async Task<IEnumerable<ItemFormModel>> ProjectToItemFormModel(IEnumerable<ItemsDetailsViewModel> items)
        {
            return items
                .Select(i => new ItemFormModel()
                {
                    ProductName = i.ProductName,
                    Price = i.Price,
                    Quantity = i.Quantity,
                    ImageUrl = i.ImageUrl
                })
                .ToList();
        }
    }
}
