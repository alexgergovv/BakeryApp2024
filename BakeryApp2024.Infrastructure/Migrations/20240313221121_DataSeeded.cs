using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BakeryApp2024.Infrastructure.Migrations
{
    public partial class DataSeeded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e", 0, "b79b19b1-914b-4a3d-9a2e-d631f96e1d5e", "guest@mail.com", false, false, null, "guest@mail.com", "guest@mail.com", "AQAAAAEAACcQAAAAEEBtvaEfmBYDxnxBhKr2za8a6MoB7V+xY2zL3sjtALqpCu0CN2j7jHGUSoQ0fI6Lag==", null, false, "f0f9aea7-7b04-46bc-a876-ee533a2334c1", false, "guest@mail.com" },
                    { "dea12856-c198-4129-b3f3-b893d8395082", 0, "91ae1c9a-8f45-414f-9cd1-09b8a84cb83d", "baker@mail.com", false, false, null, "baker@mail.com", "baker@mail.com", "AQAAAAEAACcQAAAAEJVKDWEC5IXLiTm6hGQB5zFRj9zbtpo2UYqMsKpjjHlVHeoyzkjwqPQxoyIdkJnVew==", null, false, "4a2be900-83e0-4abc-aa2b-323704cc4dcb", false, "baker@mail.com" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Bread" },
                    { 2, "Pastry" },
                    { 3, "Cake" }
                });

            migrationBuilder.InsertData(
                table: "Bakers",
                columns: new[] { "Id", "Name", "PhoneNumber", "UserId" },
                values: new object[] { 1, "Buddy Valastro", "+359562095974", "dea12856-c198-4129-b3f3-b893d8395082" });

            migrationBuilder.InsertData(
                table: "Blogs",
                columns: new[] { "Id", "Author", "Content", "DatePublished", "Title", "UserId" },
                values: new object[] { 1, "Buddy Valastro", "Welcome to our bakery blog! Whether you're a seasoned baker or new to the kitchen, we've got tips, tricks, and recipes for you. From cookies to cakes, we'll guide you through baking with detailed instructions and helpful hints. Stay tuned for weekly updates, challenges, and behind-the-scenes peeks. Let's bake together and create mouthwatering desserts!", new DateTime(2024, 3, 14, 0, 11, 21, 470, DateTimeKind.Local).AddTicks(9557), "Baking Bliss: A Guide to Creating Delicious Treats in Your Own Kitchen", "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e" });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CustomerAddress", "CustomerEmail", "CustomerName", "Date", "Number", "Price", "ProductName", "Quantity", "Status", "TotalPrice", "UserId" },
                values: new object[] { 1, "Tsar Simeon 123\nSofia, Bulgaria\n1000", "gabrielmar284@mail.com", "Gabriel Marinov", new DateTime(2024, 3, 14, 0, 11, 21, 469, DateTimeKind.Local).AddTicks(225), 123456789, 30.00m, "Raffaello Cake", 2, "Pending", 60.00m, "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "AvailableQuantity", "BakerId", "CategoryId", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { 1, 5, 1, 3, "This Raffaello Cake is a coconut lover’s dream! Layers of moist and tender almond cake, coconut custard, and coconut Swiss meringue buttercream.", "https://livforcake.com/wp-content/uploads/2019/04/raffaello-cake-thumb.jpg", "Raffaello Cake", 60.00m });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "AvailableQuantity", "BakerId", "CategoryId", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { 2, 50, 1, 1, "Experience our artisan bread: handcrafted with care, premium ingredients, and timeless techniques. Delight in its crispy crust, tender crumb, and exquisite flavor.", "https://vegansoprano.com/wp-content/uploads/2021/01/dutch-oven-artisan-bread-7.jpg", "Artisan Oven Bread", 5.00m });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "AvailableQuantity", "BakerId", "CategoryId", "Description", "ImageUrl", "Name", "Price" },
                values: new object[] { 3, 20, 1, 2, "Savor our mascarpone puff pastry: flaky layers filled with creamy mascarpone, a buttery delight for any moment!", "https://www.piesandtacos.com/wp-content/uploads/2023/02/pastries-lemon-curd-mascarpone-5-scaled.jpg", "Mascarpone Puff Pastry", 7.00m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e");

            migrationBuilder.DeleteData(
                table: "Bakers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082");
        }
    }
}
