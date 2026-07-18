using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddMoreQuizQuestions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("88888888-8888-8888-8888-888888888888"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(7950));

            migrationBuilder.UpdateData(
                table: "Module",
                keyColumn: "Id",
                keyValue: new Guid("77777777-7777-7777-7777-777777777777"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(8026), new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(8027) });

            migrationBuilder.UpdateData(
                table: "ModuleItem",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666601"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(8094), new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(8094) });

            migrationBuilder.UpdateData(
                table: "ModuleItem",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666602"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(8099), new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(8100) });

            migrationBuilder.UpdateData(
                table: "ModuleItem",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666603"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(8103), new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(8120) });

            migrationBuilder.UpdateData(
                table: "ModuleItem",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666604"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(8143), new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(8143) });

            migrationBuilder.UpdateData(
                table: "ParentProfile",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(7344), new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(7345) });

            migrationBuilder.UpdateData(
                table: "Quiz",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666603"),
                column: "PickCount",
                value: 10);

            migrationBuilder.InsertData(
                table: "QuizQuestion",
                columns: new[] { "Id", "Content", "Explanation", "IsDeleted", "MediaUrl", "QuizId" },
                values: new object[,]
                {
                    { new Guid("dddddddd-dddd-dddd-dddd-dddddddddd03"), "Question 3 for Tenses Quiz 1", null, false, null, new Guid("66666666-6666-6666-6666-666666666603") },
                    { new Guid("dddddddd-dddd-dddd-dddd-dddddddddd04"), "Question 4 for Tenses Quiz 1", null, false, null, new Guid("66666666-6666-6666-6666-666666666603") },
                    { new Guid("dddddddd-dddd-dddd-dddd-dddddddddd05"), "Question 5 for Tenses Quiz 1", null, false, null, new Guid("66666666-6666-6666-6666-666666666603") },
                    { new Guid("dddddddd-dddd-dddd-dddd-dddddddddd06"), "Question 6 for Tenses Quiz 1", null, false, null, new Guid("66666666-6666-6666-6666-666666666603") },
                    { new Guid("dddddddd-dddd-dddd-dddd-dddddddddd07"), "Question 7 for Tenses Quiz 1", null, false, null, new Guid("66666666-6666-6666-6666-666666666603") },
                    { new Guid("dddddddd-dddd-dddd-dddd-dddddddddd08"), "Question 8 for Tenses Quiz 1", null, false, null, new Guid("66666666-6666-6666-6666-666666666603") },
                    { new Guid("dddddddd-dddd-dddd-dddd-dddddddddd09"), "Question 9 for Tenses Quiz 1", null, false, null, new Guid("66666666-6666-6666-6666-666666666603") },
                    { new Guid("dddddddd-dddd-dddd-dddd-dddddddddd10"), "Question 10 for Tenses Quiz 1", null, false, null, new Guid("66666666-6666-6666-6666-666666666603") },
                    { new Guid("dddddddd-dddd-dddd-dddd-dddddddddd11"), "Question 11 for Tenses Quiz 1", null, false, null, new Guid("66666666-6666-6666-6666-666666666603") },
                    { new Guid("dddddddd-dddd-dddd-dddd-dddddddddd12"), "Question 12 for Tenses Quiz 1", null, false, null, new Guid("66666666-6666-6666-6666-666666666603") },
                    { new Guid("dddddddd-dddd-dddd-dddd-dddddddddd13"), "Question 13 for Tenses Quiz 1", null, false, null, new Guid("66666666-6666-6666-6666-666666666603") },
                    { new Guid("dddddddd-dddd-dddd-dddd-dddddddddd14"), "Question 14 for Tenses Quiz 1", null, false, null, new Guid("66666666-6666-6666-6666-666666666603") },
                    { new Guid("dddddddd-dddd-dddd-dddd-dddddddddd15"), "Question 15 for Tenses Quiz 1", null, false, null, new Guid("66666666-6666-6666-6666-666666666603") }
                });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000001"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(8725));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000002"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(8769));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000003"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(8937));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000004"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(8982));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000005"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(9019));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000006"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(9111));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000007"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(9133));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000008"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(9153));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000009"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(9174));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000010"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(9233));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000011"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(9281));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000012"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(9298));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000013"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(9352));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000014"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(9371));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000015"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(9393));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000016"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(9423));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000017"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(9478));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000018"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(9498));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000019"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(9549));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000020"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(9567));

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000001"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(8688), new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(8688) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000002"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(8763), new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(8764) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000003"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(8922), new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(8923) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000004"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(8972), new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(8973) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000005"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(9007), new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(9008) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000006"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(9101), new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(9102) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000007"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(9128), new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(9129) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000008"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(9146), new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(9147) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000009"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(9168), new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(9168) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000010"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(9228), new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(9229) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000011"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(9276), new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(9276) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000012"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(9294), new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(9294) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000013"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(9347), new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(9347) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000014"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(9366), new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(9367) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000015"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(9385), new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(9385) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000016"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(9416), new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(9416) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000017"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(9472), new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(9472) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000018"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(9493), new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(9494) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000019"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(9544), new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(9545) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000020"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(9562), new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(9563) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(7286), new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(7287) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(6993), new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(7036) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000001"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(8664), new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(8665) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000002"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(8756), new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(8756) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000003"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(8778), new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(8778) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000004"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(8961), new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(8962) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000005"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(8995), new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000006"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(9038), new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(9039) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000007"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(9121), new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(9122) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000008"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(9140), new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(9141) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000009"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(9160), new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(9160) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000010"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(9221), new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(9222) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000011"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(9267), new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(9268) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000012"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(9287), new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(9288) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000013"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(9340), new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(9340) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000014"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(9361), new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(9361) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000015"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(9378), new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(9378) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000016"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(9410), new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(9410) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000017"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(9464), new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(9464) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000018"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(9487), new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(9488) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000019"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(9505), new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(9506) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000020"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(9556), new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(9557) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(7085), new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(7086) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(7091), new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(7091) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(7098), new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(7098) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("55555555-5555-5555-5555-555555555555"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(7102), new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(7102) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666666"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(7106), new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(7106) });

            migrationBuilder.InsertData(
                table: "QuizOption",
                columns: new[] { "Id", "Content", "IsCorrect", "QuestionId" },
                values: new object[,]
                {
                    { new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee05"), "Option A", true, new Guid("dddddddd-dddd-dddd-dddd-dddddddddd03") },
                    { new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee06"), "Option B", false, new Guid("dddddddd-dddd-dddd-dddd-dddddddddd03") },
                    { new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee07"), "Option A", true, new Guid("dddddddd-dddd-dddd-dddd-dddddddddd04") },
                    { new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee08"), "Option B", false, new Guid("dddddddd-dddd-dddd-dddd-dddddddddd04") },
                    { new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee09"), "Option A", true, new Guid("dddddddd-dddd-dddd-dddd-dddddddddd05") },
                    { new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee10"), "Option B", false, new Guid("dddddddd-dddd-dddd-dddd-dddddddddd05") },
                    { new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee11"), "Option A", true, new Guid("dddddddd-dddd-dddd-dddd-dddddddddd06") },
                    { new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee12"), "Option B", false, new Guid("dddddddd-dddd-dddd-dddd-dddddddddd06") },
                    { new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee13"), "Option A", true, new Guid("dddddddd-dddd-dddd-dddd-dddddddddd07") },
                    { new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee14"), "Option B", false, new Guid("dddddddd-dddd-dddd-dddd-dddddddddd07") },
                    { new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee15"), "Option A", true, new Guid("dddddddd-dddd-dddd-dddd-dddddddddd08") },
                    { new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee16"), "Option B", false, new Guid("dddddddd-dddd-dddd-dddd-dddddddddd08") },
                    { new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee17"), "Option A", true, new Guid("dddddddd-dddd-dddd-dddd-dddddddddd09") },
                    { new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee18"), "Option B", false, new Guid("dddddddd-dddd-dddd-dddd-dddddddddd09") },
                    { new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee19"), "Option A", true, new Guid("dddddddd-dddd-dddd-dddd-dddddddddd10") },
                    { new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee20"), "Option B", false, new Guid("dddddddd-dddd-dddd-dddd-dddddddddd10") },
                    { new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee21"), "Option A", true, new Guid("dddddddd-dddd-dddd-dddd-dddddddddd11") },
                    { new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee22"), "Option B", false, new Guid("dddddddd-dddd-dddd-dddd-dddddddddd11") },
                    { new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee23"), "Option A", true, new Guid("dddddddd-dddd-dddd-dddd-dddddddddd12") },
                    { new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee24"), "Option B", false, new Guid("dddddddd-dddd-dddd-dddd-dddddddddd12") },
                    { new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee25"), "Option A", true, new Guid("dddddddd-dddd-dddd-dddd-dddddddddd13") },
                    { new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee26"), "Option B", false, new Guid("dddddddd-dddd-dddd-dddd-dddddddddd13") },
                    { new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee27"), "Option A", true, new Guid("dddddddd-dddd-dddd-dddd-dddddddddd14") },
                    { new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee28"), "Option B", false, new Guid("dddddddd-dddd-dddd-dddd-dddddddddd14") },
                    { new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee29"), "Option A", true, new Guid("dddddddd-dddd-dddd-dddd-dddddddddd15") },
                    { new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee30"), "Option B", false, new Guid("dddddddd-dddd-dddd-dddd-dddddddddd15") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "QuizOption",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee05"));

            migrationBuilder.DeleteData(
                table: "QuizOption",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee06"));

            migrationBuilder.DeleteData(
                table: "QuizOption",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee07"));

            migrationBuilder.DeleteData(
                table: "QuizOption",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee08"));

            migrationBuilder.DeleteData(
                table: "QuizOption",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee09"));

            migrationBuilder.DeleteData(
                table: "QuizOption",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee10"));

            migrationBuilder.DeleteData(
                table: "QuizOption",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee11"));

            migrationBuilder.DeleteData(
                table: "QuizOption",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee12"));

            migrationBuilder.DeleteData(
                table: "QuizOption",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee13"));

            migrationBuilder.DeleteData(
                table: "QuizOption",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee14"));

            migrationBuilder.DeleteData(
                table: "QuizOption",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee15"));

            migrationBuilder.DeleteData(
                table: "QuizOption",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee16"));

            migrationBuilder.DeleteData(
                table: "QuizOption",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee17"));

            migrationBuilder.DeleteData(
                table: "QuizOption",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee18"));

            migrationBuilder.DeleteData(
                table: "QuizOption",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee19"));

            migrationBuilder.DeleteData(
                table: "QuizOption",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee20"));

            migrationBuilder.DeleteData(
                table: "QuizOption",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee21"));

            migrationBuilder.DeleteData(
                table: "QuizOption",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee22"));

            migrationBuilder.DeleteData(
                table: "QuizOption",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee23"));

            migrationBuilder.DeleteData(
                table: "QuizOption",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee24"));

            migrationBuilder.DeleteData(
                table: "QuizOption",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee25"));

            migrationBuilder.DeleteData(
                table: "QuizOption",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee26"));

            migrationBuilder.DeleteData(
                table: "QuizOption",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee27"));

            migrationBuilder.DeleteData(
                table: "QuizOption",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee28"));

            migrationBuilder.DeleteData(
                table: "QuizOption",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee29"));

            migrationBuilder.DeleteData(
                table: "QuizOption",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeee30"));

            migrationBuilder.DeleteData(
                table: "QuizQuestion",
                keyColumn: "Id",
                keyValue: new Guid("dddddddd-dddd-dddd-dddd-dddddddddd03"));

            migrationBuilder.DeleteData(
                table: "QuizQuestion",
                keyColumn: "Id",
                keyValue: new Guid("dddddddd-dddd-dddd-dddd-dddddddddd04"));

            migrationBuilder.DeleteData(
                table: "QuizQuestion",
                keyColumn: "Id",
                keyValue: new Guid("dddddddd-dddd-dddd-dddd-dddddddddd05"));

            migrationBuilder.DeleteData(
                table: "QuizQuestion",
                keyColumn: "Id",
                keyValue: new Guid("dddddddd-dddd-dddd-dddd-dddddddddd06"));

            migrationBuilder.DeleteData(
                table: "QuizQuestion",
                keyColumn: "Id",
                keyValue: new Guid("dddddddd-dddd-dddd-dddd-dddddddddd07"));

            migrationBuilder.DeleteData(
                table: "QuizQuestion",
                keyColumn: "Id",
                keyValue: new Guid("dddddddd-dddd-dddd-dddd-dddddddddd08"));

            migrationBuilder.DeleteData(
                table: "QuizQuestion",
                keyColumn: "Id",
                keyValue: new Guid("dddddddd-dddd-dddd-dddd-dddddddddd09"));

            migrationBuilder.DeleteData(
                table: "QuizQuestion",
                keyColumn: "Id",
                keyValue: new Guid("dddddddd-dddd-dddd-dddd-dddddddddd10"));

            migrationBuilder.DeleteData(
                table: "QuizQuestion",
                keyColumn: "Id",
                keyValue: new Guid("dddddddd-dddd-dddd-dddd-dddddddddd11"));

            migrationBuilder.DeleteData(
                table: "QuizQuestion",
                keyColumn: "Id",
                keyValue: new Guid("dddddddd-dddd-dddd-dddd-dddddddddd12"));

            migrationBuilder.DeleteData(
                table: "QuizQuestion",
                keyColumn: "Id",
                keyValue: new Guid("dddddddd-dddd-dddd-dddd-dddddddddd13"));

            migrationBuilder.DeleteData(
                table: "QuizQuestion",
                keyColumn: "Id",
                keyValue: new Guid("dddddddd-dddd-dddd-dddd-dddddddddd14"));

            migrationBuilder.DeleteData(
                table: "QuizQuestion",
                keyColumn: "Id",
                keyValue: new Guid("dddddddd-dddd-dddd-dddd-dddddddddd15"));

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

            migrationBuilder.UpdateData(
                table: "Quiz",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666603"),
                column: "PickCount",
                value: null);

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
        }
    }
}
