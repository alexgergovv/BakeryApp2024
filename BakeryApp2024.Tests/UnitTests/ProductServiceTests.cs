using BakeryApp2024.Core.Contracts;
using BakeryApp2024.Core.Models.Product;
using BakeryApp2024.Core.Services;
using BakeryApp2024.Infrastructure.Data;
using BakeryApp2024.Infrastructure.Data.Common;
using BakeryApp2024.Infrastructure.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace BakeryApp2024.Tests.UnitTests
{
    [TestFixture]
    public class ProductServiceTests
    {
        private IProductService productService;
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

        //We already have 3 products into  the database
        [Test]
        public async Task TestProductEdit()
        {
            var repository = new Repository(applicationDbContext);
            productService = new ProductService(repository);

            await repository.AddAsync(new Product()
            {
                Id = 4,
                Name = "",
                ImageUrl = "",
                Price = 0,
                Description = "",
                IsApproved = false,
                BakerId = 2,
                CategoryId = 2
            });

            await repository.SaveChangesAsync();

            await productService.EditAsync(4, new ProductFormModel()
            {
                Name = "",
                ImageUrl = "",
                Price = 0,
                Description = "This product was edited",
                CategoryId = 2
            });

            var dbProduct = await repository.GetByIdAsync<Product>(4);

            Assert.That(dbProduct.Description, Is.EqualTo("This product was edited"));
        }

        [Test]
        public async Task TestCreateProduct()
        {
            var repository = new Repository(applicationDbContext);
            productService = new ProductService(repository);

            var productId = await CreateProduct();

            Assert.That(productId, Is.EqualTo(4));
        }

        [Test]
        public async Task TestApproveProduct()
        {
            var repository = new Repository(applicationDbContext);
            productService = new ProductService(repository);

            await repository.AddAsync(new Product()
            {
                Id = 4,
                Name = "",
                ImageUrl = "",
                Price = 0,
                Description = "",
                IsApproved = false,
                BakerId = 2,
                CategoryId = 2
            });

            await repository.SaveChangesAsync();

            await productService.ApproveProductAsync(4);

            var dbProduct = await repository.GetByIdAsync<Product>(4);

            Assert.That(dbProduct.IsApproved, Is.EqualTo(true));
            Assert.IsTrue(dbProduct.IsApproved);
        }

        [Test]
        public async Task TestExistsAsync()
        {
            var repository = new Repository(applicationDbContext);
            productService = new ProductService(repository);

            var id = 4;

            bool exist = applicationDbContext.Products
                 .Any(p => p.Id == id);

            Assert.That(await productService.ExistsAsync(id), Is.EqualTo(exist));
            Assert.That(await productService.ExistsAsync(1), Is.EqualTo(true));
        }

        [Test]
        public async Task TestDeleteProduct()
        {
            var repository = new Repository(applicationDbContext);
            productService = new ProductService(repository);

            var productId = await CreateProduct();

            await productService.DeleteAsync(productId);

            Assert.That(applicationDbContext.Products.Count(), Is.EqualTo(3));
        }

        [Test]
        public async Task TestHasBaker()
        {
            var repository = new Repository(applicationDbContext);
            productService = new ProductService(repository);

            var productId = await CreateProduct();

            var product = await productService.GetByIdAsync(productId);

            var baker = await repository.AllReadOnly<Baker>()
                 .Where(b => b.Id == product.BakerId)
                 .FirstAsync();

            Assert.That(await productService.HasBakerWithIdAsync(productId, baker.UserId), Is.EqualTo(true));
        }

        [Test]
        public async Task TestCategoryExists()
        {
            var repository = new Repository(applicationDbContext);
            productService = new ProductService(repository);

            Assert.That(await productService.CategoryExistsAsync(2), Is.EqualTo(true));
        }

        [Test]
        public async Task TestAllCategories()
        {
            var repository = new Repository(applicationDbContext);
            productService = new ProductService(repository);

            var categories = await applicationDbContext.Categories
                .Select(c => new ProductCategoryServiceModel()
                {
                    Id = c.Id,
                    Name = c.Name,
                })
                .ToListAsync();

            var categs = await productService.AllCategoriesAsync();

            int counter = 0;
            foreach (var category in categs)
            {
                counter++;
            }

            Assert.That(counter, Is.EqualTo(categories.Count()));
        }

        [Test]
        public async Task TestGetAllCategoryNames()
        {
            var repository = new Repository(applicationDbContext);
            productService = new ProductService(repository);

            var expected = await applicationDbContext.Categories
                .Select(c => c.Name)
                .ToListAsync();

            var categoryNames = await productService.AllCategoriesNamesAsync();

            List<string> names = new List<string>();

            foreach (var category in categoryNames)
            {
                names.Add(category);
            }

            Assert.That(names.Count, Is.EqualTo(expected.Count));
        }

        [Test]
        public async Task TestGetThreeProduct()
        {
            var repository = new Repository(applicationDbContext);
            productService = new ProductService(repository);

            var productId = await CreateProduct();
            await productService.ApproveProductAsync(productId);

            var products = await productService.GetThreeProductsAsync();

            Assert.That(products.All(p => p.Id != productId), Is.EqualTo(false));
            Assert.That(products.Count(), Is.EqualTo(1));
        }

        [TearDown]
        public void TearDown()
        {
            applicationDbContext.Dispose();
        }

        private async Task<int> CreateProduct()
        {
            var model = new ProductFormModel
            {
                Name = "Test Product",
                Description = "Test Description",
                ImageUrl = "testimage.jpg",
                Price = 10.99M,
                CategoryId = 1
            };

            var bakerId = 1;

            return await productService.CreateAsync(model, bakerId);
        }
    }
}