using BakeryApp2024.Core.Contracts;
using BakeryApp2024.Core.Models.Home;
using BakeryApp2024.Core.Models.Product;
using BakeryApp2024.Infrastructure.Data.Common;
using BakeryApp2024.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace BakeryApp2024.Core.Services
{
	public class ProductService : IProductService
	{
		private readonly IRepository repository;
		public ProductService(IRepository _repository)
		{
			repository = _repository;
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
				AvailableQuantity = model.AvailableQuantity,
				CategoryId = model.CategoryId,
				BakerId = bakerId,
			};

			await repository.AddAsync(product);
			await repository.SaveChangesAsync();

			return product.Id;
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
	}
}
