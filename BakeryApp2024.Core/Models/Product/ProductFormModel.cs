using BakeryApp2024.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BakeryApp2024.Infrastructure.Constants.DataConstants;
using static BakeryApp2024.Core.Constants.MessageConstants;

namespace BakeryApp2024.Core.Models.Product
{
	public class ProductFormModel
	{
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
		[Display(Name = "Price")]
		public decimal Price { get; init; }

		[Required(ErrorMessage = RequiredMessage)]
		[Display(Name = "Available Quantity")]
		public int AvailableQuantity { get; init; }

		[Display(Name = "Category")]
		public int CategoryId { get; set; }

		public IEnumerable<ProductCategoryServiceModel> Categories { get; set; } =
			new List<ProductCategoryServiceModel>();
	}
}
