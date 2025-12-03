using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Colour",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 12, 3, 14, 45, 21, 69, DateTimeKind.Local).AddTicks(2350), new DateTime(2025, 12, 3, 14, 45, 21, 69, DateTimeKind.Local).AddTicks(2364), "Black", "System" },
                    { 2, "System", new DateTime(2025, 12, 3, 14, 45, 21, 69, DateTimeKind.Local).AddTicks(2366), new DateTime(2025, 12, 3, 14, 45, 21, 69, DateTimeKind.Local).AddTicks(2367), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Make",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 12, 3, 14, 45, 21, 69, DateTimeKind.Local).AddTicks(2578), new DateTime(2025, 12, 3, 14, 45, 21, 69, DateTimeKind.Local).AddTicks(2578), "BMW", "System" },
                    { 2, "System", new DateTime(2025, 12, 3, 14, 45, 21, 69, DateTimeKind.Local).AddTicks(2580), new DateTime(2025, 12, 3, 14, 45, 21, 69, DateTimeKind.Local).AddTicks(2580), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Model",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 12, 3, 14, 45, 21, 69, DateTimeKind.Local).AddTicks(2663), new DateTime(2025, 12, 3, 14, 45, 21, 69, DateTimeKind.Local).AddTicks(2663), "i4", "System" },
                    { 2, "System", new DateTime(2025, 12, 3, 14, 45, 21, 69, DateTimeKind.Local).AddTicks(2665), new DateTime(2025, 12, 3, 14, 45, 21, 69, DateTimeKind.Local).AddTicks(2665), "X5", "System" },
                    { 3, "System", new DateTime(2025, 12, 3, 14, 45, 21, 69, DateTimeKind.Local).AddTicks(2666), new DateTime(2025, 12, 3, 14, 45, 21, 69, DateTimeKind.Local).AddTicks(2667), "Prius", "System" },
                    { 4, "System", new DateTime(2025, 12, 3, 14, 45, 21, 69, DateTimeKind.Local).AddTicks(2668), new DateTime(2025, 12, 3, 14, 45, 21, 69, DateTimeKind.Local).AddTicks(2668), "C-HR", "System" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
