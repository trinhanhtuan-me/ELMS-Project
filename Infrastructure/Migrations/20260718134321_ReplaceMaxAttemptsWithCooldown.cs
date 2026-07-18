using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ReplaceMaxAttemptsWithCooldown : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MaxAttempts",
                table: "Quiz");

            migrationBuilder.AddColumn<int>(
                name: "AttemptCooldownMin",
                table: "Quiz",
                type: "int",
                nullable: false,
                defaultValue: 60);

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("88888888-8888-8888-8888-888888888888"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 20, 43, 17, 731, DateTimeKind.Local).AddTicks(874));

            migrationBuilder.UpdateData(
                table: "Module",
                keyColumn: "Id",
                keyValue: new Guid("77777777-7777-7777-7777-777777777777"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 20, 43, 17, 731, DateTimeKind.Local).AddTicks(966), new DateTime(2026, 7, 18, 20, 43, 17, 731, DateTimeKind.Local).AddTicks(967) });

            migrationBuilder.UpdateData(
                table: "ModuleItem",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666601"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 20, 43, 17, 731, DateTimeKind.Local).AddTicks(1128), new DateTime(2026, 7, 18, 20, 43, 17, 731, DateTimeKind.Local).AddTicks(1128) });

            migrationBuilder.UpdateData(
                table: "ModuleItem",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666602"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 20, 43, 17, 731, DateTimeKind.Local).AddTicks(1136), new DateTime(2026, 7, 18, 20, 43, 17, 731, DateTimeKind.Local).AddTicks(1137) });

            migrationBuilder.UpdateData(
                table: "ModuleItem",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666603"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 20, 43, 17, 731, DateTimeKind.Local).AddTicks(1140), new DateTime(2026, 7, 18, 20, 43, 17, 731, DateTimeKind.Local).AddTicks(1155) });

            migrationBuilder.UpdateData(
                table: "ModuleItem",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666604"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 20, 43, 17, 731, DateTimeKind.Local).AddTicks(1184), new DateTime(2026, 7, 18, 20, 43, 17, 731, DateTimeKind.Local).AddTicks(1185) });

            migrationBuilder.UpdateData(
                table: "ParentProfile",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 20, 43, 17, 731, DateTimeKind.Local).AddTicks(240), new DateTime(2026, 7, 18, 20, 43, 17, 731, DateTimeKind.Local).AddTicks(240) });

            migrationBuilder.UpdateData(
                table: "Quiz",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666603"),
                column: "AttemptCooldownMin",
                value: 60);

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000001"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 20, 43, 17, 731, DateTimeKind.Local).AddTicks(1805));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000002"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 20, 43, 17, 731, DateTimeKind.Local).AddTicks(1921));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000003"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 20, 43, 17, 731, DateTimeKind.Local).AddTicks(1951));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000004"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 20, 43, 17, 731, DateTimeKind.Local).AddTicks(2051));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000005"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 20, 43, 17, 731, DateTimeKind.Local).AddTicks(2076));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000006"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 20, 43, 17, 731, DateTimeKind.Local).AddTicks(2146));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000007"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 20, 43, 17, 731, DateTimeKind.Local).AddTicks(2169));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000008"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 20, 43, 17, 731, DateTimeKind.Local).AddTicks(2190));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000009"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 20, 43, 17, 731, DateTimeKind.Local).AddTicks(2316));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000010"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 20, 43, 17, 731, DateTimeKind.Local).AddTicks(2364));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000011"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 20, 43, 17, 731, DateTimeKind.Local).AddTicks(2404));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000012"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 20, 43, 17, 731, DateTimeKind.Local).AddTicks(2506));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000013"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 20, 43, 17, 731, DateTimeKind.Local).AddTicks(2528));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000014"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 20, 43, 17, 731, DateTimeKind.Local).AddTicks(2554));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000015"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 20, 43, 17, 731, DateTimeKind.Local).AddTicks(2578));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000016"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 20, 43, 17, 731, DateTimeKind.Local).AddTicks(2666));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000017"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 20, 43, 17, 731, DateTimeKind.Local).AddTicks(2696));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000018"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 20, 43, 17, 731, DateTimeKind.Local).AddTicks(2773));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000019"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 20, 43, 17, 731, DateTimeKind.Local).AddTicks(2799));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000020"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 20, 43, 17, 731, DateTimeKind.Local).AddTicks(2822));

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000001"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 20, 43, 17, 731, DateTimeKind.Local).AddTicks(1761), new DateTime(2026, 7, 18, 20, 43, 17, 731, DateTimeKind.Local).AddTicks(1761) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000002"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 20, 43, 17, 731, DateTimeKind.Local).AddTicks(1912), new DateTime(2026, 7, 18, 20, 43, 17, 731, DateTimeKind.Local).AddTicks(1913) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000003"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 20, 43, 17, 731, DateTimeKind.Local).AddTicks(1942), new DateTime(2026, 7, 18, 20, 43, 17, 731, DateTimeKind.Local).AddTicks(1942) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000004"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 20, 43, 17, 731, DateTimeKind.Local).AddTicks(2043), new DateTime(2026, 7, 18, 20, 43, 17, 731, DateTimeKind.Local).AddTicks(2043) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000005"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 20, 43, 17, 731, DateTimeKind.Local).AddTicks(2069), new DateTime(2026, 7, 18, 20, 43, 17, 731, DateTimeKind.Local).AddTicks(2070) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000006"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 20, 43, 17, 731, DateTimeKind.Local).AddTicks(2140), new DateTime(2026, 7, 18, 20, 43, 17, 731, DateTimeKind.Local).AddTicks(2140) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000007"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 20, 43, 17, 731, DateTimeKind.Local).AddTicks(2163), new DateTime(2026, 7, 18, 20, 43, 17, 731, DateTimeKind.Local).AddTicks(2163) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000008"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 20, 43, 17, 731, DateTimeKind.Local).AddTicks(2184), new DateTime(2026, 7, 18, 20, 43, 17, 731, DateTimeKind.Local).AddTicks(2185) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000009"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 20, 43, 17, 731, DateTimeKind.Local).AddTicks(2308), new DateTime(2026, 7, 18, 20, 43, 17, 731, DateTimeKind.Local).AddTicks(2309) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000010"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 20, 43, 17, 731, DateTimeKind.Local).AddTicks(2343), new DateTime(2026, 7, 18, 20, 43, 17, 731, DateTimeKind.Local).AddTicks(2344) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000011"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 20, 43, 17, 731, DateTimeKind.Local).AddTicks(2394), new DateTime(2026, 7, 18, 20, 43, 17, 731, DateTimeKind.Local).AddTicks(2395) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000012"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 20, 43, 17, 731, DateTimeKind.Local).AddTicks(2499), new DateTime(2026, 7, 18, 20, 43, 17, 731, DateTimeKind.Local).AddTicks(2500) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000013"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 20, 43, 17, 731, DateTimeKind.Local).AddTicks(2522), new DateTime(2026, 7, 18, 20, 43, 17, 731, DateTimeKind.Local).AddTicks(2523) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000014"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 20, 43, 17, 731, DateTimeKind.Local).AddTicks(2547), new DateTime(2026, 7, 18, 20, 43, 17, 731, DateTimeKind.Local).AddTicks(2548) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000015"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 20, 43, 17, 731, DateTimeKind.Local).AddTicks(2572), new DateTime(2026, 7, 18, 20, 43, 17, 731, DateTimeKind.Local).AddTicks(2572) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000016"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 20, 43, 17, 731, DateTimeKind.Local).AddTicks(2660), new DateTime(2026, 7, 18, 20, 43, 17, 731, DateTimeKind.Local).AddTicks(2660) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000017"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 20, 43, 17, 731, DateTimeKind.Local).AddTicks(2689), new DateTime(2026, 7, 18, 20, 43, 17, 731, DateTimeKind.Local).AddTicks(2689) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000018"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 20, 43, 17, 731, DateTimeKind.Local).AddTicks(2767), new DateTime(2026, 7, 18, 20, 43, 17, 731, DateTimeKind.Local).AddTicks(2767) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000019"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 20, 43, 17, 731, DateTimeKind.Local).AddTicks(2790), new DateTime(2026, 7, 18, 20, 43, 17, 731, DateTimeKind.Local).AddTicks(2791) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000020"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 20, 43, 17, 731, DateTimeKind.Local).AddTicks(2816), new DateTime(2026, 7, 18, 20, 43, 17, 731, DateTimeKind.Local).AddTicks(2816) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 20, 43, 17, 731, DateTimeKind.Local).AddTicks(165), new DateTime(2026, 7, 18, 20, 43, 17, 731, DateTimeKind.Local).AddTicks(166) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 20, 43, 17, 730, DateTimeKind.Local).AddTicks(9799), new DateTime(2026, 7, 18, 20, 43, 17, 730, DateTimeKind.Local).AddTicks(9822) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000001"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 20, 43, 17, 731, DateTimeKind.Local).AddTicks(1730), new DateTime(2026, 7, 18, 20, 43, 17, 731, DateTimeKind.Local).AddTicks(1731) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000002"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 20, 43, 17, 731, DateTimeKind.Local).AddTicks(1849), new DateTime(2026, 7, 18, 20, 43, 17, 731, DateTimeKind.Local).AddTicks(1849) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000003"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 20, 43, 17, 731, DateTimeKind.Local).AddTicks(1933), new DateTime(2026, 7, 18, 20, 43, 17, 731, DateTimeKind.Local).AddTicks(1934) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000004"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 20, 43, 17, 731, DateTimeKind.Local).AddTicks(2033), new DateTime(2026, 7, 18, 20, 43, 17, 731, DateTimeKind.Local).AddTicks(2033) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000005"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 20, 43, 17, 731, DateTimeKind.Local).AddTicks(2060), new DateTime(2026, 7, 18, 20, 43, 17, 731, DateTimeKind.Local).AddTicks(2060) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000006"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 20, 43, 17, 731, DateTimeKind.Local).AddTicks(2128), new DateTime(2026, 7, 18, 20, 43, 17, 731, DateTimeKind.Local).AddTicks(2129) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000007"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 20, 43, 17, 731, DateTimeKind.Local).AddTicks(2154), new DateTime(2026, 7, 18, 20, 43, 17, 731, DateTimeKind.Local).AddTicks(2155) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000008"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 20, 43, 17, 731, DateTimeKind.Local).AddTicks(2177), new DateTime(2026, 7, 18, 20, 43, 17, 731, DateTimeKind.Local).AddTicks(2177) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000009"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 20, 43, 17, 731, DateTimeKind.Local).AddTicks(2297), new DateTime(2026, 7, 18, 20, 43, 17, 731, DateTimeKind.Local).AddTicks(2298) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000010"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 20, 43, 17, 731, DateTimeKind.Local).AddTicks(2333), new DateTime(2026, 7, 18, 20, 43, 17, 731, DateTimeKind.Local).AddTicks(2334) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000011"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 20, 43, 17, 731, DateTimeKind.Local).AddTicks(2386), new DateTime(2026, 7, 18, 20, 43, 17, 731, DateTimeKind.Local).AddTicks(2387) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000012"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 20, 43, 17, 731, DateTimeKind.Local).AddTicks(2490), new DateTime(2026, 7, 18, 20, 43, 17, 731, DateTimeKind.Local).AddTicks(2490) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000013"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 20, 43, 17, 731, DateTimeKind.Local).AddTicks(2514), new DateTime(2026, 7, 18, 20, 43, 17, 731, DateTimeKind.Local).AddTicks(2515) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000014"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 20, 43, 17, 731, DateTimeKind.Local).AddTicks(2537), new DateTime(2026, 7, 18, 20, 43, 17, 731, DateTimeKind.Local).AddTicks(2537) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000015"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 20, 43, 17, 731, DateTimeKind.Local).AddTicks(2563), new DateTime(2026, 7, 18, 20, 43, 17, 731, DateTimeKind.Local).AddTicks(2563) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000016"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 20, 43, 17, 731, DateTimeKind.Local).AddTicks(2651), new DateTime(2026, 7, 18, 20, 43, 17, 731, DateTimeKind.Local).AddTicks(2651) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000017"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 20, 43, 17, 731, DateTimeKind.Local).AddTicks(2679), new DateTime(2026, 7, 18, 20, 43, 17, 731, DateTimeKind.Local).AddTicks(2679) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000018"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 20, 43, 17, 731, DateTimeKind.Local).AddTicks(2705), new DateTime(2026, 7, 18, 20, 43, 17, 731, DateTimeKind.Local).AddTicks(2706) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000019"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 20, 43, 17, 731, DateTimeKind.Local).AddTicks(2782), new DateTime(2026, 7, 18, 20, 43, 17, 731, DateTimeKind.Local).AddTicks(2783) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000020"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 20, 43, 17, 731, DateTimeKind.Local).AddTicks(2807), new DateTime(2026, 7, 18, 20, 43, 17, 731, DateTimeKind.Local).AddTicks(2808) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 20, 43, 17, 730, DateTimeKind.Local).AddTicks(9887), new DateTime(2026, 7, 18, 20, 43, 17, 730, DateTimeKind.Local).AddTicks(9888) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 20, 43, 17, 730, DateTimeKind.Local).AddTicks(9895), new DateTime(2026, 7, 18, 20, 43, 17, 730, DateTimeKind.Local).AddTicks(9896) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 20, 43, 17, 730, DateTimeKind.Local).AddTicks(9971), new DateTime(2026, 7, 18, 20, 43, 17, 730, DateTimeKind.Local).AddTicks(9971) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("55555555-5555-5555-5555-555555555555"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 20, 43, 17, 730, DateTimeKind.Local).AddTicks(9976), new DateTime(2026, 7, 18, 20, 43, 17, 730, DateTimeKind.Local).AddTicks(9976) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666666"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 20, 43, 17, 730, DateTimeKind.Local).AddTicks(9981), new DateTime(2026, 7, 18, 20, 43, 17, 730, DateTimeKind.Local).AddTicks(9982) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AttemptCooldownMin",
                table: "Quiz");

            migrationBuilder.AddColumn<int>(
                name: "MaxAttempts",
                table: "Quiz",
                type: "int",
                nullable: false,
                defaultValue: 3);

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("88888888-8888-8888-8888-888888888888"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 18, 4, 49, 114, DateTimeKind.Local).AddTicks(9830));

            migrationBuilder.UpdateData(
                table: "Module",
                keyColumn: "Id",
                keyValue: new Guid("77777777-7777-7777-7777-777777777777"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 18, 4, 49, 114, DateTimeKind.Local).AddTicks(9888), new DateTime(2026, 7, 18, 18, 4, 49, 114, DateTimeKind.Local).AddTicks(9888) });

            migrationBuilder.UpdateData(
                table: "ModuleItem",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666601"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 18, 4, 49, 114, DateTimeKind.Local).AddTicks(9947), new DateTime(2026, 7, 18, 18, 4, 49, 114, DateTimeKind.Local).AddTicks(9947) });

            migrationBuilder.UpdateData(
                table: "ModuleItem",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666602"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 18, 4, 49, 114, DateTimeKind.Local).AddTicks(9953), new DateTime(2026, 7, 18, 18, 4, 49, 114, DateTimeKind.Local).AddTicks(9953) });

            migrationBuilder.UpdateData(
                table: "ModuleItem",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666603"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 18, 4, 49, 114, DateTimeKind.Local).AddTicks(9956), new DateTime(2026, 7, 18, 18, 4, 49, 114, DateTimeKind.Local).AddTicks(9962) });

            migrationBuilder.UpdateData(
                table: "ModuleItem",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666604"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 18, 4, 49, 114, DateTimeKind.Local).AddTicks(9982), new DateTime(2026, 7, 18, 18, 4, 49, 114, DateTimeKind.Local).AddTicks(9982) });

            migrationBuilder.UpdateData(
                table: "ParentProfile",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 18, 4, 49, 114, DateTimeKind.Local).AddTicks(9359), new DateTime(2026, 7, 18, 18, 4, 49, 114, DateTimeKind.Local).AddTicks(9360) });

            migrationBuilder.UpdateData(
                table: "Quiz",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666603"),
                column: "MaxAttempts",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000001"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(448));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000002"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(489));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000003"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(506));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000004"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(541));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000005"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(624));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000006"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(641));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000007"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(655));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000008"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(719));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000009"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(736));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000010"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(767));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000011"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(829));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000012"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(845));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000013"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(861));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000014"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(876));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000015"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(926));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000016"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(952));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000017"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000018"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(1026));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000019"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(1041));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000020"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(1057));

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000001"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(389), new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(389) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000002"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(481), new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(482) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000003"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(501), new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(502) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000004"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(536), new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(537) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000005"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(619), new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(620) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000006"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(636), new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(637) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000007"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(651), new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(652) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000008"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(715), new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(716) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000009"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(732), new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(732) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000010"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(752), new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(752) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000011"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(825), new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(825) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000012"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(841), new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(842) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000013"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(858), new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(858) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000014"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(872), new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(873) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000015"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(922), new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(923) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000016"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(948), new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(949) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000017"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(965), new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(965) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000018"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(1020), new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(1021) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000019"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(1037), new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(1038) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000020"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(1053), new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(1054) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 18, 4, 49, 114, DateTimeKind.Local).AddTicks(9305), new DateTime(2026, 7, 18, 18, 4, 49, 114, DateTimeKind.Local).AddTicks(9306) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 18, 4, 49, 114, DateTimeKind.Local).AddTicks(9087), new DateTime(2026, 7, 18, 18, 4, 49, 114, DateTimeKind.Local).AddTicks(9107) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000001"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(369), new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(370) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000002"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(475), new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(475) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000003"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(496), new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(496) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000004"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(531), new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(531) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000005"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(610), new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(611) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000006"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(631), new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(632) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000007"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(646), new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(646) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000008"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(709), new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(710) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000009"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(726), new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(726) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000010"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(747), new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(747) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000011"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(785), new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(785) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000012"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(836), new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(836) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000013"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(851), new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(851) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000014"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(867), new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(868) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000015"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(917), new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(918) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000016"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(943), new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(944) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000017"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(958), new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(959) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000018"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(1014), new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(1015) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000019"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(1032), new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(1033) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000020"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(1048), new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(1048) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 18, 4, 49, 114, DateTimeKind.Local).AddTicks(9158), new DateTime(2026, 7, 18, 18, 4, 49, 114, DateTimeKind.Local).AddTicks(9158) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 18, 4, 49, 114, DateTimeKind.Local).AddTicks(9163), new DateTime(2026, 7, 18, 18, 4, 49, 114, DateTimeKind.Local).AddTicks(9164) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 18, 4, 49, 114, DateTimeKind.Local).AddTicks(9166), new DateTime(2026, 7, 18, 18, 4, 49, 114, DateTimeKind.Local).AddTicks(9167) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("55555555-5555-5555-5555-555555555555"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 18, 4, 49, 114, DateTimeKind.Local).AddTicks(9172), new DateTime(2026, 7, 18, 18, 4, 49, 114, DateTimeKind.Local).AddTicks(9173) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666666"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 18, 4, 49, 114, DateTimeKind.Local).AddTicks(9185), new DateTime(2026, 7, 18, 18, 4, 49, 114, DateTimeKind.Local).AddTicks(9185) });
        }
    }
}
