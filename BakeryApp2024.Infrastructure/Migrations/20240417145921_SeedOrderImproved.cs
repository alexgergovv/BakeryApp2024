using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BakeryApp2024.Infrastructure.Migrations
{
    public partial class SeedOrderImproved : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7a7f2c52-f546-409d-912e-7038391cab4f", "AQAAAAEAACcQAAAAEAlIBLShPhvb+tGPv0BAuDwFcTfyXYH2RbqOkVRKnw02u6laY6SDVmWZ1JoQBJUmBw==", "aabc30ea-80c2-4556-b033-5715968124b3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b4c615e6-d99c-480f-b6c7-9f95a0c7dd06",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ad7f2bce-af96-4cbd-9c64-5e3d7d3b70c4", "AQAAAAEAACcQAAAAEEQvi5wBn08XQhRGXPA064gBbfCkRXp3fuPO4P8Y25kG8xVFBAGaulMRPMMMGeLRkQ==", "bef35803-37d0-4d95-b5af-9de4c740ae6b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ad0821b0-14da-46c9-9562-0aa35c3a2687", "AQAAAAEAACcQAAAAEBBgAirT1j8SrgsUUp7KAAjdI/wMkdmBh4ZHxiwUvCY1m9d8QzYpadUna2mUVXnTqQ==", "90958a3e-c4fd-4400-bb18-d6eefa3298d6" });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BasketItemIds", "Date" },
                values: new object[] { "1", new DateTime(2024, 4, 17, 17, 59, 20, 394, DateTimeKind.Local).AddTicks(9979) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 4, 17, 17, 59, 20, 404, DateTimeKind.Local).AddTicks(9755));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BasketItemIds", "Date" },
                values: new object[] { "14", new DateTime(2024, 4, 17, 17, 57, 11, 246, DateTimeKind.Local).AddTicks(3189) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 4, 17, 17, 57, 11, 261, DateTimeKind.Local).AddTicks(2714));
        }
    }
}
