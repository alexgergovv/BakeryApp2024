using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BakeryApp2024.Infrastructure.Migrations
{
    public partial class GenderAddedToBaker : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "Bakers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f82f31b4-cdfc-4dbe-a5cb-8a522928c00f", "AQAAAAEAACcQAAAAELCxIRlbl9cTY7VP8rex7gmDrmfnNLAXeWaZiCX/TN9XD8GMax6QXXnycOguCRkqKA==", "8f6b5c34-c70b-4d13-8beb-038efd47e1ec" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "508ee706-0f77-40d8-b1e0-c0daea654b8a", "AQAAAAEAACcQAAAAEIPq/8byJte6qVobZErpfsRobweBdGBDq9QjTBQ0YRIoiXUn7ljVxR3IELXnvNXPdQ==", "e5b3443e-a4b7-4c66-bb01-789abc9d7d83" });

            migrationBuilder.UpdateData(
                table: "Bakers",
                keyColumn: "Id",
                keyValue: 1,
                column: "Gender",
                value: "Male");

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 4, 1, 11, 9, 22, 803, DateTimeKind.Local).AddTicks(6991));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 4, 1, 11, 9, 22, 807, DateTimeKind.Local).AddTicks(6275));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Bakers");

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
    }
}
