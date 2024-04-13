using BakeryApp2024.Infrastructure.Data.Models;
using Microsoft.AspNetCore.Identity;

namespace BakeryApp2024.Infrastructure.Data.SeedDb
{
	internal class SeedData
	{
		public ApplicationUser BakerUser { get; set; }
		public ApplicationUser GuestUser { get; set; }
		public ApplicationUser AdminUser { get; set; }
		public Baker Baker { get; set; }
		public Baker AdminBaker { get; set; }
		public Category BreadCategory { get; set; }
		public Category PastryCategory { get; set; }
		public Category CakeCategory { get; set; }
		public Product RaffaelloCake { get; set; }
		public Product ArtisanBread { get; set; }
		public Product MascarponePastry { get; set; }

		public Order GuestUserOrder { get; set; }
		public BasketItem BasketItem { get; set; }
		public Review UserReview { get; set; }

		public SeedData()
		{
			SeedUsers();
			SeedBaker();
			SeedCategories();
			SeedProducts();
			SeedBasketItem();
			SeedOrder();
			SeedReview();
		}

		private void SeedUsers()
		{
			var hasher = new PasswordHasher<ApplicationUser>();

			BakerUser = new ApplicationUser()
			{
				Id = "dea12856-c198-4129-b3f3-b893d8395082",
				UserName = "baker@mail.com",
				NormalizedUserName = "baker@mail.com",
				Email = "baker@mail.com",
				NormalizedEmail = "baker@mail.com",
				FirstName = "Baker",
				LastName = "Bakerov"
			};

			BakerUser.PasswordHash =
				 hasher.HashPassword(BakerUser, "baker123");

			GuestUser = new ApplicationUser()
			{
				Id = "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
				UserName = "guest@mail.com",
				NormalizedUserName = "guest@mail.com",
				Email = "guest@mail.com",
				NormalizedEmail = "guest@mail.com",
				FirstName = "Guest",
				LastName = "Guestov"
			};

			GuestUser.PasswordHash =
			hasher.HashPassword(GuestUser, "guest123");

			AdminUser = new ApplicationUser()
			{
				Id = "b4c615e6-d99c-480f-b6c7-9f95a0c7dd06",
				UserName = "admin@mail.com",
				NormalizedUserName = "ADMIN@MAIL.COM",
				Email = "admin@mail.com",
				NormalizedEmail = "ADMIN@MAIL.COM",
				FirstName = "Great",
				LastName = "Admin"
			};

			AdminUser.PasswordHash =
			hasher.HashPassword(AdminUser, "admin123");
		}

		private void SeedBaker()
		{
			Baker = new Baker()
			{
				Id = 1,
				PhoneNumber = "+359562095974",
				UserId = BakerUser.Id,
				Gender = "Male"
			};

			AdminBaker = new Baker()
			{
				Id = 2,
				PhoneNumber = "+359888888884",
				UserId = AdminUser.Id,
				Gender = "Male"
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
				IsDeleted = false,
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

		private void SeedReview()
		{
			UserReview = new Review()
			{
				Id = 1,
				UserName = "Gabriel Marinov",
				Stars = 5,
				Description = "The best bakery in the city!! Highly recommend!",
				Date = DateTime.Now,
				UserImageUrl = "https://i.pinimg.com/736x/37/ca/2f/37ca2f94586b35e3ca05edc7b062a9cd.jpg",
				UserId = GuestUser.Id
			};
		}
	}
}
