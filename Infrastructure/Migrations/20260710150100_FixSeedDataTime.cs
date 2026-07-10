using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class FixSeedDataTime : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "InstructorProfile",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "ManagerProfile",
                keyColumn: "Id",
                keyValue: new Guid("55555555-5555-5555-5555-555555555555"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "InstructorProfile",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 10, 20, 30, 35, 606, DateTimeKind.Local).AddTicks(6068), new DateTime(2026, 7, 10, 20, 30, 35, 606, DateTimeKind.Local).AddTicks(6069) });

            migrationBuilder.UpdateData(
                table: "ManagerProfile",
                keyColumn: "Id",
                keyValue: new Guid("55555555-5555-5555-5555-555555555555"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 10, 20, 30, 35, 606, DateTimeKind.Local).AddTicks(6128), new DateTime(2026, 7, 10, 20, 30, 35, 606, DateTimeKind.Local).AddTicks(6128) });

            migrationBuilder.UpdateData(
                table: "ParentProfile",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 10, 20, 30, 35, 606, DateTimeKind.Local).AddTicks(5993), new DateTime(2026, 7, 10, 20, 30, 35, 606, DateTimeKind.Local).AddTicks(5993) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 10, 20, 30, 35, 606, DateTimeKind.Local).AddTicks(5938), new DateTime(2026, 7, 10, 20, 30, 35, 606, DateTimeKind.Local).AddTicks(5938) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 10, 20, 30, 35, 606, DateTimeKind.Local).AddTicks(5558), new DateTime(2026, 7, 10, 20, 30, 35, 606, DateTimeKind.Local).AddTicks(5575) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 10, 20, 30, 35, 606, DateTimeKind.Local).AddTicks(5645), new DateTime(2026, 7, 10, 20, 30, 35, 606, DateTimeKind.Local).AddTicks(5646) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 10, 20, 30, 35, 606, DateTimeKind.Local).AddTicks(5650), new DateTime(2026, 7, 10, 20, 30, 35, 606, DateTimeKind.Local).AddTicks(5650) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 10, 20, 30, 35, 606, DateTimeKind.Local).AddTicks(5789), new DateTime(2026, 7, 10, 20, 30, 35, 606, DateTimeKind.Local).AddTicks(5790) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("55555555-5555-5555-5555-555555555555"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 10, 20, 30, 35, 606, DateTimeKind.Local).AddTicks(5794), new DateTime(2026, 7, 10, 20, 30, 35, 606, DateTimeKind.Local).AddTicks(5794) });
        }
    }
}
