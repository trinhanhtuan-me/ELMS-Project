using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedRoleFunctionMapping : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // INSERT SEED DATA FOR ROLE-FUNCTION MAPPING USING RAW SQL
            for (int i = 1; i <= 20; i++)
            {
                migrationBuilder.Sql($"INSERT INTO p_role_function (role_id, function_id) VALUES (2, {i});");
            }
            migrationBuilder.Sql("INSERT INTO p_role_function (role_id, function_id) VALUES (1, 21);");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // REMOVE SEED DATA USING RAW SQL
            migrationBuilder.Sql("DELETE FROM p_role_function WHERE role_id = 2 AND function_id BETWEEN 1 AND 20;");
            migrationBuilder.Sql("DELETE FROM p_role_function WHERE role_id = 1 AND function_id = 21;");

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("88888888-8888-8888-8888-888888888888"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 20, 22, 48, 43, 760, DateTimeKind.Local).AddTicks(6989));

            migrationBuilder.UpdateData(
                table: "Module",
                keyColumn: "Id",
                keyValue: new Guid("77777777-7777-7777-7777-777777777777"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 22, 48, 43, 760, DateTimeKind.Local).AddTicks(7068), new DateTime(2026, 7, 20, 22, 48, 43, 760, DateTimeKind.Local).AddTicks(7069) });

            migrationBuilder.UpdateData(
                table: "ModuleItem",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666601"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 22, 48, 43, 760, DateTimeKind.Local).AddTicks(7165), new DateTime(2026, 7, 20, 22, 48, 43, 760, DateTimeKind.Local).AddTicks(7165) });

            migrationBuilder.UpdateData(
                table: "ModuleItem",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666602"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 22, 48, 43, 760, DateTimeKind.Local).AddTicks(7171), new DateTime(2026, 7, 20, 22, 48, 43, 760, DateTimeKind.Local).AddTicks(7171) });

            migrationBuilder.UpdateData(
                table: "ModuleItem",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666603"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 22, 48, 43, 760, DateTimeKind.Local).AddTicks(7175), new DateTime(2026, 7, 20, 22, 48, 43, 760, DateTimeKind.Local).AddTicks(7200) });

            migrationBuilder.UpdateData(
                table: "ModuleItem",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666604"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 22, 48, 43, 760, DateTimeKind.Local).AddTicks(7237), new DateTime(2026, 7, 20, 22, 48, 43, 760, DateTimeKind.Local).AddTicks(7238) });

            migrationBuilder.UpdateData(
                table: "ParentProfile",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 22, 48, 43, 760, DateTimeKind.Local).AddTicks(6278), new DateTime(2026, 7, 20, 22, 48, 43, 760, DateTimeKind.Local).AddTicks(6278) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000001"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 20, 22, 48, 43, 760, DateTimeKind.Local).AddTicks(7990));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000002"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 20, 22, 48, 43, 760, DateTimeKind.Local).AddTicks(8041));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000003"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 20, 22, 48, 43, 760, DateTimeKind.Local).AddTicks(8108));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000004"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 20, 22, 48, 43, 760, DateTimeKind.Local).AddTicks(8134));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000005"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 20, 22, 48, 43, 760, DateTimeKind.Local).AddTicks(8157));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000006"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 20, 22, 48, 43, 760, DateTimeKind.Local).AddTicks(8280));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000007"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 20, 22, 48, 43, 760, DateTimeKind.Local).AddTicks(8300));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000008"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 20, 22, 48, 43, 760, DateTimeKind.Local).AddTicks(8317));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000009"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 20, 22, 48, 43, 760, DateTimeKind.Local).AddTicks(8341));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000010"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 20, 22, 48, 43, 760, DateTimeKind.Local).AddTicks(8429));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000011"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 20, 22, 48, 43, 760, DateTimeKind.Local).AddTicks(8486));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000012"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 20, 22, 48, 43, 760, DateTimeKind.Local).AddTicks(8504));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000013"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 20, 22, 48, 43, 760, DateTimeKind.Local).AddTicks(8570));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000014"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 20, 22, 48, 43, 760, DateTimeKind.Local).AddTicks(8590));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000015"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 20, 22, 48, 43, 760, DateTimeKind.Local).AddTicks(8615));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000016"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 20, 22, 48, 43, 760, DateTimeKind.Local).AddTicks(8694));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000017"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 20, 22, 48, 43, 760, DateTimeKind.Local).AddTicks(8721));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000018"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 20, 22, 48, 43, 760, DateTimeKind.Local).AddTicks(8741));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000019"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 20, 22, 48, 43, 760, DateTimeKind.Local).AddTicks(8841));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000020"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 20, 22, 48, 43, 760, DateTimeKind.Local).AddTicks(8860));

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000001"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 22, 48, 43, 760, DateTimeKind.Local).AddTicks(7947), new DateTime(2026, 7, 20, 22, 48, 43, 760, DateTimeKind.Local).AddTicks(7947) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000002"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 22, 48, 43, 760, DateTimeKind.Local).AddTicks(8035), new DateTime(2026, 7, 20, 22, 48, 43, 760, DateTimeKind.Local).AddTicks(8035) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000003"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 22, 48, 43, 760, DateTimeKind.Local).AddTicks(8100), new DateTime(2026, 7, 20, 22, 48, 43, 760, DateTimeKind.Local).AddTicks(8101) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000004"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 22, 48, 43, 760, DateTimeKind.Local).AddTicks(8129), new DateTime(2026, 7, 20, 22, 48, 43, 760, DateTimeKind.Local).AddTicks(8129) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000005"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 22, 48, 43, 760, DateTimeKind.Local).AddTicks(8150), new DateTime(2026, 7, 20, 22, 48, 43, 760, DateTimeKind.Local).AddTicks(8150) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000006"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 22, 48, 43, 760, DateTimeKind.Local).AddTicks(8274), new DateTime(2026, 7, 20, 22, 48, 43, 760, DateTimeKind.Local).AddTicks(8274) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000007"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 22, 48, 43, 760, DateTimeKind.Local).AddTicks(8294), new DateTime(2026, 7, 20, 22, 48, 43, 760, DateTimeKind.Local).AddTicks(8295) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000008"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 22, 48, 43, 760, DateTimeKind.Local).AddTicks(8312), new DateTime(2026, 7, 20, 22, 48, 43, 760, DateTimeKind.Local).AddTicks(8313) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000009"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 22, 48, 43, 760, DateTimeKind.Local).AddTicks(8334), new DateTime(2026, 7, 20, 22, 48, 43, 760, DateTimeKind.Local).AddTicks(8335) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000010"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 22, 48, 43, 760, DateTimeKind.Local).AddTicks(8423), new DateTime(2026, 7, 20, 22, 48, 43, 760, DateTimeKind.Local).AddTicks(8424) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000011"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 22, 48, 43, 760, DateTimeKind.Local).AddTicks(8479), new DateTime(2026, 7, 20, 22, 48, 43, 760, DateTimeKind.Local).AddTicks(8480) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000012"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 22, 48, 43, 760, DateTimeKind.Local).AddTicks(8499), new DateTime(2026, 7, 20, 22, 48, 43, 760, DateTimeKind.Local).AddTicks(8500) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000013"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 22, 48, 43, 760, DateTimeKind.Local).AddTicks(8565), new DateTime(2026, 7, 20, 22, 48, 43, 760, DateTimeKind.Local).AddTicks(8565) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000014"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 22, 48, 43, 760, DateTimeKind.Local).AddTicks(8585), new DateTime(2026, 7, 20, 22, 48, 43, 760, DateTimeKind.Local).AddTicks(8586) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000015"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 22, 48, 43, 760, DateTimeKind.Local).AddTicks(8604), new DateTime(2026, 7, 20, 22, 48, 43, 760, DateTimeKind.Local).AddTicks(8604) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000016"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 22, 48, 43, 760, DateTimeKind.Local).AddTicks(8647), new DateTime(2026, 7, 20, 22, 48, 43, 760, DateTimeKind.Local).AddTicks(8648) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000017"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 22, 48, 43, 760, DateTimeKind.Local).AddTicks(8714), new DateTime(2026, 7, 20, 22, 48, 43, 760, DateTimeKind.Local).AddTicks(8714) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000018"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 22, 48, 43, 760, DateTimeKind.Local).AddTicks(8736), new DateTime(2026, 7, 20, 22, 48, 43, 760, DateTimeKind.Local).AddTicks(8737) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000019"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 22, 48, 43, 760, DateTimeKind.Local).AddTicks(8833), new DateTime(2026, 7, 20, 22, 48, 43, 760, DateTimeKind.Local).AddTicks(8834) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000020"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 22, 48, 43, 760, DateTimeKind.Local).AddTicks(8855), new DateTime(2026, 7, 20, 22, 48, 43, 760, DateTimeKind.Local).AddTicks(8855) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 22, 48, 43, 760, DateTimeKind.Local).AddTicks(6201), new DateTime(2026, 7, 20, 22, 48, 43, 760, DateTimeKind.Local).AddTicks(6202) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 22, 48, 43, 760, DateTimeKind.Local).AddTicks(5499), new DateTime(2026, 7, 20, 22, 48, 43, 760, DateTimeKind.Local).AddTicks(5542) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000001"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 22, 48, 43, 760, DateTimeKind.Local).AddTicks(7923), new DateTime(2026, 7, 20, 22, 48, 43, 760, DateTimeKind.Local).AddTicks(7924) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000002"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 22, 48, 43, 760, DateTimeKind.Local).AddTicks(8027), new DateTime(2026, 7, 20, 22, 48, 43, 760, DateTimeKind.Local).AddTicks(8028) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000003"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 22, 48, 43, 760, DateTimeKind.Local).AddTicks(8051), new DateTime(2026, 7, 20, 22, 48, 43, 760, DateTimeKind.Local).AddTicks(8051) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000004"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 22, 48, 43, 760, DateTimeKind.Local).AddTicks(8122), new DateTime(2026, 7, 20, 22, 48, 43, 760, DateTimeKind.Local).AddTicks(8123) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000005"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 22, 48, 43, 760, DateTimeKind.Local).AddTicks(8142), new DateTime(2026, 7, 20, 22, 48, 43, 760, DateTimeKind.Local).AddTicks(8142) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000006"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 22, 48, 43, 760, DateTimeKind.Local).AddTicks(8174), new DateTime(2026, 7, 20, 22, 48, 43, 760, DateTimeKind.Local).AddTicks(8174) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000007"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 22, 48, 43, 760, DateTimeKind.Local).AddTicks(8288), new DateTime(2026, 7, 20, 22, 48, 43, 760, DateTimeKind.Local).AddTicks(8288) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000008"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 22, 48, 43, 760, DateTimeKind.Local).AddTicks(8306), new DateTime(2026, 7, 20, 22, 48, 43, 760, DateTimeKind.Local).AddTicks(8307) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000009"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 22, 48, 43, 760, DateTimeKind.Local).AddTicks(8326), new DateTime(2026, 7, 20, 22, 48, 43, 760, DateTimeKind.Local).AddTicks(8326) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000010"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 22, 48, 43, 760, DateTimeKind.Local).AddTicks(8416), new DateTime(2026, 7, 20, 22, 48, 43, 760, DateTimeKind.Local).AddTicks(8416) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000011"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 22, 48, 43, 760, DateTimeKind.Local).AddTicks(8473), new DateTime(2026, 7, 20, 22, 48, 43, 760, DateTimeKind.Local).AddTicks(8474) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000012"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 22, 48, 43, 760, DateTimeKind.Local).AddTicks(8493), new DateTime(2026, 7, 20, 22, 48, 43, 760, DateTimeKind.Local).AddTicks(8493) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000013"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 22, 48, 43, 760, DateTimeKind.Local).AddTicks(8558), new DateTime(2026, 7, 20, 22, 48, 43, 760, DateTimeKind.Local).AddTicks(8558) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000014"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 22, 48, 43, 760, DateTimeKind.Local).AddTicks(8577), new DateTime(2026, 7, 20, 22, 48, 43, 760, DateTimeKind.Local).AddTicks(8577) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000015"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 22, 48, 43, 760, DateTimeKind.Local).AddTicks(8597), new DateTime(2026, 7, 20, 22, 48, 43, 760, DateTimeKind.Local).AddTicks(8598) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000016"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 22, 48, 43, 760, DateTimeKind.Local).AddTicks(8641), new DateTime(2026, 7, 20, 22, 48, 43, 760, DateTimeKind.Local).AddTicks(8642) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000017"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 22, 48, 43, 760, DateTimeKind.Local).AddTicks(8705), new DateTime(2026, 7, 20, 22, 48, 43, 760, DateTimeKind.Local).AddTicks(8706) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000018"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 22, 48, 43, 760, DateTimeKind.Local).AddTicks(8730), new DateTime(2026, 7, 20, 22, 48, 43, 760, DateTimeKind.Local).AddTicks(8730) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000019"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 22, 48, 43, 760, DateTimeKind.Local).AddTicks(8826), new DateTime(2026, 7, 20, 22, 48, 43, 760, DateTimeKind.Local).AddTicks(8826) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000020"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 22, 48, 43, 760, DateTimeKind.Local).AddTicks(8849), new DateTime(2026, 7, 20, 22, 48, 43, 760, DateTimeKind.Local).AddTicks(8850) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 22, 48, 43, 760, DateTimeKind.Local).AddTicks(5675), new DateTime(2026, 7, 20, 22, 48, 43, 760, DateTimeKind.Local).AddTicks(5676) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 22, 48, 43, 760, DateTimeKind.Local).AddTicks(5680), new DateTime(2026, 7, 20, 22, 48, 43, 760, DateTimeKind.Local).AddTicks(5681) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 22, 48, 43, 760, DateTimeKind.Local).AddTicks(5688), new DateTime(2026, 7, 20, 22, 48, 43, 760, DateTimeKind.Local).AddTicks(5688) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("55555555-5555-5555-5555-555555555555"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 22, 48, 43, 760, DateTimeKind.Local).AddTicks(5696), new DateTime(2026, 7, 20, 22, 48, 43, 760, DateTimeKind.Local).AddTicks(5697) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666666"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 22, 48, 43, 760, DateTimeKind.Local).AddTicks(5704), new DateTime(2026, 7, 20, 22, 48, 43, 760, DateTimeKind.Local).AddTicks(5705) });
        }
    }
}
