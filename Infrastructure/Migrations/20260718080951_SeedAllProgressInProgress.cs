using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedAllProgressInProgress : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("88888888-8888-8888-8888-888888888888"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 15, 9, 49, 984, DateTimeKind.Local).AddTicks(9745));

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

            migrationBuilder.InsertData(
                table: "Progress",
                columns: new[] { "ModuleItemId", "StudentId", "CompletedAt", "PercentDone", "ScorePct", "StartedAt", "Status", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("66666666-6666-6666-6666-666666666601"), new Guid("22222222-2222-2222-2222-000000000001"), null, 0m, null, null, (byte)1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("66666666-6666-6666-6666-666666666602"), new Guid("22222222-2222-2222-2222-000000000001"), null, 0m, null, null, (byte)1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("66666666-6666-6666-6666-666666666603"), new Guid("22222222-2222-2222-2222-000000000001"), null, 0m, null, null, (byte)1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("66666666-6666-6666-6666-666666666604"), new Guid("22222222-2222-2222-2222-000000000001"), null, 0m, null, null, (byte)1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("66666666-6666-6666-6666-666666666601"), new Guid("22222222-2222-2222-2222-000000000002"), null, 0m, null, null, (byte)1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("66666666-6666-6666-6666-666666666602"), new Guid("22222222-2222-2222-2222-000000000002"), null, 0m, null, null, (byte)1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("66666666-6666-6666-6666-666666666603"), new Guid("22222222-2222-2222-2222-000000000002"), null, 0m, null, null, (byte)1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("66666666-6666-6666-6666-666666666604"), new Guid("22222222-2222-2222-2222-000000000002"), null, 0m, null, null, (byte)1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("66666666-6666-6666-6666-666666666601"), new Guid("22222222-2222-2222-2222-000000000003"), null, 0m, null, null, (byte)1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("66666666-6666-6666-6666-666666666602"), new Guid("22222222-2222-2222-2222-000000000003"), null, 0m, null, null, (byte)1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("66666666-6666-6666-6666-666666666603"), new Guid("22222222-2222-2222-2222-000000000003"), null, 0m, null, null, (byte)1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("66666666-6666-6666-6666-666666666604"), new Guid("22222222-2222-2222-2222-000000000003"), null, 0m, null, null, (byte)1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("66666666-6666-6666-6666-666666666601"), new Guid("22222222-2222-2222-2222-000000000004"), null, 0m, null, null, (byte)1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("66666666-6666-6666-6666-666666666602"), new Guid("22222222-2222-2222-2222-000000000004"), null, 0m, null, null, (byte)1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("66666666-6666-6666-6666-666666666603"), new Guid("22222222-2222-2222-2222-000000000004"), null, 0m, null, null, (byte)1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("66666666-6666-6666-6666-666666666604"), new Guid("22222222-2222-2222-2222-000000000004"), null, 0m, null, null, (byte)1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("66666666-6666-6666-6666-666666666601"), new Guid("22222222-2222-2222-2222-000000000005"), null, 0m, null, null, (byte)1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("66666666-6666-6666-6666-666666666602"), new Guid("22222222-2222-2222-2222-000000000005"), null, 0m, null, null, (byte)1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("66666666-6666-6666-6666-666666666603"), new Guid("22222222-2222-2222-2222-000000000005"), null, 0m, null, null, (byte)1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("66666666-6666-6666-6666-666666666604"), new Guid("22222222-2222-2222-2222-000000000005"), null, 0m, null, null, (byte)1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("66666666-6666-6666-6666-666666666601"), new Guid("22222222-2222-2222-2222-000000000006"), null, 0m, null, null, (byte)1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("66666666-6666-6666-6666-666666666602"), new Guid("22222222-2222-2222-2222-000000000006"), null, 0m, null, null, (byte)1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("66666666-6666-6666-6666-666666666603"), new Guid("22222222-2222-2222-2222-000000000006"), null, 0m, null, null, (byte)1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("66666666-6666-6666-6666-666666666604"), new Guid("22222222-2222-2222-2222-000000000006"), null, 0m, null, null, (byte)1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("66666666-6666-6666-6666-666666666601"), new Guid("22222222-2222-2222-2222-000000000007"), null, 0m, null, null, (byte)1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("66666666-6666-6666-6666-666666666602"), new Guid("22222222-2222-2222-2222-000000000007"), null, 0m, null, null, (byte)1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("66666666-6666-6666-6666-666666666603"), new Guid("22222222-2222-2222-2222-000000000007"), null, 0m, null, null, (byte)1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("66666666-6666-6666-6666-666666666604"), new Guid("22222222-2222-2222-2222-000000000007"), null, 0m, null, null, (byte)1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("66666666-6666-6666-6666-666666666601"), new Guid("22222222-2222-2222-2222-000000000008"), null, 0m, null, null, (byte)1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("66666666-6666-6666-6666-666666666602"), new Guid("22222222-2222-2222-2222-000000000008"), null, 0m, null, null, (byte)1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("66666666-6666-6666-6666-666666666603"), new Guid("22222222-2222-2222-2222-000000000008"), null, 0m, null, null, (byte)1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("66666666-6666-6666-6666-666666666604"), new Guid("22222222-2222-2222-2222-000000000008"), null, 0m, null, null, (byte)1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("66666666-6666-6666-6666-666666666601"), new Guid("22222222-2222-2222-2222-000000000009"), null, 0m, null, null, (byte)1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("66666666-6666-6666-6666-666666666602"), new Guid("22222222-2222-2222-2222-000000000009"), null, 0m, null, null, (byte)1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("66666666-6666-6666-6666-666666666603"), new Guid("22222222-2222-2222-2222-000000000009"), null, 0m, null, null, (byte)1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("66666666-6666-6666-6666-666666666604"), new Guid("22222222-2222-2222-2222-000000000009"), null, 0m, null, null, (byte)1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("66666666-6666-6666-6666-666666666601"), new Guid("22222222-2222-2222-2222-000000000010"), null, 0m, null, null, (byte)1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("66666666-6666-6666-6666-666666666602"), new Guid("22222222-2222-2222-2222-000000000010"), null, 0m, null, null, (byte)1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("66666666-6666-6666-6666-666666666603"), new Guid("22222222-2222-2222-2222-000000000010"), null, 0m, null, null, (byte)1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("66666666-6666-6666-6666-666666666604"), new Guid("22222222-2222-2222-2222-000000000010"), null, 0m, null, null, (byte)1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("66666666-6666-6666-6666-666666666601"), new Guid("22222222-2222-2222-2222-000000000011"), null, 0m, null, null, (byte)1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("66666666-6666-6666-6666-666666666602"), new Guid("22222222-2222-2222-2222-000000000011"), null, 0m, null, null, (byte)1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("66666666-6666-6666-6666-666666666603"), new Guid("22222222-2222-2222-2222-000000000011"), null, 0m, null, null, (byte)1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("66666666-6666-6666-6666-666666666604"), new Guid("22222222-2222-2222-2222-000000000011"), null, 0m, null, null, (byte)1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("66666666-6666-6666-6666-666666666601"), new Guid("22222222-2222-2222-2222-000000000012"), null, 0m, null, null, (byte)1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("66666666-6666-6666-6666-666666666602"), new Guid("22222222-2222-2222-2222-000000000012"), null, 0m, null, null, (byte)1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("66666666-6666-6666-6666-666666666603"), new Guid("22222222-2222-2222-2222-000000000012"), null, 0m, null, null, (byte)1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("66666666-6666-6666-6666-666666666604"), new Guid("22222222-2222-2222-2222-000000000012"), null, 0m, null, null, (byte)1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("66666666-6666-6666-6666-666666666601"), new Guid("22222222-2222-2222-2222-000000000013"), null, 0m, null, null, (byte)1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("66666666-6666-6666-6666-666666666602"), new Guid("22222222-2222-2222-2222-000000000013"), null, 0m, null, null, (byte)1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("66666666-6666-6666-6666-666666666603"), new Guid("22222222-2222-2222-2222-000000000013"), null, 0m, null, null, (byte)1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("66666666-6666-6666-6666-666666666604"), new Guid("22222222-2222-2222-2222-000000000013"), null, 0m, null, null, (byte)1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("66666666-6666-6666-6666-666666666601"), new Guid("22222222-2222-2222-2222-000000000014"), null, 0m, null, null, (byte)1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("66666666-6666-6666-6666-666666666602"), new Guid("22222222-2222-2222-2222-000000000014"), null, 0m, null, null, (byte)1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("66666666-6666-6666-6666-666666666603"), new Guid("22222222-2222-2222-2222-000000000014"), null, 0m, null, null, (byte)1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("66666666-6666-6666-6666-666666666604"), new Guid("22222222-2222-2222-2222-000000000014"), null, 0m, null, null, (byte)1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("66666666-6666-6666-6666-666666666601"), new Guid("22222222-2222-2222-2222-000000000015"), null, 0m, null, null, (byte)1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("66666666-6666-6666-6666-666666666602"), new Guid("22222222-2222-2222-2222-000000000015"), null, 0m, null, null, (byte)1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("66666666-6666-6666-6666-666666666603"), new Guid("22222222-2222-2222-2222-000000000015"), null, 0m, null, null, (byte)1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("66666666-6666-6666-6666-666666666604"), new Guid("22222222-2222-2222-2222-000000000015"), null, 0m, null, null, (byte)1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("66666666-6666-6666-6666-666666666601"), new Guid("22222222-2222-2222-2222-000000000016"), null, 0m, null, null, (byte)1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("66666666-6666-6666-6666-666666666602"), new Guid("22222222-2222-2222-2222-000000000016"), null, 0m, null, null, (byte)1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("66666666-6666-6666-6666-666666666603"), new Guid("22222222-2222-2222-2222-000000000016"), null, 0m, null, null, (byte)1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("66666666-6666-6666-6666-666666666604"), new Guid("22222222-2222-2222-2222-000000000016"), null, 0m, null, null, (byte)1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("66666666-6666-6666-6666-666666666601"), new Guid("22222222-2222-2222-2222-000000000017"), null, 0m, null, null, (byte)1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("66666666-6666-6666-6666-666666666602"), new Guid("22222222-2222-2222-2222-000000000017"), null, 0m, null, null, (byte)1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("66666666-6666-6666-6666-666666666603"), new Guid("22222222-2222-2222-2222-000000000017"), null, 0m, null, null, (byte)1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("66666666-6666-6666-6666-666666666604"), new Guid("22222222-2222-2222-2222-000000000017"), null, 0m, null, null, (byte)1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("66666666-6666-6666-6666-666666666601"), new Guid("22222222-2222-2222-2222-000000000018"), null, 0m, null, null, (byte)1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("66666666-6666-6666-6666-666666666602"), new Guid("22222222-2222-2222-2222-000000000018"), null, 0m, null, null, (byte)1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("66666666-6666-6666-6666-666666666603"), new Guid("22222222-2222-2222-2222-000000000018"), null, 0m, null, null, (byte)1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("66666666-6666-6666-6666-666666666604"), new Guid("22222222-2222-2222-2222-000000000018"), null, 0m, null, null, (byte)1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("66666666-6666-6666-6666-666666666601"), new Guid("22222222-2222-2222-2222-000000000019"), null, 0m, null, null, (byte)1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("66666666-6666-6666-6666-666666666602"), new Guid("22222222-2222-2222-2222-000000000019"), null, 0m, null, null, (byte)1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("66666666-6666-6666-6666-666666666603"), new Guid("22222222-2222-2222-2222-000000000019"), null, 0m, null, null, (byte)1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("66666666-6666-6666-6666-666666666604"), new Guid("22222222-2222-2222-2222-000000000019"), null, 0m, null, null, (byte)1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("66666666-6666-6666-6666-666666666601"), new Guid("22222222-2222-2222-2222-000000000020"), null, 0m, null, null, (byte)1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("66666666-6666-6666-6666-666666666602"), new Guid("22222222-2222-2222-2222-000000000020"), null, 0m, null, null, (byte)1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("66666666-6666-6666-6666-666666666603"), new Guid("22222222-2222-2222-2222-000000000020"), null, 0m, null, null, (byte)1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("66666666-6666-6666-6666-666666666604"), new Guid("22222222-2222-2222-2222-000000000020"), null, 0m, null, null, (byte)1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Progress",
                keyColumns: new[] { "ModuleItemId", "StudentId" },
                keyValues: new object[] { new Guid("66666666-6666-6666-6666-666666666601"), new Guid("22222222-2222-2222-2222-000000000001") });

            migrationBuilder.DeleteData(
                table: "Progress",
                keyColumns: new[] { "ModuleItemId", "StudentId" },
                keyValues: new object[] { new Guid("66666666-6666-6666-6666-666666666602"), new Guid("22222222-2222-2222-2222-000000000001") });

            migrationBuilder.DeleteData(
                table: "Progress",
                keyColumns: new[] { "ModuleItemId", "StudentId" },
                keyValues: new object[] { new Guid("66666666-6666-6666-6666-666666666603"), new Guid("22222222-2222-2222-2222-000000000001") });

            migrationBuilder.DeleteData(
                table: "Progress",
                keyColumns: new[] { "ModuleItemId", "StudentId" },
                keyValues: new object[] { new Guid("66666666-6666-6666-6666-666666666604"), new Guid("22222222-2222-2222-2222-000000000001") });

            migrationBuilder.DeleteData(
                table: "Progress",
                keyColumns: new[] { "ModuleItemId", "StudentId" },
                keyValues: new object[] { new Guid("66666666-6666-6666-6666-666666666601"), new Guid("22222222-2222-2222-2222-000000000002") });

            migrationBuilder.DeleteData(
                table: "Progress",
                keyColumns: new[] { "ModuleItemId", "StudentId" },
                keyValues: new object[] { new Guid("66666666-6666-6666-6666-666666666602"), new Guid("22222222-2222-2222-2222-000000000002") });

            migrationBuilder.DeleteData(
                table: "Progress",
                keyColumns: new[] { "ModuleItemId", "StudentId" },
                keyValues: new object[] { new Guid("66666666-6666-6666-6666-666666666603"), new Guid("22222222-2222-2222-2222-000000000002") });

            migrationBuilder.DeleteData(
                table: "Progress",
                keyColumns: new[] { "ModuleItemId", "StudentId" },
                keyValues: new object[] { new Guid("66666666-6666-6666-6666-666666666604"), new Guid("22222222-2222-2222-2222-000000000002") });

            migrationBuilder.DeleteData(
                table: "Progress",
                keyColumns: new[] { "ModuleItemId", "StudentId" },
                keyValues: new object[] { new Guid("66666666-6666-6666-6666-666666666601"), new Guid("22222222-2222-2222-2222-000000000003") });

            migrationBuilder.DeleteData(
                table: "Progress",
                keyColumns: new[] { "ModuleItemId", "StudentId" },
                keyValues: new object[] { new Guid("66666666-6666-6666-6666-666666666602"), new Guid("22222222-2222-2222-2222-000000000003") });

            migrationBuilder.DeleteData(
                table: "Progress",
                keyColumns: new[] { "ModuleItemId", "StudentId" },
                keyValues: new object[] { new Guid("66666666-6666-6666-6666-666666666603"), new Guid("22222222-2222-2222-2222-000000000003") });

            migrationBuilder.DeleteData(
                table: "Progress",
                keyColumns: new[] { "ModuleItemId", "StudentId" },
                keyValues: new object[] { new Guid("66666666-6666-6666-6666-666666666604"), new Guid("22222222-2222-2222-2222-000000000003") });

            migrationBuilder.DeleteData(
                table: "Progress",
                keyColumns: new[] { "ModuleItemId", "StudentId" },
                keyValues: new object[] { new Guid("66666666-6666-6666-6666-666666666601"), new Guid("22222222-2222-2222-2222-000000000004") });

            migrationBuilder.DeleteData(
                table: "Progress",
                keyColumns: new[] { "ModuleItemId", "StudentId" },
                keyValues: new object[] { new Guid("66666666-6666-6666-6666-666666666602"), new Guid("22222222-2222-2222-2222-000000000004") });

            migrationBuilder.DeleteData(
                table: "Progress",
                keyColumns: new[] { "ModuleItemId", "StudentId" },
                keyValues: new object[] { new Guid("66666666-6666-6666-6666-666666666603"), new Guid("22222222-2222-2222-2222-000000000004") });

            migrationBuilder.DeleteData(
                table: "Progress",
                keyColumns: new[] { "ModuleItemId", "StudentId" },
                keyValues: new object[] { new Guid("66666666-6666-6666-6666-666666666604"), new Guid("22222222-2222-2222-2222-000000000004") });

            migrationBuilder.DeleteData(
                table: "Progress",
                keyColumns: new[] { "ModuleItemId", "StudentId" },
                keyValues: new object[] { new Guid("66666666-6666-6666-6666-666666666601"), new Guid("22222222-2222-2222-2222-000000000005") });

            migrationBuilder.DeleteData(
                table: "Progress",
                keyColumns: new[] { "ModuleItemId", "StudentId" },
                keyValues: new object[] { new Guid("66666666-6666-6666-6666-666666666602"), new Guid("22222222-2222-2222-2222-000000000005") });

            migrationBuilder.DeleteData(
                table: "Progress",
                keyColumns: new[] { "ModuleItemId", "StudentId" },
                keyValues: new object[] { new Guid("66666666-6666-6666-6666-666666666603"), new Guid("22222222-2222-2222-2222-000000000005") });

            migrationBuilder.DeleteData(
                table: "Progress",
                keyColumns: new[] { "ModuleItemId", "StudentId" },
                keyValues: new object[] { new Guid("66666666-6666-6666-6666-666666666604"), new Guid("22222222-2222-2222-2222-000000000005") });

            migrationBuilder.DeleteData(
                table: "Progress",
                keyColumns: new[] { "ModuleItemId", "StudentId" },
                keyValues: new object[] { new Guid("66666666-6666-6666-6666-666666666601"), new Guid("22222222-2222-2222-2222-000000000006") });

            migrationBuilder.DeleteData(
                table: "Progress",
                keyColumns: new[] { "ModuleItemId", "StudentId" },
                keyValues: new object[] { new Guid("66666666-6666-6666-6666-666666666602"), new Guid("22222222-2222-2222-2222-000000000006") });

            migrationBuilder.DeleteData(
                table: "Progress",
                keyColumns: new[] { "ModuleItemId", "StudentId" },
                keyValues: new object[] { new Guid("66666666-6666-6666-6666-666666666603"), new Guid("22222222-2222-2222-2222-000000000006") });

            migrationBuilder.DeleteData(
                table: "Progress",
                keyColumns: new[] { "ModuleItemId", "StudentId" },
                keyValues: new object[] { new Guid("66666666-6666-6666-6666-666666666604"), new Guid("22222222-2222-2222-2222-000000000006") });

            migrationBuilder.DeleteData(
                table: "Progress",
                keyColumns: new[] { "ModuleItemId", "StudentId" },
                keyValues: new object[] { new Guid("66666666-6666-6666-6666-666666666601"), new Guid("22222222-2222-2222-2222-000000000007") });

            migrationBuilder.DeleteData(
                table: "Progress",
                keyColumns: new[] { "ModuleItemId", "StudentId" },
                keyValues: new object[] { new Guid("66666666-6666-6666-6666-666666666602"), new Guid("22222222-2222-2222-2222-000000000007") });

            migrationBuilder.DeleteData(
                table: "Progress",
                keyColumns: new[] { "ModuleItemId", "StudentId" },
                keyValues: new object[] { new Guid("66666666-6666-6666-6666-666666666603"), new Guid("22222222-2222-2222-2222-000000000007") });

            migrationBuilder.DeleteData(
                table: "Progress",
                keyColumns: new[] { "ModuleItemId", "StudentId" },
                keyValues: new object[] { new Guid("66666666-6666-6666-6666-666666666604"), new Guid("22222222-2222-2222-2222-000000000007") });

            migrationBuilder.DeleteData(
                table: "Progress",
                keyColumns: new[] { "ModuleItemId", "StudentId" },
                keyValues: new object[] { new Guid("66666666-6666-6666-6666-666666666601"), new Guid("22222222-2222-2222-2222-000000000008") });

            migrationBuilder.DeleteData(
                table: "Progress",
                keyColumns: new[] { "ModuleItemId", "StudentId" },
                keyValues: new object[] { new Guid("66666666-6666-6666-6666-666666666602"), new Guid("22222222-2222-2222-2222-000000000008") });

            migrationBuilder.DeleteData(
                table: "Progress",
                keyColumns: new[] { "ModuleItemId", "StudentId" },
                keyValues: new object[] { new Guid("66666666-6666-6666-6666-666666666603"), new Guid("22222222-2222-2222-2222-000000000008") });

            migrationBuilder.DeleteData(
                table: "Progress",
                keyColumns: new[] { "ModuleItemId", "StudentId" },
                keyValues: new object[] { new Guid("66666666-6666-6666-6666-666666666604"), new Guid("22222222-2222-2222-2222-000000000008") });

            migrationBuilder.DeleteData(
                table: "Progress",
                keyColumns: new[] { "ModuleItemId", "StudentId" },
                keyValues: new object[] { new Guid("66666666-6666-6666-6666-666666666601"), new Guid("22222222-2222-2222-2222-000000000009") });

            migrationBuilder.DeleteData(
                table: "Progress",
                keyColumns: new[] { "ModuleItemId", "StudentId" },
                keyValues: new object[] { new Guid("66666666-6666-6666-6666-666666666602"), new Guid("22222222-2222-2222-2222-000000000009") });

            migrationBuilder.DeleteData(
                table: "Progress",
                keyColumns: new[] { "ModuleItemId", "StudentId" },
                keyValues: new object[] { new Guid("66666666-6666-6666-6666-666666666603"), new Guid("22222222-2222-2222-2222-000000000009") });

            migrationBuilder.DeleteData(
                table: "Progress",
                keyColumns: new[] { "ModuleItemId", "StudentId" },
                keyValues: new object[] { new Guid("66666666-6666-6666-6666-666666666604"), new Guid("22222222-2222-2222-2222-000000000009") });

            migrationBuilder.DeleteData(
                table: "Progress",
                keyColumns: new[] { "ModuleItemId", "StudentId" },
                keyValues: new object[] { new Guid("66666666-6666-6666-6666-666666666601"), new Guid("22222222-2222-2222-2222-000000000010") });

            migrationBuilder.DeleteData(
                table: "Progress",
                keyColumns: new[] { "ModuleItemId", "StudentId" },
                keyValues: new object[] { new Guid("66666666-6666-6666-6666-666666666602"), new Guid("22222222-2222-2222-2222-000000000010") });

            migrationBuilder.DeleteData(
                table: "Progress",
                keyColumns: new[] { "ModuleItemId", "StudentId" },
                keyValues: new object[] { new Guid("66666666-6666-6666-6666-666666666603"), new Guid("22222222-2222-2222-2222-000000000010") });

            migrationBuilder.DeleteData(
                table: "Progress",
                keyColumns: new[] { "ModuleItemId", "StudentId" },
                keyValues: new object[] { new Guid("66666666-6666-6666-6666-666666666604"), new Guid("22222222-2222-2222-2222-000000000010") });

            migrationBuilder.DeleteData(
                table: "Progress",
                keyColumns: new[] { "ModuleItemId", "StudentId" },
                keyValues: new object[] { new Guid("66666666-6666-6666-6666-666666666601"), new Guid("22222222-2222-2222-2222-000000000011") });

            migrationBuilder.DeleteData(
                table: "Progress",
                keyColumns: new[] { "ModuleItemId", "StudentId" },
                keyValues: new object[] { new Guid("66666666-6666-6666-6666-666666666602"), new Guid("22222222-2222-2222-2222-000000000011") });

            migrationBuilder.DeleteData(
                table: "Progress",
                keyColumns: new[] { "ModuleItemId", "StudentId" },
                keyValues: new object[] { new Guid("66666666-6666-6666-6666-666666666603"), new Guid("22222222-2222-2222-2222-000000000011") });

            migrationBuilder.DeleteData(
                table: "Progress",
                keyColumns: new[] { "ModuleItemId", "StudentId" },
                keyValues: new object[] { new Guid("66666666-6666-6666-6666-666666666604"), new Guid("22222222-2222-2222-2222-000000000011") });

            migrationBuilder.DeleteData(
                table: "Progress",
                keyColumns: new[] { "ModuleItemId", "StudentId" },
                keyValues: new object[] { new Guid("66666666-6666-6666-6666-666666666601"), new Guid("22222222-2222-2222-2222-000000000012") });

            migrationBuilder.DeleteData(
                table: "Progress",
                keyColumns: new[] { "ModuleItemId", "StudentId" },
                keyValues: new object[] { new Guid("66666666-6666-6666-6666-666666666602"), new Guid("22222222-2222-2222-2222-000000000012") });

            migrationBuilder.DeleteData(
                table: "Progress",
                keyColumns: new[] { "ModuleItemId", "StudentId" },
                keyValues: new object[] { new Guid("66666666-6666-6666-6666-666666666603"), new Guid("22222222-2222-2222-2222-000000000012") });

            migrationBuilder.DeleteData(
                table: "Progress",
                keyColumns: new[] { "ModuleItemId", "StudentId" },
                keyValues: new object[] { new Guid("66666666-6666-6666-6666-666666666604"), new Guid("22222222-2222-2222-2222-000000000012") });

            migrationBuilder.DeleteData(
                table: "Progress",
                keyColumns: new[] { "ModuleItemId", "StudentId" },
                keyValues: new object[] { new Guid("66666666-6666-6666-6666-666666666601"), new Guid("22222222-2222-2222-2222-000000000013") });

            migrationBuilder.DeleteData(
                table: "Progress",
                keyColumns: new[] { "ModuleItemId", "StudentId" },
                keyValues: new object[] { new Guid("66666666-6666-6666-6666-666666666602"), new Guid("22222222-2222-2222-2222-000000000013") });

            migrationBuilder.DeleteData(
                table: "Progress",
                keyColumns: new[] { "ModuleItemId", "StudentId" },
                keyValues: new object[] { new Guid("66666666-6666-6666-6666-666666666603"), new Guid("22222222-2222-2222-2222-000000000013") });

            migrationBuilder.DeleteData(
                table: "Progress",
                keyColumns: new[] { "ModuleItemId", "StudentId" },
                keyValues: new object[] { new Guid("66666666-6666-6666-6666-666666666604"), new Guid("22222222-2222-2222-2222-000000000013") });

            migrationBuilder.DeleteData(
                table: "Progress",
                keyColumns: new[] { "ModuleItemId", "StudentId" },
                keyValues: new object[] { new Guid("66666666-6666-6666-6666-666666666601"), new Guid("22222222-2222-2222-2222-000000000014") });

            migrationBuilder.DeleteData(
                table: "Progress",
                keyColumns: new[] { "ModuleItemId", "StudentId" },
                keyValues: new object[] { new Guid("66666666-6666-6666-6666-666666666602"), new Guid("22222222-2222-2222-2222-000000000014") });

            migrationBuilder.DeleteData(
                table: "Progress",
                keyColumns: new[] { "ModuleItemId", "StudentId" },
                keyValues: new object[] { new Guid("66666666-6666-6666-6666-666666666603"), new Guid("22222222-2222-2222-2222-000000000014") });

            migrationBuilder.DeleteData(
                table: "Progress",
                keyColumns: new[] { "ModuleItemId", "StudentId" },
                keyValues: new object[] { new Guid("66666666-6666-6666-6666-666666666604"), new Guid("22222222-2222-2222-2222-000000000014") });

            migrationBuilder.DeleteData(
                table: "Progress",
                keyColumns: new[] { "ModuleItemId", "StudentId" },
                keyValues: new object[] { new Guid("66666666-6666-6666-6666-666666666601"), new Guid("22222222-2222-2222-2222-000000000015") });

            migrationBuilder.DeleteData(
                table: "Progress",
                keyColumns: new[] { "ModuleItemId", "StudentId" },
                keyValues: new object[] { new Guid("66666666-6666-6666-6666-666666666602"), new Guid("22222222-2222-2222-2222-000000000015") });

            migrationBuilder.DeleteData(
                table: "Progress",
                keyColumns: new[] { "ModuleItemId", "StudentId" },
                keyValues: new object[] { new Guid("66666666-6666-6666-6666-666666666603"), new Guid("22222222-2222-2222-2222-000000000015") });

            migrationBuilder.DeleteData(
                table: "Progress",
                keyColumns: new[] { "ModuleItemId", "StudentId" },
                keyValues: new object[] { new Guid("66666666-6666-6666-6666-666666666604"), new Guid("22222222-2222-2222-2222-000000000015") });

            migrationBuilder.DeleteData(
                table: "Progress",
                keyColumns: new[] { "ModuleItemId", "StudentId" },
                keyValues: new object[] { new Guid("66666666-6666-6666-6666-666666666601"), new Guid("22222222-2222-2222-2222-000000000016") });

            migrationBuilder.DeleteData(
                table: "Progress",
                keyColumns: new[] { "ModuleItemId", "StudentId" },
                keyValues: new object[] { new Guid("66666666-6666-6666-6666-666666666602"), new Guid("22222222-2222-2222-2222-000000000016") });

            migrationBuilder.DeleteData(
                table: "Progress",
                keyColumns: new[] { "ModuleItemId", "StudentId" },
                keyValues: new object[] { new Guid("66666666-6666-6666-6666-666666666603"), new Guid("22222222-2222-2222-2222-000000000016") });

            migrationBuilder.DeleteData(
                table: "Progress",
                keyColumns: new[] { "ModuleItemId", "StudentId" },
                keyValues: new object[] { new Guid("66666666-6666-6666-6666-666666666604"), new Guid("22222222-2222-2222-2222-000000000016") });

            migrationBuilder.DeleteData(
                table: "Progress",
                keyColumns: new[] { "ModuleItemId", "StudentId" },
                keyValues: new object[] { new Guid("66666666-6666-6666-6666-666666666601"), new Guid("22222222-2222-2222-2222-000000000017") });

            migrationBuilder.DeleteData(
                table: "Progress",
                keyColumns: new[] { "ModuleItemId", "StudentId" },
                keyValues: new object[] { new Guid("66666666-6666-6666-6666-666666666602"), new Guid("22222222-2222-2222-2222-000000000017") });

            migrationBuilder.DeleteData(
                table: "Progress",
                keyColumns: new[] { "ModuleItemId", "StudentId" },
                keyValues: new object[] { new Guid("66666666-6666-6666-6666-666666666603"), new Guid("22222222-2222-2222-2222-000000000017") });

            migrationBuilder.DeleteData(
                table: "Progress",
                keyColumns: new[] { "ModuleItemId", "StudentId" },
                keyValues: new object[] { new Guid("66666666-6666-6666-6666-666666666604"), new Guid("22222222-2222-2222-2222-000000000017") });

            migrationBuilder.DeleteData(
                table: "Progress",
                keyColumns: new[] { "ModuleItemId", "StudentId" },
                keyValues: new object[] { new Guid("66666666-6666-6666-6666-666666666601"), new Guid("22222222-2222-2222-2222-000000000018") });

            migrationBuilder.DeleteData(
                table: "Progress",
                keyColumns: new[] { "ModuleItemId", "StudentId" },
                keyValues: new object[] { new Guid("66666666-6666-6666-6666-666666666602"), new Guid("22222222-2222-2222-2222-000000000018") });

            migrationBuilder.DeleteData(
                table: "Progress",
                keyColumns: new[] { "ModuleItemId", "StudentId" },
                keyValues: new object[] { new Guid("66666666-6666-6666-6666-666666666603"), new Guid("22222222-2222-2222-2222-000000000018") });

            migrationBuilder.DeleteData(
                table: "Progress",
                keyColumns: new[] { "ModuleItemId", "StudentId" },
                keyValues: new object[] { new Guid("66666666-6666-6666-6666-666666666604"), new Guid("22222222-2222-2222-2222-000000000018") });

            migrationBuilder.DeleteData(
                table: "Progress",
                keyColumns: new[] { "ModuleItemId", "StudentId" },
                keyValues: new object[] { new Guid("66666666-6666-6666-6666-666666666601"), new Guid("22222222-2222-2222-2222-000000000019") });

            migrationBuilder.DeleteData(
                table: "Progress",
                keyColumns: new[] { "ModuleItemId", "StudentId" },
                keyValues: new object[] { new Guid("66666666-6666-6666-6666-666666666602"), new Guid("22222222-2222-2222-2222-000000000019") });

            migrationBuilder.DeleteData(
                table: "Progress",
                keyColumns: new[] { "ModuleItemId", "StudentId" },
                keyValues: new object[] { new Guid("66666666-6666-6666-6666-666666666603"), new Guid("22222222-2222-2222-2222-000000000019") });

            migrationBuilder.DeleteData(
                table: "Progress",
                keyColumns: new[] { "ModuleItemId", "StudentId" },
                keyValues: new object[] { new Guid("66666666-6666-6666-6666-666666666604"), new Guid("22222222-2222-2222-2222-000000000019") });

            migrationBuilder.DeleteData(
                table: "Progress",
                keyColumns: new[] { "ModuleItemId", "StudentId" },
                keyValues: new object[] { new Guid("66666666-6666-6666-6666-666666666601"), new Guid("22222222-2222-2222-2222-000000000020") });

            migrationBuilder.DeleteData(
                table: "Progress",
                keyColumns: new[] { "ModuleItemId", "StudentId" },
                keyValues: new object[] { new Guid("66666666-6666-6666-6666-666666666602"), new Guid("22222222-2222-2222-2222-000000000020") });

            migrationBuilder.DeleteData(
                table: "Progress",
                keyColumns: new[] { "ModuleItemId", "StudentId" },
                keyValues: new object[] { new Guid("66666666-6666-6666-6666-666666666603"), new Guid("22222222-2222-2222-2222-000000000020") });

            migrationBuilder.DeleteData(
                table: "Progress",
                keyColumns: new[] { "ModuleItemId", "StudentId" },
                keyValues: new object[] { new Guid("66666666-6666-6666-6666-666666666604"), new Guid("22222222-2222-2222-2222-000000000020") });

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
    }
}
