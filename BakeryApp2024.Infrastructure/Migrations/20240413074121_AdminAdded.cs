using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BakeryApp2024.Infrastructure.Migrations
{
    public partial class AdminAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Bakers");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "FirstName", "LastName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a33946f0-4609-4fe9-b60b-26bf8a2369c0", "Guest", "Guestov", "AQAAAAEAACcQAAAAEFQaFib3GrUHyff8Ff/Mam3Dbl6sjDO2/yzs8AIC7ciPuihdMOyX/UGXWKZpGH51sw==", "3e1ef45a-3ae3-47d7-ab48-28fffabec0a9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "FirstName", "LastName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e1305abd-0538-49bd-8d6d-aa0656abd791", "Baker", "Bakerov", "AQAAAAEAACcQAAAAEG1rWRe/yNZhdDGNgPpMrxYpde3120nM3SnOSGUX69GF1V0LZI+CDTzveEH5c+siJg==", "3989f2d6-c70a-4db6-9d4b-e24e932c700e" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "b4c615e6-d99c-480f-b6c7-9f95a0c7dd06", 0, "7dd402e5-e304-4800-a7b0-d9eca3b78e87", "admin@mail.com", false, "Great", "Admin", false, null, "ADMIN@MAIL.COM", "ADMIN@MAIL.COM", "AQAAAAEAACcQAAAAEHg5qoSA4uhCHPBmwORh8FV2XB4B5hSFh3ZirG5xKH1CHgrxcCmlimswJPb/k2sXkQ==", null, false, "77c90290-00cc-41f6-adb0-13ff3241028b", false, "admin@mail.com" });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 4, 13, 10, 41, 21, 175, DateTimeKind.Local).AddTicks(1609));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 4, 13, 10, 41, 21, 189, DateTimeKind.Local).AddTicks(3995));

            migrationBuilder.InsertData(
                table: "Bakers",
                columns: new[] { "Id", "Gender", "PhoneNumber", "UserId" },
                values: new object[] { 2, "Male", "+359888888884", "b4c615e6-d99c-480f-b6c7-9f95a0c7dd06" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Bakers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b4c615e6-d99c-480f-b6c7-9f95a0c7dd06");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Bakers",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                comment: "Baker name");

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
                table: "Bakers",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Buddy Valastro");

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
    }
}
