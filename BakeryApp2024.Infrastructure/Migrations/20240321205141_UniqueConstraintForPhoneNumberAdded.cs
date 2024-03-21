using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BakeryApp2024.Infrastructure.Migrations
{
    public partial class UniqueConstraintForPhoneNumberAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.CreateIndex(
                name: "IX_Bakers_PhoneNumber",
                table: "Bakers",
                column: "PhoneNumber",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Bakers_PhoneNumber",
                table: "Bakers");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "15890ed2-d02d-482b-97a3-5f4e5ed77851", "AQAAAAEAACcQAAAAEGi9mju21j1cpJJwmeOXnu4fKu3fnGDiE9333vD9jg4WtMDRuVIF9cg2I8FD0JBxAw==", "955e920c-0cd0-4fd5-ae7e-ffe1a2155f61" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "75edcc3a-3d97-4c22-8e66-df34ba4b790c", "AQAAAAEAACcQAAAAENL7W40mNEKuvZf//bvYSqsXbT7oOGuVK6V3Ns9sh2F/qASKIZf78ns7Oh1JqlLcTw==", "3363c9af-ac2d-4144-b0d6-5c821e21e43e" });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatePublished",
                value: new DateTime(2024, 3, 14, 15, 57, 24, 739, DateTimeKind.Local).AddTicks(2514));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 3, 14, 15, 57, 24, 735, DateTimeKind.Local).AddTicks(6308));
        }
    }
}
