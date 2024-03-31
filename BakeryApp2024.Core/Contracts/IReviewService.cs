using BakeryApp2024.Core.Models.Review;

namespace BakeryApp2024.Core.Contracts
{
	public interface IReviewService
	{
		Task<IEnumerable<ReviewViewModel>> AllAsync();

		Task CreateAsync(ReviewFormModel model, string userId);
	}
}
