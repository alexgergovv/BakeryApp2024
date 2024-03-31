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

        public async Task DeleteAsync(int itemId)
        {
            await repository.DeleteAsync<BasketItem>(itemId);
            await repository.SaveChangesAsync();
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
               .AnyAsync(i => i.Id == id);
        }

        public async Task<BasketItem> GetByProductIdAsync(int productId, string userId)
        {
            return await repository.AllReadOnly<BasketItem>()
                .FirstAsync(i => i.ProductId == productId && i.UserId == userId);
        }

        public async Task<ItemFormModel?> GetItemFormModelByIdAsync(int id)
        {
            return await repository.AllReadOnly<BasketItem>()
                 .Where(i => i.Id == id)
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
                .Where(i => i.UserId == userId)
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
                .Where (i => i.UserId == userId)
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
