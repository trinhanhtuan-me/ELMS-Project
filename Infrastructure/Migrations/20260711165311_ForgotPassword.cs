using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ForgotPassword : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PasswordResetTokens");

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PasswordResetTokens",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newsequentialid())"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "(sysdatetime())"),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExpiresAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Token = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    UsedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Password__3214EC07BFB33313", x => x.Id);
                    table.ForeignKey(
                        name: "FK__PasswordR__UserI__28ED12D1",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "ParentProfile",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 10, 22, 1, 51, 335, DateTimeKind.Local).AddTicks(2081), new DateTime(2026, 7, 10, 22, 1, 51, 335, DateTimeKind.Local).AddTicks(2081) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 10, 22, 1, 51, 335, DateTimeKind.Local).AddTicks(2045), new DateTime(2026, 7, 10, 22, 1, 51, 335, DateTimeKind.Local).AddTicks(2045) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 10, 22, 1, 51, 335, DateTimeKind.Local).AddTicks(1854), new DateTime(2026, 7, 10, 22, 1, 51, 335, DateTimeKind.Local).AddTicks(1866) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 10, 22, 1, 51, 335, DateTimeKind.Local).AddTicks(1947), new DateTime(2026, 7, 10, 22, 1, 51, 335, DateTimeKind.Local).AddTicks(1948) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 10, 22, 1, 51, 335, DateTimeKind.Local).AddTicks(1958), new DateTime(2026, 7, 10, 22, 1, 51, 335, DateTimeKind.Local).AddTicks(1958) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 10, 22, 1, 51, 335, DateTimeKind.Local).AddTicks(1961), new DateTime(2026, 7, 10, 22, 1, 51, 335, DateTimeKind.Local).AddTicks(1961) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("55555555-5555-5555-5555-555555555555"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 10, 22, 1, 51, 335, DateTimeKind.Local).AddTicks(1964), new DateTime(2026, 7, 10, 22, 1, 51, 335, DateTimeKind.Local).AddTicks(1964) });

            migrationBuilder.CreateIndex(
                name: "IX_PasswordResetTokens_UserId",
                table: "PasswordResetTokens",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "UQ__Password__1EB4F8175944EB96",
                table: "PasswordResetTokens",
                column: "Token",
                unique: true);
        }
    }
}
