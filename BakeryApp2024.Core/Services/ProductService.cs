using BakeryApp2024.Core.Contracts;
using BakeryApp2024.Core.Models.Home;
using BakeryApp2024.Infrastructure.Data.Common;
using BakeryApp2024.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
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

		public async Task<IEnumerable<ProductIndexServiceModel>> GetThreeProducts()
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
