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
        public Blog FirstBlog { get; set; }

        public SeedData()
        {
            SeedUsers();
            SeedBaker();
            SeedCategories();
            SeedProducts();
            SeedOrder();
            SeedBlog();
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
                BakerId = Baker.Id,
                AvailableQuantity = 5
            };

            ArtisanBread = new Product()
            {
                Id = 2,
                Name = "Artisan Oven Bread",
                Description = "Experience our artisan bread: handcrafted with care, premium ingredients, and timeless techniques. Delight in its crispy crust, tender crumb, and exquisite flavor.",
                ImageUrl = "https://vegansoprano.com/wp-content/uploads/2021/01/dutch-oven-artisan-bread-7.jpg",
                Price = 5.00M,
                CategoryId = BreadCategory.Id,
                BakerId = Baker.Id,
                AvailableQuantity = 50
            };

            MascarponePastry = new Product()
            {
                Id = 3,
                Name = "Mascarpone Puff Pastry",
                Description = "Savor our mascarpone puff pastry: flaky layers filled with creamy mascarpone, a buttery delight for any moment!",
                ImageUrl = "https://www.piesandtacos.com/wp-content/uploads/2023/02/pastries-lemon-curd-mascarpone-5-scaled.jpg",
                Price = 7.00M,
                CategoryId = PastryCategory.Id,
                BakerId = Baker.Id,
                AvailableQuantity = 20
            };
        }
        private void SeedOrder()
        {
            GuestUserOrder = new Order()
            {
                Id = 1,
                Number = 123456789,
                ProductName = "Raffaello Cake",
                Quantity = 2,
                Price = 30.00M,
                TotalPrice = 60.00M,
                CustomerName = "Gabriel Marinov",
                CustomerAddress = "Tsar Simeon 123\nSofia, Bulgaria\n1000",
                CustomerEmail = "gabrielmar284@mail.com",
                Date = DateTime.Now,
                Status = "Pending",
                UserId = GuestUser.Id
            };
        }

        private void SeedBlog()
        {
            FirstBlog = new Blog()
            {
                Id = 1,
                Title = "Baking Bliss: A Guide to Creating Delicious Treats in Your Own Kitchen",
                Content = "Welcome to our bakery blog! Whether you're a seasoned baker or new to the kitchen, we've got tips, tricks, and recipes for you. From cookies to cakes, we'll guide you through baking with detailed instructions and helpful hints. Stay tuned for weekly updates, challenges, and behind-the-scenes peeks. Let's bake together and create mouthwatering desserts!",
                Author = Baker.Name,
                ImageUrl = "https://www.posist.com/restaurant-times/wp-content/uploads/2016/10/A-Detailed-Guide-On-Starting-A-Bakery-Business-In-India-In-2023.jpg",
				DatePublished = DateTime.Now,
                UserId = GuestUser.Id
            };
        }
    }
}
