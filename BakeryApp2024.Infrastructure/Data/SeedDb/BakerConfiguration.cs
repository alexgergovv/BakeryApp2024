using BakeryApp2024.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BakeryApp2024.Infrastructure.Data.SeedDb
{
    internal class BakerConfiguration : IEntityTypeConfiguration<Baker>
    {
        public void Configure(EntityTypeBuilder<Baker> builder)
        {
            var data = new SeedData();

            builder.HasData(new Baker[] { data.Baker });
        }
    }
}
