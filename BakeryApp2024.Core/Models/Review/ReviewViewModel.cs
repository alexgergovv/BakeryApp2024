using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakeryApp2024.Core.Models.Review
{
	public class ReviewViewModel
	{
		public int Id { get; set; }
		public string UserName { get; set; } = string.Empty;
		public string Date { get; set; } = string.Empty;
		public string Description { get; set; } = string.Empty;
		public string UserImageUrl { get; set; } = string.Empty;
		public int Stars { get; set; }
		public string UserId { get; set; } = string.Empty;
	}
}
