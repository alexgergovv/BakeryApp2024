using BakeryApp2024.Infrastructure.Data.Models;
using BakeryApp2024.Infrastructure.Data.SeedDb;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BakeryApp2024.Infrastructure.Data
{
	public class BakeryAppDbContext : IdentityDbContext
	{
		public BakeryAppDbContext(DbContextOptions<BakeryAppDbContext> options)
			: base(options)
		{

		}

		protected override void OnModelCreating(ModelBuilder builder)
		{
			builder.ApplyConfiguration(new UserConfiguration());
			builder.ApplyConfiguration(new BakerConfiguration());
			builder.ApplyConfiguration(new CategoryConfiguration());
			builder.ApplyConfiguration(new ProductConfiguration());
			builder.ApplyConfiguration(new OrderConfiguration());
			builder.ApplyConfiguration(new BasketItemConfiguration());

			base.OnModelCreating(builder);
		}

		public DbSet<Baker> Bakers { get; init; } = null!;
		public DbSet<Category> Categories { get; init; } = null!;
		public DbSet<Order> Orders { get; init; } = null!;
		public DbSet<Product> Products { get; init; } = null!;
		public DbSet<BasketItem> BasketItems { get; init; } = null!;
	}
}
