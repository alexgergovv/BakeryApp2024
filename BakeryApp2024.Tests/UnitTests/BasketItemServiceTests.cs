using BakeryApp2024.Core.Contracts;
using BakeryApp2024.Core.Models.BasketItem;
using BakeryApp2024.Core.Services;
using BakeryApp2024.Infrastructure.Data;
using BakeryApp2024.Infrastructure.Data.Common;
using BakeryApp2024.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace BakeryApp2024.Tests.UnitTests
{
    [TestFixture]
    public class BasketItemServiceTests
    {
        private IBasketItemService basketItemService;
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

        //We already have 1 basketItem into  the database
        [Test]
        public async Task TestDeleteItemsByUserId()
        {
            var repository = new Repository(applicationDbContext);
            basketItemService = new BasketItemService(repository);

            var items = await repository.AllReadOnly<BasketItem>()
                .Where(b => b.IsDeleted == false)
                .ToListAsync();

            Assert.That(items.Count, Is.EqualTo(1));

            var user = await repository.AllReadOnly<ApplicationUser>()
                .Where(u => u.FirstName == "Guest")
                .FirstAsync();

            await basketItemService.DeleteByUserIdAsync(user.Id);

            items = await repository.AllReadOnly<BasketItem>()
                .Where(b => b.IsDeleted == false)
                .ToListAsync();

            Assert.That(items.Count, Is.EqualTo(0));
        }

        [Test]
        public async Task TestEditItem()
        {
            var repository = new Repository(applicationDbContext);
            basketItemService = new BasketItemService(repository);

            var user = await repository.AllReadOnly<ApplicationUser>()
                .Where(u => u.FirstName == "Guest")
                .FirstAsync();

            var item = await basketItemService.GetByProductIdAsync(3, user.Id);

            ItemFormModel itemFormModel = new ItemFormModel()
            {
                ImageUrl = item.ImageUrl,
                ProductName = item.ProductName,
                Price = item.Price,
                Quantity = item.Quantity
            };

            Assert.That(itemFormModel.Quantity, Is.EqualTo(1));
            await basketItemService.IncreaseQuantity(item.Id);

            item = await basketItemService.GetByProductIdAsync(3, user.Id);

            Assert.That(item.Quantity, Is.EqualTo(2));
        }

        [Test]
        public async Task TestEditBasketItem()
        {
            var repository = new Repository(applicationDbContext);
            basketItemService = new BasketItemService(repository);

            var user = await repository.AllReadOnly<ApplicationUser>()
            .Where(u => u.FirstName == "Guest")
            .FirstAsync();

            var item = await basketItemService.GetByProductIdAsync(3, user.Id);

            ItemFormModel itemFormModel = new ItemFormModel()
            {
                ImageUrl = item.ImageUrl,
                ProductName = item.ProductName,
                Price = item.Price,
                Quantity = 4
            };

            await basketItemService.EditAsync(item.Id, itemFormModel);
            item = await basketItemService.GetByProductIdAsync(3, user.Id);

            Assert.That(item.Quantity, Is.EqualTo(4));
        }

        [Test]
        public async Task TestDeleteItem()
        {
            var repository = new Repository(applicationDbContext);
            basketItemService = new BasketItemService(repository);

            var count = await repository.AllReadOnly<BasketItem>()
                .Where(b => b.IsDeleted == false)
                .CountAsync();

            var item = await repository.AllReadOnly<BasketItem>()
                .Where(b => b.IsDeleted == false)
                .FirstAsync();

            Assert.That(item, Is.Not.Null);
            Assert.That(count, Is.EqualTo(1));
            await basketItemService.DeleteAsync(item.Id);

            count = await repository.AllReadOnly<BasketItem>()
                 .Where(b => b.IsDeleted == false)
                .CountAsync();

            Assert.That(count, Is.EqualTo(0));
        }

        [Test]
        public async Task TestExists()
        {
            var repository = new Repository(applicationDbContext);
            basketItemService = new BasketItemService(repository);

            Assert.That(await basketItemService.ExistsAsync(14), Is.True);
        }

        [Test]
        public async Task TestAddedItem()
        {
            var repository = new Repository(applicationDbContext);
            basketItemService = new BasketItemService(repository);
            var productService = new ProductService(repository);

            var product = await productService.GetByIdAsync(1);


            var user = await repository.AllReadOnly<ApplicationUser>()
            .Where(u => u.FirstName == "Guest")
            .FirstAsync();

            Assert.That(await repository.AllReadOnly<BasketItem>().CountAsync(), Is.EqualTo(1));

            await basketItemService.AddItemAsync(product, user.Id);

            Assert.That(await repository.AllReadOnly<BasketItem>().CountAsync(), Is.EqualTo(2));
        }

        [Test]
        public async Task TestExistsByUserId()
        {
            var repository = new Repository(applicationDbContext);
            basketItemService = new BasketItemService(repository);

            var user = await repository.AllReadOnly<ApplicationUser>()
          .Where(u => u.FirstName == "Guest")
          .FirstAsync();

            var item = await repository.AllReadOnly<BasketItem>()
                .Where(i => i.UserId == user.Id && i.IsDeleted == false && i.Id == 14)
                .FirstAsync();

            Assert.That(await basketItemService.ProductItemExistsByIdAsync(item.ProductId, user.Id), Is.True);
            Assert.That(item, Is.Not.Null);
        }


        [Test]
        public async Task TestItemGetByProductId()
        {
            var repository = new Repository(applicationDbContext);
            basketItemService = new BasketItemService(repository);

            var user = await repository.AllReadOnly<ApplicationUser>()
          .Where(u => u.FirstName == "Guest")
          .FirstAsync();

            var item = await repository.AllReadOnly<BasketItem>()
               .Where(i => i.UserId == user.Id && i.IsDeleted == false && i.Id == 14)
               .FirstAsync();

            var basketItem = await basketItemService.GetByProductIdAsync(item.ProductId, user.Id);

            Assert.That(basketItem, Is.Not.Null);
            Assert.That(basketItem.ProductName, Is.EqualTo("Mascarpone Puff Pastry")); ;
        }

        [Test]
        public async Task TestMineItems()
        {
            var repository = new Repository(applicationDbContext);
            basketItemService = new BasketItemService(repository);

            var user = await repository.AllReadOnly<ApplicationUser>()
          .Where(u => u.FirstName == "Guest")
          .FirstAsync();

            var items = await basketItemService.MineByUserIdAsync(user.Id);

            Assert.That(items.Count, Is.EqualTo(1));
        }

        [TearDown]
        public void TearDown()
        {
            applicationDbContext.Dispose();
        }
    }
}
