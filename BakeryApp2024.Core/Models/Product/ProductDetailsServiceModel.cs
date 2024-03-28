using BakeryApp2024.Core.Models.Baker;

namespace BakeryApp2024.Core.Models.Product
{
    public class ProductDetailsServiceModel: ProductServiceModel
    {
        public string Description { get; set; } = null!;

        public string Category { get; set; } = null!;

        public BakerServiceModel Baker { get; set; } = null!;
    }
}
