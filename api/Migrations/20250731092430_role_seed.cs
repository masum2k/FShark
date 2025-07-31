using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace api.Migrations
{
    /// <inheritdoc />
    public partial class role_seed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "75626fd0-bf8a-4221-b5a2-6553628ecc62");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "83080ec8-d6fb-482a-b7b5-0192c310dc3f");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3d1e56ba-43c1-4526-9b51-6445502dcb3a", null, "Admin", "ADMIN" },
                    { "d89873da-24ce-401e-ba26-e72999f5271d", null, "User", "USER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3d1e56ba-43c1-4526-9b51-6445502dcb3a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d89873da-24ce-401e-ba26-e72999f5271d");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "75626fd0-bf8a-4221-b5a2-6553628ecc62", null, "Admin", "ADMIN" },
                    { "83080ec8-d6fb-482a-b7b5-0192c310dc3f", null, "User", "USER" }
                });
        }
    }
}
