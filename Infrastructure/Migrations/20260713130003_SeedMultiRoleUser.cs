using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedMultiRoleUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_ParentLinkRequests_StudentId",
                table: "ParentLinkRequests");

            migrationBuilder.UpdateData(
                table: "ParentProfile",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 20, 0, 0, 820, DateTimeKind.Local).AddTicks(6913), new DateTime(2026, 7, 13, 20, 0, 0, 820, DateTimeKind.Local).AddTicks(6913) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 20, 0, 0, 820, DateTimeKind.Local).AddTicks(6833), new DateTime(2026, 7, 13, 20, 0, 0, 820, DateTimeKind.Local).AddTicks(6834) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 20, 0, 0, 820, DateTimeKind.Local).AddTicks(6600), new DateTime(2026, 7, 13, 20, 0, 0, 820, DateTimeKind.Local).AddTicks(6615) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 20, 0, 0, 820, DateTimeKind.Local).AddTicks(6669), new DateTime(2026, 7, 13, 20, 0, 0, 820, DateTimeKind.Local).AddTicks(6682) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 20, 0, 0, 820, DateTimeKind.Local).AddTicks(6686), new DateTime(2026, 7, 13, 20, 0, 0, 820, DateTimeKind.Local).AddTicks(6687) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 20, 0, 0, 820, DateTimeKind.Local).AddTicks(6689), new DateTime(2026, 7, 13, 20, 0, 0, 820, DateTimeKind.Local).AddTicks(6690) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("55555555-5555-5555-5555-555555555555"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 13, 20, 0, 0, 820, DateTimeKind.Local).AddTicks(6693), new DateTime(2026, 7, 13, 20, 0, 0, 820, DateTimeKind.Local).AddTicks(6693) });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Avatar", "CreatedAt", "CreatedBy", "DateOfBirth", "Email", "FullName", "Gender", "IsActive", "IsDeleted", "LastUpdatedAt", "LastUpdatedBy", "Password", "Phone", "UpdatedBy", "Username" },
                values: new object[] { new Guid("66666666-6666-6666-6666-666666666666"), null, new DateTime(2026, 7, 13, 20, 0, 0, 820, DateTimeKind.Local).AddTicks(6697), null, null, "multi@elms.com", "Vừa Phụ Huynh Vừa Giáo Viên", null, true, false, new DateTime(2026, 7, 13, 20, 0, 0, 820, DateTimeKind.Local).AddTicks(6697), null, "$2a$11$3HXCJnYevNW8Awmlq9VfIengAG7omtmw85UBxJAAYLmNTjatfD6Zy", null, null, "multirole" });

            migrationBuilder.InsertData(
                table: "p_user_role",
                columns: new[] { "role_id", "user_id" },
                values: new object[,]
                {
                    { 3, new Guid("66666666-6666-6666-6666-666666666666") },
                    { 4, new Guid("66666666-6666-6666-6666-666666666666") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ParentLinkRequests_StudentId_ParentId",
                table: "ParentLinkRequests",
                columns: new[] { "StudentId", "ParentId" },
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_ParentLinkRequests_StudentId_ParentId",
                table: "ParentLinkRequests");

            migrationBuilder.DeleteData(
                table: "p_user_role",
                keyColumns: new[] { "role_id", "user_id" },
                keyValues: new object[] { 3, new Guid("66666666-6666-6666-6666-666666666666") });

            migrationBuilder.DeleteData(
                table: "p_user_role",
                keyColumns: new[] { "role_id", "user_id" },
                keyValues: new object[] { 4, new Guid("66666666-6666-6666-6666-666666666666") });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666666"));

            migrationBuilder.UpdateData(
                table: "ParentProfile",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 11, 23, 53, 9, 560, DateTimeKind.Local).AddTicks(2339), new DateTime(2026, 7, 11, 23, 53, 9, 560, DateTimeKind.Local).AddTicks(2340) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 11, 23, 53, 9, 560, DateTimeKind.Local).AddTicks(2275), new DateTime(2026, 7, 11, 23, 53, 9, 560, DateTimeKind.Local).AddTicks(2275) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 11, 23, 53, 9, 560, DateTimeKind.Local).AddTicks(2118), new DateTime(2026, 7, 11, 23, 53, 9, 560, DateTimeKind.Local).AddTicks(2131) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 11, 23, 53, 9, 560, DateTimeKind.Local).AddTicks(2171), new DateTime(2026, 7, 11, 23, 53, 9, 560, DateTimeKind.Local).AddTicks(2172) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 11, 23, 53, 9, 560, DateTimeKind.Local).AddTicks(2175), new DateTime(2026, 7, 11, 23, 53, 9, 560, DateTimeKind.Local).AddTicks(2175) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 11, 23, 53, 9, 560, DateTimeKind.Local).AddTicks(2180), new DateTime(2026, 7, 11, 23, 53, 9, 560, DateTimeKind.Local).AddTicks(2180) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("55555555-5555-5555-5555-555555555555"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 11, 23, 53, 9, 560, DateTimeKind.Local).AddTicks(2193), new DateTime(2026, 7, 11, 23, 53, 9, 560, DateTimeKind.Local).AddTicks(2193) });

            migrationBuilder.CreateIndex(
                name: "IX_ParentLinkRequests_StudentId",
                table: "ParentLinkRequests",
                column: "StudentId");
        }
    }
}
