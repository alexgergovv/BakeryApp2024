using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using static BakeryApp2024.Infrastructure.Constants.DataConstants;

namespace BakeryApp2024.Infrastructure.Data.Models
{
    [Comment("Blog for recipes")]
    public class Blog
    {
        [Key]
        [Comment("Blog identifier")]
        public int Id { get; init; }

        [Required]
        [MaxLength(BlogTitleMaxLength)]
        [Comment("Blog title")]
        public string Title { get; init; } = string.Empty;

        [Required]
        [MaxLength(BlogContentMaxLength)]
        [Comment("Blog content")]
        public string Content { get; init; } = string.Empty;

        [Required]
        [MaxLength(BlogAuthorNameMaxLength)]
        [Comment("Blog author")]
        public string Author { get; init; } = string.Empty;

		[Comment("Blog image url")]
		public string? ImageUrl { get; init; } 

		[Required]
        [Comment("Publishing date")]
        public DateTime DatePublished { get; init; }

        [Required]
        [Comment("User identifier")]
        public string UserId { get; init; } = string.Empty;

        [ForeignKey(nameof(UserId))]
        public IdentityUser User { get; init; } = null!;
    }
}
