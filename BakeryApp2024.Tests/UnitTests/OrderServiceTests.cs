using BakeryApp2024.Core.Contracts;
using BakeryApp2024.Core.Models.Order;
using BakeryApp2024.Core.Services;
using BakeryApp2024.Infrastructure.Data;
using BakeryApp2024.Infrastructure.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace BakeryApp2024.Tests.UnitTests
{
    public class OrderServiceTests
    {
        private IOrderService orderService;
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
        public async Task TestCreateReview()
        {
            var repository = new Repository(applicationDbContext);
            orderService = new OrderService(repository);

            var userId = await applicationDbContext.Users
              .Select(u => u.Id)
              .FirstOrDefaultAsync();

            CreateOrder(userId);

            Assert.That(applicationDbContext.Orders.Count(), Is.EqualTo(2));
        }

        [Test]
        public async Task TestGetOrdersByUserId()
        {
            var repository = new Repository(applicationDbContext);
            orderService = new OrderService(repository);

            var userId = await applicationDbContext.Users
                .Select(u => u.Id)
                .FirstOrDefaultAsync();

            CreateOrder(userId);
            var orders = await orderService.GetOrdersByUserIdAsync(userId);

            Assert.That(orders.Count(), Is.EqualTo(1));

        }

            [TearDown]
        public void TearDown()
        {
            applicationDbContext.Dispose();
        }

        private async void CreateOrder(string userId)
        {
            OrderFormModel orderFormModel = new OrderFormModel()
            {
                CustomerName = "",
                ZipCode = 8000,
                City = "",
                Country = "",
                CustomerAddress = "",
                CustomerEmail = ""
            };

            await applicationDbContext.Users
                .Select(u => u.Id == userId)
                .FirstOrDefaultAsync();

            await orderService.CreateAsync(orderFormModel, userId);
        }
    }
}
