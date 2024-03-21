using BakeryApp2024.Core.Models.Home;
using BakeryApp2024.Core.Models.Product;

namespace BakeryApp2024.Core.Contracts
{
	public interface IProductService
	{
		Task<IEnumerable<ProductIndexServiceModel>> GetThreeProductsAsync();

		Task<IEnumerable<ProductCategoryServiceModel>> AllCategoriesAsync();

		Task<bool> CategoryExistsAsync(int categoryId);

		Task<int> CreateAsync(ProductFormModel model, int bakerId);
	}
}
