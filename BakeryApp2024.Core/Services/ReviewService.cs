using BakeryApp2024.Core.Contracts;
using BakeryApp2024.Core.Models.Review;
using BakeryApp2024.Infrastructure.Data.Common;
using BakeryApp2024.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
	}
}
