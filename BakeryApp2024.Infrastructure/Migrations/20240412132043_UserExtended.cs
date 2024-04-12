using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BakeryApp2024.Infrastructure.Migrations
{
    public partial class UserExtended : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "Reviews",
                type: "nvarchar(40)",
                maxLength: 40,
                nullable: false,
                comment: "User's name",
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldComment: "User's name");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "FirstName", "LastName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2c349d9f-4304-48cd-bb1a-5aa43f4a7b61", "", "", "AQAAAAEAACcQAAAAEJFOb/id0jgEj3zcwV518ocUzJVCyHZKNbENJmnU8p73g/4emiHwHnyKYKKi68bEbA==", "9269a610-c156-42fb-bffd-7aa031127064" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "FirstName", "LastName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "12cc5bdd-7105-4e98-ae1c-1b9455f027d1", "", "", "AQAAAAEAACcQAAAAEKCEhQ0NDv/zkOKg4g3qKCvjW3memxBTEBXJphLM1R4EdsZn+gtksDOPPWqVYwyltQ==", "bcab7ba5-f9c0-4144-bffb-e8dcac7de18b" });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 4, 12, 16, 20, 42, 603, DateTimeKind.Local).AddTicks(9136));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 4, 12, 16, 20, 42, 607, DateTimeKind.Local).AddTicks(7934));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "Reviews",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                comment: "User's name",
                oldClrType: typeof(string),
                oldType: "nvarchar(40)",
                oldMaxLength: 40,
                oldComment: "User's name");

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
    }
}
