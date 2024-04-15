using BakeryApp2024.Core.Contracts;
using BakeryApp2024.Core.Models.Baker;
using BakeryApp2024.Core.Services;
using BakeryApp2024.Infrastructure.Data;
using BakeryApp2024.Infrastructure.Data.Common;
using BakeryApp2024.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace BakeryApp2024.Tests.UnitTests
{
    [TestFixture]
    public class BakerServiceTests
    {
        private IBakerService bakerService;
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

        //We already have 2 baker into  the database
        [Test]
        public async Task TestCreateBaker()
        {
            var repository = new Repository(applicationDbContext);
            bakerService = new BakerService(repository);

            var user = await CreateUser();

            await repository.AddAsync(user);
            await repository.SaveChangesAsync();

            await CreateBaker(user);

            Assert.That(repository.AllReadOnly<Baker>().Count(), Is.EqualTo(3));
        }

        [Test]
        public async Task TestUserWithPhoneNumberExists()
        {
            var repository = new Repository(applicationDbContext);
            bakerService = new BakerService(repository);

            var user = await CreateUser();

            await repository.AddAsync(user);
            await repository.SaveChangesAsync();

            await CreateBaker(user);

            Assert.That(await bakerService.UserWithPhoneNumberExistsAsync("+1286567890"), Is.True);
        }

        [Test]
        public async Task TestGetAllAsChipModel()
        {
            var repository = new Repository(applicationDbContext);
            bakerService = new BakerService(repository);

            var user = await CreateUser();

            await repository.AddAsync(user);
            await repository.SaveChangesAsync();

            await CreateBaker(user);

            var models = bakerService.GetAllAsChipModelAsync();
            var count = await repository.AllReadOnly<Baker>()
                .CountAsync();

            var baker = models.Result.Where(b => b.PhoneNumber == "+1286567890").First();

            Assert.That(baker.Gender, Is.EqualTo("Male"));
            Assert.That(models.Result.Count(), Is.EqualTo(count));
        }

        [Test]
        public async Task TestExistsById()
        {
            var repository = new Repository(applicationDbContext);
            bakerService = new BakerService(repository);

            var user = await CreateUser();

            await repository.AddAsync(user);
            await repository.SaveChangesAsync();

            await CreateBaker(user);

            Assert.That(await bakerService.ExistsByIdAsync(user.Id), Is.True);
        }

        [Test]
        public async Task TestGetBakerById()
        {
            var repository = new Repository(applicationDbContext);
            bakerService = new BakerService(repository);

            var user = await CreateUser();

            await repository.AddAsync(user);
            await repository.SaveChangesAsync();

            await CreateBaker(user);

            Assert.That(await bakerService.GetBakerIdAsync(user.Id), Is.EqualTo(3));
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

        private async Task CreateBaker(ApplicationUser user)
        {
            BecomeBakerFormModel baker = new BecomeBakerFormModel()
            {
                Gender = "Male",
                PhoneNumber = "+1286567890",
            };

            await bakerService.CreateAsync(baker, user.Id);
        }
    }
}
