using BakeryApp2024.Core.Models.Review;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakeryApp2024.Core.Contracts
{
	public interface IReviewService
	{
		Task<IEnumerable<ReviewViewModel>> AllAsync();
	}
}
