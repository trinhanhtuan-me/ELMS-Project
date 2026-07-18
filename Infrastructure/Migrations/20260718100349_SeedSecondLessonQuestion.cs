using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedSecondLessonQuestion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("88888888-8888-8888-8888-888888888888"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 17, 3, 48, 346, DateTimeKind.Local).AddTicks(7719));

            migrationBuilder.InsertData(
                table: "LessonQuestion",
                columns: new[] { "Id", "Content", "Explanation", "LessonId" },
                values: new object[] { new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbb2"), "Cụm từ 'to be out of sorts' có nghĩa là gì?", "To be out of sorts = cảm thấy không khỏe, khó ở.", new Guid("66666666-6666-6666-6666-666666666601") });

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
                values: new object[] { new DateTime(2026, 7, 18, 17, 3, 48, 346, DateTimeKind.Local).AddTicks(7125), new DateTime(2026, 7, 18, 17, 3, 48, 346, DateTimeKind.Local).AddTicks(7126) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000001"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 17, 3, 48, 346, DateTimeKind.Local).AddTicks(8536));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000002"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 17, 3, 48, 346, DateTimeKind.Local).AddTicks(8584));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000003"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 17, 3, 48, 346, DateTimeKind.Local).AddTicks(8613));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000004"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 17, 3, 48, 346, DateTimeKind.Local).AddTicks(8727));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000005"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 17, 3, 48, 346, DateTimeKind.Local).AddTicks(8758));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000006"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 17, 3, 48, 346, DateTimeKind.Local).AddTicks(8813));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000007"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 17, 3, 48, 346, DateTimeKind.Local).AddTicks(8831));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000008"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 17, 3, 48, 346, DateTimeKind.Local).AddTicks(8894));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000009"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 17, 3, 48, 346, DateTimeKind.Local).AddTicks(8919));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000010"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 17, 3, 48, 346, DateTimeKind.Local).AddTicks(8956));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000011"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 17, 3, 48, 346, DateTimeKind.Local).AddTicks(9032));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000012"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 17, 3, 48, 346, DateTimeKind.Local).AddTicks(9053));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000013"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 17, 3, 48, 346, DateTimeKind.Local).AddTicks(9073));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000014"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 17, 3, 48, 346, DateTimeKind.Local).AddTicks(9135));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000015"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 17, 3, 48, 346, DateTimeKind.Local).AddTicks(9160));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000016"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 17, 3, 48, 346, DateTimeKind.Local).AddTicks(9196));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000017"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 17, 3, 48, 346, DateTimeKind.Local).AddTicks(9262));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000018"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 17, 3, 48, 346, DateTimeKind.Local).AddTicks(9285));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000019"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 17, 3, 48, 346, DateTimeKind.Local).AddTicks(9304));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000020"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 17, 3, 48, 346, DateTimeKind.Local).AddTicks(9366));

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000001"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 17, 3, 48, 346, DateTimeKind.Local).AddTicks(8498), new DateTime(2026, 7, 18, 17, 3, 48, 346, DateTimeKind.Local).AddTicks(8499) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000002"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 17, 3, 48, 346, DateTimeKind.Local).AddTicks(8578), new DateTime(2026, 7, 18, 17, 3, 48, 346, DateTimeKind.Local).AddTicks(8579) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000003"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 17, 3, 48, 346, DateTimeKind.Local).AddTicks(8608), new DateTime(2026, 7, 18, 17, 3, 48, 346, DateTimeKind.Local).AddTicks(8609) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000004"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 17, 3, 48, 346, DateTimeKind.Local).AddTicks(8659), new DateTime(2026, 7, 18, 17, 3, 48, 346, DateTimeKind.Local).AddTicks(8660) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000005"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 17, 3, 48, 346, DateTimeKind.Local).AddTicks(8751), new DateTime(2026, 7, 18, 17, 3, 48, 346, DateTimeKind.Local).AddTicks(8751) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000006"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 17, 3, 48, 346, DateTimeKind.Local).AddTicks(8806), new DateTime(2026, 7, 18, 17, 3, 48, 346, DateTimeKind.Local).AddTicks(8806) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000007"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 17, 3, 48, 346, DateTimeKind.Local).AddTicks(8827), new DateTime(2026, 7, 18, 17, 3, 48, 346, DateTimeKind.Local).AddTicks(8827) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000008"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 17, 3, 48, 346, DateTimeKind.Local).AddTicks(8889), new DateTime(2026, 7, 18, 17, 3, 48, 346, DateTimeKind.Local).AddTicks(8890) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000009"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 17, 3, 48, 346, DateTimeKind.Local).AddTicks(8912), new DateTime(2026, 7, 18, 17, 3, 48, 346, DateTimeKind.Local).AddTicks(8913) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000010"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 17, 3, 48, 346, DateTimeKind.Local).AddTicks(8951), new DateTime(2026, 7, 18, 17, 3, 48, 346, DateTimeKind.Local).AddTicks(8952) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000011"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 17, 3, 48, 346, DateTimeKind.Local).AddTicks(9027), new DateTime(2026, 7, 18, 17, 3, 48, 346, DateTimeKind.Local).AddTicks(9028) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000012"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 17, 3, 48, 346, DateTimeKind.Local).AddTicks(9049), new DateTime(2026, 7, 18, 17, 3, 48, 346, DateTimeKind.Local).AddTicks(9049) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000013"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 17, 3, 48, 346, DateTimeKind.Local).AddTicks(9068), new DateTime(2026, 7, 18, 17, 3, 48, 346, DateTimeKind.Local).AddTicks(9069) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000014"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 17, 3, 48, 346, DateTimeKind.Local).AddTicks(9127), new DateTime(2026, 7, 18, 17, 3, 48, 346, DateTimeKind.Local).AddTicks(9128) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000015"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 17, 3, 48, 346, DateTimeKind.Local).AddTicks(9149), new DateTime(2026, 7, 18, 17, 3, 48, 346, DateTimeKind.Local).AddTicks(9150) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000016"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 17, 3, 48, 346, DateTimeKind.Local).AddTicks(9190), new DateTime(2026, 7, 18, 17, 3, 48, 346, DateTimeKind.Local).AddTicks(9191) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000017"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 17, 3, 48, 346, DateTimeKind.Local).AddTicks(9214), new DateTime(2026, 7, 18, 17, 3, 48, 346, DateTimeKind.Local).AddTicks(9215) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000018"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 17, 3, 48, 346, DateTimeKind.Local).AddTicks(9280), new DateTime(2026, 7, 18, 17, 3, 48, 346, DateTimeKind.Local).AddTicks(9280) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000019"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 17, 3, 48, 346, DateTimeKind.Local).AddTicks(9299), new DateTime(2026, 7, 18, 17, 3, 48, 346, DateTimeKind.Local).AddTicks(9300) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000020"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 17, 3, 48, 346, DateTimeKind.Local).AddTicks(9321), new DateTime(2026, 7, 18, 17, 3, 48, 346, DateTimeKind.Local).AddTicks(9321) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 17, 3, 48, 346, DateTimeKind.Local).AddTicks(7057), new DateTime(2026, 7, 18, 17, 3, 48, 346, DateTimeKind.Local).AddTicks(7058) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 17, 3, 48, 346, DateTimeKind.Local).AddTicks(6728), new DateTime(2026, 7, 18, 17, 3, 48, 346, DateTimeKind.Local).AddTicks(6749) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000001"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 17, 3, 48, 346, DateTimeKind.Local).AddTicks(8472), new DateTime(2026, 7, 18, 17, 3, 48, 346, DateTimeKind.Local).AddTicks(8473) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000002"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 17, 3, 48, 346, DateTimeKind.Local).AddTicks(8570), new DateTime(2026, 7, 18, 17, 3, 48, 346, DateTimeKind.Local).AddTicks(8571) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000003"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 17, 3, 48, 346, DateTimeKind.Local).AddTicks(8601), new DateTime(2026, 7, 18, 17, 3, 48, 346, DateTimeKind.Local).AddTicks(8602) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000004"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 17, 3, 48, 346, DateTimeKind.Local).AddTicks(8652), new DateTime(2026, 7, 18, 17, 3, 48, 346, DateTimeKind.Local).AddTicks(8653) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000005"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 17, 3, 48, 346, DateTimeKind.Local).AddTicks(8735), new DateTime(2026, 7, 18, 17, 3, 48, 346, DateTimeKind.Local).AddTicks(8735) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000006"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 17, 3, 48, 346, DateTimeKind.Local).AddTicks(8799), new DateTime(2026, 7, 18, 17, 3, 48, 346, DateTimeKind.Local).AddTicks(8800) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000007"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 17, 3, 48, 346, DateTimeKind.Local).AddTicks(8820), new DateTime(2026, 7, 18, 17, 3, 48, 346, DateTimeKind.Local).AddTicks(8820) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000008"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 17, 3, 48, 346, DateTimeKind.Local).AddTicks(8882), new DateTime(2026, 7, 18, 17, 3, 48, 346, DateTimeKind.Local).AddTicks(8882) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000009"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 17, 3, 48, 346, DateTimeKind.Local).AddTicks(8901), new DateTime(2026, 7, 18, 17, 3, 48, 346, DateTimeKind.Local).AddTicks(8902) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000010"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 17, 3, 48, 346, DateTimeKind.Local).AddTicks(8933), new DateTime(2026, 7, 18, 17, 3, 48, 346, DateTimeKind.Local).AddTicks(8934) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000011"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 17, 3, 48, 346, DateTimeKind.Local).AddTicks(9019), new DateTime(2026, 7, 18, 17, 3, 48, 346, DateTimeKind.Local).AddTicks(9020) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000012"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 17, 3, 48, 346, DateTimeKind.Local).AddTicks(9042), new DateTime(2026, 7, 18, 17, 3, 48, 346, DateTimeKind.Local).AddTicks(9042) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000013"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 17, 3, 48, 346, DateTimeKind.Local).AddTicks(9061), new DateTime(2026, 7, 18, 17, 3, 48, 346, DateTimeKind.Local).AddTicks(9062) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000014"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 17, 3, 48, 346, DateTimeKind.Local).AddTicks(9081), new DateTime(2026, 7, 18, 17, 3, 48, 346, DateTimeKind.Local).AddTicks(9081) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000015"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 17, 3, 48, 346, DateTimeKind.Local).AddTicks(9142), new DateTime(2026, 7, 18, 17, 3, 48, 346, DateTimeKind.Local).AddTicks(9143) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000016"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 17, 3, 48, 346, DateTimeKind.Local).AddTicks(9184), new DateTime(2026, 7, 18, 17, 3, 48, 346, DateTimeKind.Local).AddTicks(9184) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000017"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 17, 3, 48, 346, DateTimeKind.Local).AddTicks(9203), new DateTime(2026, 7, 18, 17, 3, 48, 346, DateTimeKind.Local).AddTicks(9204) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000018"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 17, 3, 48, 346, DateTimeKind.Local).AddTicks(9272), new DateTime(2026, 7, 18, 17, 3, 48, 346, DateTimeKind.Local).AddTicks(9273) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000019"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 17, 3, 48, 346, DateTimeKind.Local).AddTicks(9292), new DateTime(2026, 7, 18, 17, 3, 48, 346, DateTimeKind.Local).AddTicks(9293) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000020"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 17, 3, 48, 346, DateTimeKind.Local).AddTicks(9314), new DateTime(2026, 7, 18, 17, 3, 48, 346, DateTimeKind.Local).AddTicks(9314) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 17, 3, 48, 346, DateTimeKind.Local).AddTicks(6866), new DateTime(2026, 7, 18, 17, 3, 48, 346, DateTimeKind.Local).AddTicks(6867) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 17, 3, 48, 346, DateTimeKind.Local).AddTicks(6876), new DateTime(2026, 7, 18, 17, 3, 48, 346, DateTimeKind.Local).AddTicks(6876) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 17, 3, 48, 346, DateTimeKind.Local).AddTicks(6880), new DateTime(2026, 7, 18, 17, 3, 48, 346, DateTimeKind.Local).AddTicks(6880) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("55555555-5555-5555-5555-555555555555"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 17, 3, 48, 346, DateTimeKind.Local).AddTicks(6885), new DateTime(2026, 7, 18, 17, 3, 48, 346, DateTimeKind.Local).AddTicks(6885) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666666"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 17, 3, 48, 346, DateTimeKind.Local).AddTicks(6888), new DateTime(2026, 7, 18, 17, 3, 48, 346, DateTimeKind.Local).AddTicks(6888) });

            migrationBuilder.InsertData(
                table: "LessonOption",
                columns: new[] { "Id", "Content", "IsCorrect", "QuestionId" },
                values: new object[,]
                {
                    { new Guid("cccccccc-cccc-cccc-cccc-cccccccccc03"), "Rất vui vẻ và năng động", false, new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbb2") },
                    { new Guid("cccccccc-cccc-cccc-cccc-cccccccccc04"), "Cảm thấy không khỏe, hơi khó ở", true, new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbb2") },
                    { new Guid("cccccccc-cccc-cccc-cccc-cccccccccc05"), "Hết tiền, rỗng túi", false, new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbb2") },
                    { new Guid("cccccccc-cccc-cccc-cccc-cccccccccc06"), "Đi ra ngoài chơi", false, new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbb2") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "LessonOption",
                keyColumn: "Id",
                keyValue: new Guid("cccccccc-cccc-cccc-cccc-cccccccccc03"));

            migrationBuilder.DeleteData(
                table: "LessonOption",
                keyColumn: "Id",
                keyValue: new Guid("cccccccc-cccc-cccc-cccc-cccccccccc04"));

            migrationBuilder.DeleteData(
                table: "LessonOption",
                keyColumn: "Id",
                keyValue: new Guid("cccccccc-cccc-cccc-cccc-cccccccccc05"));

            migrationBuilder.DeleteData(
                table: "LessonOption",
                keyColumn: "Id",
                keyValue: new Guid("cccccccc-cccc-cccc-cccc-cccccccccc06"));

            migrationBuilder.DeleteData(
                table: "LessonQuestion",
                keyColumn: "Id",
                keyValue: new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbb2"));

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("88888888-8888-8888-8888-888888888888"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 15, 33, 34, 686, DateTimeKind.Local).AddTicks(4113));

            migrationBuilder.UpdateData(
                table: "Module",
                keyColumn: "Id",
                keyValue: new Guid("77777777-7777-7777-7777-777777777777"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 33, 34, 686, DateTimeKind.Local).AddTicks(4171), new DateTime(2026, 7, 18, 15, 33, 34, 686, DateTimeKind.Local).AddTicks(4172) });

            migrationBuilder.UpdateData(
                table: "ModuleItem",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666601"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 33, 34, 686, DateTimeKind.Local).AddTicks(4230), new DateTime(2026, 7, 18, 15, 33, 34, 686, DateTimeKind.Local).AddTicks(4230) });

            migrationBuilder.UpdateData(
                table: "ModuleItem",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666602"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 33, 34, 686, DateTimeKind.Local).AddTicks(4236), new DateTime(2026, 7, 18, 15, 33, 34, 686, DateTimeKind.Local).AddTicks(4236) });

            migrationBuilder.UpdateData(
                table: "ModuleItem",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666603"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 33, 34, 686, DateTimeKind.Local).AddTicks(4239), new DateTime(2026, 7, 18, 15, 33, 34, 686, DateTimeKind.Local).AddTicks(4255) });

            migrationBuilder.UpdateData(
                table: "ModuleItem",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666604"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 33, 34, 686, DateTimeKind.Local).AddTicks(4578), new DateTime(2026, 7, 18, 15, 33, 34, 686, DateTimeKind.Local).AddTicks(4579) });

            migrationBuilder.UpdateData(
                table: "ParentProfile",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 33, 34, 686, DateTimeKind.Local).AddTicks(3656), new DateTime(2026, 7, 18, 15, 33, 34, 686, DateTimeKind.Local).AddTicks(3656) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000001"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 15, 33, 34, 686, DateTimeKind.Local).AddTicks(5262));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000002"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 15, 33, 34, 686, DateTimeKind.Local).AddTicks(5305));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000003"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 15, 33, 34, 686, DateTimeKind.Local).AddTicks(5364));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000004"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 15, 33, 34, 686, DateTimeKind.Local).AddTicks(5406));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000005"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 15, 33, 34, 686, DateTimeKind.Local).AddTicks(5435));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000006"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 15, 33, 34, 686, DateTimeKind.Local).AddTicks(5529));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000007"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 15, 33, 34, 686, DateTimeKind.Local).AddTicks(5584));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000008"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 15, 33, 34, 686, DateTimeKind.Local).AddTicks(5599));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000009"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 15, 33, 34, 686, DateTimeKind.Local).AddTicks(5621));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000010"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 15, 33, 34, 686, DateTimeKind.Local).AddTicks(5689));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000011"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 15, 33, 34, 686, DateTimeKind.Local).AddTicks(5720));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000012"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 15, 33, 34, 686, DateTimeKind.Local).AddTicks(5738));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000013"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 15, 33, 34, 686, DateTimeKind.Local).AddTicks(5794));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000014"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 15, 33, 34, 686, DateTimeKind.Local).AddTicks(5809));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000015"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 15, 33, 34, 686, DateTimeKind.Local).AddTicks(5831));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000016"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 15, 33, 34, 686, DateTimeKind.Local).AddTicks(5859));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000017"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 15, 33, 34, 686, DateTimeKind.Local).AddTicks(5906));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000018"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 15, 33, 34, 686, DateTimeKind.Local).AddTicks(5924));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000019"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 15, 33, 34, 686, DateTimeKind.Local).AddTicks(6011));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000020"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 15, 33, 34, 686, DateTimeKind.Local).AddTicks(6030));

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000001"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 33, 34, 686, DateTimeKind.Local).AddTicks(5218), new DateTime(2026, 7, 18, 15, 33, 34, 686, DateTimeKind.Local).AddTicks(5218) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000002"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 33, 34, 686, DateTimeKind.Local).AddTicks(5299), new DateTime(2026, 7, 18, 15, 33, 34, 686, DateTimeKind.Local).AddTicks(5300) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000003"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 33, 34, 686, DateTimeKind.Local).AddTicks(5319), new DateTime(2026, 7, 18, 15, 33, 34, 686, DateTimeKind.Local).AddTicks(5320) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000004"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 33, 34, 686, DateTimeKind.Local).AddTicks(5386), new DateTime(2026, 7, 18, 15, 33, 34, 686, DateTimeKind.Local).AddTicks(5386) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000005"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 33, 34, 686, DateTimeKind.Local).AddTicks(5428), new DateTime(2026, 7, 18, 15, 33, 34, 686, DateTimeKind.Local).AddTicks(5429) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000006"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 33, 34, 686, DateTimeKind.Local).AddTicks(5524), new DateTime(2026, 7, 18, 15, 33, 34, 686, DateTimeKind.Local).AddTicks(5524) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000007"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 33, 34, 686, DateTimeKind.Local).AddTicks(5580), new DateTime(2026, 7, 18, 15, 33, 34, 686, DateTimeKind.Local).AddTicks(5580) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000008"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 33, 34, 686, DateTimeKind.Local).AddTicks(5595), new DateTime(2026, 7, 18, 15, 33, 34, 686, DateTimeKind.Local).AddTicks(5595) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000009"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 33, 34, 686, DateTimeKind.Local).AddTicks(5613), new DateTime(2026, 7, 18, 15, 33, 34, 686, DateTimeKind.Local).AddTicks(5614) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000010"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 33, 34, 686, DateTimeKind.Local).AddTicks(5684), new DateTime(2026, 7, 18, 15, 33, 34, 686, DateTimeKind.Local).AddTicks(5684) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000011"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 33, 34, 686, DateTimeKind.Local).AddTicks(5716), new DateTime(2026, 7, 18, 15, 33, 34, 686, DateTimeKind.Local).AddTicks(5716) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000012"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 33, 34, 686, DateTimeKind.Local).AddTicks(5734), new DateTime(2026, 7, 18, 15, 33, 34, 686, DateTimeKind.Local).AddTicks(5734) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000013"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 33, 34, 686, DateTimeKind.Local).AddTicks(5789), new DateTime(2026, 7, 18, 15, 33, 34, 686, DateTimeKind.Local).AddTicks(5789) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000014"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 33, 34, 686, DateTimeKind.Local).AddTicks(5805), new DateTime(2026, 7, 18, 15, 33, 34, 686, DateTimeKind.Local).AddTicks(5806) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000015"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 33, 34, 686, DateTimeKind.Local).AddTicks(5822), new DateTime(2026, 7, 18, 15, 33, 34, 686, DateTimeKind.Local).AddTicks(5823) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000016"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 33, 34, 686, DateTimeKind.Local).AddTicks(5855), new DateTime(2026, 7, 18, 15, 33, 34, 686, DateTimeKind.Local).AddTicks(5855) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000017"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 33, 34, 686, DateTimeKind.Local).AddTicks(5899), new DateTime(2026, 7, 18, 15, 33, 34, 686, DateTimeKind.Local).AddTicks(5899) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000018"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 33, 34, 686, DateTimeKind.Local).AddTicks(5919), new DateTime(2026, 7, 18, 15, 33, 34, 686, DateTimeKind.Local).AddTicks(5920) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000019"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 33, 34, 686, DateTimeKind.Local).AddTicks(6006), new DateTime(2026, 7, 18, 15, 33, 34, 686, DateTimeKind.Local).AddTicks(6006) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000020"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 33, 34, 686, DateTimeKind.Local).AddTicks(6025), new DateTime(2026, 7, 18, 15, 33, 34, 686, DateTimeKind.Local).AddTicks(6026) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 33, 34, 686, DateTimeKind.Local).AddTicks(3593), new DateTime(2026, 7, 18, 15, 33, 34, 686, DateTimeKind.Local).AddTicks(3594) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 33, 34, 686, DateTimeKind.Local).AddTicks(3276), new DateTime(2026, 7, 18, 15, 33, 34, 686, DateTimeKind.Local).AddTicks(3292) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000001"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 33, 34, 686, DateTimeKind.Local).AddTicks(5174), new DateTime(2026, 7, 18, 15, 33, 34, 686, DateTimeKind.Local).AddTicks(5178) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000002"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 33, 34, 686, DateTimeKind.Local).AddTicks(5293), new DateTime(2026, 7, 18, 15, 33, 34, 686, DateTimeKind.Local).AddTicks(5293) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000003"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 33, 34, 686, DateTimeKind.Local).AddTicks(5313), new DateTime(2026, 7, 18, 15, 33, 34, 686, DateTimeKind.Local).AddTicks(5314) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000004"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 33, 34, 686, DateTimeKind.Local).AddTicks(5378), new DateTime(2026, 7, 18, 15, 33, 34, 686, DateTimeKind.Local).AddTicks(5378) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000005"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 33, 34, 686, DateTimeKind.Local).AddTicks(5413), new DateTime(2026, 7, 18, 15, 33, 34, 686, DateTimeKind.Local).AddTicks(5413) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000006"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 33, 34, 686, DateTimeKind.Local).AddTicks(5517), new DateTime(2026, 7, 18, 15, 33, 34, 686, DateTimeKind.Local).AddTicks(5518) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000007"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 33, 34, 686, DateTimeKind.Local).AddTicks(5573), new DateTime(2026, 7, 18, 15, 33, 34, 686, DateTimeKind.Local).AddTicks(5574) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000008"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 33, 34, 686, DateTimeKind.Local).AddTicks(5590), new DateTime(2026, 7, 18, 15, 33, 34, 686, DateTimeKind.Local).AddTicks(5590) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000009"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 33, 34, 686, DateTimeKind.Local).AddTicks(5606), new DateTime(2026, 7, 18, 15, 33, 34, 686, DateTimeKind.Local).AddTicks(5606) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000010"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 33, 34, 686, DateTimeKind.Local).AddTicks(5668), new DateTime(2026, 7, 18, 15, 33, 34, 686, DateTimeKind.Local).AddTicks(5668) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000011"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 33, 34, 686, DateTimeKind.Local).AddTicks(5710), new DateTime(2026, 7, 18, 15, 33, 34, 686, DateTimeKind.Local).AddTicks(5710) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000012"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 33, 34, 686, DateTimeKind.Local).AddTicks(5726), new DateTime(2026, 7, 18, 15, 33, 34, 686, DateTimeKind.Local).AddTicks(5727) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000013"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 33, 34, 686, DateTimeKind.Local).AddTicks(5744), new DateTime(2026, 7, 18, 15, 33, 34, 686, DateTimeKind.Local).AddTicks(5744) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000014"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 33, 34, 686, DateTimeKind.Local).AddTicks(5800), new DateTime(2026, 7, 18, 15, 33, 34, 686, DateTimeKind.Local).AddTicks(5800) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000015"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 33, 34, 686, DateTimeKind.Local).AddTicks(5817), new DateTime(2026, 7, 18, 15, 33, 34, 686, DateTimeKind.Local).AddTicks(5817) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000016"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 33, 34, 686, DateTimeKind.Local).AddTicks(5849), new DateTime(2026, 7, 18, 15, 33, 34, 686, DateTimeKind.Local).AddTicks(5849) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000017"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 33, 34, 686, DateTimeKind.Local).AddTicks(5890), new DateTime(2026, 7, 18, 15, 33, 34, 686, DateTimeKind.Local).AddTicks(5891) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000018"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 33, 34, 686, DateTimeKind.Local).AddTicks(5913), new DateTime(2026, 7, 18, 15, 33, 34, 686, DateTimeKind.Local).AddTicks(5914) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000019"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 33, 34, 686, DateTimeKind.Local).AddTicks(5930), new DateTime(2026, 7, 18, 15, 33, 34, 686, DateTimeKind.Local).AddTicks(5931) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000020"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 33, 34, 686, DateTimeKind.Local).AddTicks(6018), new DateTime(2026, 7, 18, 15, 33, 34, 686, DateTimeKind.Local).AddTicks(6018) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 33, 34, 686, DateTimeKind.Local).AddTicks(3352), new DateTime(2026, 7, 18, 15, 33, 34, 686, DateTimeKind.Local).AddTicks(3353) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 33, 34, 686, DateTimeKind.Local).AddTicks(3359), new DateTime(2026, 7, 18, 15, 33, 34, 686, DateTimeKind.Local).AddTicks(3360) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 33, 34, 686, DateTimeKind.Local).AddTicks(3362), new DateTime(2026, 7, 18, 15, 33, 34, 686, DateTimeKind.Local).AddTicks(3363) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("55555555-5555-5555-5555-555555555555"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 33, 34, 686, DateTimeKind.Local).AddTicks(3369), new DateTime(2026, 7, 18, 15, 33, 34, 686, DateTimeKind.Local).AddTicks(3369) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666666"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 33, 34, 686, DateTimeKind.Local).AddTicks(3382), new DateTime(2026, 7, 18, 15, 33, 34, 686, DateTimeKind.Local).AddTicks(3382) });
        }
    }
}
