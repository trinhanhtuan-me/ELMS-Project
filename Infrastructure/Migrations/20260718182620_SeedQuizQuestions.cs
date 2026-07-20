using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedQuizQuestions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("88888888-8888-8888-8888-888888888888"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 19, 1, 26, 17, 575, DateTimeKind.Local).AddTicks(1119));

            migrationBuilder.UpdateData(
                table: "Module",
                keyColumn: "Id",
                keyValue: new Guid("77777777-7777-7777-7777-777777777777"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 1, 26, 17, 575, DateTimeKind.Local).AddTicks(1187), new DateTime(2026, 7, 19, 1, 26, 17, 575, DateTimeKind.Local).AddTicks(1187) });

            migrationBuilder.UpdateData(
                table: "ModuleItem",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666601"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 1, 26, 17, 575, DateTimeKind.Local).AddTicks(1256), new DateTime(2026, 7, 19, 1, 26, 17, 575, DateTimeKind.Local).AddTicks(1257) });

            migrationBuilder.UpdateData(
                table: "ModuleItem",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666602"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 1, 26, 17, 575, DateTimeKind.Local).AddTicks(1263), new DateTime(2026, 7, 19, 1, 26, 17, 575, DateTimeKind.Local).AddTicks(1263) });

            migrationBuilder.UpdateData(
                table: "ModuleItem",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666603"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 1, 26, 17, 575, DateTimeKind.Local).AddTicks(1266), new DateTime(2026, 7, 19, 1, 26, 17, 575, DateTimeKind.Local).AddTicks(1274) });

            migrationBuilder.UpdateData(
                table: "ModuleItem",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666604"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 1, 26, 17, 575, DateTimeKind.Local).AddTicks(1291), new DateTime(2026, 7, 19, 1, 26, 17, 575, DateTimeKind.Local).AddTicks(1292) });

            migrationBuilder.UpdateData(
                table: "ParentProfile",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 1, 26, 17, 575, DateTimeKind.Local).AddTicks(677), new DateTime(2026, 7, 19, 1, 26, 17, 575, DateTimeKind.Local).AddTicks(678) });

            migrationBuilder.InsertData(
                table: "QuizQuestion",
                columns: new[] { "Id", "Content", "Explanation", "IsDeleted", "MediaUrl", "QuizId" },
                values: new object[,]
                {
                    { new Guid("dddddddd-dddd-dddd-dddd-ddddddddddd1"), "Question 1 for Tenses Quiz 1", null, false, null, new Guid("66666666-6666-6666-6666-666666666603") },
                    { new Guid("dddddddd-dddd-dddd-dddd-ddddddddddd2"), "Question 2 for Tenses Quiz 1", null, false, null, new Guid("66666666-6666-6666-6666-666666666603") }
                });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000001"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 19, 1, 26, 17, 575, DateTimeKind.Local).AddTicks(1857));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000002"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 19, 1, 26, 17, 575, DateTimeKind.Local).AddTicks(1901));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000003"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 19, 1, 26, 17, 575, DateTimeKind.Local).AddTicks(1958));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000004"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 19, 1, 26, 17, 575, DateTimeKind.Local).AddTicks(1983));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000005"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 19, 1, 26, 17, 575, DateTimeKind.Local).AddTicks(2003));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000006"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 19, 1, 26, 17, 575, DateTimeKind.Local).AddTicks(2059));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000007"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 19, 1, 26, 17, 575, DateTimeKind.Local).AddTicks(2076));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000008"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 19, 1, 26, 17, 575, DateTimeKind.Local).AddTicks(2095));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000009"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 19, 1, 26, 17, 575, DateTimeKind.Local).AddTicks(2144));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000010"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 19, 1, 26, 17, 575, DateTimeKind.Local).AddTicks(2169));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000011"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 19, 1, 26, 17, 575, DateTimeKind.Local).AddTicks(2214));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000012"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 19, 1, 26, 17, 575, DateTimeKind.Local).AddTicks(2231));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000013"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 19, 1, 26, 17, 575, DateTimeKind.Local).AddTicks(2274));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000014"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 19, 1, 26, 17, 575, DateTimeKind.Local).AddTicks(2292));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000015"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 19, 1, 26, 17, 575, DateTimeKind.Local).AddTicks(2316));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000016"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 19, 1, 26, 17, 575, DateTimeKind.Local).AddTicks(2412));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000017"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 19, 1, 26, 17, 575, DateTimeKind.Local).AddTicks(2435));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000018"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 19, 1, 26, 17, 575, DateTimeKind.Local).AddTicks(2453));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000019"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 19, 1, 26, 17, 575, DateTimeKind.Local).AddTicks(2513));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000020"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 19, 1, 26, 17, 575, DateTimeKind.Local).AddTicks(2531));

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000001"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 1, 26, 17, 575, DateTimeKind.Local).AddTicks(1818), new DateTime(2026, 7, 19, 1, 26, 17, 575, DateTimeKind.Local).AddTicks(1819) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000002"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 1, 26, 17, 575, DateTimeKind.Local).AddTicks(1896), new DateTime(2026, 7, 19, 1, 26, 17, 575, DateTimeKind.Local).AddTicks(1896) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000003"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 1, 26, 17, 575, DateTimeKind.Local).AddTicks(1952), new DateTime(2026, 7, 19, 1, 26, 17, 575, DateTimeKind.Local).AddTicks(1953) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000004"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 1, 26, 17, 575, DateTimeKind.Local).AddTicks(1978), new DateTime(2026, 7, 19, 1, 26, 17, 575, DateTimeKind.Local).AddTicks(1978) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000005"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 1, 26, 17, 575, DateTimeKind.Local).AddTicks(1998), new DateTime(2026, 7, 19, 1, 26, 17, 575, DateTimeKind.Local).AddTicks(1998) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000006"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 1, 26, 17, 575, DateTimeKind.Local).AddTicks(2054), new DateTime(2026, 7, 19, 1, 26, 17, 575, DateTimeKind.Local).AddTicks(2055) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000007"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 1, 26, 17, 575, DateTimeKind.Local).AddTicks(2071), new DateTime(2026, 7, 19, 1, 26, 17, 575, DateTimeKind.Local).AddTicks(2071) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000008"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 1, 26, 17, 575, DateTimeKind.Local).AddTicks(2089), new DateTime(2026, 7, 19, 1, 26, 17, 575, DateTimeKind.Local).AddTicks(2089) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000009"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 1, 26, 17, 575, DateTimeKind.Local).AddTicks(2108), new DateTime(2026, 7, 19, 1, 26, 17, 575, DateTimeKind.Local).AddTicks(2109) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000010"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 1, 26, 17, 575, DateTimeKind.Local).AddTicks(2164), new DateTime(2026, 7, 19, 1, 26, 17, 575, DateTimeKind.Local).AddTicks(2164) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000011"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 1, 26, 17, 575, DateTimeKind.Local).AddTicks(2209), new DateTime(2026, 7, 19, 1, 26, 17, 575, DateTimeKind.Local).AddTicks(2210) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000012"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 1, 26, 17, 575, DateTimeKind.Local).AddTicks(2227), new DateTime(2026, 7, 19, 1, 26, 17, 575, DateTimeKind.Local).AddTicks(2227) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000013"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 1, 26, 17, 575, DateTimeKind.Local).AddTicks(2269), new DateTime(2026, 7, 19, 1, 26, 17, 575, DateTimeKind.Local).AddTicks(2270) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000014"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 1, 26, 17, 575, DateTimeKind.Local).AddTicks(2288), new DateTime(2026, 7, 19, 1, 26, 17, 575, DateTimeKind.Local).AddTicks(2289) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000015"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 1, 26, 17, 575, DateTimeKind.Local).AddTicks(2305), new DateTime(2026, 7, 19, 1, 26, 17, 575, DateTimeKind.Local).AddTicks(2305) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000016"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 1, 26, 17, 575, DateTimeKind.Local).AddTicks(2404), new DateTime(2026, 7, 19, 1, 26, 17, 575, DateTimeKind.Local).AddTicks(2405) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000017"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 1, 26, 17, 575, DateTimeKind.Local).AddTicks(2429), new DateTime(2026, 7, 19, 1, 26, 17, 575, DateTimeKind.Local).AddTicks(2429) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000018"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 1, 26, 17, 575, DateTimeKind.Local).AddTicks(2449), new DateTime(2026, 7, 19, 1, 26, 17, 575, DateTimeKind.Local).AddTicks(2449) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000019"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 1, 26, 17, 575, DateTimeKind.Local).AddTicks(2509), new DateTime(2026, 7, 19, 1, 26, 17, 575, DateTimeKind.Local).AddTicks(2509) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000020"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 1, 26, 17, 575, DateTimeKind.Local).AddTicks(2527), new DateTime(2026, 7, 19, 1, 26, 17, 575, DateTimeKind.Local).AddTicks(2527) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 1, 26, 17, 575, DateTimeKind.Local).AddTicks(622), new DateTime(2026, 7, 19, 1, 26, 17, 575, DateTimeKind.Local).AddTicks(623) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 1, 26, 17, 575, DateTimeKind.Local).AddTicks(277), new DateTime(2026, 7, 19, 1, 26, 17, 575, DateTimeKind.Local).AddTicks(291) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000001"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 1, 26, 17, 575, DateTimeKind.Local).AddTicks(1800), new DateTime(2026, 7, 19, 1, 26, 17, 575, DateTimeKind.Local).AddTicks(1800) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000002"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 1, 26, 17, 575, DateTimeKind.Local).AddTicks(1888), new DateTime(2026, 7, 19, 1, 26, 17, 575, DateTimeKind.Local).AddTicks(1889) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000003"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 1, 26, 17, 575, DateTimeKind.Local).AddTicks(1943), new DateTime(2026, 7, 19, 1, 26, 17, 575, DateTimeKind.Local).AddTicks(1944) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000004"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 1, 26, 17, 575, DateTimeKind.Local).AddTicks(1971), new DateTime(2026, 7, 19, 1, 26, 17, 575, DateTimeKind.Local).AddTicks(1972) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000005"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 1, 26, 17, 575, DateTimeKind.Local).AddTicks(1990), new DateTime(2026, 7, 19, 1, 26, 17, 575, DateTimeKind.Local).AddTicks(1991) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000006"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 1, 26, 17, 575, DateTimeKind.Local).AddTicks(2047), new DateTime(2026, 7, 19, 1, 26, 17, 575, DateTimeKind.Local).AddTicks(2048) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000007"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 1, 26, 17, 575, DateTimeKind.Local).AddTicks(2066), new DateTime(2026, 7, 19, 1, 26, 17, 575, DateTimeKind.Local).AddTicks(2066) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000008"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 1, 26, 17, 575, DateTimeKind.Local).AddTicks(2083), new DateTime(2026, 7, 19, 1, 26, 17, 575, DateTimeKind.Local).AddTicks(2083) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000009"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 1, 26, 17, 575, DateTimeKind.Local).AddTicks(2101), new DateTime(2026, 7, 19, 1, 26, 17, 575, DateTimeKind.Local).AddTicks(2102) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000010"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 1, 26, 17, 575, DateTimeKind.Local).AddTicks(2157), new DateTime(2026, 7, 19, 1, 26, 17, 575, DateTimeKind.Local).AddTicks(2158) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000011"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 1, 26, 17, 575, DateTimeKind.Local).AddTicks(2202), new DateTime(2026, 7, 19, 1, 26, 17, 575, DateTimeKind.Local).AddTicks(2202) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000012"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 1, 26, 17, 575, DateTimeKind.Local).AddTicks(2221), new DateTime(2026, 7, 19, 1, 26, 17, 575, DateTimeKind.Local).AddTicks(2222) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000013"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 1, 26, 17, 575, DateTimeKind.Local).AddTicks(2262), new DateTime(2026, 7, 19, 1, 26, 17, 575, DateTimeKind.Local).AddTicks(2263) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000014"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 1, 26, 17, 575, DateTimeKind.Local).AddTicks(2283), new DateTime(2026, 7, 19, 1, 26, 17, 575, DateTimeKind.Local).AddTicks(2284) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000015"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 1, 26, 17, 575, DateTimeKind.Local).AddTicks(2299), new DateTime(2026, 7, 19, 1, 26, 17, 575, DateTimeKind.Local).AddTicks(2300) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000016"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 1, 26, 17, 575, DateTimeKind.Local).AddTicks(2335), new DateTime(2026, 7, 19, 1, 26, 17, 575, DateTimeKind.Local).AddTicks(2335) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000017"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 1, 26, 17, 575, DateTimeKind.Local).AddTicks(2421), new DateTime(2026, 7, 19, 1, 26, 17, 575, DateTimeKind.Local).AddTicks(2421) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000018"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 1, 26, 17, 575, DateTimeKind.Local).AddTicks(2443), new DateTime(2026, 7, 19, 1, 26, 17, 575, DateTimeKind.Local).AddTicks(2444) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000019"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 1, 26, 17, 575, DateTimeKind.Local).AddTicks(2500), new DateTime(2026, 7, 19, 1, 26, 17, 575, DateTimeKind.Local).AddTicks(2501) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000020"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 1, 26, 17, 575, DateTimeKind.Local).AddTicks(2520), new DateTime(2026, 7, 19, 1, 26, 17, 575, DateTimeKind.Local).AddTicks(2521) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 1, 26, 17, 575, DateTimeKind.Local).AddTicks(345), new DateTime(2026, 7, 19, 1, 26, 17, 575, DateTimeKind.Local).AddTicks(345) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 1, 26, 17, 575, DateTimeKind.Local).AddTicks(349), new DateTime(2026, 7, 19, 1, 26, 17, 575, DateTimeKind.Local).AddTicks(349) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 1, 26, 17, 575, DateTimeKind.Local).AddTicks(355), new DateTime(2026, 7, 19, 1, 26, 17, 575, DateTimeKind.Local).AddTicks(356) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("55555555-5555-5555-5555-555555555555"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 1, 26, 17, 575, DateTimeKind.Local).AddTicks(359), new DateTime(2026, 7, 19, 1, 26, 17, 575, DateTimeKind.Local).AddTicks(360) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666666"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 1, 26, 17, 575, DateTimeKind.Local).AddTicks(363), new DateTime(2026, 7, 19, 1, 26, 17, 575, DateTimeKind.Local).AddTicks(364) });

            migrationBuilder.InsertData(
                table: "QuizOption",
                columns: new[] { "Id", "Content", "IsCorrect", "QuestionId" },
                values: new object[,]
                {
                    { new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeee1"), "Option A", true, new Guid("dddddddd-dddd-dddd-dddd-ddddddddddd1") },
                    { new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeee2"), "Option B", false, new Guid("dddddddd-dddd-dddd-dddd-ddddddddddd1") },
                    { new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeee3"), "Option C", false, new Guid("dddddddd-dddd-dddd-dddd-ddddddddddd1") },
                    { new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeee4"), "Option D", false, new Guid("dddddddd-dddd-dddd-dddd-ddddddddddd1") },
                    { new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeee5"), "Option A", false, new Guid("dddddddd-dddd-dddd-dddd-ddddddddddd2") },
                    { new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeee6"), "Option B", true, new Guid("dddddddd-dddd-dddd-dddd-ddddddddddd2") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "QuizOption",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeee1"));

            migrationBuilder.DeleteData(
                table: "QuizOption",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeee2"));

            migrationBuilder.DeleteData(
                table: "QuizOption",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeee3"));

            migrationBuilder.DeleteData(
                table: "QuizOption",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeee4"));

            migrationBuilder.DeleteData(
                table: "QuizOption",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeee5"));

            migrationBuilder.DeleteData(
                table: "QuizOption",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeee6"));

            migrationBuilder.DeleteData(
                table: "QuizQuestion",
                keyColumn: "Id",
                keyValue: new Guid("dddddddd-dddd-dddd-dddd-ddddddddddd1"));

            migrationBuilder.DeleteData(
                table: "QuizQuestion",
                keyColumn: "Id",
                keyValue: new Guid("dddddddd-dddd-dddd-dddd-ddddddddddd2"));

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
    }
}
