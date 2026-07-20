using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UpdateLessonVideoUrl : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("88888888-8888-8888-8888-888888888888"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 15, 22, 42, 777, DateTimeKind.Local).AddTicks(630));

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666601"),
                column: "VideoUrl",
                value: "https://res.cloudinary.com/pewx8g7u/video/upload/v1784285507/lessons/video/TIẾNG_ANH_GIAO_TIẾP_3_PHÚT_MỖI_NGÀY_-_Bài_80__TO_BE_OUT_OF_SORTS_x98vvq.mp4");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("88888888-8888-8888-8888-888888888888"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 15, 9, 49, 984, DateTimeKind.Local).AddTicks(9745));

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666601"),
                column: "VideoUrl",
                value: "https://www.youtube.com/embed/YOUR_VIDEO_ID");

            migrationBuilder.UpdateData(
                table: "Module",
                keyColumn: "Id",
                keyValue: new Guid("77777777-7777-7777-7777-777777777777"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 9, 49, 984, DateTimeKind.Local).AddTicks(9801), new DateTime(2026, 7, 18, 15, 9, 49, 984, DateTimeKind.Local).AddTicks(9802) });

            migrationBuilder.UpdateData(
                table: "ModuleItem",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666601"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 9, 49, 984, DateTimeKind.Local).AddTicks(9860), new DateTime(2026, 7, 18, 15, 9, 49, 984, DateTimeKind.Local).AddTicks(9861) });

            migrationBuilder.UpdateData(
                table: "ModuleItem",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666602"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 9, 49, 984, DateTimeKind.Local).AddTicks(9866), new DateTime(2026, 7, 18, 15, 9, 49, 984, DateTimeKind.Local).AddTicks(9867) });

            migrationBuilder.UpdateData(
                table: "ModuleItem",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666603"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 9, 49, 984, DateTimeKind.Local).AddTicks(9870), new DateTime(2026, 7, 18, 15, 9, 49, 984, DateTimeKind.Local).AddTicks(9880) });

            migrationBuilder.UpdateData(
                table: "ModuleItem",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666604"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 9, 49, 984, DateTimeKind.Local).AddTicks(9898), new DateTime(2026, 7, 18, 15, 9, 49, 984, DateTimeKind.Local).AddTicks(9899) });

            migrationBuilder.UpdateData(
                table: "ParentProfile",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 9, 49, 984, DateTimeKind.Local).AddTicks(9253), new DateTime(2026, 7, 18, 15, 9, 49, 984, DateTimeKind.Local).AddTicks(9253) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000001"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 15, 9, 49, 985, DateTimeKind.Local).AddTicks(325));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000002"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 15, 9, 49, 985, DateTimeKind.Local).AddTicks(370));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000003"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 15, 9, 49, 985, DateTimeKind.Local).AddTicks(389));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000004"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 15, 9, 49, 985, DateTimeKind.Local).AddTicks(487));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000005"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 15, 9, 49, 985, DateTimeKind.Local).AddTicks(524));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000006"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 15, 9, 49, 985, DateTimeKind.Local).AddTicks(568));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000007"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 15, 9, 49, 985, DateTimeKind.Local).AddTicks(600));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000008"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 15, 9, 49, 985, DateTimeKind.Local).AddTicks(683));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000009"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 15, 9, 49, 985, DateTimeKind.Local).AddTicks(702));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000010"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 15, 9, 49, 985, DateTimeKind.Local).AddTicks(738));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000011"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 15, 9, 49, 985, DateTimeKind.Local).AddTicks(820));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000012"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 15, 9, 49, 985, DateTimeKind.Local).AddTicks(836));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000013"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 15, 9, 49, 985, DateTimeKind.Local).AddTicks(853));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000014"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 15, 9, 49, 985, DateTimeKind.Local).AddTicks(904));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000015"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 15, 9, 49, 985, DateTimeKind.Local).AddTicks(926));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000016"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 15, 9, 49, 985, DateTimeKind.Local).AddTicks(955));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000017"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 15, 9, 49, 985, DateTimeKind.Local).AddTicks(1006));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000018"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 15, 9, 49, 985, DateTimeKind.Local).AddTicks(1026));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000019"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 15, 9, 49, 985, DateTimeKind.Local).AddTicks(1043));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000020"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 15, 9, 49, 985, DateTimeKind.Local).AddTicks(1095));

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000001"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 9, 49, 985, DateTimeKind.Local).AddTicks(293), new DateTime(2026, 7, 18, 15, 9, 49, 985, DateTimeKind.Local).AddTicks(294) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000002"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 9, 49, 985, DateTimeKind.Local).AddTicks(365), new DateTime(2026, 7, 18, 15, 9, 49, 985, DateTimeKind.Local).AddTicks(365) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000003"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 9, 49, 985, DateTimeKind.Local).AddTicks(385), new DateTime(2026, 7, 18, 15, 9, 49, 985, DateTimeKind.Local).AddTicks(385) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000004"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 9, 49, 985, DateTimeKind.Local).AddTicks(481), new DateTime(2026, 7, 18, 15, 9, 49, 985, DateTimeKind.Local).AddTicks(482) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000005"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 9, 49, 985, DateTimeKind.Local).AddTicks(510), new DateTime(2026, 7, 18, 15, 9, 49, 985, DateTimeKind.Local).AddTicks(510) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000006"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 9, 49, 985, DateTimeKind.Local).AddTicks(564), new DateTime(2026, 7, 18, 15, 9, 49, 985, DateTimeKind.Local).AddTicks(564) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000007"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 9, 49, 985, DateTimeKind.Local).AddTicks(594), new DateTime(2026, 7, 18, 15, 9, 49, 985, DateTimeKind.Local).AddTicks(595) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000008"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 9, 49, 985, DateTimeKind.Local).AddTicks(678), new DateTime(2026, 7, 18, 15, 9, 49, 985, DateTimeKind.Local).AddTicks(679) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000009"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 9, 49, 985, DateTimeKind.Local).AddTicks(697), new DateTime(2026, 7, 18, 15, 9, 49, 985, DateTimeKind.Local).AddTicks(697) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000010"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 9, 49, 985, DateTimeKind.Local).AddTicks(733), new DateTime(2026, 7, 18, 15, 9, 49, 985, DateTimeKind.Local).AddTicks(734) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000011"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 9, 49, 985, DateTimeKind.Local).AddTicks(816), new DateTime(2026, 7, 18, 15, 9, 49, 985, DateTimeKind.Local).AddTicks(816) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000012"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 9, 49, 985, DateTimeKind.Local).AddTicks(832), new DateTime(2026, 7, 18, 15, 9, 49, 985, DateTimeKind.Local).AddTicks(832) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000013"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 9, 49, 985, DateTimeKind.Local).AddTicks(849), new DateTime(2026, 7, 18, 15, 9, 49, 985, DateTimeKind.Local).AddTicks(849) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000014"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 9, 49, 985, DateTimeKind.Local).AddTicks(900), new DateTime(2026, 7, 18, 15, 9, 49, 985, DateTimeKind.Local).AddTicks(900) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000015"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 9, 49, 985, DateTimeKind.Local).AddTicks(916), new DateTime(2026, 7, 18, 15, 9, 49, 985, DateTimeKind.Local).AddTicks(916) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000016"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 9, 49, 985, DateTimeKind.Local).AddTicks(950), new DateTime(2026, 7, 18, 15, 9, 49, 985, DateTimeKind.Local).AddTicks(951) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000017"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 9, 49, 985, DateTimeKind.Local).AddTicks(969), new DateTime(2026, 7, 18, 15, 9, 49, 985, DateTimeKind.Local).AddTicks(969) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000018"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 9, 49, 985, DateTimeKind.Local).AddTicks(1022), new DateTime(2026, 7, 18, 15, 9, 49, 985, DateTimeKind.Local).AddTicks(1022) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000019"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 9, 49, 985, DateTimeKind.Local).AddTicks(1039), new DateTime(2026, 7, 18, 15, 9, 49, 985, DateTimeKind.Local).AddTicks(1039) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000020"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 9, 49, 985, DateTimeKind.Local).AddTicks(1090), new DateTime(2026, 7, 18, 15, 9, 49, 985, DateTimeKind.Local).AddTicks(1090) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 9, 49, 984, DateTimeKind.Local).AddTicks(9185), new DateTime(2026, 7, 18, 15, 9, 49, 984, DateTimeKind.Local).AddTicks(9186) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 9, 49, 984, DateTimeKind.Local).AddTicks(8947), new DateTime(2026, 7, 18, 15, 9, 49, 984, DateTimeKind.Local).AddTicks(8966) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000001"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 9, 49, 985, DateTimeKind.Local).AddTicks(273), new DateTime(2026, 7, 18, 15, 9, 49, 985, DateTimeKind.Local).AddTicks(274) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000002"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 9, 49, 985, DateTimeKind.Local).AddTicks(356), new DateTime(2026, 7, 18, 15, 9, 49, 985, DateTimeKind.Local).AddTicks(356) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000003"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 9, 49, 985, DateTimeKind.Local).AddTicks(378), new DateTime(2026, 7, 18, 15, 9, 49, 985, DateTimeKind.Local).AddTicks(379) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000004"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 9, 49, 985, DateTimeKind.Local).AddTicks(402), new DateTime(2026, 7, 18, 15, 9, 49, 985, DateTimeKind.Local).AddTicks(402) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000005"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 9, 49, 985, DateTimeKind.Local).AddTicks(496), new DateTime(2026, 7, 18, 15, 9, 49, 985, DateTimeKind.Local).AddTicks(496) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000006"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 9, 49, 985, DateTimeKind.Local).AddTicks(557), new DateTime(2026, 7, 18, 15, 9, 49, 985, DateTimeKind.Local).AddTicks(557) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000007"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 9, 49, 985, DateTimeKind.Local).AddTicks(589), new DateTime(2026, 7, 18, 15, 9, 49, 985, DateTimeKind.Local).AddTicks(589) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000008"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 9, 49, 985, DateTimeKind.Local).AddTicks(672), new DateTime(2026, 7, 18, 15, 9, 49, 985, DateTimeKind.Local).AddTicks(672) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000009"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 9, 49, 985, DateTimeKind.Local).AddTicks(690), new DateTime(2026, 7, 18, 15, 9, 49, 985, DateTimeKind.Local).AddTicks(690) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000010"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 9, 49, 985, DateTimeKind.Local).AddTicks(714), new DateTime(2026, 7, 18, 15, 9, 49, 985, DateTimeKind.Local).AddTicks(714) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000011"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 9, 49, 985, DateTimeKind.Local).AddTicks(809), new DateTime(2026, 7, 18, 15, 9, 49, 985, DateTimeKind.Local).AddTicks(809) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000012"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 9, 49, 985, DateTimeKind.Local).AddTicks(826), new DateTime(2026, 7, 18, 15, 9, 49, 985, DateTimeKind.Local).AddTicks(826) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000013"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 9, 49, 985, DateTimeKind.Local).AddTicks(843), new DateTime(2026, 7, 18, 15, 9, 49, 985, DateTimeKind.Local).AddTicks(844) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000014"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 9, 49, 985, DateTimeKind.Local).AddTicks(859), new DateTime(2026, 7, 18, 15, 9, 49, 985, DateTimeKind.Local).AddTicks(860) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000015"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 9, 49, 985, DateTimeKind.Local).AddTicks(910), new DateTime(2026, 7, 18, 15, 9, 49, 985, DateTimeKind.Local).AddTicks(911) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000016"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 9, 49, 985, DateTimeKind.Local).AddTicks(945), new DateTime(2026, 7, 18, 15, 9, 49, 985, DateTimeKind.Local).AddTicks(945) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000017"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 9, 49, 985, DateTimeKind.Local).AddTicks(961), new DateTime(2026, 7, 18, 15, 9, 49, 985, DateTimeKind.Local).AddTicks(962) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000018"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 9, 49, 985, DateTimeKind.Local).AddTicks(1014), new DateTime(2026, 7, 18, 15, 9, 49, 985, DateTimeKind.Local).AddTicks(1014) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000019"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 9, 49, 985, DateTimeKind.Local).AddTicks(1032), new DateTime(2026, 7, 18, 15, 9, 49, 985, DateTimeKind.Local).AddTicks(1033) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000020"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 9, 49, 985, DateTimeKind.Local).AddTicks(1049), new DateTime(2026, 7, 18, 15, 9, 49, 985, DateTimeKind.Local).AddTicks(1050) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 9, 49, 984, DateTimeKind.Local).AddTicks(9027), new DateTime(2026, 7, 18, 15, 9, 49, 984, DateTimeKind.Local).AddTicks(9027) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 9, 49, 984, DateTimeKind.Local).AddTicks(9032), new DateTime(2026, 7, 18, 15, 9, 49, 984, DateTimeKind.Local).AddTicks(9033) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 9, 49, 984, DateTimeKind.Local).AddTicks(9037), new DateTime(2026, 7, 18, 15, 9, 49, 984, DateTimeKind.Local).AddTicks(9037) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("55555555-5555-5555-5555-555555555555"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 9, 49, 984, DateTimeKind.Local).AddTicks(9052), new DateTime(2026, 7, 18, 15, 9, 49, 984, DateTimeKind.Local).AddTicks(9052) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666666"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 9, 49, 984, DateTimeKind.Local).AddTicks(9056), new DateTime(2026, 7, 18, 15, 9, 49, 984, DateTimeKind.Local).AddTicks(9056) });
        }
    }
}
