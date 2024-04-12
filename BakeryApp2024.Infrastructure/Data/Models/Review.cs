using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static BakeryApp2024.Infrastructure.Constants.DataConstants;

namespace BakeryApp2024.Infrastructure.Data.Models
{
	public class Review
	{
		[Key]
		[Comment("Review identifier")]
		public int Id { get; set; }

		[Required]
		[MaxLength(ReviewerNameMaxLength)]
		[Comment("User's name")]
		public string UserName { get; set; } = null!;

		[Required]
		[Comment("Review date")]
		public DateTime Date { get; set; }

		[Required]
		[Comment("Review description")]
		[MaxLength(ReviewDescriptionMaxLength)]
		public string Description { get; set; } = null!;

		[Comment("User's image URL")]
		public string UserImageUrl {get; set; } = null!;

		[Comment("Review stars")]
		public int Stars {  get; set; }

		[Required]
		[Comment("User identifier")]
		public string UserId { get; set; } = string.Empty;

		[ForeignKey(nameof(UserId))]
		public ApplicationUser User { get; set; } = null!;
	}
}
