using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedLearningData2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("88888888-8888-8888-8888-888888888888"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 14, 48, 2, 427, DateTimeKind.Local).AddTicks(7350));

            migrationBuilder.InsertData(
                table: "Module",
                columns: new[] { "Id", "CourseId", "CreatedAt", "CreatedBy", "Description", "LastUpdatedAt", "LastUpdatedBy", "OrderIndex", "Title", "UpdatedBy" },
                values: new object[] { new Guid("77777777-7777-7777-7777-777777777777"), new Guid("88888888-8888-8888-8888-888888888888"), new DateTime(2026, 7, 18, 14, 48, 2, 427, DateTimeKind.Local).AddTicks(7437), new Guid("44444444-4444-4444-4444-444444444444"), null, new DateTime(2026, 7, 18, 14, 48, 2, 427, DateTimeKind.Local).AddTicks(7437), null, 1, "Module 1: Basics", null });

            migrationBuilder.UpdateData(
                table: "ParentProfile",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 14, 48, 2, 427, DateTimeKind.Local).AddTicks(6578), new DateTime(2026, 7, 18, 14, 48, 2, 427, DateTimeKind.Local).AddTicks(6579) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000001"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 14, 48, 2, 427, DateTimeKind.Local).AddTicks(8196));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000002"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 14, 48, 2, 427, DateTimeKind.Local).AddTicks(8251));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000003"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 14, 48, 2, 427, DateTimeKind.Local).AddTicks(8272));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000004"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 14, 48, 2, 427, DateTimeKind.Local).AddTicks(8289));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000005"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 14, 48, 2, 427, DateTimeKind.Local).AddTicks(8312));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000006"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 14, 48, 2, 427, DateTimeKind.Local).AddTicks(8518));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000007"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 14, 48, 2, 427, DateTimeKind.Local).AddTicks(8549));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000008"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 14, 48, 2, 427, DateTimeKind.Local).AddTicks(8568));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000009"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 14, 48, 2, 427, DateTimeKind.Local).AddTicks(8588));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000010"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 14, 48, 2, 427, DateTimeKind.Local).AddTicks(8686));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000011"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 14, 48, 2, 427, DateTimeKind.Local).AddTicks(8737));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000012"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 14, 48, 2, 427, DateTimeKind.Local).AddTicks(8754));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000013"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 14, 48, 2, 427, DateTimeKind.Local).AddTicks(8773));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000014"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 14, 48, 2, 427, DateTimeKind.Local).AddTicks(8855));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000015"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 14, 48, 2, 427, DateTimeKind.Local).AddTicks(8873));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000016"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 14, 48, 2, 427, DateTimeKind.Local).AddTicks(8907));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000017"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 14, 48, 2, 427, DateTimeKind.Local).AddTicks(8927));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000018"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 14, 48, 2, 427, DateTimeKind.Local).AddTicks(9003));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000019"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 14, 48, 2, 427, DateTimeKind.Local).AddTicks(9023));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000020"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 14, 48, 2, 427, DateTimeKind.Local).AddTicks(9040));

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000001"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 14, 48, 2, 427, DateTimeKind.Local).AddTicks(8078), new DateTime(2026, 7, 18, 14, 48, 2, 427, DateTimeKind.Local).AddTicks(8079) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000002"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 14, 48, 2, 427, DateTimeKind.Local).AddTicks(8245), new DateTime(2026, 7, 18, 14, 48, 2, 427, DateTimeKind.Local).AddTicks(8245) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000003"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 14, 48, 2, 427, DateTimeKind.Local).AddTicks(8267), new DateTime(2026, 7, 18, 14, 48, 2, 427, DateTimeKind.Local).AddTicks(8268) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000004"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 14, 48, 2, 427, DateTimeKind.Local).AddTicks(8284), new DateTime(2026, 7, 18, 14, 48, 2, 427, DateTimeKind.Local).AddTicks(8285) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000005"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 14, 48, 2, 427, DateTimeKind.Local).AddTicks(8303), new DateTime(2026, 7, 18, 14, 48, 2, 427, DateTimeKind.Local).AddTicks(8304) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000006"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 14, 48, 2, 427, DateTimeKind.Local).AddTicks(8512), new DateTime(2026, 7, 18, 14, 48, 2, 427, DateTimeKind.Local).AddTicks(8513) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000007"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 14, 48, 2, 427, DateTimeKind.Local).AddTicks(8544), new DateTime(2026, 7, 18, 14, 48, 2, 427, DateTimeKind.Local).AddTicks(8545) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000008"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 14, 48, 2, 427, DateTimeKind.Local).AddTicks(8563), new DateTime(2026, 7, 18, 14, 48, 2, 427, DateTimeKind.Local).AddTicks(8564) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000009"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 14, 48, 2, 427, DateTimeKind.Local).AddTicks(8581), new DateTime(2026, 7, 18, 14, 48, 2, 427, DateTimeKind.Local).AddTicks(8582) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000010"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 14, 48, 2, 427, DateTimeKind.Local).AddTicks(8671), new DateTime(2026, 7, 18, 14, 48, 2, 427, DateTimeKind.Local).AddTicks(8672) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000011"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 14, 48, 2, 427, DateTimeKind.Local).AddTicks(8731), new DateTime(2026, 7, 18, 14, 48, 2, 427, DateTimeKind.Local).AddTicks(8732) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000012"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 14, 48, 2, 427, DateTimeKind.Local).AddTicks(8748), new DateTime(2026, 7, 18, 14, 48, 2, 427, DateTimeKind.Local).AddTicks(8749) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000013"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 14, 48, 2, 427, DateTimeKind.Local).AddTicks(8766), new DateTime(2026, 7, 18, 14, 48, 2, 427, DateTimeKind.Local).AddTicks(8767) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000014"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 14, 48, 2, 427, DateTimeKind.Local).AddTicks(8849), new DateTime(2026, 7, 18, 14, 48, 2, 427, DateTimeKind.Local).AddTicks(8850) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000015"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 14, 48, 2, 427, DateTimeKind.Local).AddTicks(8868), new DateTime(2026, 7, 18, 14, 48, 2, 427, DateTimeKind.Local).AddTicks(8868) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000016"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 14, 48, 2, 427, DateTimeKind.Local).AddTicks(8902), new DateTime(2026, 7, 18, 14, 48, 2, 427, DateTimeKind.Local).AddTicks(8903) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000017"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 14, 48, 2, 427, DateTimeKind.Local).AddTicks(8921), new DateTime(2026, 7, 18, 14, 48, 2, 427, DateTimeKind.Local).AddTicks(8922) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000018"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 14, 48, 2, 427, DateTimeKind.Local).AddTicks(8997), new DateTime(2026, 7, 18, 14, 48, 2, 427, DateTimeKind.Local).AddTicks(8998) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000019"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 14, 48, 2, 427, DateTimeKind.Local).AddTicks(9018), new DateTime(2026, 7, 18, 14, 48, 2, 427, DateTimeKind.Local).AddTicks(9019) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000020"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 14, 48, 2, 427, DateTimeKind.Local).AddTicks(9035), new DateTime(2026, 7, 18, 14, 48, 2, 427, DateTimeKind.Local).AddTicks(9036) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 14, 48, 2, 427, DateTimeKind.Local).AddTicks(6493), new DateTime(2026, 7, 18, 14, 48, 2, 427, DateTimeKind.Local).AddTicks(6494) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 14, 48, 2, 427, DateTimeKind.Local).AddTicks(6145), new DateTime(2026, 7, 18, 14, 48, 2, 427, DateTimeKind.Local).AddTicks(6177) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000001"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 14, 48, 2, 427, DateTimeKind.Local).AddTicks(8048), new DateTime(2026, 7, 18, 14, 48, 2, 427, DateTimeKind.Local).AddTicks(8049) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000002"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 14, 48, 2, 427, DateTimeKind.Local).AddTicks(8237), new DateTime(2026, 7, 18, 14, 48, 2, 427, DateTimeKind.Local).AddTicks(8238) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000003"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 14, 48, 2, 427, DateTimeKind.Local).AddTicks(8260), new DateTime(2026, 7, 18, 14, 48, 2, 427, DateTimeKind.Local).AddTicks(8261) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000004"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 14, 48, 2, 427, DateTimeKind.Local).AddTicks(8278), new DateTime(2026, 7, 18, 14, 48, 2, 427, DateTimeKind.Local).AddTicks(8279) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000005"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 14, 48, 2, 427, DateTimeKind.Local).AddTicks(8295), new DateTime(2026, 7, 18, 14, 48, 2, 427, DateTimeKind.Local).AddTicks(8296) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000006"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 14, 48, 2, 427, DateTimeKind.Local).AddTicks(8505), new DateTime(2026, 7, 18, 14, 48, 2, 427, DateTimeKind.Local).AddTicks(8506) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000007"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 14, 48, 2, 427, DateTimeKind.Local).AddTicks(8538), new DateTime(2026, 7, 18, 14, 48, 2, 427, DateTimeKind.Local).AddTicks(8539) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000008"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 14, 48, 2, 427, DateTimeKind.Local).AddTicks(8555), new DateTime(2026, 7, 18, 14, 48, 2, 427, DateTimeKind.Local).AddTicks(8556) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000009"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 14, 48, 2, 427, DateTimeKind.Local).AddTicks(8574), new DateTime(2026, 7, 18, 14, 48, 2, 427, DateTimeKind.Local).AddTicks(8574) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000010"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 14, 48, 2, 427, DateTimeKind.Local).AddTicks(8663), new DateTime(2026, 7, 18, 14, 48, 2, 427, DateTimeKind.Local).AddTicks(8664) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000011"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 14, 48, 2, 427, DateTimeKind.Local).AddTicks(8724), new DateTime(2026, 7, 18, 14, 48, 2, 427, DateTimeKind.Local).AddTicks(8725) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000012"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 14, 48, 2, 427, DateTimeKind.Local).AddTicks(8742), new DateTime(2026, 7, 18, 14, 48, 2, 427, DateTimeKind.Local).AddTicks(8743) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000013"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 14, 48, 2, 427, DateTimeKind.Local).AddTicks(8760), new DateTime(2026, 7, 18, 14, 48, 2, 427, DateTimeKind.Local).AddTicks(8761) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000014"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 14, 48, 2, 427, DateTimeKind.Local).AddTicks(8779), new DateTime(2026, 7, 18, 14, 48, 2, 427, DateTimeKind.Local).AddTicks(8779) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000015"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 14, 48, 2, 427, DateTimeKind.Local).AddTicks(8861), new DateTime(2026, 7, 18, 14, 48, 2, 427, DateTimeKind.Local).AddTicks(8862) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000016"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 14, 48, 2, 427, DateTimeKind.Local).AddTicks(8894), new DateTime(2026, 7, 18, 14, 48, 2, 427, DateTimeKind.Local).AddTicks(8894) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000017"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 14, 48, 2, 427, DateTimeKind.Local).AddTicks(8913), new DateTime(2026, 7, 18, 14, 48, 2, 427, DateTimeKind.Local).AddTicks(8914) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000018"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 14, 48, 2, 427, DateTimeKind.Local).AddTicks(8991), new DateTime(2026, 7, 18, 14, 48, 2, 427, DateTimeKind.Local).AddTicks(8991) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000019"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 14, 48, 2, 427, DateTimeKind.Local).AddTicks(9011), new DateTime(2026, 7, 18, 14, 48, 2, 427, DateTimeKind.Local).AddTicks(9012) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000020"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 14, 48, 2, 427, DateTimeKind.Local).AddTicks(9029), new DateTime(2026, 7, 18, 14, 48, 2, 427, DateTimeKind.Local).AddTicks(9030) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 14, 48, 2, 427, DateTimeKind.Local).AddTicks(6262), new DateTime(2026, 7, 18, 14, 48, 2, 427, DateTimeKind.Local).AddTicks(6262) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 14, 48, 2, 427, DateTimeKind.Local).AddTicks(6269), new DateTime(2026, 7, 18, 14, 48, 2, 427, DateTimeKind.Local).AddTicks(6269) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 14, 48, 2, 427, DateTimeKind.Local).AddTicks(6274), new DateTime(2026, 7, 18, 14, 48, 2, 427, DateTimeKind.Local).AddTicks(6275) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("55555555-5555-5555-5555-555555555555"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 14, 48, 2, 427, DateTimeKind.Local).AddTicks(6278), new DateTime(2026, 7, 18, 14, 48, 2, 427, DateTimeKind.Local).AddTicks(6278) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666666"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 14, 48, 2, 427, DateTimeKind.Local).AddTicks(6283), new DateTime(2026, 7, 18, 14, 48, 2, 427, DateTimeKind.Local).AddTicks(6283) });

            migrationBuilder.InsertData(
                table: "ModuleItem",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "ItemType", "LastUpdatedAt", "LastUpdatedBy", "ModuleId", "OrderIndex", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("66666666-6666-6666-6666-666666666601"), new DateTime(2026, 7, 18, 14, 48, 2, 427, DateTimeKind.Local).AddTicks(7528), null, (byte)1, new DateTime(2026, 7, 18, 14, 48, 2, 427, DateTimeKind.Local).AddTicks(7528), null, new Guid("77777777-7777-7777-7777-777777777777"), 1, null },
                    { new Guid("66666666-6666-6666-6666-666666666602"), new DateTime(2026, 7, 18, 14, 48, 2, 427, DateTimeKind.Local).AddTicks(7536), null, (byte)1, new DateTime(2026, 7, 18, 14, 48, 2, 427, DateTimeKind.Local).AddTicks(7537), null, new Guid("77777777-7777-7777-7777-777777777777"), 2, null },
                    { new Guid("66666666-6666-6666-6666-666666666603"), new DateTime(2026, 7, 18, 14, 48, 2, 427, DateTimeKind.Local).AddTicks(7541), null, (byte)2, new DateTime(2026, 7, 18, 14, 48, 2, 427, DateTimeKind.Local).AddTicks(7558), null, new Guid("77777777-7777-7777-7777-777777777777"), 3, null },
                    { new Guid("66666666-6666-6666-6666-666666666604"), new DateTime(2026, 7, 18, 14, 48, 2, 427, DateTimeKind.Local).AddTicks(7589), null, (byte)3, new DateTime(2026, 7, 18, 14, 48, 2, 427, DateTimeKind.Local).AddTicks(7589), null, new Guid("77777777-7777-7777-7777-777777777777"), 4, null }
                });

            migrationBuilder.InsertData(
                table: "Assignment",
                columns: new[] { "Id", "AttachmentUrl", "Content", "Instructions", "MaxScore", "PassingScorePct", "SubmissionType", "Title" },
                values: new object[] { new Guid("66666666-6666-6666-6666-666666666604"), null, "Mô tả thói quen", "Write a paragraph...", 100m, 70.00m, (byte)0, "Daily Routine Paragraph" });

            migrationBuilder.InsertData(
                table: "Lesson",
                columns: new[] { "Id", "ContentType", "DurationSec", "TextContent", "Title", "VideoUrl" },
                values: new object[,]
                {
                    { new Guid("66666666-6666-6666-6666-666666666601"), (byte)1, 600, null, "Present Simple & Continuous", "https://www.youtube.com/embed/YOUR_VIDEO_ID" },
                    { new Guid("66666666-6666-6666-6666-666666666602"), (byte)2, 300, "Tense Timelines content", "Tense Timelines (Reading)", null }
                });

            migrationBuilder.InsertData(
                table: "Progress",
                columns: new[] { "ModuleItemId", "StudentId", "CompletedAt", "PercentDone", "ScorePct", "StartedAt", "Status", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("66666666-6666-6666-6666-666666666601"), new Guid("22222222-2222-2222-2222-000000000001"), null, 100m, null, null, (byte)2, new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("66666666-6666-6666-6666-666666666601"), new Guid("22222222-2222-2222-2222-000000000002"), null, 100m, null, null, (byte)2, new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("66666666-6666-6666-6666-666666666601"), new Guid("22222222-2222-2222-2222-000000000003"), null, 100m, null, null, (byte)2, new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("66666666-6666-6666-6666-666666666601"), new Guid("22222222-2222-2222-2222-000000000004"), null, 100m, null, null, (byte)2, new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("66666666-6666-6666-6666-666666666601"), new Guid("22222222-2222-2222-2222-000000000005"), null, 100m, null, null, (byte)2, new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("66666666-6666-6666-6666-666666666601"), new Guid("22222222-2222-2222-2222-000000000006"), null, 100m, null, null, (byte)2, new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("66666666-6666-6666-6666-666666666601"), new Guid("22222222-2222-2222-2222-000000000007"), null, 100m, null, null, (byte)2, new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("66666666-6666-6666-6666-666666666601"), new Guid("22222222-2222-2222-2222-000000000008"), null, 100m, null, null, (byte)2, new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("66666666-6666-6666-6666-666666666601"), new Guid("22222222-2222-2222-2222-000000000009"), null, 100m, null, null, (byte)2, new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("66666666-6666-6666-6666-666666666601"), new Guid("22222222-2222-2222-2222-000000000010"), null, 100m, null, null, (byte)2, new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("66666666-6666-6666-6666-666666666601"), new Guid("22222222-2222-2222-2222-000000000011"), null, 100m, null, null, (byte)2, new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("66666666-6666-6666-6666-666666666601"), new Guid("22222222-2222-2222-2222-000000000012"), null, 100m, null, null, (byte)2, new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("66666666-6666-6666-6666-666666666601"), new Guid("22222222-2222-2222-2222-000000000013"), null, 100m, null, null, (byte)2, new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("66666666-6666-6666-6666-666666666601"), new Guid("22222222-2222-2222-2222-000000000014"), null, 100m, null, null, (byte)2, new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("66666666-6666-6666-6666-666666666601"), new Guid("22222222-2222-2222-2222-000000000015"), null, 100m, null, null, (byte)2, new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("66666666-6666-6666-6666-666666666601"), new Guid("22222222-2222-2222-2222-000000000016"), null, 100m, null, null, (byte)2, new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("66666666-6666-6666-6666-666666666601"), new Guid("22222222-2222-2222-2222-000000000017"), null, 100m, null, null, (byte)2, new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("66666666-6666-6666-6666-666666666601"), new Guid("22222222-2222-2222-2222-000000000018"), null, 100m, null, null, (byte)2, new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("66666666-6666-6666-6666-666666666601"), new Guid("22222222-2222-2222-2222-000000000019"), null, 100m, null, null, (byte)2, new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("66666666-6666-6666-6666-666666666601"), new Guid("22222222-2222-2222-2222-000000000020"), null, 100m, null, null, (byte)2, new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Quiz",
                columns: new[] { "Id", "MaxAttempts", "PassingScorePct", "PickCount", "TimeLimitMin", "Title" },
                values: new object[] { new Guid("66666666-6666-6666-6666-666666666603"), 3, 70.00m, null, 15, "Tenses Quiz 1" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Assignment",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666604"));

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666601"));

            migrationBuilder.DeleteData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666602"));

            migrationBuilder.DeleteData(
                table: "Progress",
                keyColumns: new[] { "ModuleItemId", "StudentId" },
                keyValues: new object[] { new Guid("66666666-6666-6666-6666-666666666601"), new Guid("22222222-2222-2222-2222-000000000001") });

            migrationBuilder.DeleteData(
                table: "Progress",
                keyColumns: new[] { "ModuleItemId", "StudentId" },
                keyValues: new object[] { new Guid("66666666-6666-6666-6666-666666666601"), new Guid("22222222-2222-2222-2222-000000000002") });

            migrationBuilder.DeleteData(
                table: "Progress",
                keyColumns: new[] { "ModuleItemId", "StudentId" },
                keyValues: new object[] { new Guid("66666666-6666-6666-6666-666666666601"), new Guid("22222222-2222-2222-2222-000000000003") });

            migrationBuilder.DeleteData(
                table: "Progress",
                keyColumns: new[] { "ModuleItemId", "StudentId" },
                keyValues: new object[] { new Guid("66666666-6666-6666-6666-666666666601"), new Guid("22222222-2222-2222-2222-000000000004") });

            migrationBuilder.DeleteData(
                table: "Progress",
                keyColumns: new[] { "ModuleItemId", "StudentId" },
                keyValues: new object[] { new Guid("66666666-6666-6666-6666-666666666601"), new Guid("22222222-2222-2222-2222-000000000005") });

            migrationBuilder.DeleteData(
                table: "Progress",
                keyColumns: new[] { "ModuleItemId", "StudentId" },
                keyValues: new object[] { new Guid("66666666-6666-6666-6666-666666666601"), new Guid("22222222-2222-2222-2222-000000000006") });

            migrationBuilder.DeleteData(
                table: "Progress",
                keyColumns: new[] { "ModuleItemId", "StudentId" },
                keyValues: new object[] { new Guid("66666666-6666-6666-6666-666666666601"), new Guid("22222222-2222-2222-2222-000000000007") });

            migrationBuilder.DeleteData(
                table: "Progress",
                keyColumns: new[] { "ModuleItemId", "StudentId" },
                keyValues: new object[] { new Guid("66666666-6666-6666-6666-666666666601"), new Guid("22222222-2222-2222-2222-000000000008") });

            migrationBuilder.DeleteData(
                table: "Progress",
                keyColumns: new[] { "ModuleItemId", "StudentId" },
                keyValues: new object[] { new Guid("66666666-6666-6666-6666-666666666601"), new Guid("22222222-2222-2222-2222-000000000009") });

            migrationBuilder.DeleteData(
                table: "Progress",
                keyColumns: new[] { "ModuleItemId", "StudentId" },
                keyValues: new object[] { new Guid("66666666-6666-6666-6666-666666666601"), new Guid("22222222-2222-2222-2222-000000000010") });

            migrationBuilder.DeleteData(
                table: "Progress",
                keyColumns: new[] { "ModuleItemId", "StudentId" },
                keyValues: new object[] { new Guid("66666666-6666-6666-6666-666666666601"), new Guid("22222222-2222-2222-2222-000000000011") });

            migrationBuilder.DeleteData(
                table: "Progress",
                keyColumns: new[] { "ModuleItemId", "StudentId" },
                keyValues: new object[] { new Guid("66666666-6666-6666-6666-666666666601"), new Guid("22222222-2222-2222-2222-000000000012") });

            migrationBuilder.DeleteData(
                table: "Progress",
                keyColumns: new[] { "ModuleItemId", "StudentId" },
                keyValues: new object[] { new Guid("66666666-6666-6666-6666-666666666601"), new Guid("22222222-2222-2222-2222-000000000013") });

            migrationBuilder.DeleteData(
                table: "Progress",
                keyColumns: new[] { "ModuleItemId", "StudentId" },
                keyValues: new object[] { new Guid("66666666-6666-6666-6666-666666666601"), new Guid("22222222-2222-2222-2222-000000000014") });

            migrationBuilder.DeleteData(
                table: "Progress",
                keyColumns: new[] { "ModuleItemId", "StudentId" },
                keyValues: new object[] { new Guid("66666666-6666-6666-6666-666666666601"), new Guid("22222222-2222-2222-2222-000000000015") });

            migrationBuilder.DeleteData(
                table: "Progress",
                keyColumns: new[] { "ModuleItemId", "StudentId" },
                keyValues: new object[] { new Guid("66666666-6666-6666-6666-666666666601"), new Guid("22222222-2222-2222-2222-000000000016") });

            migrationBuilder.DeleteData(
                table: "Progress",
                keyColumns: new[] { "ModuleItemId", "StudentId" },
                keyValues: new object[] { new Guid("66666666-6666-6666-6666-666666666601"), new Guid("22222222-2222-2222-2222-000000000017") });

            migrationBuilder.DeleteData(
                table: "Progress",
                keyColumns: new[] { "ModuleItemId", "StudentId" },
                keyValues: new object[] { new Guid("66666666-6666-6666-6666-666666666601"), new Guid("22222222-2222-2222-2222-000000000018") });

            migrationBuilder.DeleteData(
                table: "Progress",
                keyColumns: new[] { "ModuleItemId", "StudentId" },
                keyValues: new object[] { new Guid("66666666-6666-6666-6666-666666666601"), new Guid("22222222-2222-2222-2222-000000000019") });

            migrationBuilder.DeleteData(
                table: "Progress",
                keyColumns: new[] { "ModuleItemId", "StudentId" },
                keyValues: new object[] { new Guid("66666666-6666-6666-6666-666666666601"), new Guid("22222222-2222-2222-2222-000000000020") });

            migrationBuilder.DeleteData(
                table: "Quiz",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666603"));

            migrationBuilder.DeleteData(
                table: "ModuleItem",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666601"));

            migrationBuilder.DeleteData(
                table: "ModuleItem",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666602"));

            migrationBuilder.DeleteData(
                table: "ModuleItem",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666603"));

            migrationBuilder.DeleteData(
                table: "ModuleItem",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666604"));

            migrationBuilder.DeleteData(
                table: "Module",
                keyColumn: "Id",
                keyValue: new Guid("77777777-7777-7777-7777-777777777777"));

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("88888888-8888-8888-8888-888888888888"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(7937));

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
