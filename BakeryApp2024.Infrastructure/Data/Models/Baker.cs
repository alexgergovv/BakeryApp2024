using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static BakeryApp2024.Infrastructure.Constants.DataConstants;

namespace BakeryApp2024.Infrastructure.Data.Models
{
	[Index(nameof(PhoneNumber), IsUnique = true)]
    [Comment("Product Baker")]
    public class Baker
    {
        [Key]
        [Comment("Baker identifier")]
        public int Id { get; set; }

        [Required]
        [MaxLength(BakerNameMaxLength)]
        [Comment("Baker name")]
        public string Name { get; set; } = string.Empty;

        [Required]
        [MaxLength(BakerPhoneNumberMaxLength)]
        [Comment("Baker's phone number")]
        public string PhoneNumber { get; set; } = string.Empty;

        [Required]
        public string Gender {  get; set; } = string.Empty;

        [Required]
        [Comment("User identifier")]
        public string UserId { get; set; } = string.Empty;

        [ForeignKey(nameof(UserId))]
        public ApplicationUser User { get; set; } = null!;

        public List<Product> Products { get; set; } = new List<Product>();
    }
}
