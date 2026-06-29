using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedUsersData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Avatar", "CreatedAt", "CreatedBy", "DateOfBirth", "Email", "FullName", "Gender", "IsActive", "IsDeleted", "LastUpdatedAt", "LastUpdatedBy", "Password", "Phone", "UpdatedBy", "Username" },
                values: new object[,]
                {
                    { new Guid("11111111-1111-1111-1111-111111111111"), null, new DateTime(2026, 6, 29, 10, 34, 34, 627, DateTimeKind.Local).AddTicks(759), null, null, "admin@elms.com", "System Admin", null, true, false, new DateTime(2026, 6, 29, 10, 34, 34, 627, DateTimeKind.Local).AddTicks(773), null, "$2a$11$3HXCJnYevNW8Awmlq9VfIengAG7omtmw85UBxJAAYLmNTjatfD6Zy", null, null, "admin" },
                    { new Guid("22222222-2222-2222-2222-222222222222"), null, new DateTime(2026, 6, 29, 10, 34, 34, 627, DateTimeKind.Local).AddTicks(860), null, null, "student@elms.com", "Sample Student", null, true, false, new DateTime(2026, 6, 29, 10, 34, 34, 627, DateTimeKind.Local).AddTicks(860), null, "$2a$11$3HXCJnYevNW8Awmlq9VfIengAG7omtmw85UBxJAAYLmNTjatfD6Zy", null, null, "student" },
                    { new Guid("33333333-3333-3333-3333-333333333333"), null, new DateTime(2026, 6, 29, 10, 34, 34, 627, DateTimeKind.Local).AddTicks(865), null, null, "parent@elms.com", "Sample Parent", null, true, false, new DateTime(2026, 6, 29, 10, 34, 34, 627, DateTimeKind.Local).AddTicks(865), null, "$2a$11$3HXCJnYevNW8Awmlq9VfIengAG7omtmw85UBxJAAYLmNTjatfD6Zy", null, null, "parent" },
                    { new Guid("44444444-4444-4444-4444-444444444444"), null, new DateTime(2026, 6, 29, 10, 34, 34, 627, DateTimeKind.Local).AddTicks(869), null, null, "teacher@elms.com", "Sample Teacher", null, true, false, new DateTime(2026, 6, 29, 10, 34, 34, 627, DateTimeKind.Local).AddTicks(869), null, "$2a$11$3HXCJnYevNW8Awmlq9VfIengAG7omtmw85UBxJAAYLmNTjatfD6Zy", null, null, "teacher" },
                    { new Guid("55555555-5555-5555-5555-555555555555"), null, new DateTime(2026, 6, 29, 10, 34, 34, 627, DateTimeKind.Local).AddTicks(872), null, null, "manager@elms.com", "Sample Manager", null, true, false, new DateTime(2026, 6, 29, 10, 34, 34, 627, DateTimeKind.Local).AddTicks(873), null, "$2a$11$3HXCJnYevNW8Awmlq9VfIengAG7omtmw85UBxJAAYLmNTjatfD6Zy", null, null, "manager" }
                });

            migrationBuilder.InsertData(
                table: "InstructorProfile",
                columns: new[] { "Id", "Bio", "CreatedAt", "CreatedBy", "Expertise", "LastUpdatedAt", "LastUpdatedBy", "Qualifications", "UpdatedBy" },
                values: new object[] { new Guid("44444444-4444-4444-4444-444444444444"), "Experienced Teacher", new DateTime(2026, 6, 29, 10, 34, 34, 627, DateTimeKind.Local).AddTicks(1188), null, "Software Engineering", new DateTime(2026, 6, 29, 10, 34, 34, 627, DateTimeKind.Local).AddTicks(1189), null, "PhD", null });

            migrationBuilder.InsertData(
                table: "ManagerProfile",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "LastUpdatedAt", "LastUpdatedBy", "Position", "Specialization", "UpdatedBy" },
                values: new object[] { new Guid("55555555-5555-5555-5555-555555555555"), new DateTime(2026, 6, 29, 10, 34, 34, 627, DateTimeKind.Local).AddTicks(1246), null, new DateTime(2026, 6, 29, 10, 34, 34, 627, DateTimeKind.Local).AddTicks(1247), null, "Academic Head", "Operations", null });

            migrationBuilder.InsertData(
                table: "ParentProfile",
                columns: new[] { "Id", "Address", "CreatedAt", "CreatedBy", "LastUpdatedAt", "LastUpdatedBy", "Occupation", "UpdatedBy" },
                values: new object[] { new Guid("33333333-3333-3333-3333-333333333333"), "Hanoi", new DateTime(2026, 6, 29, 10, 34, 34, 627, DateTimeKind.Local).AddTicks(1124), null, new DateTime(2026, 6, 29, 10, 34, 34, 627, DateTimeKind.Local).AddTicks(1125), null, "Engineer", null });

            migrationBuilder.InsertData(
                table: "StudentProfile",
                columns: new[] { "Id", "Address", "CreatedAt", "CreatedBy", "GradeLevel", "Institution", "LastUpdatedAt", "LastUpdatedBy", "ParentId", "UpdatedBy" },
                values: new object[] { new Guid("22222222-2222-2222-2222-222222222222"), "Hoa Lac", new DateTime(2026, 6, 29, 10, 34, 34, 627, DateTimeKind.Local).AddTicks(1051), null, "University", "FPT University", new DateTime(2026, 6, 29, 10, 34, 34, 627, DateTimeKind.Local).AddTicks(1053), null, null, null });

            migrationBuilder.InsertData(
                table: "p_user_role",
                columns: new[] { "role_id", "user_id" },
                values: new object[,]
                {
                    { 1, new Guid("11111111-1111-1111-1111-111111111111") },
                    { 2, new Guid("22222222-2222-2222-2222-222222222222") },
                    { 3, new Guid("33333333-3333-3333-3333-333333333333") },
                    { 4, new Guid("44444444-4444-4444-4444-444444444444") },
                    { 5, new Guid("55555555-5555-5555-5555-555555555555") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "InstructorProfile",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"));

            migrationBuilder.DeleteData(
                table: "ManagerProfile",
                keyColumn: "Id",
                keyValue: new Guid("55555555-5555-5555-5555-555555555555"));

            migrationBuilder.DeleteData(
                table: "ParentProfile",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"));

            migrationBuilder.DeleteData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"));

            migrationBuilder.DeleteData(
                table: "p_user_role",
                keyColumns: new[] { "role_id", "user_id" },
                keyValues: new object[] { 1, new Guid("11111111-1111-1111-1111-111111111111") });

            migrationBuilder.DeleteData(
                table: "p_user_role",
                keyColumns: new[] { "role_id", "user_id" },
                keyValues: new object[] { 2, new Guid("22222222-2222-2222-2222-222222222222") });

            migrationBuilder.DeleteData(
                table: "p_user_role",
                keyColumns: new[] { "role_id", "user_id" },
                keyValues: new object[] { 3, new Guid("33333333-3333-3333-3333-333333333333") });

            migrationBuilder.DeleteData(
                table: "p_user_role",
                keyColumns: new[] { "role_id", "user_id" },
                keyValues: new object[] { 4, new Guid("44444444-4444-4444-4444-444444444444") });

            migrationBuilder.DeleteData(
                table: "p_user_role",
                keyColumns: new[] { "role_id", "user_id" },
                keyValues: new object[] { 5, new Guid("55555555-5555-5555-5555-555555555555") });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("55555555-5555-5555-5555-555555555555"));
        }
    }
}
