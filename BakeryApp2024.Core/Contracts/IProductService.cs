using BakeryApp2024.Core.Models.Home;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakeryApp2024.Core.Contracts
{
	public interface IProductService
	{
		Task<IEnumerable<ProductIndexServiceModel>> GetThreeProductsAsync();
	}
}
