using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static BakeryApp2024.Infrastructure.Constants.DataConstants;

namespace BakeryApp2024.Infrastructure.Data.Models
{
    [Comment("Product Baker")]
    public class Baker
    {
        [Key]
        [Comment("Baker identifier")]
        public int Id { get; init; }

        [Required]
        [MaxLength(BakerNameMaxLength)]
        [Comment("Baker name")]
        public string Name { get; init; } = string.Empty;

        [Required]
        [MaxLength(BakerPhoneNumberMaxLength)]
        [Comment("Baker's phone number")]
        public string PhoneNumber { get; init; } = string.Empty;

        [Required]
        [Comment("User identifier")]
        public string UserId { get; init; } = string.Empty;

        [ForeignKey(nameof(UserId))]
        public IdentityUser User { get; init; } = null!;

        public List<Product> Products { get; set; } = new List<Product>();
    }
}
