﻿using BakeryApp2024.Core.Contracts;
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
            var productsToShow = repository.AllReadOnly<Product>()
                .Where(p => p.IsApproved);

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

        public async Task<IEnumerable<ProductServiceModel>> AllProductsByBakerIdAsync(int bakerId)
        {
            return await repository.AllReadOnly<Product>()
                .Where(h => h.IsApproved && h.BakerId == bakerId)
                .ProjectToProductServiceModel()
                .ToListAsync();
        }

        public async Task ApproveProductAsync(int productId)
        {
            var product = await repository.GetByIdAsync<Product>(productId);

            if (product != null && product.IsApproved == false)
            {
                product.IsApproved = true;

                await repository.SaveChangesAsync();
            }
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
                IsApproved = false
            };

            await repository.AddAsync(product);
            await repository.SaveChangesAsync();

            return product.Id;
        }

        public async Task DeleteAsync(int productId)
        {
            await repository.DeleteAsync<Product>(productId);
            await repository.SaveChangesAsync();
        }

        public async Task EditAsync(int productId, ProductFormModel model)
        {
            var product = await repository.GetByIdAsync<Product>(productId);

            if (product != null)
            {
                product.Name = model.Name;
                product.Description = model.Description;
                product.ImageUrl = model.ImageUrl;
                product.Price = model.Price;
                product.CategoryId = model.CategoryId;

                await repository.SaveChangesAsync();
            }
        }

        public async Task<bool> ExistsAsync(int id)
        {
            return await repository
                .AllReadOnly<Product>()
                .AnyAsync(p => p.Id == id);
        }

        public async Task<Product> GetByIdAsync(int id)
        {
            return await repository.GetByIdAsync<Product>(id);
        }

        public async Task<ProductFormModel?> GetProductFormModelByIdAsync(int id)
        {
            var product = await repository.AllReadOnly<Product>()
                .Where(p => p.Id == id && p.IsApproved)
                .Select(p => new ProductFormModel()
                {
                    Name = p.Name,
                    Description = p.Description,
                    ImageUrl = p.ImageUrl,
                    Price = p.Price,
                    CategoryId = p.CategoryId
                })
                .FirstOrDefaultAsync();

            if (product != null)
            {
                product.Categories = await AllCategoriesAsync();
            }

            return product;
        }

        public async Task<IEnumerable<ProductIndexServiceModel>> GetThreeProductsAsync()
        {
            return await repository
                .AllReadOnly<Product>()
                .Where(p => p.IsApproved)
                .OrderBy(p => p.Id)
                .Take(3)
                .Select(p => new ProductIndexServiceModel()
                {
                    Id = p.Id,
                    Name = p.Name,
                    ImageUrl = p.ImageUrl,
                })
                .ToListAsync();
        }

        public async Task<IEnumerable<ProductApproveModel>> GetUnApprovedAsync()
        {
            return await repository.AllReadOnly<Product>()
                .Where(p => p.IsApproved == false)
                .Select(p => new ProductApproveModel()
                {
                    Id = p.Id,
                    ImageUrl = p.ImageUrl,
                    Price = p.Price,
                    Name = p.Name,
                    Description = p.Description
                })
                .ToListAsync();
        }

        public async Task<bool> HasBakerWithIdAsync(int productId, string userId)
        {
            return await repository
                .AllReadOnly<Product>()
                .AnyAsync(p => p.Id == productId && p.Baker.UserId == userId);
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
                         FullName = $"{p.Baker.User.FirstName} {p.Baker.User.LastName}",
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
