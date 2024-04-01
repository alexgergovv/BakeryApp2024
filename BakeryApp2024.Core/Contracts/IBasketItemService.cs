using BakeryApp2024.Core.Models.BasketItem;
using BakeryApp2024.Infrastructure.Data.Models;

namespace BakeryApp2024.Core.Contracts
{
	public interface IBasketItemService
	{
		Task<IEnumerable<ItemsDetailsViewModel>> MineByUserIdAsync(string userId);

		Task AddItemAsync(Product product, string userId);

		Task DeleteAsync(int productId);

		Task<bool> ProductItemExistsByIdAsync(int productId, string userId); 

		Task<BasketItem> GetByProductIdAsync(int productId, string userId);

		Task IncreaseQuantity(int itemId);

		Task<bool> ExistsAsync(int id);

		Task<ItemFormModel?> GetItemFormModelByIdAsync(int id);

        Task EditAsync(int itemId, ItemFormModel model);

		Task<IEnumerable<ItemFormModel>> ProjectToItemFormModel(IEnumerable<ItemsDetailsViewModel> items);

		Task DeleteByUserIdAsync(string userId);
    }
}
