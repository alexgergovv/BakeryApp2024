using System.ComponentModel.DataAnnotations;
using static BakeryApp2024.Infrastructure.Constants.DataConstants;
using static BakeryApp2024.Core.Constants.MessageConstants;

namespace BakeryApp2024.Core.Models.Product
{
    public class ProductServiceModel
    {
        public int Id { get; init; }

        [Required(ErrorMessage = RequiredMessage)]
        [StringLength(ProductNameMaxLength,
            MinimumLength = ProductNameMinLength,
            ErrorMessage = LengthMessage)]
        public string Name { get; init; } = string.Empty;

        [Required(ErrorMessage = RequiredMessage)]
        [StringLength(ProductDescriptionMaxLength,
            MinimumLength = ProductDescriptionMinLength,
            ErrorMessage = LengthMessage)]
        public string Description { get; init; } = string.Empty;

        [Required(ErrorMessage = RequiredMessage)]
        [Display(Name = "Image URL")]
        public string ImageUrl { get; init; } = string.Empty;

        [Required(ErrorMessage = RequiredMessage)]
        [Range(typeof(decimal),
            ProductPriceMinValue,
            ProductPriceMaxValue,
            ConvertValueInInvariantCulture = true,
            ErrorMessage = "Product price must be a positive number and less than {2} dollars")]
        public decimal Price { get; init; }
    }
}
