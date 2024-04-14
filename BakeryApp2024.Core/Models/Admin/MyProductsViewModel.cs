using BakeryApp2024.Core.Models.Product;

namespace BakeryApp2024.Core.Models.Admin
{
    public class MyProductsViewModel
    {
        public IEnumerable<ProductServiceModel> AddedProducts { get; set; } = new List<ProductServiceModel>();
    }
}
