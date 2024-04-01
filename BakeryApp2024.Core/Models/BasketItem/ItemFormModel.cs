﻿namespace BakeryApp2024.Core.Models.BasketItem
{
	public class ItemFormModel
	{
		public string ProductName { get; set; } = string.Empty;
		public string ImageUrl { get; set; } = string.Empty;
		public decimal Price { get; set; }
		public int Quantity { get; set; }
	}
}
