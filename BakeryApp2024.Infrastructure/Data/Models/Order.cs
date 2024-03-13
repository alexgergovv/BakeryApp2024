using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static BakeryApp2024.Infrastructure.Constants.DataConstants;

namespace BakeryApp2024.Infrastructure.Data.Models
{
    [Comment("Products orders")]
    public class Order
    {
        [Key]
        [Comment("Order identifier")]
        public int Id { get; init; }

        [Required]
        [Comment("Order number")]
        public int Number { get; init; }

        [Required]
        [MaxLength(ProductNameMaxLength)]
        [Comment("Product name")]
        public string ProductName { get; init; } = string.Empty;

        [Required]
        [Comment("Products quantity")]
        public int Quantity { get; init; }

        [Required]
        [Comment("Product price")]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; init; } 

        [Required]
        [MaxLength(OrderCustomerNameMaxLength)]
        [Comment("Customer name")]
        public string CustomerName { get; init; } = string.Empty;

        [Required]
        [MaxLength(OrderCustomerAddressMaxLength)]
        [Comment("Customer address")]
        public string CustomerAddress { get; init; } = string.Empty;

        [Required]
        [MaxLength(OrderCustomerEmailMaxLength)]
        [Comment("Customer email")]
        public string CustomerEmail { get; init; } = string.Empty;

        [Required]
        [Comment("Total price")]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal TotalPrice { get; init; }

        [Required]
        [Comment("Order date")]
        public DateTime Date { get; init; }

        [Required]
        [MaxLength(OrderStatusMaxLength)]
        [Comment("Order status")]
        public string Status { get; init; } = string.Empty;

        [Required]
        [Comment("User identifier")]
        public string UserId { get; init; } = string.Empty;

        [ForeignKey(nameof(UserId))]
        public IdentityUser User { get; init; } = null!;
    }
}
