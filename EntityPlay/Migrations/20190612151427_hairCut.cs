using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityPlay.Migrations
{
    public partial class hairCut : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTimeOffset(new DateTime(2019, 6, 12, 11, 14, 27, 731, DateTimeKind.Unspecified).AddTicks(5242), new TimeSpan(0, -4, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTimeOffset(new DateTime(2019, 6, 12, 11, 14, 27, 733, DateTimeKind.Unspecified).AddTicks(4614), new TimeSpan(0, -4, 0, 0, 0)));

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "Id", "CustomerId", "Date", "Title" },
                values: new object[] { 3, 2, new DateTimeOffset(new DateTime(2019, 6, 12, 11, 14, 27, 733, DateTimeKind.Unspecified).AddTicks(4639), new TimeSpan(0, -4, 0, 0, 0)), "Get hair cut" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTimeOffset(new DateTime(2019, 6, 12, 11, 10, 32, 323, DateTimeKind.Unspecified).AddTicks(4925), new TimeSpan(0, -4, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 2,
                column: "Date",
                value: new DateTimeOffset(new DateTime(2019, 6, 12, 11, 10, 32, 326, DateTimeKind.Unspecified).AddTicks(7065), new TimeSpan(0, -4, 0, 0, 0)));
        }
    }
}
