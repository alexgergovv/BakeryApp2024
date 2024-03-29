using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BakeryApp2024.Infrastructure.Migrations
{
    public partial class BasketItemsChanges : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5674402c-8f58-4145-899e-ce754bee716e", "AQAAAAEAACcQAAAAEKLO+Cnc/jCwlCvQrtykEH70xz9DBpaWP4M6nsIMJRQugiDyTdlF5RjRDV6BPwYD2g==", "f6518b9c-d68a-4d32-9464-cf0f2dc67fe2" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "360ce63f-7401-4f81-a444-3c97a5fd1ace", "AQAAAAEAACcQAAAAEObWOw74cv726oULVXCKa3ThomLbRGBrSf4gEwvYVENO9d/pe1vrxf7/8cdEJNb4ow==", "852df1ee-4161-4832-ae6a-8250a3e7d23f" });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 3, 30, 0, 38, 0, 241, DateTimeKind.Local).AddTicks(5706));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 3, 29, 22, 17, 20, 13, DateTimeKind.Local).AddTicks(8376));
        }
    }
}
