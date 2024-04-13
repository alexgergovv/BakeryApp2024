using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BakeryApp2024.Infrastructure.Migrations
{
    public partial class IsApprovedAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsApproved",
                table: "Products",
                type: "bit",
                nullable: false,
                defaultValue: false,
                comment: "Is product approved by admin");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "76b959c7-918e-4ff7-8f7d-2ee50b0eb3bb", "AQAAAAEAACcQAAAAECGp3Tp6yOQOmNqKdPJ/7dV7MWdGtuYtm6CofXa5wbOKRvs+JQF1UPXsLQJRhWnobw==", "7d81c46b-7708-48fc-962c-5c60489059ce" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b4c615e6-d99c-480f-b6c7-9f95a0c7dd06",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "767303ac-3c28-4ad1-8b0e-686e1fbb438b", "AQAAAAEAACcQAAAAELJGhEXmZgSTC7raOU9XIu/FkDjM8Cvo78M5rVLTDs9PXTn8ocR6mRBi+QtzDCMidQ==", "07a3d27a-dbea-4a79-be4c-b3c3e0168ac5" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "aae2b43e-3ed4-47c2-a7e1-2c69ea1ba61f", "AQAAAAEAACcQAAAAEC1sQu4jm5mQGoQYzfxL2aQbEvgWxPmuikQ5KGMkE8BrCT9eu5ShUA8+dUK0LDugEg==", "25143fed-beb9-492c-acb5-880d37e48a49" });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 4, 13, 20, 45, 2, 547, DateTimeKind.Local).AddTicks(5542));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 4, 13, 20, 45, 2, 553, DateTimeKind.Local).AddTicks(4140));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsApproved",
                table: "Products");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a33946f0-4609-4fe9-b60b-26bf8a2369c0", "AQAAAAEAACcQAAAAEFQaFib3GrUHyff8Ff/Mam3Dbl6sjDO2/yzs8AIC7ciPuihdMOyX/UGXWKZpGH51sw==", "3e1ef45a-3ae3-47d7-ab48-28fffabec0a9" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b4c615e6-d99c-480f-b6c7-9f95a0c7dd06",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7dd402e5-e304-4800-a7b0-d9eca3b78e87", "AQAAAAEAACcQAAAAEHg5qoSA4uhCHPBmwORh8FV2XB4B5hSFh3ZirG5xKH1CHgrxcCmlimswJPb/k2sXkQ==", "77c90290-00cc-41f6-adb0-13ff3241028b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e1305abd-0538-49bd-8d6d-aa0656abd791", "AQAAAAEAACcQAAAAEG1rWRe/yNZhdDGNgPpMrxYpde3120nM3SnOSGUX69GF1V0LZI+CDTzveEH5c+siJg==", "3989f2d6-c70a-4db6-9d4b-e24e932c700e" });

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
        }
    }
}
