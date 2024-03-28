using BakeryApp2024.Core.Models.Product;
using BakeryApp2024.Infrastructure.Data.Models;

namespace System.Linq
{
    public static class IQueryableProductExtension
    {
        public static IQueryable<ProductServiceModel> ProjectToProductServiceModel(this IQueryable<Product> products)
        {
            return products
                .Select(p => new ProductServiceModel()
                {
                    Id = p.Id,
                    Name = p.Name,
                    ImageUrl = p.ImageUrl,
                    Price = p.Price
                });
        }
    }
}
