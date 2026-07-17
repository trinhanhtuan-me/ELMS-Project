using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class MakePrendIdNullableCourserequest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<Guid>(
                name: "ParentId",
                table: "CourseRequests",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.UpdateData(
                table: "ParentProfile",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 15, 10, 42, 12, 398, DateTimeKind.Local).AddTicks(5629), new DateTime(2026, 7, 15, 10, 42, 12, 398, DateTimeKind.Local).AddTicks(5630) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 15, 10, 42, 12, 398, DateTimeKind.Local).AddTicks(5579), new DateTime(2026, 7, 15, 10, 42, 12, 398, DateTimeKind.Local).AddTicks(5580) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 15, 10, 42, 12, 398, DateTimeKind.Local).AddTicks(5299), new DateTime(2026, 7, 15, 10, 42, 12, 398, DateTimeKind.Local).AddTicks(5317) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 15, 10, 42, 12, 398, DateTimeKind.Local).AddTicks(5390), new DateTime(2026, 7, 15, 10, 42, 12, 398, DateTimeKind.Local).AddTicks(5390) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 15, 10, 42, 12, 398, DateTimeKind.Local).AddTicks(5396), new DateTime(2026, 7, 15, 10, 42, 12, 398, DateTimeKind.Local).AddTicks(5397) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 15, 10, 42, 12, 398, DateTimeKind.Local).AddTicks(5399), new DateTime(2026, 7, 15, 10, 42, 12, 398, DateTimeKind.Local).AddTicks(5400) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("55555555-5555-5555-5555-555555555555"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 15, 10, 42, 12, 398, DateTimeKind.Local).AddTicks(5403), new DateTime(2026, 7, 15, 10, 42, 12, 398, DateTimeKind.Local).AddTicks(5404) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666666"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 15, 10, 42, 12, 398, DateTimeKind.Local).AddTicks(5406), new DateTime(2026, 7, 15, 10, 42, 12, 398, DateTimeKind.Local).AddTicks(5407) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<Guid>(
                name: "ParentId",
                table: "CourseRequests",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "ParentProfile",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 20, 0, 0, 820, DateTimeKind.Local).AddTicks(6913), new DateTime(2026, 7, 13, 20, 0, 0, 820, DateTimeKind.Local).AddTicks(6913) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 20, 0, 0, 820, DateTimeKind.Local).AddTicks(6833), new DateTime(2026, 7, 13, 20, 0, 0, 820, DateTimeKind.Local).AddTicks(6834) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 20, 0, 0, 820, DateTimeKind.Local).AddTicks(6600), new DateTime(2026, 7, 13, 20, 0, 0, 820, DateTimeKind.Local).AddTicks(6615) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 20, 0, 0, 820, DateTimeKind.Local).AddTicks(6669), new DateTime(2026, 7, 13, 20, 0, 0, 820, DateTimeKind.Local).AddTicks(6682) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 20, 0, 0, 820, DateTimeKind.Local).AddTicks(6686), new DateTime(2026, 7, 13, 20, 0, 0, 820, DateTimeKind.Local).AddTicks(6687) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 20, 0, 0, 820, DateTimeKind.Local).AddTicks(6689), new DateTime(2026, 7, 13, 20, 0, 0, 820, DateTimeKind.Local).AddTicks(6690) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("55555555-5555-5555-5555-555555555555"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 20, 0, 0, 820, DateTimeKind.Local).AddTicks(6693), new DateTime(2026, 7, 13, 20, 0, 0, 820, DateTimeKind.Local).AddTicks(6693) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666666"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 20, 0, 0, 820, DateTimeKind.Local).AddTicks(6697), new DateTime(2026, 7, 13, 20, 0, 0, 820, DateTimeKind.Local).AddTicks(6697) });
        }
    }
}
