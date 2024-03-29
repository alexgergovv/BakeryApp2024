using BakeryApp2024.Core.Models.BasketItem;
using BakeryApp2024.Core.Models.Product;
using BakeryApp2024.Infrastructure.Data.Models;

namespace BakeryApp2024.Core.Contracts
{
	public interface IBasketItemService
	{
		Task<IEnumerable<ItemsDetailsViewModel>> MineByUserIdAsync(string userId);

		Task AddItemAsync(BasketItem model);

		Task DeleteAsync(int productId);

		Task<bool> ProductItemExistsByIdAsync(int productId); 

		Task<BasketItem> GetByProductIdAsync(int productId);

		Task IncreaseQuantity(int itemId);

		Task<bool> ExistsAsync(int id);

		Task<ItemFormModel?> GetItemFormModelByIdAsync(int id);

        Task EditAsync(int itemId, ItemFormModel model);
    }
}
