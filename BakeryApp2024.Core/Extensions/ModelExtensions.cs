using BakeryApp2024.Core.Contracts;
using System.Text.RegularExpressions;

namespace BakeryApp2024.Core.Extensions
{
	public static class ModelExtensions
	{
		public static string GetName(this IProductModel product)
		{
			string name = product.Name.Replace(" ", "-");

			return name;
		}
	}
}
