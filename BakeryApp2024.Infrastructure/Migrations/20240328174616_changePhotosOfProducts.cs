using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BakeryApp2024.Infrastructure.Migrations
{
    public partial class changePhotosOfProducts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dc3e9e22-2abf-48e4-b5f8-56dbf9a9659f", "AQAAAAEAACcQAAAAEBCafUn4bpqniVAo3gcjxZzNYjriFwJB48XbEfSbB3UA+8JQotv+0XVbbalvyonggQ==", "ea337cc7-46a2-443a-b8b3-2f418c386fd5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "08473922-194e-4799-b435-1fa65abae4e3", "AQAAAAEAACcQAAAAEH8V7xn95vk1T5kzazFsldU2U8lfenHtRlA2GZIcwycjPREMzRRvxjlnAsU2rfrUZQ==", "1891d1f3-9712-426b-a59b-9f92de411fa1" });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatePublished",
                value: new DateTime(2024, 3, 28, 19, 46, 16, 213, DateTimeKind.Local).AddTicks(8422));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 3, 28, 19, 46, 16, 210, DateTimeKind.Local).AddTicks(3515));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "https://www.kitchensanctuary.com/wp-content/uploads/2020/06/Artisan-Bread-square-FS-46.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: "https://www.californiastrawberries.com/wp-content/uploads/2021/04/Strawberry-Mascarpone-Danishes.png");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "ImageUrl",
                value: "https://vegansoprano.com/wp-content/uploads/2021/01/dutch-oven-artisan-bread-7.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "ImageUrl",
                value: "https://www.piesandtacos.com/wp-content/uploads/2023/02/pastries-lemon-curd-mascarpone-5-scaled.jpg");
        }
    }
}
