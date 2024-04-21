using BakeryApp2024.Core.Enumerations;
using BakeryApp2024.Core.Models.Home;
using BakeryApp2024.Core.Models.Product;
using BakeryApp2024.Infrastructure.Data.Common;
using BakeryApp2024.Infrastructure.Data.Models;

namespace BakeryApp2024.Core.Contracts
{
	public interface IProductService
	{
		Task<IEnumerable<ProductIndexServiceModel>> GetThreeProductsAsync();

		Task<IEnumerable<ProductCategoryServiceModel>> AllCategoriesAsync();

		Task<bool> CategoryExistsAsync(int categoryId);

		Task<int> CreateAsync(ProductFormModel model, int bakerId);

		Task<ProductQueryServiceModel> AllAsync(
			string? category = null,
			string? searchTerm = null,
			ProductSorting sorting = ProductSorting.NameAlphabetically,
			int currentPage = 1,
			int productsPerPage = 3);

		Task<IEnumerable<string>> AllCategoriesNamesAsync();

		Task<bool> ExistsAsync(int id);

		Task<ProductDetailsServiceModel> ProductDetailsByIdAsync(int id);	

		Task EditAsync(int productId,  ProductFormModel model);

		Task<bool> HasBakerWithIdAsync(int productId, string userId);

		Task<ProductFormModel?> GetProductFormModelByIdAsync(int productId);

		Task DeleteAsync(int productId);

		Task<Product> GetByIdAsync(int id);

        Task<IEnumerable<ProductServiceModel>> AllProductsByBakerIdAsync(int bakerId);

        Task<IEnumerable<ProductApproveModel>> GetUnApprovedAsync();

        Task ApproveProductAsync(int productId);
    }
}
