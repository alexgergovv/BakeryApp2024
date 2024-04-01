using BakeryApp2024.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BakeryApp2024.Infrastructure.Data.SeedDb
{
	internal class ReviewConfiguration : IEntityTypeConfiguration<Review>
	{
		public void Configure(EntityTypeBuilder<Review> builder)
		{
			var data = new SeedData();

			builder.HasData(new Review[] { data.UserReview });
		}
	}
}
