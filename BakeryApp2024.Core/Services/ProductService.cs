using BakeryApp2024.Core.Contracts;
using BakeryApp2024.Core.Enumerations;
using BakeryApp2024.Core.Models.Home;
using BakeryApp2024.Core.Models.Product;
using BakeryApp2024.Infrastructure.Data.Common;
using BakeryApp2024.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace BakeryApp2024.Core.Services
{
    public class ProductService : IProductService
	{
		private readonly IRepository repository;
		public ProductService(IRepository _repository)
		{
			repository = _repository;
		}

        public async Task<ProductQueryServiceModel> AllAsync(string? category = null, string? searchTerm = null, ProductSorting sorting = ProductSorting.NameAlphabetically, int currentPage = 1, int productsPerPage = 3)
        {
			var productsToShow = repository.AllReadOnly<Product>();

			if (category != null)
			{
				productsToShow = productsToShow
					.Where(p => p.Category.Name == category);
			}

			if (searchTerm != null)
			{
				productsToShow = productsToShow
					.Where(p => p.Name.ToLower().Contains(searchTerm.ToLower()) ||
					p.Description.ToLower().Contains(searchTerm.ToLower()));
			}

			productsToShow = sorting switch
			{
				ProductSorting.NameAlphabetically => productsToShow
				.OrderBy(p => p.Name),
				ProductSorting.PriceAscending => productsToShow
				.OrderBy(p => p.Price),
				ProductSorting.PriceDescending => productsToShow
				.OrderByDescending(p => p.Price),
				_ => productsToShow
				.OrderByDescending(p => p.Id)
			};

			var products = await productsToShow
				.Skip((currentPage - 1) * productsPerPage)
				.Take(productsPerPage)
				.ProjectToProductServiceModel()
                .ToListAsync();

			int totalProducts = await productsToShow.CountAsync();

			return new ProductQueryServiceModel()
			{
				TotalProductsCount = totalProducts,	
				Products = products
			};
        }

        public async Task<IEnumerable<ProductCategoryServiceModel>> AllCategoriesAsync()
        {
			return await repository.AllReadOnly<Category>()
			  .Select(c => new ProductCategoryServiceModel()
			  {
				  Id = c.Id,
				  Name = c.Name,
			  })
			  .ToListAsync();
		}

        public async Task<IEnumerable<string>> AllCategoriesNamesAsync()
        {
            return await repository.AllReadOnly<Category>()
				.Select(c => c.Name)
				.Distinct()
				.ToListAsync();
        }

        public async Task<bool> CategoryExistsAsync(int categoryId)
        {
			return await repository.AllReadOnly<Category>()
				.AnyAsync(c => c.Id == categoryId);
		}

        public async Task<int> CreateAsync(ProductFormModel model, int bakerId)
        {
			Product product = new Product()
			{
				Name = model.Name,
				Description = model.Description,
				ImageUrl = model.ImageUrl,
				Price = model.Price,
				CategoryId = model.CategoryId,
				BakerId = bakerId,
			};

			await repository.AddAsync(product);
			await repository.SaveChangesAsync();

			return product.Id;
		}

        public async Task<bool> ExistsAsync(int id)
        {
            return await repository
				.AllReadOnly<Product>()
				.AnyAsync(p => p.Id == id);
        }

        public async Task<IEnumerable<ProductIndexServiceModel>> GetThreeProductsAsync()
		{
			return await repository
				.AllReadOnly<Product>()
				.Take(3)
				.Select(p => new ProductIndexServiceModel()
				{
					Id = p.Id,
					Name = p.Name,
					ImageUrl = p.ImageUrl,
				})
				.ToListAsync();
		}

        public async Task<ProductDetailsServiceModel> ProductDetailsByIdAsync(int id)
        {
			return await repository.AllReadOnly<Product>()
				 .Where(p => p.Id == id)
				 .Select(p => new ProductDetailsServiceModel()
				 {
					 Id = id,
					 Name = p.Name,
					 ImageUrl = p.ImageUrl,
					 Price = p.Price,
					 Baker = new Models.Baker.BakerServiceModel()
					 {
						 PhoneNumber = p.Baker.PhoneNumber,
						 Email = p.Baker.User.Email
					 },
					 Category = p.Category.Name,
					 Description = p.Description
				 })
				 .FirstAsync();
        }
    }
}
