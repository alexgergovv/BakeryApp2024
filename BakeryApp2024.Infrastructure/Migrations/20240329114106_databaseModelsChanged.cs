using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BakeryApp2024.Infrastructure.Migrations
{
    public partial class databaseModelsChanged : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "ProductName",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "Orders");

            migrationBuilder.CreateTable(
                name: "BasketItem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Item identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "Product name"),
                    Quantity = table.Column<int>(type: "int", nullable: false, comment: "Products quantity"),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false, comment: "Product price"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false, comment: "User identifier"),
                    OrderId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BasketItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BasketItem_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BasketItem_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id");
                },
                comment: "Basket items");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dc15113a-cdef-4475-a0a5-daa37bf3b867", "AQAAAAEAACcQAAAAENpUCWGtbog4U4TZJRHsmqwFVuRBGBiORK/VYmhOWKzSzX2m+f9jMCb/sup+Uj85yg==", "0f4e0e0b-0f92-4f58-be8b-0037c25da1e3" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7190a7fb-27ab-4911-b695-bb3b356af0e4", "AQAAAAEAACcQAAAAEB7xFE30/q7vhCx09NKvyzp+BWN64Y23hgTnbdn5SJ17q37n7ivoPDbKpN5+kxS60A==", "9ed141c8-de9a-44df-a89c-ffb8acdc6b58" });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatePublished",
                value: new DateTime(2024, 3, 29, 13, 41, 6, 379, DateTimeKind.Local).AddTicks(5469));

            migrationBuilder.CreateIndex(
                name: "IX_BasketItem_OrderId",
                table: "BasketItem",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_BasketItem_UserId",
                table: "BasketItem",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BasketItem");

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "Orders",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m,
                comment: "Product price");

            migrationBuilder.AddColumn<string>(
                name: "ProductName",
                table: "Orders",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                comment: "Product name");

            migrationBuilder.AddColumn<int>(
                name: "Quantity",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0,
                comment: "Products quantity");

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

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "CustomerAddress", "CustomerEmail", "CustomerName", "Date", "Number", "Price", "ProductName", "Quantity", "Status", "TotalPrice", "UserId" },
                values: new object[] { 1, "Tsar Simeon 123\nSofia, Bulgaria\n1000", "gabrielmar284@mail.com", "Gabriel Marinov", new DateTime(2024, 3, 28, 19, 46, 16, 210, DateTimeKind.Local).AddTicks(3515), 123456789, 30.00m, "Raffaello Cake", 2, "Pending", 60.00m, "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e" });
        }
    }
}
