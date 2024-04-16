using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BakeryApp2024.Infrastructure.Migrations
{
    public partial class SeedOrderChanged : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Bakers_UserId",
                table: "Bakers");

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

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BasketItemIds", "Date", "TotalPrice" },
                values: new object[] { "14", new DateTime(2024, 4, 16, 23, 39, 39, 33, DateTimeKind.Local).AddTicks(6074), 7.00m });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 4, 16, 23, 39, 39, 44, DateTimeKind.Local).AddTicks(758));

            migrationBuilder.CreateIndex(
                name: "IX_Bakers_UserId",
                table: "Bakers",
                column: "UserId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Bakers_UserId",
                table: "Bakers");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "959c9b8c-5816-47ac-a8f5-891491ad8cf0", "AQAAAAEAACcQAAAAEKPSlFOECON4t5liaZr/D7MuBz3SitoAZTulwAeSwcm0jNkBSB/wEK2T5uDIf7HYqw==", "4422bb2a-2412-4e52-b843-e297e75483ce" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b4c615e6-d99c-480f-b6c7-9f95a0c7dd06",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "90ac954d-e0fe-4fb3-9771-5a031fd4c889", "AQAAAAEAACcQAAAAECrqkwicIs84rYqBrww7g9qPQ4GOlF5NWqP5g3Z7EkBp7UwEpWde2ghHomOu8duE6w==", "a10a53cd-a7bf-4082-8f68-9a0bdcfb183a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c26faf02-bfd0-42e7-bbb0-d421e7dccab2", "AQAAAAEAACcQAAAAEEGcSEg7vfOc5d7zGVGzPnahP9P84YqVd/uEFqgplU9jBkYgUvyqvSaSpisv9M0LGw==", "488e32f3-b589-46a6-a646-b49bbcfb4917" });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BasketItemIds", "Date", "TotalPrice" },
                values: new object[] { "", new DateTime(2024, 4, 13, 22, 57, 40, 455, DateTimeKind.Local).AddTicks(5667), 0.00m });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 4, 13, 22, 57, 40, 461, DateTimeKind.Local).AddTicks(3670));

            migrationBuilder.CreateIndex(
                name: "IX_Bakers_UserId",
                table: "Bakers",
                column: "UserId");
        }
    }
}
