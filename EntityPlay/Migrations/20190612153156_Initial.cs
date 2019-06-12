using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityPlay.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 200, nullable: false),
                    Age = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Appointments",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Title = table.Column<string>(nullable: true),
                    Date = table.Column<DateTimeOffset>(nullable: false),
                    CustomerId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appointments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Appointments_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Age", "Name" },
                values: new object[] { 1, 5, "James" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Age", "Name" },
                values: new object[] { 2, 6, "Byron" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Age", "Name" },
                values: new object[] { 3, 7, "Nora" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "Id", "CustomerId", "Date", "Title" },
                values: new object[] { 1, 1, new DateTimeOffset(new DateTime(2019, 6, 12, 11, 31, 56, 737, DateTimeKind.Unspecified).AddTicks(4266), new TimeSpan(0, -4, 0, 0, 0)), "Get Teeth Cleaned" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "Id", "CustomerId", "Date", "Title" },
                values: new object[] { 2, 2, new DateTimeOffset(new DateTime(2019, 6, 12, 11, 31, 56, 739, DateTimeKind.Unspecified).AddTicks(5439), new TimeSpan(0, -4, 0, 0, 0)), "Get Teeth Pulled" });

            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "Id", "CustomerId", "Date", "Title" },
                values: new object[] { 3, 2, new DateTimeOffset(new DateTime(2019, 6, 12, 11, 31, 56, 739, DateTimeKind.Unspecified).AddTicks(5463), new TimeSpan(0, -4, 0, 0, 0)), "Get hair cut" });

            migrationBuilder.CreateIndex(
                name: "IX_Appointments_CustomerId",
                table: "Appointments",
                column: "CustomerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Appointments");

            migrationBuilder.DropTable(
                name: "Customers");
        }
    }
}
