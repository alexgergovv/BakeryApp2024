using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BakeryApp2024.Infrastructure.Migrations
{
    public partial class BasketItemModified : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BasketItem_AspNetUsers_UserId",
                table: "BasketItem");

            migrationBuilder.DropForeignKey(
                name: "FK_BasketItem_Orders_OrderId",
                table: "BasketItem");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BasketItem",
                table: "BasketItem");

            migrationBuilder.RenameTable(
                name: "BasketItem",
                newName: "BasketItems");

            migrationBuilder.RenameIndex(
                name: "IX_BasketItem_UserId",
                table: "BasketItems",
                newName: "IX_BasketItems_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_BasketItem_OrderId",
                table: "BasketItems",
                newName: "IX_BasketItems_OrderId");

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "BasketItems",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                comment: "Product image url");

            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "BasketItems",
                type: "int",
                nullable: false,
                defaultValue: 0,
                comment: "Product identifier");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BasketItems",
                table: "BasketItems",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fc53b996-2ba2-47b9-90b7-12cfa891c60c", "AQAAAAEAACcQAAAAECTkF2SZqQyAGg1cNb1sp+3WQ07e0x83UlDVyas6kgvn6Zfyi9D5zJHtMMzowf48Fw==", "583313e0-7d88-476e-b0e7-53adf4f9e3fb" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3ca14042-7629-4f1d-9583-484906c52ed1", "AQAAAAEAACcQAAAAENTYrL9KkAGgAlg9kQoJU/414ejMj7QVacklYsdHEg08BfoJB6gqqbYF6jc9+RJwSw==", "07baf533-619e-4fb5-adf0-e8c22df08e41" });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatePublished",
                value: new DateTime(2024, 3, 29, 14, 37, 47, 509, DateTimeKind.Local).AddTicks(650));

            migrationBuilder.CreateIndex(
                name: "IX_BasketItems_ProductId",
                table: "BasketItems",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_BasketItems_AspNetUsers_UserId",
                table: "BasketItems",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BasketItems_Orders_OrderId",
                table: "BasketItems",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_BasketItems_Products_ProductId",
                table: "BasketItems",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BasketItems_AspNetUsers_UserId",
                table: "BasketItems");

            migrationBuilder.DropForeignKey(
                name: "FK_BasketItems_Orders_OrderId",
                table: "BasketItems");

            migrationBuilder.DropForeignKey(
                name: "FK_BasketItems_Products_ProductId",
                table: "BasketItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BasketItems",
                table: "BasketItems");

            migrationBuilder.DropIndex(
                name: "IX_BasketItems_ProductId",
                table: "BasketItems");

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "BasketItems");

            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "BasketItems");

            migrationBuilder.RenameTable(
                name: "BasketItems",
                newName: "BasketItem");

            migrationBuilder.RenameIndex(
                name: "IX_BasketItems_UserId",
                table: "BasketItem",
                newName: "IX_BasketItem_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_BasketItems_OrderId",
                table: "BasketItem",
                newName: "IX_BasketItem_OrderId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BasketItem",
                table: "BasketItem",
                column: "Id");

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

            migrationBuilder.AddForeignKey(
                name: "FK_BasketItem_AspNetUsers_UserId",
                table: "BasketItem",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BasketItem_Orders_OrderId",
                table: "BasketItem",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id");
        }
    }
}
