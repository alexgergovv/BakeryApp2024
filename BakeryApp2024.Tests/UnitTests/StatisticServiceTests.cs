using BakeryApp2024.Core.Contracts;
using BakeryApp2024.Core.Services;
using BakeryApp2024.Infrastructure.Data.Common;
using BakeryApp2024.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BakeryApp2024.Core.Models.Product;

namespace BakeryApp2024.Tests.UnitTests
{
    [TestFixture]
    public class StatisticServiceTests
    {
        private IStatisticService statisticService;
        private BakeryAppDbContext applicationDbContext;

        [SetUp]
        public void Setup()
        {
            var contextOptions = new DbContextOptionsBuilder<BakeryAppDbContext>()
                .UseInMemoryDatabase("BakeryDb")
                .Options;

            applicationDbContext = new BakeryAppDbContext(contextOptions);

            applicationDbContext.Database.EnsureDeleted();
            applicationDbContext.Database.EnsureCreated();
        }

        [Test]
        public async Task TestAllTotal()
        {
            var repository = new Repository(applicationDbContext);
            statisticService = new StatisticService(repository);
            var productService = new ProductService(repository);


            var stats = await statisticService.TotalAsync();

            Assert.That(stats.CakeProductsCount, Is.EqualTo(0));
            Assert.That(stats.BreadProductsCount, Is.EqualTo(0));
            Assert.That(stats.PastryProductsCount, Is.EqualTo(0));
            Assert.That(stats.TotalProducts, Is.EqualTo(0));

            var model = new ProductFormModel
            {
                Name = "Test Product",
                Description = "Test Description",
                ImageUrl = "testimage.jpg",
                Price = 10.99M,
                CategoryId = 3
            };

            var bakerId = 1;

            await productService.CreateAsync(model, bakerId);

            await productService.ApproveProductAsync(4);

            stats = await statisticService.TotalAsync();

            Assert.That(stats.CakeProductsCount, Is.EqualTo(1));
            Assert.That(stats.BreadProductsCount, Is.EqualTo(0));
            Assert.That(stats.PastryProductsCount, Is.EqualTo(0));
            Assert.That(stats.TotalProducts, Is.EqualTo(1));
        }

        [TearDown]
        public void TearDown()
        {
            applicationDbContext.Dispose();
        }
    }
}
