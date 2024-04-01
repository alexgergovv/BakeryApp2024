using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BakeryApp2024.Infrastructure.Migrations
{
    public partial class PropertyAddedToBasketItem : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "BasketItems",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "752082bd-3be0-43e6-b065-c196d7ee00e5", "AQAAAAEAACcQAAAAEGCSJMnBZ+Cj5m/vlkmBSTO0EnM2bjIjhYZFds3j/OxDCNYYoDi2WG6tmGNSUyGK+w==", "98edaa0e-00d9-4b5f-9320-35d028e9bea2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2686cf6c-3f72-4378-b460-35a88c27910a", "AQAAAAEAACcQAAAAEBPKRXke5iYTtabCZZ6sFg2vKDgrEd+GllElbLKHpcEABHqEeF3z8VNjh/Kf+2ba1Q==", "c8d9d325-d0eb-4a10-aa74-6512138b77eb" });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 4, 1, 0, 42, 52, 747, DateTimeKind.Local).AddTicks(1630));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 4, 1, 0, 42, 52, 751, DateTimeKind.Local).AddTicks(365));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "BasketItems");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9141c862-74d2-48ea-82e0-51422fdcd0b8", "AQAAAAEAACcQAAAAEKOpeXAc5y5s3r0CU6RoO310l2V2AlzujDdfhn3s93ns4lAUnhuK4OrycEUBQ5fvKA==", "248ba015-f3d5-458d-a1ab-58fb6fc428d1" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "58ddaaab-29bf-4d6d-b582-cd73a31f2a13", "AQAAAAEAACcQAAAAEKNsbg8Bgn9un99F4lyZnQldtC8iMnvZzUFYL3JREnLfuI+b50Yqw2e83dEBJxjJEA==", "a9056c19-5694-4182-8bb5-d0323db742b2" });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 3, 31, 12, 4, 19, 204, DateTimeKind.Local).AddTicks(4304));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 3, 31, 12, 4, 19, 208, DateTimeKind.Local).AddTicks(3024));
        }
    }
}
