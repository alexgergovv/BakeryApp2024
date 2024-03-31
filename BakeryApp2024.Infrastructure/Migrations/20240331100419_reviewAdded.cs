using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BakeryApp2024.Infrastructure.Migrations
{
    public partial class reviewAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Review identifier")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, comment: "User's name"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false, comment: "Review date"),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false, comment: "Review description"),
                    UserImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "User's image URL"),
                    Stars = table.Column<int>(type: "int", nullable: false, comment: "Review stars"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false, comment: "User identifier")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Reviews_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Date", "Description", "Stars", "UserId", "UserImageUrl", "UserName" },
                values: new object[] { 1, new DateTime(2024, 3, 31, 12, 4, 19, 208, DateTimeKind.Local).AddTicks(3024), "The best bakery in the city!! Highly recommend!", 5, "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e", "https://i.pinimg.com/736x/37/ca/2f/37ca2f94586b35e3ca05edc7b062a9cd.jpg", "Gabriel Marinov" });

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_UserId",
                table: "Reviews",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Reviews");

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
                column: "Date",
                value: new DateTime(2024, 3, 30, 0, 57, 26, 4, DateTimeKind.Local).AddTicks(9921));
        }
    }
}
