using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BakeryApp2024.Infrastructure.Migrations
{
    public partial class changedDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AvailableQuantity",
                table: "Products");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9e22c317-82b2-49f8-9425-3d039ae16341", "AQAAAAEAACcQAAAAEK1ifqmt5zbULObpBp5Lf+KryTe+a+YQ0UJhioRRIdvBxtkj0MfuFqr4i2z1iUkYcg==", "20a121fe-f58c-4ef3-9b63-880e251f90a4" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6fb784bb-5ca4-4509-9a01-32f1cf8048af", "AQAAAAEAACcQAAAAEGGsvhqvKf//3TEhcISWvOhMVxu1MIFT5FxPDNneca4GNn7WdvFD5il6Vr/9yooW2w==", "9c02d95a-adf9-4de0-9d09-0ecc3a94d657" });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatePublished",
                value: new DateTime(2024, 3, 28, 17, 59, 55, 812, DateTimeKind.Local).AddTicks(2149));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 3, 28, 17, 59, 55, 808, DateTimeKind.Local).AddTicks(8901));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AvailableQuantity",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0,
                comment: "Available quantity");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "42ad127f-25e7-4453-af54-6f903e28cc64", "AQAAAAEAACcQAAAAEHwqKeJeLiZGE5MrDWzaZwsPX4dFmZHcvhDPAPm1yGDhOrk4AgZXnitQGDrLKQ6onw==", "4eb41696-eec0-4eaf-9ca8-d1ae9f6e64cb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "df31a4f6-edb6-4d4b-b3bc-944d57faf18e", "AQAAAAEAACcQAAAAEP+iKQmlXkmo86rdcHqmjSR/X7Dw63C2SszOto4Ty9oyndzFlGSourxANqHcGKpxjw==", "841f9cf2-6f70-4bdd-ba98-6da9e235c840" });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatePublished",
                value: new DateTime(2024, 3, 21, 22, 51, 40, 747, DateTimeKind.Local).AddTicks(8304));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 3, 21, 22, 51, 40, 745, DateTimeKind.Local).AddTicks(8888));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "AvailableQuantity",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "AvailableQuantity",
                value: 50);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "AvailableQuantity",
                value: 20);
        }
    }
}
