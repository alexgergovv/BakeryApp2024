using BakeryApp2024.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BakeryApp2024.Infrastructure.Data.SeedDb
{
    internal class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder
              .HasOne(p => p.Category)
              .WithMany(c => c.Products)
              .HasForeignKey(p => p.CategoryId)
              .OnDelete(DeleteBehavior.Restrict);

            builder
               .HasOne(p => p.Baker)
               .WithMany(b => b.Products)
               .HasForeignKey(p => p.BakerId)
               .OnDelete(DeleteBehavior.Restrict);

            var data = new SeedData();

            builder.HasData(new Product[] { data.RaffaelloCake, data.ArtisanBread, data.MascarponePastry });
        }
    }
}
