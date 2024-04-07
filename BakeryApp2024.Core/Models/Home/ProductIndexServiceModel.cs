using BakeryApp2024.Core.Contracts;

namespace BakeryApp2024.Core.Models.Home
{
	public class ProductIndexServiceModel: IProductModel
	{
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string ImageUrl { get; set; } = string.Empty;
    }
}
