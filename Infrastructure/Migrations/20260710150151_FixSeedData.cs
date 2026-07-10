using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class FixSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ParentProfile",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 10, 22, 1, 51, 335, DateTimeKind.Local).AddTicks(2081), new DateTime(2026, 7, 10, 22, 1, 51, 335, DateTimeKind.Local).AddTicks(2081) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 10, 22, 1, 51, 335, DateTimeKind.Local).AddTicks(2045), new DateTime(2026, 7, 10, 22, 1, 51, 335, DateTimeKind.Local).AddTicks(2045) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 10, 22, 1, 51, 335, DateTimeKind.Local).AddTicks(1854), new DateTime(2026, 7, 10, 22, 1, 51, 335, DateTimeKind.Local).AddTicks(1866) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 10, 22, 1, 51, 335, DateTimeKind.Local).AddTicks(1947), new DateTime(2026, 7, 10, 22, 1, 51, 335, DateTimeKind.Local).AddTicks(1948) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 10, 22, 1, 51, 335, DateTimeKind.Local).AddTicks(1958), new DateTime(2026, 7, 10, 22, 1, 51, 335, DateTimeKind.Local).AddTicks(1958) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 10, 22, 1, 51, 335, DateTimeKind.Local).AddTicks(1961), new DateTime(2026, 7, 10, 22, 1, 51, 335, DateTimeKind.Local).AddTicks(1961) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("55555555-5555-5555-5555-555555555555"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 10, 22, 1, 51, 335, DateTimeKind.Local).AddTicks(1964), new DateTime(2026, 7, 10, 22, 1, 51, 335, DateTimeKind.Local).AddTicks(1964) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "ParentProfile",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 10, 22, 0, 59, 234, DateTimeKind.Local).AddTicks(7649), new DateTime(2026, 7, 10, 22, 0, 59, 234, DateTimeKind.Local).AddTicks(7649) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 10, 22, 0, 59, 234, DateTimeKind.Local).AddTicks(7593), new DateTime(2026, 7, 10, 22, 0, 59, 234, DateTimeKind.Local).AddTicks(7594) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 10, 22, 0, 59, 234, DateTimeKind.Local).AddTicks(7337), new DateTime(2026, 7, 10, 22, 0, 59, 234, DateTimeKind.Local).AddTicks(7352) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 10, 22, 0, 59, 234, DateTimeKind.Local).AddTicks(7454), new DateTime(2026, 7, 10, 22, 0, 59, 234, DateTimeKind.Local).AddTicks(7454) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 10, 22, 0, 59, 234, DateTimeKind.Local).AddTicks(7459), new DateTime(2026, 7, 10, 22, 0, 59, 234, DateTimeKind.Local).AddTicks(7459) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 10, 22, 0, 59, 234, DateTimeKind.Local).AddTicks(7462), new DateTime(2026, 7, 10, 22, 0, 59, 234, DateTimeKind.Local).AddTicks(7463) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("55555555-5555-5555-5555-555555555555"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 10, 22, 0, 59, 234, DateTimeKind.Local).AddTicks(7466), new DateTime(2026, 7, 10, 22, 0, 59, 234, DateTimeKind.Local).AddTicks(7467) });
        }
    }
}
