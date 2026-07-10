using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddFibo2Credential : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Fido2Credentials",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DescriptorId = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    PublicKey = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    UserHandle = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    SignatureCounter = table.Column<long>(type: "bigint", nullable: false),
                    CredType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AaGuid = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fido2Credentials", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Fido2Credential_User",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "InstructorProfile",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 30, 1, 27, 50, 305, DateTimeKind.Local).AddTicks(5577), new DateTime(2026, 6, 30, 1, 27, 50, 305, DateTimeKind.Local).AddTicks(5577) });

            migrationBuilder.UpdateData(
                table: "ManagerProfile",
                keyColumn: "Id",
                keyValue: new Guid("55555555-5555-5555-5555-555555555555"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 30, 1, 27, 50, 305, DateTimeKind.Local).AddTicks(5638), new DateTime(2026, 6, 30, 1, 27, 50, 305, DateTimeKind.Local).AddTicks(5639) });

            migrationBuilder.UpdateData(
                table: "ParentProfile",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 30, 1, 27, 50, 305, DateTimeKind.Local).AddTicks(5515), new DateTime(2026, 6, 30, 1, 27, 50, 305, DateTimeKind.Local).AddTicks(5515) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 30, 1, 27, 50, 305, DateTimeKind.Local).AddTicks(5444), new DateTime(2026, 6, 30, 1, 27, 50, 305, DateTimeKind.Local).AddTicks(5444) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 30, 1, 27, 50, 305, DateTimeKind.Local).AddTicks(5161), new DateTime(2026, 6, 30, 1, 27, 50, 305, DateTimeKind.Local).AddTicks(5178) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 30, 1, 27, 50, 305, DateTimeKind.Local).AddTicks(5225), new DateTime(2026, 6, 30, 1, 27, 50, 305, DateTimeKind.Local).AddTicks(5226) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 30, 1, 27, 50, 305, DateTimeKind.Local).AddTicks(5242), new DateTime(2026, 6, 30, 1, 27, 50, 305, DateTimeKind.Local).AddTicks(5243) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 30, 1, 27, 50, 305, DateTimeKind.Local).AddTicks(5261), new DateTime(2026, 6, 30, 1, 27, 50, 305, DateTimeKind.Local).AddTicks(5262) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("55555555-5555-5555-5555-555555555555"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 30, 1, 27, 50, 305, DateTimeKind.Local).AddTicks(5266), new DateTime(2026, 6, 30, 1, 27, 50, 305, DateTimeKind.Local).AddTicks(5266) });

            migrationBuilder.CreateIndex(
                name: "IX_Fido2Credentials_UserId",
                table: "Fido2Credentials",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Fido2Credentials");

            migrationBuilder.UpdateData(
                table: "InstructorProfile",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 29, 10, 34, 34, 627, DateTimeKind.Local).AddTicks(1188), new DateTime(2026, 6, 29, 10, 34, 34, 627, DateTimeKind.Local).AddTicks(1189) });

            migrationBuilder.UpdateData(
                table: "ManagerProfile",
                keyColumn: "Id",
                keyValue: new Guid("55555555-5555-5555-5555-555555555555"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 29, 10, 34, 34, 627, DateTimeKind.Local).AddTicks(1246), new DateTime(2026, 6, 29, 10, 34, 34, 627, DateTimeKind.Local).AddTicks(1247) });

            migrationBuilder.UpdateData(
                table: "ParentProfile",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 29, 10, 34, 34, 627, DateTimeKind.Local).AddTicks(1124), new DateTime(2026, 6, 29, 10, 34, 34, 627, DateTimeKind.Local).AddTicks(1125) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 29, 10, 34, 34, 627, DateTimeKind.Local).AddTicks(1051), new DateTime(2026, 6, 29, 10, 34, 34, 627, DateTimeKind.Local).AddTicks(1053) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 29, 10, 34, 34, 627, DateTimeKind.Local).AddTicks(759), new DateTime(2026, 6, 29, 10, 34, 34, 627, DateTimeKind.Local).AddTicks(773) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 29, 10, 34, 34, 627, DateTimeKind.Local).AddTicks(860), new DateTime(2026, 6, 29, 10, 34, 34, 627, DateTimeKind.Local).AddTicks(860) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 29, 10, 34, 34, 627, DateTimeKind.Local).AddTicks(865), new DateTime(2026, 6, 29, 10, 34, 34, 627, DateTimeKind.Local).AddTicks(865) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 29, 10, 34, 34, 627, DateTimeKind.Local).AddTicks(869), new DateTime(2026, 6, 29, 10, 34, 34, 627, DateTimeKind.Local).AddTicks(869) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("55555555-5555-5555-5555-555555555555"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 29, 10, 34, 34, 627, DateTimeKind.Local).AddTicks(872), new DateTime(2026, 6, 29, 10, 34, 34, 627, DateTimeKind.Local).AddTicks(873) });
        }
    }
}
