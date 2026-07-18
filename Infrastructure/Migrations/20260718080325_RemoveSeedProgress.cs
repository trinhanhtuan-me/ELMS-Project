using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class RemoveSeedProgress : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("88888888-8888-8888-8888-888888888888"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 15, 3, 24, 338, DateTimeKind.Local).AddTicks(1975));

            migrationBuilder.UpdateData(
                table: "Module",
                keyColumn: "Id",
                keyValue: new Guid("77777777-7777-7777-7777-777777777777"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 3, 24, 338, DateTimeKind.Local).AddTicks(2063), new DateTime(2026, 7, 18, 15, 3, 24, 338, DateTimeKind.Local).AddTicks(2065) });

            migrationBuilder.UpdateData(
                table: "ModuleItem",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666601"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 3, 24, 338, DateTimeKind.Local).AddTicks(2164), new DateTime(2026, 7, 18, 15, 3, 24, 338, DateTimeKind.Local).AddTicks(2164) });

            migrationBuilder.UpdateData(
                table: "ModuleItem",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666602"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 3, 24, 338, DateTimeKind.Local).AddTicks(2173), new DateTime(2026, 7, 18, 15, 3, 24, 338, DateTimeKind.Local).AddTicks(2173) });

            migrationBuilder.UpdateData(
                table: "ModuleItem",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666603"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 3, 24, 338, DateTimeKind.Local).AddTicks(2180), new DateTime(2026, 7, 18, 15, 3, 24, 338, DateTimeKind.Local).AddTicks(2214) });

            migrationBuilder.UpdateData(
                table: "ModuleItem",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666604"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 3, 24, 338, DateTimeKind.Local).AddTicks(2243), new DateTime(2026, 7, 18, 15, 3, 24, 338, DateTimeKind.Local).AddTicks(2244) });

            migrationBuilder.UpdateData(
                table: "ParentProfile",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 3, 24, 338, DateTimeKind.Local).AddTicks(1200), new DateTime(2026, 7, 18, 15, 3, 24, 338, DateTimeKind.Local).AddTicks(1202) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000001"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 15, 3, 24, 338, DateTimeKind.Local).AddTicks(2920));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000002"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 15, 3, 24, 338, DateTimeKind.Local).AddTicks(2971));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000003"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 15, 3, 24, 338, DateTimeKind.Local).AddTicks(3075));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000004"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 15, 3, 24, 338, DateTimeKind.Local).AddTicks(3109));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000005"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 15, 3, 24, 338, DateTimeKind.Local).AddTicks(3167));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000006"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 15, 3, 24, 338, DateTimeKind.Local).AddTicks(3233));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000007"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 15, 3, 24, 338, DateTimeKind.Local).AddTicks(3508));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000008"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 15, 3, 24, 338, DateTimeKind.Local).AddTicks(3543));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000009"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 15, 3, 24, 338, DateTimeKind.Local).AddTicks(3587));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000010"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 15, 3, 24, 338, DateTimeKind.Local).AddTicks(3649));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000011"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 15, 3, 24, 338, DateTimeKind.Local).AddTicks(3713));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000012"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 15, 3, 24, 338, DateTimeKind.Local).AddTicks(3832));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000013"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 15, 3, 24, 338, DateTimeKind.Local).AddTicks(3864));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000014"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 15, 3, 24, 338, DateTimeKind.Local).AddTicks(3900));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000015"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 15, 3, 24, 338, DateTimeKind.Local).AddTicks(3937));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000016"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 15, 3, 24, 338, DateTimeKind.Local).AddTicks(3979));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000017"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 15, 3, 24, 338, DateTimeKind.Local).AddTicks(4079));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000018"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 15, 3, 24, 338, DateTimeKind.Local).AddTicks(4113));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000019"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 15, 3, 24, 338, DateTimeKind.Local).AddTicks(4149));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000020"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 15, 3, 24, 338, DateTimeKind.Local).AddTicks(4179));

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000001"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 3, 24, 338, DateTimeKind.Local).AddTicks(2869), new DateTime(2026, 7, 18, 15, 3, 24, 338, DateTimeKind.Local).AddTicks(2870) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000002"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 3, 24, 338, DateTimeKind.Local).AddTicks(2960), new DateTime(2026, 7, 18, 15, 3, 24, 338, DateTimeKind.Local).AddTicks(2961) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000003"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 3, 24, 338, DateTimeKind.Local).AddTicks(3058), new DateTime(2026, 7, 18, 15, 3, 24, 338, DateTimeKind.Local).AddTicks(3059) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000004"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 3, 24, 338, DateTimeKind.Local).AddTicks(3099), new DateTime(2026, 7, 18, 15, 3, 24, 338, DateTimeKind.Local).AddTicks(3100) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000005"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 3, 24, 338, DateTimeKind.Local).AddTicks(3145), new DateTime(2026, 7, 18, 15, 3, 24, 338, DateTimeKind.Local).AddTicks(3146) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000006"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 3, 24, 338, DateTimeKind.Local).AddTicks(3223), new DateTime(2026, 7, 18, 15, 3, 24, 338, DateTimeKind.Local).AddTicks(3224) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000007"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 3, 24, 338, DateTimeKind.Local).AddTicks(3306), new DateTime(2026, 7, 18, 15, 3, 24, 338, DateTimeKind.Local).AddTicks(3307) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000008"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 3, 24, 338, DateTimeKind.Local).AddTicks(3533), new DateTime(2026, 7, 18, 15, 3, 24, 338, DateTimeKind.Local).AddTicks(3534) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000009"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 3, 24, 338, DateTimeKind.Local).AddTicks(3574), new DateTime(2026, 7, 18, 15, 3, 24, 338, DateTimeKind.Local).AddTicks(3575) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000010"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 3, 24, 338, DateTimeKind.Local).AddTicks(3637), new DateTime(2026, 7, 18, 15, 3, 24, 338, DateTimeKind.Local).AddTicks(3637) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000011"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 3, 24, 338, DateTimeKind.Local).AddTicks(3700), new DateTime(2026, 7, 18, 15, 3, 24, 338, DateTimeKind.Local).AddTicks(3701) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000012"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 3, 24, 338, DateTimeKind.Local).AddTicks(3822), new DateTime(2026, 7, 18, 15, 3, 24, 338, DateTimeKind.Local).AddTicks(3823) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000013"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 3, 24, 338, DateTimeKind.Local).AddTicks(3855), new DateTime(2026, 7, 18, 15, 3, 24, 338, DateTimeKind.Local).AddTicks(3856) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000014"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 3, 24, 338, DateTimeKind.Local).AddTicks(3890), new DateTime(2026, 7, 18, 15, 3, 24, 338, DateTimeKind.Local).AddTicks(3891) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000015"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 3, 24, 338, DateTimeKind.Local).AddTicks(3922), new DateTime(2026, 7, 18, 15, 3, 24, 338, DateTimeKind.Local).AddTicks(3923) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000016"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 3, 24, 338, DateTimeKind.Local).AddTicks(3970), new DateTime(2026, 7, 18, 15, 3, 24, 338, DateTimeKind.Local).AddTicks(3971) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000017"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 3, 24, 338, DateTimeKind.Local).AddTicks(4065), new DateTime(2026, 7, 18, 15, 3, 24, 338, DateTimeKind.Local).AddTicks(4066) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000018"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 3, 24, 338, DateTimeKind.Local).AddTicks(4104), new DateTime(2026, 7, 18, 15, 3, 24, 338, DateTimeKind.Local).AddTicks(4104) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000019"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 3, 24, 338, DateTimeKind.Local).AddTicks(4137), new DateTime(2026, 7, 18, 15, 3, 24, 338, DateTimeKind.Local).AddTicks(4138) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000020"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 3, 24, 338, DateTimeKind.Local).AddTicks(4170), new DateTime(2026, 7, 18, 15, 3, 24, 338, DateTimeKind.Local).AddTicks(4171) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 3, 24, 338, DateTimeKind.Local).AddTicks(1102), new DateTime(2026, 7, 18, 15, 3, 24, 338, DateTimeKind.Local).AddTicks(1103) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 3, 24, 338, DateTimeKind.Local).AddTicks(624), new DateTime(2026, 7, 18, 15, 3, 24, 338, DateTimeKind.Local).AddTicks(646) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000001"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 3, 24, 338, DateTimeKind.Local).AddTicks(2827), new DateTime(2026, 7, 18, 15, 3, 24, 338, DateTimeKind.Local).AddTicks(2828) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000002"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 3, 24, 338, DateTimeKind.Local).AddTicks(2948), new DateTime(2026, 7, 18, 15, 3, 24, 338, DateTimeKind.Local).AddTicks(2949) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000003"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 3, 24, 338, DateTimeKind.Local).AddTicks(2982), new DateTime(2026, 7, 18, 15, 3, 24, 338, DateTimeKind.Local).AddTicks(2982) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000004"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 3, 24, 338, DateTimeKind.Local).AddTicks(3087), new DateTime(2026, 7, 18, 15, 3, 24, 338, DateTimeKind.Local).AddTicks(3088) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000005"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 3, 24, 338, DateTimeKind.Local).AddTicks(3119), new DateTime(2026, 7, 18, 15, 3, 24, 338, DateTimeKind.Local).AddTicks(3119) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000006"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 3, 24, 338, DateTimeKind.Local).AddTicks(3206), new DateTime(2026, 7, 18, 15, 3, 24, 338, DateTimeKind.Local).AddTicks(3207) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000007"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 3, 24, 338, DateTimeKind.Local).AddTicks(3295), new DateTime(2026, 7, 18, 15, 3, 24, 338, DateTimeKind.Local).AddTicks(3296) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000008"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 3, 24, 338, DateTimeKind.Local).AddTicks(3521), new DateTime(2026, 7, 18, 15, 3, 24, 338, DateTimeKind.Local).AddTicks(3522) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000009"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 3, 24, 338, DateTimeKind.Local).AddTicks(3558), new DateTime(2026, 7, 18, 15, 3, 24, 338, DateTimeKind.Local).AddTicks(3559) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000010"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 3, 24, 338, DateTimeKind.Local).AddTicks(3605), new DateTime(2026, 7, 18, 15, 3, 24, 338, DateTimeKind.Local).AddTicks(3606) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000011"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 3, 24, 338, DateTimeKind.Local).AddTicks(3687), new DateTime(2026, 7, 18, 15, 3, 24, 338, DateTimeKind.Local).AddTicks(3687) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000012"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 3, 24, 338, DateTimeKind.Local).AddTicks(3808), new DateTime(2026, 7, 18, 15, 3, 24, 338, DateTimeKind.Local).AddTicks(3809) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000013"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 3, 24, 338, DateTimeKind.Local).AddTicks(3843), new DateTime(2026, 7, 18, 15, 3, 24, 338, DateTimeKind.Local).AddTicks(3844) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000014"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 3, 24, 338, DateTimeKind.Local).AddTicks(3875), new DateTime(2026, 7, 18, 15, 3, 24, 338, DateTimeKind.Local).AddTicks(3876) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000015"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 3, 24, 338, DateTimeKind.Local).AddTicks(3910), new DateTime(2026, 7, 18, 15, 3, 24, 338, DateTimeKind.Local).AddTicks(3911) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000016"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 3, 24, 338, DateTimeKind.Local).AddTicks(3958), new DateTime(2026, 7, 18, 15, 3, 24, 338, DateTimeKind.Local).AddTicks(3959) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000017"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 3, 24, 338, DateTimeKind.Local).AddTicks(4046), new DateTime(2026, 7, 18, 15, 3, 24, 338, DateTimeKind.Local).AddTicks(4048) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000018"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 3, 24, 338, DateTimeKind.Local).AddTicks(4092), new DateTime(2026, 7, 18, 15, 3, 24, 338, DateTimeKind.Local).AddTicks(4092) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000019"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 3, 24, 338, DateTimeKind.Local).AddTicks(4125), new DateTime(2026, 7, 18, 15, 3, 24, 338, DateTimeKind.Local).AddTicks(4126) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000020"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 3, 24, 338, DateTimeKind.Local).AddTicks(4160), new DateTime(2026, 7, 18, 15, 3, 24, 338, DateTimeKind.Local).AddTicks(4160) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 3, 24, 338, DateTimeKind.Local).AddTicks(821), new DateTime(2026, 7, 18, 15, 3, 24, 338, DateTimeKind.Local).AddTicks(822) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 3, 24, 338, DateTimeKind.Local).AddTicks(830), new DateTime(2026, 7, 18, 15, 3, 24, 338, DateTimeKind.Local).AddTicks(831) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 3, 24, 338, DateTimeKind.Local).AddTicks(837), new DateTime(2026, 7, 18, 15, 3, 24, 338, DateTimeKind.Local).AddTicks(837) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("55555555-5555-5555-5555-555555555555"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 3, 24, 338, DateTimeKind.Local).AddTicks(842), new DateTime(2026, 7, 18, 15, 3, 24, 338, DateTimeKind.Local).AddTicks(843) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666666"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 15, 3, 24, 338, DateTimeKind.Local).AddTicks(849), new DateTime(2026, 7, 18, 15, 3, 24, 338, DateTimeKind.Local).AddTicks(850) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("88888888-8888-8888-8888-888888888888"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 14, 48, 2, 427, DateTimeKind.Local).AddTicks(7350));

            migrationBuilder.UpdateData(
                table: "Module",
                keyColumn: "Id",
                keyValue: new Guid("77777777-7777-7777-7777-777777777777"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 14, 48, 2, 427, DateTimeKind.Local).AddTicks(7437), new DateTime(2026, 7, 18, 14, 48, 2, 427, DateTimeKind.Local).AddTicks(7437) });

            migrationBuilder.UpdateData(
                table: "ModuleItem",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666601"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 14, 48, 2, 427, DateTimeKind.Local).AddTicks(7528), new DateTime(2026, 7, 18, 14, 48, 2, 427, DateTimeKind.Local).AddTicks(7528) });

            migrationBuilder.UpdateData(
                table: "ModuleItem",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666602"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 14, 48, 2, 427, DateTimeKind.Local).AddTicks(7536), new DateTime(2026, 7, 18, 14, 48, 2, 427, DateTimeKind.Local).AddTicks(7537) });

            migrationBuilder.UpdateData(
                table: "ModuleItem",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666603"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 14, 48, 2, 427, DateTimeKind.Local).AddTicks(7541), new DateTime(2026, 7, 18, 14, 48, 2, 427, DateTimeKind.Local).AddTicks(7558) });

            migrationBuilder.UpdateData(
                table: "ModuleItem",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666604"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 14, 48, 2, 427, DateTimeKind.Local).AddTicks(7589), new DateTime(2026, 7, 18, 14, 48, 2, 427, DateTimeKind.Local).AddTicks(7589) });

            migrationBuilder.UpdateData(
                table: "ParentProfile",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 14, 48, 2, 427, DateTimeKind.Local).AddTicks(6578), new DateTime(2026, 7, 18, 14, 48, 2, 427, DateTimeKind.Local).AddTicks(6579) });

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
        }
    }
}
