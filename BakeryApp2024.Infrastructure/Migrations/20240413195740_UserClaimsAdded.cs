using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BakeryApp2024.Infrastructure.Migrations
{
    public partial class UserClaimsAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUserClaims",
                columns: new[] { "Id", "ClaimType", "ClaimValue", "UserId" },
                values: new object[,]
                {
                    { 1, "user:fullname", "Baker Bakerov", "dea12856-c198-4129-b3f3-b893d8395082" },
                    { 2, "user:fullname", "Guest Guestov", "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e" },
                    { 3, "user:fullname", "Great Admin", "b4c615e6-d99c-480f-b6c7-9f95a0c7dd06" }
                });

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
                column: "Date",
                value: new DateTime(2024, 4, 13, 22, 57, 40, 455, DateTimeKind.Local).AddTicks(5667));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 4, 13, 22, 57, 40, 461, DateTimeKind.Local).AddTicks(3670));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "76b959c7-918e-4ff7-8f7d-2ee50b0eb3bb", "AQAAAAEAACcQAAAAECGp3Tp6yOQOmNqKdPJ/7dV7MWdGtuYtm6CofXa5wbOKRvs+JQF1UPXsLQJRhWnobw==", "7d81c46b-7708-48fc-962c-5c60489059ce" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b4c615e6-d99c-480f-b6c7-9f95a0c7dd06",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "767303ac-3c28-4ad1-8b0e-686e1fbb438b", "AQAAAAEAACcQAAAAELJGhEXmZgSTC7raOU9XIu/FkDjM8Cvo78M5rVLTDs9PXTn8ocR6mRBi+QtzDCMidQ==", "07a3d27a-dbea-4a79-be4c-b3c3e0168ac5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "aae2b43e-3ed4-47c2-a7e1-2c69ea1ba61f", "AQAAAAEAACcQAAAAEC1sQu4jm5mQGoQYzfxL2aQbEvgWxPmuikQ5KGMkE8BrCT9eu5ShUA8+dUK0LDugEg==", "25143fed-beb9-492c-acb5-880d37e48a49" });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 4, 13, 20, 45, 2, 547, DateTimeKind.Local).AddTicks(5542));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 4, 13, 20, 45, 2, 553, DateTimeKind.Local).AddTicks(4140));
        }
    }
}
