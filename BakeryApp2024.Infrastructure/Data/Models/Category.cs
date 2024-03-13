using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using static BakeryApp2024.Infrastructure.Constants.DataConstants;

namespace BakeryApp2024.Infrastructure.Data.Models
{
    [Comment("Product category")]
    public class Category
    {
        [Key]
        [Comment("Category identifier")]
        public int Id { get; init; }

        [Required]
        [MaxLength(CategoryNameMaxLength)]
        [Comment("Category name")]
        public string Name { get; init; } = string.Empty;

        public List<Product> Products { get; init; } = new List<Product>();
    }
}
