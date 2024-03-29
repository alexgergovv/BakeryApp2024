using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BakeryApp2024.Infrastructure.Migrations
{
    public partial class OrderEntityChanged : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BasketItems_Orders_OrderId",
                table: "BasketItems");

            migrationBuilder.DropIndex(
                name: "IX_BasketItems_OrderId",
                table: "BasketItems");

            migrationBuilder.DropColumn(
                name: "OrderId",
                table: "BasketItems");

            migrationBuilder.AddColumn<string>(
                name: "BasketItemIds",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "14e31d44-b84b-4b29-ba66-a70a8a9a68db", "AQAAAAEAACcQAAAAEKS/sENVuY95UWIXsGyAm/ZYs02tfEObX+q/UAap9eSo47j9fgktelEFFNxd8vRtIQ==", "1a53b942-e66c-4df9-89d7-8c8bb9eff1c0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "460699ef-e08e-4889-81aa-6b4a9cab615c", "AQAAAAEAACcQAAAAEBOwiEzU4Ls8hDPehhsjJL0/qtAobs4HsuyAq+fDsjFcOgB2ut2tL/6VRUcciiQPwQ==", "bfc62d64-6ed6-4218-a341-e7aa3eeb182e" });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BasketItemIds", "Date" },
                values: new object[] { "", new DateTime(2024, 3, 30, 0, 57, 26, 4, DateTimeKind.Local).AddTicks(9921) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BasketItemIds",
                table: "Orders");

            migrationBuilder.AddColumn<int>(
                name: "OrderId",
                table: "BasketItems",
                type: "int",
                nullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_BasketItems_OrderId",
                table: "BasketItems",
                column: "OrderId");

            migrationBuilder.AddForeignKey(
                name: "FK_BasketItems_Orders_OrderId",
                table: "BasketItems",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id");
        }
    }
}
