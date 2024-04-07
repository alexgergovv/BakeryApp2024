using BakeryApp2024.Core.Contracts;

namespace BakeryApp2024.Core.Models.Product
{
    public class ProductDetailsViewModel: IProductModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string ImageUrl {  get; set; } = string.Empty;   
    }
}
