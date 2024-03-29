using BakeryApp2024.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Identity;

namespace BakeryApp2024.Infrastructure.Data.SeedDb
{
    internal class SeedData
    {
        public IdentityUser BakerUser { get; set; }
        public IdentityUser GuestUser { get; set; }
        public Baker Baker { get; set; }
        public Category BreadCategory { get; set; }
        public Category PastryCategory { get; set; }
        public Category CakeCategory { get; set; }
        public Product RaffaelloCake { get; set; }
        public Product ArtisanBread { get; set; }
        public Product MascarponePastry { get; set; }

        public Order GuestUserOrder { get; set; }
        public BasketItem BasketItem { get; set; }

        public SeedData()
        {
            SeedUsers();
            SeedBaker();
            SeedCategories();
            SeedProducts();
            SeedBasketItem();
            SeedOrder();
        }

        private void SeedUsers()
        {
            var hasher = new PasswordHasher<IdentityUser>();

            BakerUser = new IdentityUser()
            {
                Id = "dea12856-c198-4129-b3f3-b893d8395082",
                UserName = "baker@mail.com",
                NormalizedUserName = "baker@mail.com",
                Email = "baker@mail.com",
                NormalizedEmail = "baker@mail.com"
            };

            BakerUser.PasswordHash =
                 hasher.HashPassword(BakerUser, "baker123");

            GuestUser = new IdentityUser()
            {
                Id = "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                UserName = "guest@mail.com",
                NormalizedUserName = "guest@mail.com",
                Email = "guest@mail.com",
                NormalizedEmail = "guest@mail.com"
            };

            GuestUser.PasswordHash =
            hasher.HashPassword(BakerUser, "guest123");
        }

        private void SeedBaker()
        {
            Baker = new Baker()
            {
                Id = 1,
                Name = "Buddy Valastro",
                PhoneNumber = "+359562095974",
                UserId = BakerUser.Id
            };
        }

        private void SeedCategories()
        {
            BreadCategory = new Category()
            {
                Id = 1,
                Name = "Bread"
            };

            PastryCategory = new Category()
            {
                Id = 2,
                Name = "Pastry"
            };

            CakeCategory = new Category()
            {
                Id = 3,
                Name = "Cake"
            };
        }

        private void SeedProducts()
        {
            RaffaelloCake = new Product()
            {
                Id = 1,
                Name = "Raffaello Cake",
                Description = "This Raffaello Cake is a coconut lover’s dream! Layers of moist and tender almond cake, coconut custard, and coconut Swiss meringue buttercream.",
                ImageUrl = "https://livforcake.com/wp-content/uploads/2019/04/raffaello-cake-thumb.jpg",
                Price = 60.00M,
                CategoryId = CakeCategory.Id,
                BakerId = Baker.Id
            };

            ArtisanBread = new Product()
            {
                Id = 2,
                Name = "Artisan Oven Bread",
                Description = "Experience our artisan bread: handcrafted with care, premium ingredients, and timeless techniques. Delight in its crispy crust, tender crumb, and exquisite flavor.",
                ImageUrl = "https://www.kitchensanctuary.com/wp-content/uploads/2020/06/Artisan-Bread-square-FS-46.jpg",
                Price = 5.00M,
                CategoryId = BreadCategory.Id,
                BakerId = Baker.Id
            };

            MascarponePastry = new Product()
            {
                Id = 3,
                Name = "Mascarpone Puff Pastry",
                Description = "Savor our mascarpone puff pastry: flaky layers filled with creamy mascarpone, a buttery delight for any moment!",
                ImageUrl = "https://www.californiastrawberries.com/wp-content/uploads/2021/04/Strawberry-Mascarpone-Danishes.png",
                Price = 7.00M,
                CategoryId = PastryCategory.Id,
                BakerId = Baker.Id
            };
        }

        public void SeedBasketItem()
        {
            BasketItem = new BasketItem()
            {
                Id = 14,
                ProductName = MascarponePastry.Name,
                Price = MascarponePastry.Price,
                ImageUrl = MascarponePastry.ImageUrl,
                ProductId = 3,
                Quantity = 1,
                UserId = GuestUser.Id
            };
        }
        private void SeedOrder()
        {
            GuestUserOrder = new Order()
            {
                Id = 1,
                Number = 123456789,
                TotalPrice = 0.00M,
                CustomerName = "Gabriel Marinov",
                CustomerAddress = "Tsar Simeon 123",
                ZipCode = 1000,
                Country = "Bulgaria",
                City = "Pleven",
                CustomerEmail = "gabrielmar284@mail.com",
                Date = DateTime.Now,
                Status = "Pending",
                UserId = GuestUser.Id
            };
        }
    }
}
