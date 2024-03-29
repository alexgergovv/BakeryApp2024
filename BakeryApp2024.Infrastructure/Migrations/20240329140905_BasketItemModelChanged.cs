using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BakeryApp2024.Infrastructure.Migrations
{
    public partial class BasketItemModelChanged : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6687a5c4-b508-404a-b03f-84bf07b4a246", "AQAAAAEAACcQAAAAENDUTvUaECkcmuuswz4v3lRzZMAwX1EPgKDvmC10ypeyoLHtrphwr00Ys+WChuG91w==", "d74ca399-3b2a-4e29-9484-fce551e2f651" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0b4c36d6-727b-4229-95b8-a09a1db3dc80", "AQAAAAEAACcQAAAAEGxkdaW7OzR6zX4EzNPwXdi92hd0TdJBuZ062xzikhp35iUF48nlZV8AcyFP8yZ7jw==", "781412ab-f05a-4811-846a-c224c451d659" });

            migrationBuilder.UpdateData(
                table: "Blogs",
                keyColumn: "Id",
                keyValue: 1,
                column: "DatePublished",
                value: new DateTime(2024, 3, 29, 16, 9, 4, 734, DateTimeKind.Local).AddTicks(3522));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
