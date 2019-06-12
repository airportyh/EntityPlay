using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityPlay.Migrations
{
    public partial class AddedSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Age", "Name" },
                values: new object[] { 1, 5, "James" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Age", "Name" },
                values: new object[] { 2, 6, "Byron" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "Id", "CustomerId", "Date", "Title" },
                values: new object[] { 1, 1, new DateTimeOffset(new DateTime(2019, 6, 12, 11, 10, 32, 323, DateTimeKind.Unspecified).AddTicks(4925), new TimeSpan(0, -4, 0, 0, 0)), "Get Teeth Cleaned" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "Id", "CustomerId", "Date", "Title" },
                values: new object[] { 2, 2, new DateTimeOffset(new DateTime(2019, 6, 12, 11, 10, 32, 326, DateTimeKind.Unspecified).AddTicks(7065), new TimeSpan(0, -4, 0, 0, 0)), "Get Teeth Pulled" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
