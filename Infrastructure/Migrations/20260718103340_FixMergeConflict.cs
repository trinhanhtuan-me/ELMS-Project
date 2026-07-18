using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class FixMergeConflict : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("88888888-8888-8888-8888-888888888888"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 17, 33, 38, 29, DateTimeKind.Local).AddTicks(9105));

            migrationBuilder.UpdateData(
                table: "Module",
                keyColumn: "Id",
                keyValue: new Guid("77777777-7777-7777-7777-777777777777"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 17, 33, 38, 29, DateTimeKind.Local).AddTicks(9156), new DateTime(2026, 7, 18, 17, 33, 38, 29, DateTimeKind.Local).AddTicks(9157) });

            migrationBuilder.UpdateData(
                table: "ModuleItem",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666601"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 17, 33, 38, 29, DateTimeKind.Local).AddTicks(9223), new DateTime(2026, 7, 18, 17, 33, 38, 29, DateTimeKind.Local).AddTicks(9223) });

            migrationBuilder.UpdateData(
                table: "ModuleItem",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666602"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 17, 33, 38, 29, DateTimeKind.Local).AddTicks(9228), new DateTime(2026, 7, 18, 17, 33, 38, 29, DateTimeKind.Local).AddTicks(9228) });

            migrationBuilder.UpdateData(
                table: "ModuleItem",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666603"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 17, 33, 38, 29, DateTimeKind.Local).AddTicks(9230), new DateTime(2026, 7, 18, 17, 33, 38, 29, DateTimeKind.Local).AddTicks(9230) });

            migrationBuilder.UpdateData(
                table: "ModuleItem",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666604"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 17, 33, 38, 29, DateTimeKind.Local).AddTicks(9232), new DateTime(2026, 7, 18, 17, 33, 38, 29, DateTimeKind.Local).AddTicks(9232) });

            migrationBuilder.UpdateData(
                table: "ParentProfile",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 17, 33, 38, 29, DateTimeKind.Local).AddTicks(8738), new DateTime(2026, 7, 18, 17, 33, 38, 29, DateTimeKind.Local).AddTicks(8739) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000001"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 17, 33, 38, 29, DateTimeKind.Local).AddTicks(9677));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000002"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 17, 33, 38, 29, DateTimeKind.Local).AddTicks(9712));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000003"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 17, 33, 38, 29, DateTimeKind.Local).AddTicks(9766));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000004"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 17, 33, 38, 29, DateTimeKind.Local).AddTicks(9782));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000005"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 17, 33, 38, 29, DateTimeKind.Local).AddTicks(9799));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000006"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 17, 33, 38, 29, DateTimeKind.Local).AddTicks(9840));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000007"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 17, 33, 38, 29, DateTimeKind.Local).AddTicks(9854));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000008"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 17, 33, 38, 29, DateTimeKind.Local).AddTicks(9867));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000009"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 17, 33, 38, 29, DateTimeKind.Local).AddTicks(9940));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000010"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 17, 33, 38, 29, DateTimeKind.Local).AddTicks(9960));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000011"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 17, 33, 38, 29, DateTimeKind.Local).AddTicks(9977));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000012"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 17, 33, 38, 30, DateTimeKind.Local).AddTicks(33));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000013"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 17, 33, 38, 30, DateTimeKind.Local).AddTicks(49));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000014"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 17, 33, 38, 30, DateTimeKind.Local).AddTicks(66));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000015"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 17, 33, 38, 30, DateTimeKind.Local).AddTicks(80));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000016"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 17, 33, 38, 30, DateTimeKind.Local).AddTicks(126));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000017"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 17, 33, 38, 30, DateTimeKind.Local).AddTicks(145));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000018"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 17, 33, 38, 30, DateTimeKind.Local).AddTicks(160));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000019"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 17, 33, 38, 30, DateTimeKind.Local).AddTicks(209));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000020"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 17, 33, 38, 30, DateTimeKind.Local).AddTicks(224));

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000001"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 17, 33, 38, 29, DateTimeKind.Local).AddTicks(9651), new DateTime(2026, 7, 18, 17, 33, 38, 29, DateTimeKind.Local).AddTicks(9651) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000002"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 17, 33, 38, 29, DateTimeKind.Local).AddTicks(9707), new DateTime(2026, 7, 18, 17, 33, 38, 29, DateTimeKind.Local).AddTicks(9708) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000003"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 17, 33, 38, 29, DateTimeKind.Local).AddTicks(9760), new DateTime(2026, 7, 18, 17, 33, 38, 29, DateTimeKind.Local).AddTicks(9760) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000004"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 17, 33, 38, 29, DateTimeKind.Local).AddTicks(9777), new DateTime(2026, 7, 18, 17, 33, 38, 29, DateTimeKind.Local).AddTicks(9778) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000005"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 17, 33, 38, 29, DateTimeKind.Local).AddTicks(9794), new DateTime(2026, 7, 18, 17, 33, 38, 29, DateTimeKind.Local).AddTicks(9795) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000006"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 17, 33, 38, 29, DateTimeKind.Local).AddTicks(9836), new DateTime(2026, 7, 18, 17, 33, 38, 29, DateTimeKind.Local).AddTicks(9836) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000007"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 17, 33, 38, 29, DateTimeKind.Local).AddTicks(9850), new DateTime(2026, 7, 18, 17, 33, 38, 29, DateTimeKind.Local).AddTicks(9850) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000008"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 17, 33, 38, 29, DateTimeKind.Local).AddTicks(9863), new DateTime(2026, 7, 18, 17, 33, 38, 29, DateTimeKind.Local).AddTicks(9864) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000009"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 17, 33, 38, 29, DateTimeKind.Local).AddTicks(9934), new DateTime(2026, 7, 18, 17, 33, 38, 29, DateTimeKind.Local).AddTicks(9935) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000010"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 17, 33, 38, 29, DateTimeKind.Local).AddTicks(9956), new DateTime(2026, 7, 18, 17, 33, 38, 29, DateTimeKind.Local).AddTicks(9956) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000011"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 17, 33, 38, 29, DateTimeKind.Local).AddTicks(9971), new DateTime(2026, 7, 18, 17, 33, 38, 29, DateTimeKind.Local).AddTicks(9971) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000012"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 17, 33, 38, 29, DateTimeKind.Local).AddTicks(9986), new DateTime(2026, 7, 18, 17, 33, 38, 29, DateTimeKind.Local).AddTicks(9987) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000013"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 17, 33, 38, 30, DateTimeKind.Local).AddTicks(45), new DateTime(2026, 7, 18, 17, 33, 38, 30, DateTimeKind.Local).AddTicks(45) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000014"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 17, 33, 38, 30, DateTimeKind.Local).AddTicks(62), new DateTime(2026, 7, 18, 17, 33, 38, 30, DateTimeKind.Local).AddTicks(62) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000015"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 17, 33, 38, 30, DateTimeKind.Local).AddTicks(76), new DateTime(2026, 7, 18, 17, 33, 38, 30, DateTimeKind.Local).AddTicks(77) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000016"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 17, 33, 38, 30, DateTimeKind.Local).AddTicks(122), new DateTime(2026, 7, 18, 17, 33, 38, 30, DateTimeKind.Local).AddTicks(122) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000017"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 17, 33, 38, 30, DateTimeKind.Local).AddTicks(140), new DateTime(2026, 7, 18, 17, 33, 38, 30, DateTimeKind.Local).AddTicks(140) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000018"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 17, 33, 38, 30, DateTimeKind.Local).AddTicks(157), new DateTime(2026, 7, 18, 17, 33, 38, 30, DateTimeKind.Local).AddTicks(157) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000019"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 17, 33, 38, 30, DateTimeKind.Local).AddTicks(203), new DateTime(2026, 7, 18, 17, 33, 38, 30, DateTimeKind.Local).AddTicks(204) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000020"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 17, 33, 38, 30, DateTimeKind.Local).AddTicks(220), new DateTime(2026, 7, 18, 17, 33, 38, 30, DateTimeKind.Local).AddTicks(221) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 17, 33, 38, 29, DateTimeKind.Local).AddTicks(8689), new DateTime(2026, 7, 18, 17, 33, 38, 29, DateTimeKind.Local).AddTicks(8690) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 17, 33, 38, 29, DateTimeKind.Local).AddTicks(8446), new DateTime(2026, 7, 18, 17, 33, 38, 29, DateTimeKind.Local).AddTicks(8457) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000001"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 17, 33, 38, 29, DateTimeKind.Local).AddTicks(9631), new DateTime(2026, 7, 18, 17, 33, 38, 29, DateTimeKind.Local).AddTicks(9632) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000002"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 17, 33, 38, 29, DateTimeKind.Local).AddTicks(9701), new DateTime(2026, 7, 18, 17, 33, 38, 29, DateTimeKind.Local).AddTicks(9702) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000003"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 17, 33, 38, 29, DateTimeKind.Local).AddTicks(9755), new DateTime(2026, 7, 18, 17, 33, 38, 29, DateTimeKind.Local).AddTicks(9755) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000004"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 17, 33, 38, 29, DateTimeKind.Local).AddTicks(9772), new DateTime(2026, 7, 18, 17, 33, 38, 29, DateTimeKind.Local).AddTicks(9773) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000005"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 17, 33, 38, 29, DateTimeKind.Local).AddTicks(9787), new DateTime(2026, 7, 18, 17, 33, 38, 29, DateTimeKind.Local).AddTicks(9788) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000006"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 17, 33, 38, 29, DateTimeKind.Local).AddTicks(9829), new DateTime(2026, 7, 18, 17, 33, 38, 29, DateTimeKind.Local).AddTicks(9829) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000007"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 17, 33, 38, 29, DateTimeKind.Local).AddTicks(9845), new DateTime(2026, 7, 18, 17, 33, 38, 29, DateTimeKind.Local).AddTicks(9845) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000008"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 17, 33, 38, 29, DateTimeKind.Local).AddTicks(9859), new DateTime(2026, 7, 18, 17, 33, 38, 29, DateTimeKind.Local).AddTicks(9859) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000009"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 17, 33, 38, 29, DateTimeKind.Local).AddTicks(9874), new DateTime(2026, 7, 18, 17, 33, 38, 29, DateTimeKind.Local).AddTicks(9874) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000010"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 17, 33, 38, 29, DateTimeKind.Local).AddTicks(9949), new DateTime(2026, 7, 18, 17, 33, 38, 29, DateTimeKind.Local).AddTicks(9950) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000011"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 17, 33, 38, 29, DateTimeKind.Local).AddTicks(9966), new DateTime(2026, 7, 18, 17, 33, 38, 29, DateTimeKind.Local).AddTicks(9966) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000012"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 17, 33, 38, 29, DateTimeKind.Local).AddTicks(9982), new DateTime(2026, 7, 18, 17, 33, 38, 29, DateTimeKind.Local).AddTicks(9982) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000013"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 17, 33, 38, 30, DateTimeKind.Local).AddTicks(39), new DateTime(2026, 7, 18, 17, 33, 38, 30, DateTimeKind.Local).AddTicks(39) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000014"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 17, 33, 38, 30, DateTimeKind.Local).AddTicks(55), new DateTime(2026, 7, 18, 17, 33, 38, 30, DateTimeKind.Local).AddTicks(56) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000015"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 17, 33, 38, 30, DateTimeKind.Local).AddTicks(71), new DateTime(2026, 7, 18, 17, 33, 38, 30, DateTimeKind.Local).AddTicks(71) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000016"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 17, 33, 38, 30, DateTimeKind.Local).AddTicks(86), new DateTime(2026, 7, 18, 17, 33, 38, 30, DateTimeKind.Local).AddTicks(86) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000017"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 17, 33, 38, 30, DateTimeKind.Local).AddTicks(133), new DateTime(2026, 7, 18, 17, 33, 38, 30, DateTimeKind.Local).AddTicks(133) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000018"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 17, 33, 38, 30, DateTimeKind.Local).AddTicks(151), new DateTime(2026, 7, 18, 17, 33, 38, 30, DateTimeKind.Local).AddTicks(152) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000019"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 17, 33, 38, 30, DateTimeKind.Local).AddTicks(198), new DateTime(2026, 7, 18, 17, 33, 38, 30, DateTimeKind.Local).AddTicks(199) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000020"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 17, 33, 38, 30, DateTimeKind.Local).AddTicks(215), new DateTime(2026, 7, 18, 17, 33, 38, 30, DateTimeKind.Local).AddTicks(216) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 17, 33, 38, 29, DateTimeKind.Local).AddTicks(8518), new DateTime(2026, 7, 18, 17, 33, 38, 29, DateTimeKind.Local).AddTicks(8518) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 17, 33, 38, 29, DateTimeKind.Local).AddTicks(8521), new DateTime(2026, 7, 18, 17, 33, 38, 29, DateTimeKind.Local).AddTicks(8522) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 17, 33, 38, 29, DateTimeKind.Local).AddTicks(8524), new DateTime(2026, 7, 18, 17, 33, 38, 29, DateTimeKind.Local).AddTicks(8525) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("55555555-5555-5555-5555-555555555555"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 17, 33, 38, 29, DateTimeKind.Local).AddTicks(8528), new DateTime(2026, 7, 18, 17, 33, 38, 29, DateTimeKind.Local).AddTicks(8528) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666666"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 17, 33, 38, 29, DateTimeKind.Local).AddTicks(8531), new DateTime(2026, 7, 18, 17, 33, 38, 29, DateTimeKind.Local).AddTicks(8531) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("88888888-8888-8888-8888-888888888888"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(7937));

            migrationBuilder.UpdateData(
                table: "Module",
                keyColumn: "Id",
                keyValue: new Guid("77777777-7777-7777-7777-777777777777"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 17, 3, 48, 346, DateTimeKind.Local).AddTicks(7784), new DateTime(2026, 7, 18, 17, 3, 48, 346, DateTimeKind.Local).AddTicks(7785) });

            migrationBuilder.UpdateData(
                table: "ModuleItem",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666601"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 17, 3, 48, 346, DateTimeKind.Local).AddTicks(7852), new DateTime(2026, 7, 18, 17, 3, 48, 346, DateTimeKind.Local).AddTicks(7852) });

            migrationBuilder.UpdateData(
                table: "ModuleItem",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666602"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 17, 3, 48, 346, DateTimeKind.Local).AddTicks(7860), new DateTime(2026, 7, 18, 17, 3, 48, 346, DateTimeKind.Local).AddTicks(7861) });

            migrationBuilder.UpdateData(
                table: "ModuleItem",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666603"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 17, 3, 48, 346, DateTimeKind.Local).AddTicks(7865), new DateTime(2026, 7, 18, 17, 3, 48, 346, DateTimeKind.Local).AddTicks(7880) });

            migrationBuilder.UpdateData(
                table: "ModuleItem",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666604"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 17, 3, 48, 346, DateTimeKind.Local).AddTicks(7901), new DateTime(2026, 7, 18, 17, 3, 48, 346, DateTimeKind.Local).AddTicks(7902) });

            migrationBuilder.UpdateData(
                table: "ParentProfile",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(7572), new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(7573) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000001"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8127));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000002"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8158));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000003"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8175));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000004"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8194));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000005"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8222));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000006"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8239));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000007"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8258));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000008"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8274));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000009"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8305));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000010"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8325));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000011"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8341));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000012"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8359));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000013"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8375));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000014"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8400));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000015"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8418));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000016"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8434));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000017"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8455));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000018"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8483));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000019"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8499));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000020"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8517));

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000001"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8093), new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8093) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000002"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8153), new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8153) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000003"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8170), new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8170) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000004"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8189), new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8189) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000005"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8216), new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8216) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000006"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8234), new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8235) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000007"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8253), new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8253) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000008"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8269), new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8269) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000009"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8297), new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8297) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000010"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8320), new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8321) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000011"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8336), new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8337) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000012"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8354), new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8354) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000013"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8370), new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8371) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000014"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8395), new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8396) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000015"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8414), new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8414) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000016"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8429), new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8430) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000017"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8447), new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8447) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000018"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8478), new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8478) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000019"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8494), new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8495) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000020"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8512), new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8513) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(7530), new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(7531) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(7289), new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(7303) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000001"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8074), new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8074) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000002"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8145), new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8146) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000003"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8164), new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8164) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000004"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8180), new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8181) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000005"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8206), new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8207) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000006"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8228), new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8228) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000007"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8246), new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8246) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000008"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8263), new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8263) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000009"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8279), new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8280) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000010"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8313), new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8314) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000011"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8330), new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8330) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000012"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8346), new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8346) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000013"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8364), new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8364) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000014"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8388), new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8389) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000015"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8407), new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8407) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000016"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8423), new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8424) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000017"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8438), new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8439) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000018"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8471), new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8472) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000019"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8488), new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8489) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000020"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8504), new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8504) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(7404), new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(7404) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(7408), new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(7409) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(7411), new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(7412) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("55555555-5555-5555-5555-555555555555"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(7414), new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(7415) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666666"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(7417), new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(7418) });
        }
    }
}
