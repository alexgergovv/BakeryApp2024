﻿// <auto-generated />
using System;
using BakeryApp2024.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BakeryApp2024.Infrastructure.Migrations
{
    [DbContext(typeof(BakeryAppDbContext))]
    [Migration("20240417145921_SeedOrderImproved")]
    partial class SeedOrderImproved
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.28")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BakeryApp2024.Infrastructure.Data.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "dea12856-c198-4129-b3f3-b893d8395082",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "ad0821b0-14da-46c9-9562-0aa35c3a2687",
                            Email = "baker@mail.com",
                            EmailConfirmed = false,
                            FirstName = "Baker",
                            LastName = "Bakerov",
                            LockoutEnabled = false,
                            NormalizedEmail = "baker@mail.com",
                            NormalizedUserName = "baker@mail.com",
                            PasswordHash = "AQAAAAEAACcQAAAAEBBgAirT1j8SrgsUUp7KAAjdI/wMkdmBh4ZHxiwUvCY1m9d8QzYpadUna2mUVXnTqQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "90958a3e-c4fd-4400-bb18-d6eefa3298d6",
                            TwoFactorEnabled = false,
                            UserName = "baker@mail.com"
                        },
                        new
                        {
                            Id = "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "7a7f2c52-f546-409d-912e-7038391cab4f",
                            Email = "guest@mail.com",
                            EmailConfirmed = false,
                            FirstName = "Guest",
                            LastName = "Guestov",
                            LockoutEnabled = false,
                            NormalizedEmail = "guest@mail.com",
                            NormalizedUserName = "guest@mail.com",
                            PasswordHash = "AQAAAAEAACcQAAAAEAlIBLShPhvb+tGPv0BAuDwFcTfyXYH2RbqOkVRKnw02u6laY6SDVmWZ1JoQBJUmBw==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "aabc30ea-80c2-4556-b033-5715968124b3",
                            TwoFactorEnabled = false,
                            UserName = "guest@mail.com"
                        },
                        new
                        {
                            Id = "b4c615e6-d99c-480f-b6c7-9f95a0c7dd06",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "ad7f2bce-af96-4cbd-9c64-5e3d7d3b70c4",
                            Email = "admin@mail.com",
                            EmailConfirmed = false,
                            FirstName = "Great",
                            LastName = "Admin",
                            LockoutEnabled = false,
                            NormalizedEmail = "ADMIN@MAIL.COM",
                            NormalizedUserName = "ADMIN@MAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEEQvi5wBn08XQhRGXPA064gBbfCkRXp3fuPO4P8Y25kG8xVFBAGaulMRPMMMGeLRkQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "bef35803-37d0-4d95-b5af-9de4c740ae6b",
                            TwoFactorEnabled = false,
                            UserName = "admin@mail.com"
                        });
                });

            modelBuilder.Entity("BakeryApp2024.Infrastructure.Data.Models.Baker", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasComment("Baker identifier");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)")
                        .HasComment("Baker's phone number");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)")
                        .HasComment("User identifier");

                    b.HasKey("Id");

                    b.HasIndex("PhoneNumber")
                        .IsUnique();

                    b.HasIndex("UserId")
                        .IsUnique();

                    b.ToTable("Bakers");

                    b.HasComment("Product Baker");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Gender = "Male",
                            PhoneNumber = "+359562095974",
                            UserId = "dea12856-c198-4129-b3f3-b893d8395082"
                        },
                        new
                        {
                            Id = 2,
                            Gender = "Male",
                            PhoneNumber = "+359888888884",
                            UserId = "b4c615e6-d99c-480f-b6c7-9f95a0c7dd06"
                        });
                });

            modelBuilder.Entity("BakeryApp2024.Infrastructure.Data.Models.BasketItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasComment("Item identifier");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasComment("Product image url");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)")
                        .HasComment("Product price");

                    b.Property<int>("ProductId")
                        .HasColumnType("int")
                        .HasComment("Product identifier");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasComment("Product name");

                    b.Property<int>("Quantity")
                        .HasColumnType("int")
                        .HasComment("Products quantity");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)")
                        .HasComment("User identifier");

                    b.HasKey("Id");

                    b.HasIndex("ProductId");

                    b.HasIndex("UserId");

                    b.ToTable("BasketItems");

                    b.HasComment("Basket items");

                    b.HasData(
                        new
                        {
                            Id = 2,
                            ImageUrl = "https://livforcake.com/wp-content/uploads/2019/04/raffaello-cake-thumb.jpg",
                            IsDeleted = false,
                            Price = 60.00m,
                            ProductId = 1,
                            ProductName = "Raffaello Cake",
                            Quantity = 1,
                            UserId = "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e"
                        });
                });

            modelBuilder.Entity("BakeryApp2024.Infrastructure.Data.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasComment("Category identifier");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasComment("Category name");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasComment("Product category");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Bread"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Pastry"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Cake"
                        });
                });

            modelBuilder.Entity("BakeryApp2024.Infrastructure.Data.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasComment("Order identifier");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("BasketItemIds")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("CustomerAddress")
                        .IsRequired()
                        .HasMaxLength(120)
                        .HasColumnType("nvarchar(120)")
                        .HasComment("Customer address");

                    b.Property<string>("CustomerEmail")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("nvarchar(64)")
                        .HasComment("Customer email");

                    b.Property<string>("CustomerName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasComment("Customer name");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2")
                        .HasComment("Order date");

                    b.Property<int>("Number")
                        .HasColumnType("int")
                        .HasComment("Order number");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)")
                        .HasComment("Order status");

                    b.Property<decimal>("TotalPrice")
                        .HasColumnType("decimal(18,2)")
                        .HasComment("Total price");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)")
                        .HasComment("User identifier");

                    b.Property<int>("ZipCode")
                        .HasColumnType("int")
                        .HasComment("Zip code");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Orders");

                    b.HasComment("Products orders");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BasketItemIds = "1",
                            City = "Pleven",
                            Country = "Bulgaria",
                            CustomerAddress = "Tsar Simeon 123",
                            CustomerEmail = "gabrielmar284@mail.com",
                            CustomerName = "Gabriel Marinov",
                            Date = new DateTime(2024, 4, 17, 17, 59, 20, 394, DateTimeKind.Local).AddTicks(9979),
                            Number = 123456789,
                            Status = "Pending",
                            TotalPrice = 7.00m,
                            UserId = "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                            ZipCode = 1000
                        });
                });

            modelBuilder.Entity("BakeryApp2024.Infrastructure.Data.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasComment("Product identifier");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("BakerId")
                        .HasColumnType("int")
                        .HasComment("Baker identifier");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int")
                        .HasComment("Category identifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)")
                        .HasComment("Product description");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasComment("Product image url");

                    b.Property<bool>("IsApproved")
                        .HasColumnType("bit")
                        .HasComment("Is product approved by admin");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasComment("Product name");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)")
                        .HasComment("Product price");

                    b.HasKey("Id");

                    b.HasIndex("BakerId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasComment("Product for sale");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BakerId = 1,
                            CategoryId = 3,
                            Description = "This Raffaello Cake is a coconut lover’s dream! Layers of moist and tender almond cake, coconut custard, and coconut Swiss meringue buttercream.",
                            ImageUrl = "https://livforcake.com/wp-content/uploads/2019/04/raffaello-cake-thumb.jpg",
                            IsApproved = false,
                            Name = "Raffaello Cake",
                            Price = 60.00m
                        },
                        new
                        {
                            Id = 2,
                            BakerId = 1,
                            CategoryId = 1,
                            Description = "Experience our artisan bread: handcrafted with care, premium ingredients, and timeless techniques. Delight in its crispy crust, tender crumb, and exquisite flavor.",
                            ImageUrl = "https://www.kitchensanctuary.com/wp-content/uploads/2020/06/Artisan-Bread-square-FS-46.jpg",
                            IsApproved = false,
                            Name = "Artisan Oven Bread",
                            Price = 5.00m
                        },
                        new
                        {
                            Id = 3,
                            BakerId = 1,
                            CategoryId = 2,
                            Description = "Savor our mascarpone puff pastry: flaky layers filled with creamy mascarpone, a buttery delight for any moment!",
                            ImageUrl = "https://www.californiastrawberries.com/wp-content/uploads/2021/04/Strawberry-Mascarpone-Danishes.png",
                            IsApproved = false,
                            Name = "Mascarpone Puff Pastry",
                            Price = 7.00m
                        });
                });

            modelBuilder.Entity("BakeryApp2024.Infrastructure.Data.Models.Review", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasComment("Review identifier");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2")
                        .HasComment("Review date");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)")
                        .HasComment("Review description");

                    b.Property<int>("Stars")
                        .HasColumnType("int")
                        .HasComment("Review stars");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)")
                        .HasComment("User identifier");

                    b.Property<string>("UserImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasComment("User's image URL");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)")
                        .HasComment("User's name");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Reviews");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Date = new DateTime(2024, 4, 17, 17, 59, 20, 404, DateTimeKind.Local).AddTicks(9755),
                            Description = "The best bakery in the city!! Highly recommend!",
                            Stars = 5,
                            UserId = "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                            UserImageUrl = "https://i.pinimg.com/736x/37/ca/2f/37ca2f94586b35e3ca05edc7b062a9cd.jpg",
                            UserName = "Gabriel Marinov"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ClaimType = "user:fullname",
                            ClaimValue = "Baker Bakerov",
                            UserId = "dea12856-c198-4129-b3f3-b893d8395082"
                        },
                        new
                        {
                            Id = 2,
                            ClaimType = "user:fullname",
                            ClaimValue = "Guest Guestov",
                            UserId = "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e"
                        },
                        new
                        {
                            Id = 3,
                            ClaimType = "user:fullname",
                            ClaimValue = "Great Admin",
                            UserId = "b4c615e6-d99c-480f-b6c7-9f95a0c7dd06"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Name")
                        .HasMaxLength(128)
                        .HasColumnType("nvarchar(128)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("BakeryApp2024.Infrastructure.Data.Models.Baker", b =>
                {
                    b.HasOne("BakeryApp2024.Infrastructure.Data.Models.ApplicationUser", "User")
                        .WithOne("Baker")
                        .HasForeignKey("BakeryApp2024.Infrastructure.Data.Models.Baker", "UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("BakeryApp2024.Infrastructure.Data.Models.BasketItem", b =>
                {
                    b.HasOne("BakeryApp2024.Infrastructure.Data.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BakeryApp2024.Infrastructure.Data.Models.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("User");
                });

            modelBuilder.Entity("BakeryApp2024.Infrastructure.Data.Models.Order", b =>
                {
                    b.HasOne("BakeryApp2024.Infrastructure.Data.Models.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("BakeryApp2024.Infrastructure.Data.Models.Product", b =>
                {
                    b.HasOne("BakeryApp2024.Infrastructure.Data.Models.Baker", "Baker")
                        .WithMany("Products")
                        .HasForeignKey("BakerId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("BakeryApp2024.Infrastructure.Data.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Baker");

                    b.Navigation("Category");
                });

            modelBuilder.Entity("BakeryApp2024.Infrastructure.Data.Models.Review", b =>
                {
                    b.HasOne("BakeryApp2024.Infrastructure.Data.Models.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("BakeryApp2024.Infrastructure.Data.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("BakeryApp2024.Infrastructure.Data.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BakeryApp2024.Infrastructure.Data.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("BakeryApp2024.Infrastructure.Data.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BakeryApp2024.Infrastructure.Data.Models.ApplicationUser", b =>
                {
                    b.Navigation("Baker");
                });

            modelBuilder.Entity("BakeryApp2024.Infrastructure.Data.Models.Baker", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("BakeryApp2024.Infrastructure.Data.Models.Category", b =>
                {
                    b.Navigation("Products");
                });
#pragma warning restore 612, 618
        }
    }
}