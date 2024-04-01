using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static BakeryApp2024.Infrastructure.Constants.DataConstants;

namespace BakeryApp2024.Infrastructure.Data.Models
{
    [Comment("Basket items")]
    public class BasketItem
    {
        [Key]
        [Comment("Item identifier")]
        public int Id { get; set; }

        [Required]
        [MaxLength(ProductNameMaxLength)]
        [Comment("Product name")]
        public string ProductName { get; set; } = string.Empty;

        [Required]
        [Comment("Products quantity")]
        public int Quantity { get; set; }


        [Required]
        [Comment("Product price")]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }

		[Required]
		[Comment("Product image url")]
		public string ImageUrl { get; set; } = string.Empty;

        [Required]
        public bool IsDeleted { get; set; }

		[Required]
        [Comment("User identifier")]
        public string UserId { get; set; } = string.Empty;


        [ForeignKey(nameof(UserId))]
        public IdentityUser User { get; set; } = null!;

		[Required]
		[Comment("Product identifier")]
		public int ProductId { get; set; } 


		[ForeignKey(nameof(ProductId))]
		public Product Product { get; set; } = null!;
	}
}
