using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class FixPermissionKeys : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("UPDATE p_function SET permission_key = REPLACE(permission_key, '/Index', '') WHERE permission_key LIKE '%/Index';");

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("88888888-8888-8888-8888-888888888888"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(908));

            migrationBuilder.UpdateData(
                table: "Module",
                keyColumn: "Id",
                keyValue: new Guid("77777777-7777-7777-7777-777777777777"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(1483), new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(1485) });

            migrationBuilder.UpdateData(
                table: "ModuleItem",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666601"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(1658), new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(1659) });

            migrationBuilder.UpdateData(
                table: "ModuleItem",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666602"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(1671), new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(1672) });

            migrationBuilder.UpdateData(
                table: "ModuleItem",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666603"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(1677), new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(1703) });

            migrationBuilder.UpdateData(
                table: "ModuleItem",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666604"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(1735), new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(1736) });

            migrationBuilder.UpdateData(
                table: "ParentProfile",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 23, 15, 51, 465, DateTimeKind.Local).AddTicks(8826), new DateTime(2026, 7, 20, 23, 15, 51, 465, DateTimeKind.Local).AddTicks(8827) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000001"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(4850));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000002"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(5318));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000003"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(5831));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000004"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(6018));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000005"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(6552));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000006"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(6653));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000007"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(6698));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000008"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(6746));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000009"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(7002));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000010"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(7102));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000011"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(7215));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000012"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(7484));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000013"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(7528));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000014"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(7574));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000015"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(7815));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000016"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(7972));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000017"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(8061));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000018"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(8382));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000019"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(8434));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000020"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(8472));

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000001"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(4662), new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(4663) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000002"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(5297), new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(5298) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000003"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(5585), new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(5595) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000004"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(6005), new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(6006) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000005"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(6070), new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(6071) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000006"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(6633), new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(6634) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000007"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(6687), new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(6688) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000008"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(6735), new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(6736) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000009"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(6983), new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(6985) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000010"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(7053), new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(7054) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000011"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(7193), new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(7194) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000012"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(7464), new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(7465) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000013"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(7516), new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(7517) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000014"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(7562), new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(7564) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000015"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(7611), new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(7612) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000016"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(7957), new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(7958) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000017"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(8041), new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(8042) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000018"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(8364), new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(8365) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000019"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(8416), new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(8417) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000020"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(8462), new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(8463) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 23, 15, 51, 465, DateTimeKind.Local).AddTicks(8653), new DateTime(2026, 7, 20, 23, 15, 51, 465, DateTimeKind.Local).AddTicks(8657) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 23, 15, 51, 465, DateTimeKind.Local).AddTicks(7656), new DateTime(2026, 7, 20, 23, 15, 51, 465, DateTimeKind.Local).AddTicks(7745) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000001"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(4407), new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(4415) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000002"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(5005), new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(5006) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000003"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(5372), new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(5373) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000004"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(5950), new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(5951) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000005"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(6038), new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(6039) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000006"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(6599), new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(6600) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000007"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(6671), new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(6672) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000008"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(6716), new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(6717) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000009"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(6958), new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(6959) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000010"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(7033), new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(7033) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000011"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(7174), new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(7176) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000012"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(7442), new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(7442) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000013"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(7502), new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(7503) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000014"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(7543), new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(7544) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000015"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(7592), new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(7593) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000016"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(7940), new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(7941) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000017"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(8001), new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(8002) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000018"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(8339), new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(8341) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000019"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(8399), new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(8400) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000020"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(8448), new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(8449) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 23, 15, 51, 465, DateTimeKind.Local).AddTicks(7917), new DateTime(2026, 7, 20, 23, 15, 51, 465, DateTimeKind.Local).AddTicks(7918) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 23, 15, 51, 465, DateTimeKind.Local).AddTicks(8106), new DateTime(2026, 7, 20, 23, 15, 51, 465, DateTimeKind.Local).AddTicks(8108) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 23, 15, 51, 465, DateTimeKind.Local).AddTicks(8115), new DateTime(2026, 7, 20, 23, 15, 51, 465, DateTimeKind.Local).AddTicks(8116) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("55555555-5555-5555-5555-555555555555"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 23, 15, 51, 465, DateTimeKind.Local).AddTicks(8121), new DateTime(2026, 7, 20, 23, 15, 51, 465, DateTimeKind.Local).AddTicks(8121) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666666"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 23, 15, 51, 465, DateTimeKind.Local).AddTicks(8129), new DateTime(2026, 7, 20, 23, 15, 51, 465, DateTimeKind.Local).AddTicks(8130) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("UPDATE p_function SET permission_key = permission_key + '/Index' WHERE permission_key IN ('/Learning', '/MyProgress', '/StudentFamily', '/StudentProfile', '/SecurityManagement');");

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("88888888-8888-8888-8888-888888888888"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 20, 23, 0, 28, 894, DateTimeKind.Local).AddTicks(8348));

            migrationBuilder.UpdateData(
                table: "Module",
                keyColumn: "Id",
                keyValue: new Guid("77777777-7777-7777-7777-777777777777"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 23, 0, 28, 894, DateTimeKind.Local).AddTicks(8434), new DateTime(2026, 7, 20, 23, 0, 28, 894, DateTimeKind.Local).AddTicks(8435) });

            migrationBuilder.UpdateData(
                table: "ModuleItem",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666601"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 23, 0, 28, 894, DateTimeKind.Local).AddTicks(8506), new DateTime(2026, 7, 20, 23, 0, 28, 894, DateTimeKind.Local).AddTicks(8507) });

            migrationBuilder.UpdateData(
                table: "ModuleItem",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666602"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 23, 0, 28, 894, DateTimeKind.Local).AddTicks(8512), new DateTime(2026, 7, 20, 23, 0, 28, 894, DateTimeKind.Local).AddTicks(8512) });

            migrationBuilder.UpdateData(
                table: "ModuleItem",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666603"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 23, 0, 28, 894, DateTimeKind.Local).AddTicks(8515), new DateTime(2026, 7, 20, 23, 0, 28, 894, DateTimeKind.Local).AddTicks(8541) });

            migrationBuilder.UpdateData(
                table: "ModuleItem",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666604"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 23, 0, 28, 894, DateTimeKind.Local).AddTicks(8562), new DateTime(2026, 7, 20, 23, 0, 28, 894, DateTimeKind.Local).AddTicks(8562) });

            migrationBuilder.UpdateData(
                table: "ParentProfile",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 23, 0, 28, 894, DateTimeKind.Local).AddTicks(7797), new DateTime(2026, 7, 20, 23, 0, 28, 894, DateTimeKind.Local).AddTicks(7798) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000001"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 20, 23, 0, 28, 894, DateTimeKind.Local).AddTicks(9273));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000002"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 20, 23, 0, 28, 894, DateTimeKind.Local).AddTicks(9323));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000003"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 20, 23, 0, 28, 894, DateTimeKind.Local).AddTicks(9460));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000004"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 20, 23, 0, 28, 894, DateTimeKind.Local).AddTicks(9496));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000005"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 20, 23, 0, 28, 894, DateTimeKind.Local).AddTicks(9522));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000006"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 20, 23, 0, 28, 894, DateTimeKind.Local).AddTicks(9586));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000007"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 20, 23, 0, 28, 894, DateTimeKind.Local).AddTicks(9609));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000008"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 20, 23, 0, 28, 894, DateTimeKind.Local).AddTicks(9633));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000009"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 20, 23, 0, 28, 894, DateTimeKind.Local).AddTicks(9658));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000010"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 20, 23, 0, 28, 894, DateTimeKind.Local).AddTicks(9767));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000011"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 20, 23, 0, 28, 894, DateTimeKind.Local).AddTicks(9817));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000012"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 20, 23, 0, 28, 894, DateTimeKind.Local).AddTicks(9839));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000013"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 20, 23, 0, 28, 894, DateTimeKind.Local).AddTicks(9923));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000014"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 20, 23, 0, 28, 894, DateTimeKind.Local).AddTicks(9949));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000015"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 20, 23, 0, 28, 894, DateTimeKind.Local).AddTicks(9978));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000016"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 20, 23, 0, 28, 895, DateTimeKind.Local).AddTicks(54));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000017"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 20, 23, 0, 28, 895, DateTimeKind.Local).AddTicks(82));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000018"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 20, 23, 0, 28, 895, DateTimeKind.Local).AddTicks(107));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000019"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 20, 23, 0, 28, 895, DateTimeKind.Local).AddTicks(190));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000020"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 20, 23, 0, 28, 895, DateTimeKind.Local).AddTicks(228));

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000001"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 23, 0, 28, 894, DateTimeKind.Local).AddTicks(9227), new DateTime(2026, 7, 20, 23, 0, 28, 894, DateTimeKind.Local).AddTicks(9227) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000002"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 23, 0, 28, 894, DateTimeKind.Local).AddTicks(9317), new DateTime(2026, 7, 20, 23, 0, 28, 894, DateTimeKind.Local).AddTicks(9317) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000003"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 23, 0, 28, 894, DateTimeKind.Local).AddTicks(9454), new DateTime(2026, 7, 20, 23, 0, 28, 894, DateTimeKind.Local).AddTicks(9454) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000004"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 23, 0, 28, 894, DateTimeKind.Local).AddTicks(9489), new DateTime(2026, 7, 20, 23, 0, 28, 894, DateTimeKind.Local).AddTicks(9490) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000005"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 23, 0, 28, 894, DateTimeKind.Local).AddTicks(9515), new DateTime(2026, 7, 20, 23, 0, 28, 894, DateTimeKind.Local).AddTicks(9515) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000006"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 23, 0, 28, 894, DateTimeKind.Local).AddTicks(9580), new DateTime(2026, 7, 20, 23, 0, 28, 894, DateTimeKind.Local).AddTicks(9580) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000007"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 23, 0, 28, 894, DateTimeKind.Local).AddTicks(9603), new DateTime(2026, 7, 20, 23, 0, 28, 894, DateTimeKind.Local).AddTicks(9603) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000008"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 23, 0, 28, 894, DateTimeKind.Local).AddTicks(9625), new DateTime(2026, 7, 20, 23, 0, 28, 894, DateTimeKind.Local).AddTicks(9625) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000009"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 23, 0, 28, 894, DateTimeKind.Local).AddTicks(9651), new DateTime(2026, 7, 20, 23, 0, 28, 894, DateTimeKind.Local).AddTicks(9651) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000010"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 23, 0, 28, 894, DateTimeKind.Local).AddTicks(9761), new DateTime(2026, 7, 20, 23, 0, 28, 894, DateTimeKind.Local).AddTicks(9761) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000011"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 23, 0, 28, 894, DateTimeKind.Local).AddTicks(9812), new DateTime(2026, 7, 20, 23, 0, 28, 894, DateTimeKind.Local).AddTicks(9812) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000012"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 23, 0, 28, 894, DateTimeKind.Local).AddTicks(9833), new DateTime(2026, 7, 20, 23, 0, 28, 894, DateTimeKind.Local).AddTicks(9834) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000013"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 23, 0, 28, 894, DateTimeKind.Local).AddTicks(9917), new DateTime(2026, 7, 20, 23, 0, 28, 894, DateTimeKind.Local).AddTicks(9918) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000014"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 23, 0, 28, 894, DateTimeKind.Local).AddTicks(9943), new DateTime(2026, 7, 20, 23, 0, 28, 894, DateTimeKind.Local).AddTicks(9944) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000015"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 23, 0, 28, 894, DateTimeKind.Local).AddTicks(9965), new DateTime(2026, 7, 20, 23, 0, 28, 894, DateTimeKind.Local).AddTicks(9966) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000016"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 23, 0, 28, 895, DateTimeKind.Local).AddTicks(8), new DateTime(2026, 7, 20, 23, 0, 28, 895, DateTimeKind.Local).AddTicks(9) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000017"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 23, 0, 28, 895, DateTimeKind.Local).AddTicks(75), new DateTime(2026, 7, 20, 23, 0, 28, 895, DateTimeKind.Local).AddTicks(75) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000018"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 23, 0, 28, 895, DateTimeKind.Local).AddTicks(100), new DateTime(2026, 7, 20, 23, 0, 28, 895, DateTimeKind.Local).AddTicks(101) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000019"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 23, 0, 28, 895, DateTimeKind.Local).AddTicks(179), new DateTime(2026, 7, 20, 23, 0, 28, 895, DateTimeKind.Local).AddTicks(180) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000020"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 23, 0, 28, 895, DateTimeKind.Local).AddTicks(219), new DateTime(2026, 7, 20, 23, 0, 28, 895, DateTimeKind.Local).AddTicks(220) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 23, 0, 28, 894, DateTimeKind.Local).AddTicks(7719), new DateTime(2026, 7, 20, 23, 0, 28, 894, DateTimeKind.Local).AddTicks(7721) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 23, 0, 28, 894, DateTimeKind.Local).AddTicks(7135), new DateTime(2026, 7, 20, 23, 0, 28, 894, DateTimeKind.Local).AddTicks(7152) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000001"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 23, 0, 28, 894, DateTimeKind.Local).AddTicks(9199), new DateTime(2026, 7, 20, 23, 0, 28, 894, DateTimeKind.Local).AddTicks(9201) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000002"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 23, 0, 28, 894, DateTimeKind.Local).AddTicks(9308), new DateTime(2026, 7, 20, 23, 0, 28, 894, DateTimeKind.Local).AddTicks(9308) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000003"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 23, 0, 28, 894, DateTimeKind.Local).AddTicks(9335), new DateTime(2026, 7, 20, 23, 0, 28, 894, DateTimeKind.Local).AddTicks(9336) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000004"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 23, 0, 28, 894, DateTimeKind.Local).AddTicks(9481), new DateTime(2026, 7, 20, 23, 0, 28, 894, DateTimeKind.Local).AddTicks(9482) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000005"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 23, 0, 28, 894, DateTimeKind.Local).AddTicks(9505), new DateTime(2026, 7, 20, 23, 0, 28, 894, DateTimeKind.Local).AddTicks(9506) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000006"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 23, 0, 28, 894, DateTimeKind.Local).AddTicks(9542), new DateTime(2026, 7, 20, 23, 0, 28, 894, DateTimeKind.Local).AddTicks(9543) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000007"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 23, 0, 28, 894, DateTimeKind.Local).AddTicks(9595), new DateTime(2026, 7, 20, 23, 0, 28, 894, DateTimeKind.Local).AddTicks(9596) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000008"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 23, 0, 28, 894, DateTimeKind.Local).AddTicks(9617), new DateTime(2026, 7, 20, 23, 0, 28, 894, DateTimeKind.Local).AddTicks(9617) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000009"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 23, 0, 28, 894, DateTimeKind.Local).AddTicks(9641), new DateTime(2026, 7, 20, 23, 0, 28, 894, DateTimeKind.Local).AddTicks(9641) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000010"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 23, 0, 28, 894, DateTimeKind.Local).AddTicks(9752), new DateTime(2026, 7, 20, 23, 0, 28, 894, DateTimeKind.Local).AddTicks(9752) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000011"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 23, 0, 28, 894, DateTimeKind.Local).AddTicks(9802), new DateTime(2026, 7, 20, 23, 0, 28, 894, DateTimeKind.Local).AddTicks(9803) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000012"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 23, 0, 28, 894, DateTimeKind.Local).AddTicks(9825), new DateTime(2026, 7, 20, 23, 0, 28, 894, DateTimeKind.Local).AddTicks(9826) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000013"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 23, 0, 28, 894, DateTimeKind.Local).AddTicks(9909), new DateTime(2026, 7, 20, 23, 0, 28, 894, DateTimeKind.Local).AddTicks(9910) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000014"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 23, 0, 28, 894, DateTimeKind.Local).AddTicks(9935), new DateTime(2026, 7, 20, 23, 0, 28, 894, DateTimeKind.Local).AddTicks(9935) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000015"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 23, 0, 28, 894, DateTimeKind.Local).AddTicks(9957), new DateTime(2026, 7, 20, 23, 0, 28, 894, DateTimeKind.Local).AddTicks(9958) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000016"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 23, 0, 28, 895, DateTimeKind.Local), new DateTime(2026, 7, 20, 23, 0, 28, 895, DateTimeKind.Local).AddTicks(1) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000017"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 23, 0, 28, 895, DateTimeKind.Local).AddTicks(64), new DateTime(2026, 7, 20, 23, 0, 28, 895, DateTimeKind.Local).AddTicks(65) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000018"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 23, 0, 28, 895, DateTimeKind.Local).AddTicks(93), new DateTime(2026, 7, 20, 23, 0, 28, 895, DateTimeKind.Local).AddTicks(93) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000019"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 23, 0, 28, 895, DateTimeKind.Local).AddTicks(162), new DateTime(2026, 7, 20, 23, 0, 28, 895, DateTimeKind.Local).AddTicks(163) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000020"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 23, 0, 28, 895, DateTimeKind.Local).AddTicks(206), new DateTime(2026, 7, 20, 23, 0, 28, 895, DateTimeKind.Local).AddTicks(207) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 23, 0, 28, 894, DateTimeKind.Local).AddTicks(7211), new DateTime(2026, 7, 20, 23, 0, 28, 894, DateTimeKind.Local).AddTicks(7212) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 23, 0, 28, 894, DateTimeKind.Local).AddTicks(7218), new DateTime(2026, 7, 20, 23, 0, 28, 894, DateTimeKind.Local).AddTicks(7219) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 23, 0, 28, 894, DateTimeKind.Local).AddTicks(7224), new DateTime(2026, 7, 20, 23, 0, 28, 894, DateTimeKind.Local).AddTicks(7225) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("55555555-5555-5555-5555-555555555555"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 23, 0, 28, 894, DateTimeKind.Local).AddTicks(7230), new DateTime(2026, 7, 20, 23, 0, 28, 894, DateTimeKind.Local).AddTicks(7231) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666666"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 23, 0, 28, 894, DateTimeKind.Local).AddTicks(7236), new DateTime(2026, 7, 20, 23, 0, 28, 894, DateTimeKind.Local).AddTicks(7237) });
        }
    }
}
