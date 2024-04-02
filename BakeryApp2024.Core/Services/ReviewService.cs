using BakeryApp2024.Core.Contracts;
using BakeryApp2024.Core.Models.Review;
using BakeryApp2024.Infrastructure.Data.Common;
using BakeryApp2024.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace BakeryApp2024.Core.Services
{
	public class ReviewService : IReviewService
	{
		private readonly IRepository repository;
		public ReviewService(IRepository _repository)
		{ 
			repository = _repository;
		}

		public async Task<IEnumerable<ReviewViewModel>> AllAsync()
		{
			return await repository.AllReadOnly<Review>()
				.OrderByDescending(r => r.Date)
				.Select(r => new ReviewViewModel()
				{
					Id = r.Id,
					UserName = r.UserName,
					Description = r.Description,
					Date = r.Date.ToShortDateString(),
					UserImageUrl = r.UserImageUrl,
					Stars = r.Stars,
					UserId = r.UserId
				})
				.ToListAsync();
		}

		public async Task CreateAsync(ReviewFormModel model, string userId)
		{

			Review review = new Review()
			{
				UserName = model.UserName,
				Description = model.Description,
				Date = DateTime.Now,
				UserId = userId,
				UserImageUrl = model.UserImageUrl,
				Stars = model.Stars,
			};

			if (model.Stars == 0)
			{
				review.Stars = 5;
			}

			if (string.IsNullOrEmpty(model.UserImageUrl))
			{
				review.UserImageUrl = "https://upload.wikimedia.org/wikipedia/commons/a/ac/Default_pfp.jpg";
			}

			await repository.AddAsync(review);
			await repository.SaveChangesAsync();
		}
	}
}
