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
        public int Id { get; set; }

        [Required]
        [Comment("Order number")]
        public int Number { get; set; }

        [Required]
        [MaxLength(OrderCustomerNameMaxLength)]
        [Comment("Customer name")]
        public string CustomerName { get; set; } = string.Empty;

        [Required]
        [MaxLength(OrderCustomerAddressMaxLength)]
        [Comment("Customer address")]
        public string CustomerAddress { get; set; } = string.Empty;

        [Required]
        [MaxLength(OrderCustomerEmailMaxLength)]
        [Comment("Customer email")]
        public string CustomerEmail { get; set; } = string.Empty;

        [Required]
        [Comment("Total price")]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal TotalPrice { get; set; }

        [Required]
        [Comment("Order date")]
        public DateTime Date { get; set; }

        [Required]
        [MaxLength(OrderStatusMaxLength)]
        [Comment("Order status")]
        public string Status { get; set; } = string.Empty;

        [Required]
        [Comment("User identifier")]
        public string UserId { get; set; } = string.Empty;


        [ForeignKey(nameof(UserId))]
        public IdentityUser User { get; set; } = null!;
        public IEnumerable<BasketItem> BasketItems { get; set; } = new List<BasketItem>();
    }
}
