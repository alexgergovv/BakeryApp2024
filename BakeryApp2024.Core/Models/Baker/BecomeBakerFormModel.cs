﻿using System.ComponentModel.DataAnnotations;
using static BakeryApp2024.Core.Constants.MessageConstants;
using static BakeryApp2024.Infrastructure.Constants.DataConstants;

namespace BakeryApp2024.Core.Models.Baker
{
	public class BecomeBakerFormModel
	{
        [Required(ErrorMessage = RequiredMessage)]
        [StringLength(BakerPhoneNumberMaxLength,
            MinimumLength = BakerPhoneNumberMinLength, 
            ErrorMessage = LengthMessage)]
        [Display(Name = "Phone number")]
        [Phone]
        public string PhoneNumber { get; set; } = string.Empty;

        [Required(ErrorMessage = RequiredMessage)]
        public string Gender {  get; set; } = string.Empty;
    }
}
