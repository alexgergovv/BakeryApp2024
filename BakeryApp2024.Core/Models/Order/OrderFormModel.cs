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
			ErrorMessage = "Invalid zip code!")]
		[Display(Name = "Zip code")]
		public int ZipCode { get; set; }

		[Required(ErrorMessage = RequiredMessage)]
		[Display(Name = "Email")]
		public string CustomerEmail { get; set; } = string.Empty;

        [Required(ErrorMessage = RequiredMessage)]
        [StringLength(NameOnCardMaxLength,
            MinimumLength = NameOnCardMinLength,
            ErrorMessage = LengthMessage)]
        [Display(Name = "Name on card")]
        public string NameOnCard { get; set; } = string.Empty;

		[Required(ErrorMessage = RequiredMessage)]
		[StringLength(CardNumberMaxLength,
			MinimumLength = CardNumberMinLength,
			ErrorMessage = "Invalid Card Number!")]
		[Display(Name = "Card number")]
		public string CardNumber { get; set; } = string.Empty;

		[Required(ErrorMessage = RequiredMessage)]
		[Range(CardExpirationMonthMinValue,
			CardExpirationMonthMaxValue,
			ErrorMessage = "Invalid month!")]
		[Display(Name = "Expiration month")]
		public int ExpirationMonth { get; set; }

		[Required(ErrorMessage = RequiredMessage)]
		[Range(CardExpirationYearMinValue,
			CardExpirationYearMaxValue,
			ErrorMessage = "Invalid year!")]
		[Display(Name = "Expiration year")]
		public int ExpirationYear { get; set; }

		[Required(ErrorMessage = RequiredMessage)]
		[StringLength(CardCVVMaxLength,
			MinimumLength = CardCVVMinLength,
			ErrorMessage = "Invalid CVV!")]
		public string CVV { get; set; } = string.Empty;

		public IEnumerable<ItemFormModel> BasketItems { get; set; } = new List<ItemFormModel>();
	}
}
