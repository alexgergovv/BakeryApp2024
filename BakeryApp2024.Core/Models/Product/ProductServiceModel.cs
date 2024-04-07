using System.ComponentModel.DataAnnotations;
using static BakeryApp2024.Infrastructure.Constants.DataConstants;
using static BakeryApp2024.Core.Constants.MessageConstants;
using BakeryApp2024.Core.Contracts;

namespace BakeryApp2024.Core.Models.Product
{
    public class ProductServiceModel: IProductModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = RequiredMessage)]
        [StringLength(ProductNameMaxLength,
            MinimumLength = ProductNameMinLength,
            ErrorMessage = LengthMessage)]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = RequiredMessage)]
        [Display(Name = "Image URL")]
        public string ImageUrl { get; set; } = string.Empty;

        [Required(ErrorMessage = RequiredMessage)]
        [Range(typeof(decimal),
            ProductPriceMinValue,
            ProductPriceMaxValue,
            ConvertValueInInvariantCulture = true,
            ErrorMessage = "Product price must be a positive number and less than {2} dollars")]
        public decimal Price { get; set; }
    }
}
