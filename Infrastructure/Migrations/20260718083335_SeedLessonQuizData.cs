using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedLessonQuizData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("88888888-8888-8888-8888-888888888888"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 15, 33, 34, 686, DateTimeKind.Local).AddTicks(4113));

            migrationBuilder.InsertData(
                table: "LessonQuestion",
                columns: new[] { "Id", "Content", "Explanation", "LessonId" },
                values: new object[] { new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbb1"), "Thì hiện tại tiếp diễn dùng để diễn tả hành động nào?", "Chỉ hành động đang diễn ra tại thời điểm nói.", new Guid("66666666-6666-6666-6666-666666666601") });

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

            migrationBuilder.InsertData(
                table: "LessonOption",
                columns: new[] { "Id", "Content", "IsCorrect", "QuestionId" },
                values: new object[,]
                {
                    { new Guid("cccccccc-cccc-cccc-cccc-cccccccccc01"), "Hành động lặp đi lặp lại", false, new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbb1") },
                    { new Guid("cccccccc-cccc-cccc-cccc-cccccccccc02"), "Hành động đang xảy ra ngay lúc nói", true, new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbb1") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "LessonOption",
                keyColumn: "Id",
                keyValue: new Guid("cccccccc-cccc-cccc-cccc-cccccccccc01"));

            migrationBuilder.DeleteData(
                table: "LessonOption",
                keyColumn: "Id",
                keyValue: new Guid("cccccccc-cccc-cccc-cccc-cccccccccc02"));

            migrationBuilder.DeleteData(
                table: "LessonQuestion",
                keyColumn: "Id",
                keyValue: new Guid("bbbbbbbb-bbbb-bbbb-bbbb-bbbbbbbbbbb1"));

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("88888888-8888-8888-8888-888888888888"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 15, 22, 42, 777, DateTimeKind.Local).AddTicks(630));

            migrationBuilder.UpdateData(
                table: "Module",
                keyColumn: "Id",
                keyValue: new Guid("77777777-7777-7777-7777-777777777777"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 22, 42, 777, DateTimeKind.Local).AddTicks(717), new DateTime(2026, 7, 18, 15, 22, 42, 777, DateTimeKind.Local).AddTicks(718) });

            migrationBuilder.UpdateData(
                table: "ModuleItem",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666601"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 22, 42, 777, DateTimeKind.Local).AddTicks(815), new DateTime(2026, 7, 18, 15, 22, 42, 777, DateTimeKind.Local).AddTicks(816) });

            migrationBuilder.UpdateData(
                table: "ModuleItem",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666602"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 22, 42, 777, DateTimeKind.Local).AddTicks(830), new DateTime(2026, 7, 18, 15, 22, 42, 777, DateTimeKind.Local).AddTicks(830) });

            migrationBuilder.UpdateData(
                table: "ModuleItem",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666603"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 22, 42, 777, DateTimeKind.Local).AddTicks(834), new DateTime(2026, 7, 18, 15, 22, 42, 777, DateTimeKind.Local).AddTicks(855) });

            migrationBuilder.UpdateData(
                table: "ModuleItem",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666604"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 22, 42, 777, DateTimeKind.Local).AddTicks(882), new DateTime(2026, 7, 18, 15, 22, 42, 777, DateTimeKind.Local).AddTicks(883) });

            migrationBuilder.UpdateData(
                table: "ParentProfile",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 22, 42, 776, DateTimeKind.Local).AddTicks(9887), new DateTime(2026, 7, 18, 15, 22, 42, 776, DateTimeKind.Local).AddTicks(9888) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000001"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 15, 22, 42, 777, DateTimeKind.Local).AddTicks(1478));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000002"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 15, 22, 42, 777, DateTimeKind.Local).AddTicks(1600));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000003"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 15, 22, 42, 777, DateTimeKind.Local).AddTicks(1627));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000004"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 15, 22, 42, 777, DateTimeKind.Local).AddTicks(1663));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000005"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 15, 22, 42, 777, DateTimeKind.Local).AddTicks(1821));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000006"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 15, 22, 42, 777, DateTimeKind.Local).AddTicks(1852));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000007"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 15, 22, 42, 777, DateTimeKind.Local).AddTicks(1886));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000008"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 15, 22, 42, 777, DateTimeKind.Local).AddTicks(1909));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000009"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 15, 22, 42, 777, DateTimeKind.Local).AddTicks(2013));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000010"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 15, 22, 42, 777, DateTimeKind.Local).AddTicks(2043));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000011"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 15, 22, 42, 777, DateTimeKind.Local).AddTicks(2105));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000012"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 15, 22, 42, 777, DateTimeKind.Local).AddTicks(2186));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000013"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 15, 22, 42, 777, DateTimeKind.Local).AddTicks(2209));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000014"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 15, 22, 42, 777, DateTimeKind.Local).AddTicks(2233));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000015"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 15, 22, 42, 777, DateTimeKind.Local).AddTicks(2318));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000016"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 15, 22, 42, 777, DateTimeKind.Local).AddTicks(2358));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000017"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 15, 22, 42, 777, DateTimeKind.Local).AddTicks(2389));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000018"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 15, 22, 42, 777, DateTimeKind.Local).AddTicks(2471));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000019"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 15, 22, 42, 777, DateTimeKind.Local).AddTicks(2494));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000020"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 15, 22, 42, 777, DateTimeKind.Local).AddTicks(2518));

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000001"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 22, 42, 777, DateTimeKind.Local).AddTicks(1393), new DateTime(2026, 7, 18, 15, 22, 42, 777, DateTimeKind.Local).AddTicks(1393) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000002"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 22, 42, 777, DateTimeKind.Local).AddTicks(1592), new DateTime(2026, 7, 18, 15, 22, 42, 777, DateTimeKind.Local).AddTicks(1593) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000003"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 22, 42, 777, DateTimeKind.Local).AddTicks(1620), new DateTime(2026, 7, 18, 15, 22, 42, 777, DateTimeKind.Local).AddTicks(1621) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000004"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 22, 42, 777, DateTimeKind.Local).AddTicks(1657), new DateTime(2026, 7, 18, 15, 22, 42, 777, DateTimeKind.Local).AddTicks(1658) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000005"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 22, 42, 777, DateTimeKind.Local).AddTicks(1684), new DateTime(2026, 7, 18, 15, 22, 42, 777, DateTimeKind.Local).AddTicks(1685) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000006"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 22, 42, 777, DateTimeKind.Local).AddTicks(1843), new DateTime(2026, 7, 18, 15, 22, 42, 777, DateTimeKind.Local).AddTicks(1844) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000007"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 22, 42, 777, DateTimeKind.Local).AddTicks(1880), new DateTime(2026, 7, 18, 15, 22, 42, 777, DateTimeKind.Local).AddTicks(1880) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000008"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 22, 42, 777, DateTimeKind.Local).AddTicks(1904), new DateTime(2026, 7, 18, 15, 22, 42, 777, DateTimeKind.Local).AddTicks(1904) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000009"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 22, 42, 777, DateTimeKind.Local).AddTicks(2005), new DateTime(2026, 7, 18, 15, 22, 42, 777, DateTimeKind.Local).AddTicks(2006) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000010"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 22, 42, 777, DateTimeKind.Local).AddTicks(2037), new DateTime(2026, 7, 18, 15, 22, 42, 777, DateTimeKind.Local).AddTicks(2037) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000011"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 22, 42, 777, DateTimeKind.Local).AddTicks(2099), new DateTime(2026, 7, 18, 15, 22, 42, 777, DateTimeKind.Local).AddTicks(2099) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000012"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 22, 42, 777, DateTimeKind.Local).AddTicks(2180), new DateTime(2026, 7, 18, 15, 22, 42, 777, DateTimeKind.Local).AddTicks(2181) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000013"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 22, 42, 777, DateTimeKind.Local).AddTicks(2203), new DateTime(2026, 7, 18, 15, 22, 42, 777, DateTimeKind.Local).AddTicks(2204) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000014"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 22, 42, 777, DateTimeKind.Local).AddTicks(2225), new DateTime(2026, 7, 18, 15, 22, 42, 777, DateTimeKind.Local).AddTicks(2226) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000015"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 22, 42, 777, DateTimeKind.Local).AddTicks(2250), new DateTime(2026, 7, 18, 15, 22, 42, 777, DateTimeKind.Local).AddTicks(2251) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000016"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 22, 42, 777, DateTimeKind.Local).AddTicks(2352), new DateTime(2026, 7, 18, 15, 22, 42, 777, DateTimeKind.Local).AddTicks(2353) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000017"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 22, 42, 777, DateTimeKind.Local).AddTicks(2381), new DateTime(2026, 7, 18, 15, 22, 42, 777, DateTimeKind.Local).AddTicks(2382) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000018"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 22, 42, 777, DateTimeKind.Local).AddTicks(2464), new DateTime(2026, 7, 18, 15, 22, 42, 777, DateTimeKind.Local).AddTicks(2465) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000019"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 22, 42, 777, DateTimeKind.Local).AddTicks(2488), new DateTime(2026, 7, 18, 15, 22, 42, 777, DateTimeKind.Local).AddTicks(2489) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000020"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 22, 42, 777, DateTimeKind.Local).AddTicks(2513), new DateTime(2026, 7, 18, 15, 22, 42, 777, DateTimeKind.Local).AddTicks(2514) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 22, 42, 776, DateTimeKind.Local).AddTicks(9798), new DateTime(2026, 7, 18, 15, 22, 42, 776, DateTimeKind.Local).AddTicks(9799) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 22, 42, 776, DateTimeKind.Local).AddTicks(9355), new DateTime(2026, 7, 18, 15, 22, 42, 776, DateTimeKind.Local).AddTicks(9384) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000001"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 22, 42, 777, DateTimeKind.Local).AddTicks(1308), new DateTime(2026, 7, 18, 15, 22, 42, 777, DateTimeKind.Local).AddTicks(1309) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000002"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 22, 42, 777, DateTimeKind.Local).AddTicks(1538), new DateTime(2026, 7, 18, 15, 22, 42, 777, DateTimeKind.Local).AddTicks(1539) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000003"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 22, 42, 777, DateTimeKind.Local).AddTicks(1611), new DateTime(2026, 7, 18, 15, 22, 42, 777, DateTimeKind.Local).AddTicks(1612) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000004"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 22, 42, 777, DateTimeKind.Local).AddTicks(1648), new DateTime(2026, 7, 18, 15, 22, 42, 777, DateTimeKind.Local).AddTicks(1649) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000005"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 22, 42, 777, DateTimeKind.Local).AddTicks(1673), new DateTime(2026, 7, 18, 15, 22, 42, 777, DateTimeKind.Local).AddTicks(1674) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000006"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 22, 42, 777, DateTimeKind.Local).AddTicks(1833), new DateTime(2026, 7, 18, 15, 22, 42, 777, DateTimeKind.Local).AddTicks(1834) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000007"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 22, 42, 777, DateTimeKind.Local).AddTicks(1872), new DateTime(2026, 7, 18, 15, 22, 42, 777, DateTimeKind.Local).AddTicks(1872) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000008"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 22, 42, 777, DateTimeKind.Local).AddTicks(1895), new DateTime(2026, 7, 18, 15, 22, 42, 777, DateTimeKind.Local).AddTicks(1895) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000009"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 22, 42, 777, DateTimeKind.Local).AddTicks(1992), new DateTime(2026, 7, 18, 15, 22, 42, 777, DateTimeKind.Local).AddTicks(1993) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000010"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 22, 42, 777, DateTimeKind.Local).AddTicks(2027), new DateTime(2026, 7, 18, 15, 22, 42, 777, DateTimeKind.Local).AddTicks(2028) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000011"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 22, 42, 777, DateTimeKind.Local).AddTicks(2090), new DateTime(2026, 7, 18, 15, 22, 42, 777, DateTimeKind.Local).AddTicks(2090) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000012"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 22, 42, 777, DateTimeKind.Local).AddTicks(2170), new DateTime(2026, 7, 18, 15, 22, 42, 777, DateTimeKind.Local).AddTicks(2171) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000013"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 22, 42, 777, DateTimeKind.Local).AddTicks(2194), new DateTime(2026, 7, 18, 15, 22, 42, 777, DateTimeKind.Local).AddTicks(2195) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000014"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 22, 42, 777, DateTimeKind.Local).AddTicks(2217), new DateTime(2026, 7, 18, 15, 22, 42, 777, DateTimeKind.Local).AddTicks(2218) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000015"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 22, 42, 777, DateTimeKind.Local).AddTicks(2241), new DateTime(2026, 7, 18, 15, 22, 42, 777, DateTimeKind.Local).AddTicks(2242) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000016"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 22, 42, 777, DateTimeKind.Local).AddTicks(2343), new DateTime(2026, 7, 18, 15, 22, 42, 777, DateTimeKind.Local).AddTicks(2344) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000017"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 22, 42, 777, DateTimeKind.Local).AddTicks(2368), new DateTime(2026, 7, 18, 15, 22, 42, 777, DateTimeKind.Local).AddTicks(2368) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000018"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 22, 42, 777, DateTimeKind.Local).AddTicks(2456), new DateTime(2026, 7, 18, 15, 22, 42, 777, DateTimeKind.Local).AddTicks(2457) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000019"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 22, 42, 777, DateTimeKind.Local).AddTicks(2479), new DateTime(2026, 7, 18, 15, 22, 42, 777, DateTimeKind.Local).AddTicks(2480) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000020"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 22, 42, 777, DateTimeKind.Local).AddTicks(2505), new DateTime(2026, 7, 18, 15, 22, 42, 777, DateTimeKind.Local).AddTicks(2506) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 22, 42, 776, DateTimeKind.Local).AddTicks(9526), new DateTime(2026, 7, 18, 15, 22, 42, 776, DateTimeKind.Local).AddTicks(9527) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 22, 42, 776, DateTimeKind.Local).AddTicks(9533), new DateTime(2026, 7, 18, 15, 22, 42, 776, DateTimeKind.Local).AddTicks(9534) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 22, 42, 776, DateTimeKind.Local).AddTicks(9539), new DateTime(2026, 7, 18, 15, 22, 42, 776, DateTimeKind.Local).AddTicks(9539) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("55555555-5555-5555-5555-555555555555"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 22, 42, 776, DateTimeKind.Local).AddTicks(9543), new DateTime(2026, 7, 18, 15, 22, 42, 776, DateTimeKind.Local).AddTicks(9543) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666666"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 22, 42, 776, DateTimeKind.Local).AddTicks(9547), new DateTime(2026, 7, 18, 15, 22, 42, 776, DateTimeKind.Local).AddTicks(9548) });
        }
    }
}
