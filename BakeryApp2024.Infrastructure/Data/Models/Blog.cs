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
        public int Id { get; set; }

        [Required]
        [MaxLength(BlogTitleMaxLength)]
        [Comment("Blog title")]
        public string Title { get; set; } = string.Empty;

        [Required]
        [MaxLength(BlogContentMaxLength)]
        [Comment("Blog content")]
        public string Content { get; set; } = string.Empty;

        [Required]
        [MaxLength(BlogAuthorNameMaxLength)]
        [Comment("Blog author")]
        public string Author { get; set; } = string.Empty;

		[Comment("Blog image url")]
		public string? ImageUrl { get; set; } 

		[Required]
        [Comment("Publishing date")]
        public DateTime DatePublished { get; set; }

        [Required]
        [Comment("User identifier")]
        public string UserId { get; set; } = string.Empty;

        [ForeignKey(nameof(UserId))]
        public IdentityUser User { get; set; } = null!;
    }
}
