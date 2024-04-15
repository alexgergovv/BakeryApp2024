using BakeryApp2024.Core.Contracts;
using BakeryApp2024.Core.Services;
using BakeryApp2024.Infrastructure.Data;
using BakeryApp2024.Infrastructure.Data.Common;
using BakeryApp2024.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace BakeryApp2024.Tests.UnitTests
{
    [TestFixture]
    public class UserServiceTests
    {
        private IUserService userService;
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

        //We already have 3 users into  the database
        [Test]
        public async Task TestGetUserFullName()
        {
            var repository = new Repository(applicationDbContext);
            userService = new UserService(repository);

            var user = await repository.AllReadOnly<ApplicationUser>()
            .Where(u => u.FirstName == "Guest")
            .FirstAsync();

            string name = await userService.UserFullNameAsync(user.Id);
            
            Assert.That(name, Is.EqualTo("Guest Guestov"));
        }

        [Test]
        public async Task TestAllUsers()
        {
            var repository = new Repository(applicationDbContext);
            userService = new UserService(repository);
        
            Assert.That(userService.AllAsync().Result.Count(), Is.EqualTo(3));
        }

            [TearDown]
        public void TearDown()
        {
            applicationDbContext.Dispose();
        }
    }
}
