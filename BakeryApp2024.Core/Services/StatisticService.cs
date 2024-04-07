using BakeryApp2024.Core.Contracts;
using BakeryApp2024.Core.Models.Statistics;
using BakeryApp2024.Infrastructure.Data.Common;
using BakeryApp2024.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace BakeryApp2024.Core.Services
{
	public class StatisticService : IStatisticService
	{
		private readonly IRepository repository;
        public StatisticService(IRepository _repository)
        {
            repository = _repository;
        }
        public async Task<StatisticServiceModel> TotalAsync()
		{
			int totalProducts = await repository.AllReadOnly<Product>()
				.CountAsync();

			int breadProductsCount = await repository.AllReadOnly<Product>()
				.Where(p => p.Category.Name == "Bread")
				.CountAsync();

			int pastryProductsCount = await repository.AllReadOnly<Product>()
				.Where(p => p.Category.Name == "Pastry")
				.CountAsync();

			int cakeProductsCount = await repository.AllReadOnly<Product>()
				.Where(p => p.Category.Name == "Cake")
				.CountAsync();

			return new StatisticServiceModel()
			{
				TotalProducts = totalProducts,
				BreadProductsCount = breadProductsCount,
				PastryProductsCount = pastryProductsCount,
				CakeProductsCount = cakeProductsCount
			};
		}
	}
}
