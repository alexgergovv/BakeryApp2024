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
                    { "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e", 0, "15890ed2-d02d-482b-97a3-5f4e5ed77851", "guest@mail.com", false, false, null, "guest@mail.com", "guest@mail.com", "AQAAAAEAACcQAAAAEGi9mju21j1cpJJwmeOXnu4fKu3fnGDiE9333vD9jg4WtMDRuVIF9cg2I8FD0JBxAw==", null, false, "955e920c-0cd0-4fd5-ae7e-ffe1a2155f61", false, "guest@mail.com" },
                    { "dea12856-c198-4129-b3f3-b893d8395082", 0, "75edcc3a-3d97-4c22-8e66-df34ba4b790c", "baker@mail.com", false, false, null, "baker@mail.com", "baker@mail.com", "AQAAAAEAACcQAAAAENL7W40mNEKuvZf//bvYSqsXbT7oOGuVK6V3Ns9sh2F/qASKIZf78ns7Oh1JqlLcTw==", null, false, "3363c9af-ac2d-4144-b0d6-5c821e21e43e", false, "baker@mail.com" }
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
                columns: new[] { "Id", "Author", "Content", "DatePublished", "ImageUrl", "Title", "UserId" },
                values: new object[] { 1, "Buddy Valastro", "Welcome to our bakery blog! Whether you're a seasoned baker or new to the kitchen, we've got tips, tricks, and recipes for you. From cookies to cakes, we'll guide you through baking with detailed instructions and helpful hints. Stay tuned for weekly updates, challenges, and behind-the-scenes peeks. Let's bake together and create mouthwatering desserts!", new DateTime(2024, 3, 14, 15, 57, 24, 739, DateTimeKind.Local).AddTicks(2514), "https://www.posist.com/restaurant-times/wp-content/uploads/2016/10/A-Detailed-Guide-On-Starting-A-Bakery-Business-In-India-In-2023.jpg", "Baking Bliss: A Guide to Creating Delicious Treats in Your Own Kitchen", "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e" });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CustomerAddress", "CustomerEmail", "CustomerName", "Date", "Number", "Price", "ProductName", "Quantity", "Status", "TotalPrice", "UserId" },
                values: new object[] { 1, "Tsar Simeon 123\nSofia, Bulgaria\n1000", "gabrielmar284@mail.com", "Gabriel Marinov", new DateTime(2024, 3, 14, 15, 57, 24, 735, DateTimeKind.Local).AddTicks(6308), 123456789, 30.00m, "Raffaello Cake", 2, "Pending", 60.00m, "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e" });

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
