using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BakeryApp2024.Infrastructure.Migrations
{
    public partial class SeedBasketItemImproved : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BasketItems",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "86737ae8-6c1d-4ab4-ad27-3c9a534d8cb8", "AQAAAAEAACcQAAAAEDV5RZqTp/n0fWVirp146sejcHtHSFmkCt3vBZNjE0SHBNJb5mJprT0/sNTFQW000A==", "b345fe76-6b32-4ee4-80f7-2d39d90d2ff2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b4c615e6-d99c-480f-b6c7-9f95a0c7dd06",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "160c24bc-5eb9-40fa-915a-2a1dfc05b951", "AQAAAAEAACcQAAAAECIYgw7OHvF0fmZqe9o85A9zIuCgbgnZkFh14E5f9Pair54/RdJTYDJ1zDzXnASsLQ==", "d0a777f5-fa33-410f-a903-784a2e570591" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fb46fa65-6eae-4948-b475-a6928453849a", "AQAAAAEAACcQAAAAEOqgl6+UlvtsHeXfBjYJRC0qGxphHzM1ddue23S+xhVIz7L41pzZ706NNrZnmI5Dlw==", "64142e83-ebe9-4bdb-8a42-8ba469adb8c1" });

            migrationBuilder.InsertData(
                table: "BasketItems",
                columns: new[] { "Id", "ImageUrl", "IsDeleted", "Price", "ProductId", "ProductName", "Quantity", "UserId" },
                values: new object[] { 2, "https://livforcake.com/wp-content/uploads/2019/04/raffaello-cake-thumb.jpg", false, 60.00m, 1, "Raffaello Cake", 1, "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e" });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 4, 17, 17, 57, 11, 246, DateTimeKind.Local).AddTicks(3189));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 4, 17, 17, 57, 11, 261, DateTimeKind.Local).AddTicks(2714));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BasketItems",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "80e59c44-82c5-4e13-ad05-64bf4245dabb", "AQAAAAEAACcQAAAAEB2xKc5UId92NPj2U4qenPbkDTIKMMRaIqOMAEmy82zjvwfcgztbdZWDUB3ka9Eanw==", "bf783103-cf33-4ad7-ae8a-8ebfdd1d51e0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b4c615e6-d99c-480f-b6c7-9f95a0c7dd06",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a0fb3070-d7ff-4ea7-a4d0-cb98fe116ca0", "AQAAAAEAACcQAAAAEJS1PNiTrPrUDjY/fM1+neDjl/5q7OyJv4ugK0F6ggrsyq5VdGzPECgXaAIoOXDEGw==", "4faf05f2-9724-45c9-9e43-19b9c7707d13" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "571f0e51-38d2-49e6-8b56-a3f761b6c590", "AQAAAAEAACcQAAAAEORrlxXHW+hUbqupe+DUBYD/4UJA6he5lhhmeTnxfmCq6VIglTbf/BzEogjsoy8txw==", "bf678afd-f5e6-4fb1-b72d-7bad25d12e60" });

            migrationBuilder.InsertData(
                table: "BasketItems",
                columns: new[] { "Id", "ImageUrl", "IsDeleted", "Price", "ProductId", "ProductName", "Quantity", "UserId" },
                values: new object[] { 14, "https://www.californiastrawberries.com/wp-content/uploads/2021/04/Strawberry-Mascarpone-Danishes.png", false, 7.00m, 3, "Mascarpone Puff Pastry", 1, "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e" });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 4, 16, 23, 39, 39, 33, DateTimeKind.Local).AddTicks(6074));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 4, 16, 23, 39, 39, 44, DateTimeKind.Local).AddTicks(758));
        }
    }
}
