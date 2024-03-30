using BakeryApp2024.Core.Models.BasketItem;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakeryApp2024.Core.Models.Order
{
	public class OrderViewModel
	{
		public string CustomerName { get; set; } = string.Empty;
		public int Number {  get; set; }
		public string Date { get; set; } = string.Empty;
		public decimal TotalPrice { get; set; }
		public string OrderStatus { get; set; } = string.Empty;
		public List<ItemFormModel> BasketItems { get; set; } = new List<ItemFormModel>();
	}
}
