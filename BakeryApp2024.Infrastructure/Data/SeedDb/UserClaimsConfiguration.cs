using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BakeryApp2024.Infrastructure.Data.SeedDb
{
	public class UserClaimsConfiguration : IEntityTypeConfiguration<IdentityUserClaim<string>>
	{
		public void Configure(EntityTypeBuilder<IdentityUserClaim<string>> builder)
		{
			var data = new SeedData();

			builder.HasData(data.BakerUserClaim, data.GuestUserClaim, data.AdminUserClaim);
		}
	}
}
