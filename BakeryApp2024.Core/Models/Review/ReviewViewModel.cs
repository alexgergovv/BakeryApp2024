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
