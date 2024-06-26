﻿namespace BakeryApp2024.Core.Models.BasketItem
{
    public class ItemsDetailsViewModel
    {
		public int Id { get; set; }
		public string ProductName { get; set; } = string.Empty;
		public string ImageUrl { get; set; } = string.Empty;
		public decimal Price { get; set; }
		public int Quantity { get; set; }
		public int ProductId { get; set; }
	}
}
