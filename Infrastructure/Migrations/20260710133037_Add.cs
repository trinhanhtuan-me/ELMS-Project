using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Add : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "InstructorProfile",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 30, 1, 27, 50, 305, DateTimeKind.Local).AddTicks(5577), new DateTime(2026, 6, 30, 1, 27, 50, 305, DateTimeKind.Local).AddTicks(5577) });

            migrationBuilder.UpdateData(
                table: "ManagerProfile",
                keyColumn: "Id",
                keyValue: new Guid("55555555-5555-5555-5555-555555555555"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 30, 1, 27, 50, 305, DateTimeKind.Local).AddTicks(5638), new DateTime(2026, 6, 30, 1, 27, 50, 305, DateTimeKind.Local).AddTicks(5639) });

            migrationBuilder.UpdateData(
                table: "ParentProfile",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 30, 1, 27, 50, 305, DateTimeKind.Local).AddTicks(5515), new DateTime(2026, 6, 30, 1, 27, 50, 305, DateTimeKind.Local).AddTicks(5515) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 30, 1, 27, 50, 305, DateTimeKind.Local).AddTicks(5444), new DateTime(2026, 6, 30, 1, 27, 50, 305, DateTimeKind.Local).AddTicks(5444) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 30, 1, 27, 50, 305, DateTimeKind.Local).AddTicks(5161), new DateTime(2026, 6, 30, 1, 27, 50, 305, DateTimeKind.Local).AddTicks(5178) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 30, 1, 27, 50, 305, DateTimeKind.Local).AddTicks(5225), new DateTime(2026, 6, 30, 1, 27, 50, 305, DateTimeKind.Local).AddTicks(5226) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 30, 1, 27, 50, 305, DateTimeKind.Local).AddTicks(5242), new DateTime(2026, 6, 30, 1, 27, 50, 305, DateTimeKind.Local).AddTicks(5243) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 30, 1, 27, 50, 305, DateTimeKind.Local).AddTicks(5261), new DateTime(2026, 6, 30, 1, 27, 50, 305, DateTimeKind.Local).AddTicks(5262) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("55555555-5555-5555-5555-555555555555"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 30, 1, 27, 50, 305, DateTimeKind.Local).AddTicks(5266), new DateTime(2026, 6, 30, 1, 27, 50, 305, DateTimeKind.Local).AddTicks(5266) });
        }
    }
}
