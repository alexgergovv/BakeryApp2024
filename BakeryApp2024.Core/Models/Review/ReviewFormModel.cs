using System.ComponentModel.DataAnnotations;
using static BakeryApp2024.Core.Constants.MessageConstants;
using static BakeryApp2024.Infrastructure.Constants.DataConstants;

namespace BakeryApp2024.Core.Models.Review
{
	public class ReviewFormModel
	{
		[Required(ErrorMessage = RequiredMessage)]
		[StringLength(ReviewerNameMaxLength,
			MinimumLength = ReviewerNameMinLength,
			ErrorMessage = LengthMessage)]
		public string UserName { get; set; } = string.Empty;

		[Required(ErrorMessage = RequiredMessage)]
		[StringLength(ReviewDescriptionMaxLength,
			MinimumLength = ReviewDescriptionMinLength,
			ErrorMessage = LengthMessage)]
		public string Description { get; set; } = string.Empty;

		public string? UserImageUrl { get; set; } = string.Empty;

		[Required(ErrorMessage = RequiredMessage)]
		public int Stars { get; set; }
	}
}
