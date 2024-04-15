using BakeryApp2024.Core.Contracts;
using BakeryApp2024.Core.Models.Review;
using BakeryApp2024.Core.Services;
using BakeryApp2024.Infrastructure.Data;
using BakeryApp2024.Infrastructure.Data.Common;
using BakeryApp2024.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace BakeryApp2024.Tests.UnitTests
{
    [TestFixture]
    public class ReviewServiceTests
    {
        private IReviewService reviewService;
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

        //We already have 1 review into  the database
        [Test]
        public async Task TestCreateReview()
        {
            var repository = new Repository(applicationDbContext);
            reviewService = new ReviewService(repository);

            ReviewFormModel model = new ReviewFormModel()
            {
                Description = "",
                Stars = 5,
                UserImageUrl = "",
                UserName = "",
            };

            var user = await CreateUser();

            await reviewService.CreateAsync(model, user.Id);

            Assert.That(await repository.AllReadOnly<Review>().CountAsync(), Is.EqualTo(2));
        }

        [Test]
        public async Task TestAllReviews()
        {
            var repository = new Repository(applicationDbContext);
            reviewService = new ReviewService(repository);

            Assert.That(await repository.AllReadOnly<Review>().CountAsync(), Is.EqualTo(1));

            ReviewFormModel model = new ReviewFormModel()
            {
                Description = "",
                Stars = 5,
                UserImageUrl = "",
                UserName = "",
            };

            var user = await CreateUser();

            await reviewService.CreateAsync(model, user.Id);

            Assert.That(reviewService.AllAsync().Result.Count(), Is.EqualTo(2));
        }

        [TearDown]
        public void TearDown()
        {
            applicationDbContext.Dispose();
        }
        private async Task<ApplicationUser> CreateUser()
        {
            return new ApplicationUser()
            {
                Id = "6d7473ce-d726-4fc8-83d9-d6b3ac1f591e",
                UserName = "test@mail.com",
                NormalizedUserName = "@mail.com",
                Email = "test@mail.com",
                NormalizedEmail = "TEST@mail.com",
                FirstName = "Test",
                LastName = "Testov"
            };
        }
    }
}
