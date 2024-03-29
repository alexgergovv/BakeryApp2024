using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BakeryApp2024.Infrastructure.Migrations
{
    public partial class SeedAndChangedDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Blogs");

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Orders",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "Orders",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "ZipCode",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0,
                comment: "Zip code");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b5939dd6-f35c-4dd6-ad49-bb6bd7375dbe", "AQAAAAEAACcQAAAAEFOKhqpXwZrQdXqF6PqAA7JjO1df5pbcts82fq78njF5XgstQfpELUKA6BqAhQqcIw==", "b98aaf6c-225e-4944-ae74-7615f3bb1d54" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1a7ce2b5-13a6-4da2-8523-ce3e287332e5", "AQAAAAEAACcQAAAAEBHPLAAmMBTEUCwBa2miznd/f5AOLu4HfiCxzc3FUV22a5LFCcxDhqEpgC4AHCA1BQ==", "335c9b05-6565-4cb3-b287-89325e5354f3" });

            migrationBuilder.InsertData(
                table: "BasketItems",
                columns: new[] { "Id", "ImageUrl", "OrderId", "Price", "ProductId", "ProductName", "Quantity", "UserId" },
                values: new object[] { 14, "https://www.californiastrawberries.com/wp-content/uploads/2021/04/Strawberry-Mascarpone-Danishes.png", null, 7.00m, 3, "Mascarpone Puff Pastry", 1, "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e" });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "City", "Country", "CustomerAddress", "CustomerEmail", "CustomerName", "Date", "Number", "Status", "TotalPrice", "UserId", "ZipCode" },
                values: new object[] { 1, "Pleven", "Bulgaria", "Tsar Simeon 123", "gabrielmar284@mail.com", "Gabriel Marinov", new DateTime(2024, 3, 29, 22, 17, 20, 13, DateTimeKind.Local).AddTicks(8376), 123456789, "Pending", 0.00m, "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e", 1000 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BasketItems",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DropColumn(
                name: "City",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Country",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "ZipCode",
                table: "Orders");

            migrationBuilder.CreateTable(
                name: "Blogs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Blog identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false, comment: "User identifier"),
                    Author = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Blog author"),
                    Content = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false, comment: "Blog content"),
                    DatePublished = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Publishing date"),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true, comment: "Blog image url"),
                    Title = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false, comment: "Blog title")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blogs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Blogs_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                },
                comment: "Blog for recipes");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6687a5c4-b508-404a-b03f-84bf07b4a246", "AQAAAAEAACcQAAAAENDUTvUaECkcmuuswz4v3lRzZMAwX1EPgKDvmC10ypeyoLHtrphwr00Ys+WChuG91w==", "d74ca399-3b2a-4e29-9484-fce551e2f651" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0b4c36d6-727b-4229-95b8-a09a1db3dc80", "AQAAAAEAACcQAAAAEGxkdaW7OzR6zX4EzNPwXdi92hd0TdJBuZ062xzikhp35iUF48nlZV8AcyFP8yZ7jw==", "781412ab-f05a-4811-846a-c224c451d659" });

            migrationBuilder.InsertData(
                table: "Blogs",
                columns: new[] { "Id", "Author", "Content", "DatePublished", "ImageUrl", "Title", "UserId" },
                values: new object[] { 1, "Buddy Valastro", "Welcome to our bakery blog! Whether you're a seasoned baker or new to the kitchen, we've got tips, tricks, and recipes for you. From cookies to cakes, we'll guide you through baking with detailed instructions and helpful hints. Stay tuned for weekly updates, challenges, and behind-the-scenes peeks. Let's bake together and create mouthwatering desserts!", new DateTime(2024, 3, 29, 16, 9, 4, 734, DateTimeKind.Local).AddTicks(3522), "https://www.posist.com/restaurant-times/wp-content/uploads/2016/10/A-Detailed-Guide-On-Starting-A-Bakery-Business-In-India-In-2023.jpg", "Baking Bliss: A Guide to Creating Delicious Treats in Your Own Kitchen", "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e" });

            migrationBuilder.CreateIndex(
                name: "IX_Blogs_UserId",
                table: "Blogs",
                column: "UserId");
        }
    }
}
