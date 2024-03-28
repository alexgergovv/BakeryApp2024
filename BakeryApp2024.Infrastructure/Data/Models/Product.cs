using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static BakeryApp2024.Infrastructure.Constants.DataConstants;

namespace BakeryApp2024.Infrastructure.Data.Models
{
    [Comment("Product for sale")]
    public class Product
    {
        [Key]
        [Comment("Product identifier")]
        public int Id { get; init; }

        [Required]
        [MaxLength(ProductNameMaxLength)]
        [Comment("Product name")]
        public string Name { get; init; } = string.Empty;

        [Required]
        [MaxLength(ProductDescriptionMaxLength)]
        [Comment("Product description")]
        public string Description {  get; init; } = string.Empty;

        [Required]
        [Comment("Product image url")]
        public string ImageUrl { get; init; } = string.Empty;

        [Required]
        [Comment("Product price")]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; init; }

        [Required]
        [Comment("Category identifier")]
        public int CategoryId { get; set; }

        [ForeignKey(nameof(CategoryId))]
        public Category Category { get; set; } = null!;

        [Required]
        [Comment("Baker identifier")]
        public int BakerId { get; set; }

        [ForeignKey(nameof(BakerId))]
        public Baker Baker { get; set; } = null!;
    }
}
