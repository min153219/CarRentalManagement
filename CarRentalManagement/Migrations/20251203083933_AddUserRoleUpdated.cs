using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class AddUserRoleUpdated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", null, "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "73475cc7-6fde-41dd-8e9a-0c30d58b1365", "admin@localhost.com", true, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEE97Ayr1yI/GbqBZ96uoAc1/IxGAVXZEdU8cEpc2uhXi3ezY3cj7CsNzaeiPWme4Ug==", null, false, "893e75f5-4f86-418c-96d0-2c7d0e006fdb", false, "admin@localhost.com" });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 3, 16, 39, 32, 402, DateTimeKind.Local).AddTicks(9172), new DateTime(2025, 12, 3, 16, 39, 32, 402, DateTimeKind.Local).AddTicks(9187) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 3, 16, 39, 32, 402, DateTimeKind.Local).AddTicks(9190), new DateTime(2025, 12, 3, 16, 39, 32, 402, DateTimeKind.Local).AddTicks(9191) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 3, 16, 39, 32, 402, DateTimeKind.Local).AddTicks(9393), new DateTime(2025, 12, 3, 16, 39, 32, 402, DateTimeKind.Local).AddTicks(9394) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 3, 16, 39, 32, 402, DateTimeKind.Local).AddTicks(9395), new DateTime(2025, 12, 3, 16, 39, 32, 402, DateTimeKind.Local).AddTicks(9395) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 3, 16, 39, 32, 402, DateTimeKind.Local).AddTicks(9492), new DateTime(2025, 12, 3, 16, 39, 32, 402, DateTimeKind.Local).AddTicks(9492) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 3, 16, 39, 32, 402, DateTimeKind.Local).AddTicks(9494), new DateTime(2025, 12, 3, 16, 39, 32, 402, DateTimeKind.Local).AddTicks(9494) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 3, 16, 39, 32, 402, DateTimeKind.Local).AddTicks(9495), new DateTime(2025, 12, 3, 16, 39, 32, 402, DateTimeKind.Local).AddTicks(9496) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 3, 16, 39, 32, 402, DateTimeKind.Local).AddTicks(9497), new DateTime(2025, 12, 3, 16, 39, 32, 402, DateTimeKind.Local).AddTicks(9497) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 3, 16, 11, 46, 87, DateTimeKind.Local).AddTicks(5615), new DateTime(2025, 12, 3, 16, 11, 46, 87, DateTimeKind.Local).AddTicks(5634) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 3, 16, 11, 46, 87, DateTimeKind.Local).AddTicks(5637), new DateTime(2025, 12, 3, 16, 11, 46, 87, DateTimeKind.Local).AddTicks(5638) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 3, 16, 11, 46, 87, DateTimeKind.Local).AddTicks(5984), new DateTime(2025, 12, 3, 16, 11, 46, 87, DateTimeKind.Local).AddTicks(5985) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 3, 16, 11, 46, 87, DateTimeKind.Local).AddTicks(5987), new DateTime(2025, 12, 3, 16, 11, 46, 87, DateTimeKind.Local).AddTicks(5988) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 3, 16, 11, 46, 87, DateTimeKind.Local).AddTicks(6159), new DateTime(2025, 12, 3, 16, 11, 46, 87, DateTimeKind.Local).AddTicks(6160) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 3, 16, 11, 46, 87, DateTimeKind.Local).AddTicks(6162), new DateTime(2025, 12, 3, 16, 11, 46, 87, DateTimeKind.Local).AddTicks(6163) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 3, 16, 11, 46, 87, DateTimeKind.Local).AddTicks(6165), new DateTime(2025, 12, 3, 16, 11, 46, 87, DateTimeKind.Local).AddTicks(6166) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 12, 3, 16, 11, 46, 87, DateTimeKind.Local).AddTicks(6168), new DateTime(2025, 12, 3, 16, 11, 46, 87, DateTimeKind.Local).AddTicks(6169) });
        }
    }
}
