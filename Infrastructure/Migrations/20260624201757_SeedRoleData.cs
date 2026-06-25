using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedRoleData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "p_category",
                columns: new[] { "Id", "description", "identity" },
                values: new object[,]
                {
                    { 100, "Hệ thống", "System" },
                    { 101, "Người dùng", "User" }
                });

            migrationBuilder.InsertData(
                table: "p_function",
                columns: new[] { "Id", "category_id", "description", "is_deleted", "permission_key" },
                values: new object[,]
                {
                    { 100, 100, "Cài đặt hệ thống", false, "System/Setting" },
                    { 101, 101, "Xem người dùng", false, "User/View" },
                    { 102, 101, "Tạo người dùng", false, "User/Create" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "p_function",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "p_function",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "p_function",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "p_category",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "p_category",
                keyColumn: "Id",
                keyValue: 101);
        }
    }
}
