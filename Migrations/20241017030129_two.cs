using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InventoryManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class two : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Email", "Name", "Password", "SerialNumber", "Status", "UserId", "by", "when" },
                values: new object[] { 1, "Hossein.Sabzian@maine.edu", "Hossein", "RyanLove@@10", 55, "OK", 1, "Today", new DateTime(2024, 10, 16, 23, 1, 29, 277, DateTimeKind.Local).AddTicks(1538) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
