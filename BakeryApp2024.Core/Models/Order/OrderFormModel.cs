using BakeryApp2024.Core.Models.BasketItem;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static BakeryApp2024.Infrastructure.Constants.DataConstants;
using static BakeryApp2024.Core.Constants.MessageConstants;

namespace BakeryApp2024.Core.Models.Order
{
	public class OrderFormModel
	{
		[Required(ErrorMessage = RequiredMessage)]
		[StringLength(OrderCustomerNameMaxLength,
			MinimumLength = OrderCustomerNameMinLength,
			ErrorMessage = LengthMessage)]
		[Display(Name = "Name")]
		public string CustomerName { get; set; } = string.Empty;

		[Required(ErrorMessage = RequiredMessage)]
		[StringLength(OrderCustomerAddressMaxLength,
		MinimumLength = OrderCustomerAddressMinLength,
		ErrorMessage = LengthMessage)]
		[Display(Name = "Address")]
		public string CustomerAddress { get; set; } = string.Empty;

		[Required(ErrorMessage = RequiredMessage)]
		[StringLength(CityMaxLength,
		MinimumLength = CityMinLength,
		ErrorMessage = LengthMessage)]
		public string City { get; set; } = string.Empty;

		[Required(ErrorMessage = RequiredMessage)]
		[StringLength(CountryMaxLength,
		MinimumLength = CountryMinLength,
	    ErrorMessage = LengthMessage)]
		public string Country { get; set; } = string.Empty;

		[Required(ErrorMessage = RequiredMessage)]
		[Range(ZipCodeMinValue, 
			ZipCodeMaxValue,
			ErrorMessage = RequiredMessage)]
		[Display(Name = "Zip code")]
		public int ZipCode { get; set; }

		[Required(ErrorMessage = RequiredMessage)]
		[Display(Name = "Email")]
		public string CustomerEmail { get; set; } = string.Empty;

		public IEnumerable<ItemFormModel> BasketItems { get; set; } = new List<ItemFormModel>();
	}
}
