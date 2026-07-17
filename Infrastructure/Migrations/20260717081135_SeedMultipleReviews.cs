using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedMultipleReviews : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Description", "Name", "Picture" },
                values: new object[] { 999, "Learn English Grammar", "English Grammar", "grammar.jpg" });

            migrationBuilder.UpdateData(
                table: "ParentProfile",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(7572), new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(7573) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(7530), new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(7531) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(7289), new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(7303) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(7404), new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(7404) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(7408), new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(7409) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(7411), new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(7412) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("55555555-5555-5555-5555-555555555555"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(7414), new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(7415) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666666"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(7417), new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(7418) });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Avatar", "CreatedAt", "CreatedBy", "DateOfBirth", "Email", "FullName", "Gender", "IsActive", "IsDeleted", "LastUpdatedAt", "LastUpdatedBy", "Password", "Phone", "UpdatedBy", "Username" },
                values: new object[,]
                {
                    { new Guid("22222222-2222-2222-2222-000000000001"), null, new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8074), null, null, "student1@elms.com", "Test Student 1", null, true, false, new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8074), null, "$2a$11$3HXCJnYevNW8Awmlq9VfIengAG7omtmw85UBxJAAYLmNTjatfD6Zy", null, null, "student1" },
                    { new Guid("22222222-2222-2222-2222-000000000002"), null, new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8145), null, null, "student2@elms.com", "Test Student 2", null, true, false, new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8146), null, "$2a$11$3HXCJnYevNW8Awmlq9VfIengAG7omtmw85UBxJAAYLmNTjatfD6Zy", null, null, "student2" },
                    { new Guid("22222222-2222-2222-2222-000000000003"), null, new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8164), null, null, "student3@elms.com", "Test Student 3", null, true, false, new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8164), null, "$2a$11$3HXCJnYevNW8Awmlq9VfIengAG7omtmw85UBxJAAYLmNTjatfD6Zy", null, null, "student3" },
                    { new Guid("22222222-2222-2222-2222-000000000004"), null, new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8180), null, null, "student4@elms.com", "Test Student 4", null, true, false, new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8181), null, "$2a$11$3HXCJnYevNW8Awmlq9VfIengAG7omtmw85UBxJAAYLmNTjatfD6Zy", null, null, "student4" },
                    { new Guid("22222222-2222-2222-2222-000000000005"), null, new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8206), null, null, "student5@elms.com", "Test Student 5", null, true, false, new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8207), null, "$2a$11$3HXCJnYevNW8Awmlq9VfIengAG7omtmw85UBxJAAYLmNTjatfD6Zy", null, null, "student5" },
                    { new Guid("22222222-2222-2222-2222-000000000006"), null, new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8228), null, null, "student6@elms.com", "Test Student 6", null, true, false, new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8228), null, "$2a$11$3HXCJnYevNW8Awmlq9VfIengAG7omtmw85UBxJAAYLmNTjatfD6Zy", null, null, "student6" },
                    { new Guid("22222222-2222-2222-2222-000000000007"), null, new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8246), null, null, "student7@elms.com", "Test Student 7", null, true, false, new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8246), null, "$2a$11$3HXCJnYevNW8Awmlq9VfIengAG7omtmw85UBxJAAYLmNTjatfD6Zy", null, null, "student7" },
                    { new Guid("22222222-2222-2222-2222-000000000008"), null, new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8263), null, null, "student8@elms.com", "Test Student 8", null, true, false, new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8263), null, "$2a$11$3HXCJnYevNW8Awmlq9VfIengAG7omtmw85UBxJAAYLmNTjatfD6Zy", null, null, "student8" },
                    { new Guid("22222222-2222-2222-2222-000000000009"), null, new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8279), null, null, "student9@elms.com", "Test Student 9", null, true, false, new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8280), null, "$2a$11$3HXCJnYevNW8Awmlq9VfIengAG7omtmw85UBxJAAYLmNTjatfD6Zy", null, null, "student9" },
                    { new Guid("22222222-2222-2222-2222-000000000010"), null, new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8313), null, null, "student10@elms.com", "Test Student 10", null, true, false, new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8314), null, "$2a$11$3HXCJnYevNW8Awmlq9VfIengAG7omtmw85UBxJAAYLmNTjatfD6Zy", null, null, "student10" },
                    { new Guid("22222222-2222-2222-2222-000000000011"), null, new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8330), null, null, "student11@elms.com", "Test Student 11", null, true, false, new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8330), null, "$2a$11$3HXCJnYevNW8Awmlq9VfIengAG7omtmw85UBxJAAYLmNTjatfD6Zy", null, null, "student11" },
                    { new Guid("22222222-2222-2222-2222-000000000012"), null, new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8346), null, null, "student12@elms.com", "Test Student 12", null, true, false, new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8346), null, "$2a$11$3HXCJnYevNW8Awmlq9VfIengAG7omtmw85UBxJAAYLmNTjatfD6Zy", null, null, "student12" },
                    { new Guid("22222222-2222-2222-2222-000000000013"), null, new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8364), null, null, "student13@elms.com", "Test Student 13", null, true, false, new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8364), null, "$2a$11$3HXCJnYevNW8Awmlq9VfIengAG7omtmw85UBxJAAYLmNTjatfD6Zy", null, null, "student13" },
                    { new Guid("22222222-2222-2222-2222-000000000014"), null, new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8388), null, null, "student14@elms.com", "Test Student 14", null, true, false, new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8389), null, "$2a$11$3HXCJnYevNW8Awmlq9VfIengAG7omtmw85UBxJAAYLmNTjatfD6Zy", null, null, "student14" },
                    { new Guid("22222222-2222-2222-2222-000000000015"), null, new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8407), null, null, "student15@elms.com", "Test Student 15", null, true, false, new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8407), null, "$2a$11$3HXCJnYevNW8Awmlq9VfIengAG7omtmw85UBxJAAYLmNTjatfD6Zy", null, null, "student15" },
                    { new Guid("22222222-2222-2222-2222-000000000016"), null, new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8423), null, null, "student16@elms.com", "Test Student 16", null, true, false, new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8424), null, "$2a$11$3HXCJnYevNW8Awmlq9VfIengAG7omtmw85UBxJAAYLmNTjatfD6Zy", null, null, "student16" },
                    { new Guid("22222222-2222-2222-2222-000000000017"), null, new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8438), null, null, "student17@elms.com", "Test Student 17", null, true, false, new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8439), null, "$2a$11$3HXCJnYevNW8Awmlq9VfIengAG7omtmw85UBxJAAYLmNTjatfD6Zy", null, null, "student17" },
                    { new Guid("22222222-2222-2222-2222-000000000018"), null, new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8471), null, null, "student18@elms.com", "Test Student 18", null, true, false, new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8472), null, "$2a$11$3HXCJnYevNW8Awmlq9VfIengAG7omtmw85UBxJAAYLmNTjatfD6Zy", null, null, "student18" },
                    { new Guid("22222222-2222-2222-2222-000000000019"), null, new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8488), null, null, "student19@elms.com", "Test Student 19", null, true, false, new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8489), null, "$2a$11$3HXCJnYevNW8Awmlq9VfIengAG7omtmw85UBxJAAYLmNTjatfD6Zy", null, null, "student19" },
                    { new Guid("22222222-2222-2222-2222-000000000020"), null, new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8504), null, null, "student20@elms.com", "Test Student 20", null, true, false, new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8504), null, "$2a$11$3HXCJnYevNW8Awmlq9VfIengAG7omtmw85UBxJAAYLmNTjatfD6Zy", null, null, "student20" }
                });

            migrationBuilder.InsertData(
                table: "Course",
                columns: new[] { "Id", "CategoryId", "CreatedAt", "CreatedBy", "Description", "IsDeleted", "Language", "LastUpdatedAt", "LastUpdatedBy", "Level", "PublishAt", "Status", "Thumbnail", "Title", "UpdatedAt", "UpdatedBy" },
                values: new object[] { new Guid("88888888-8888-8888-8888-888888888888"), 999, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("44444444-4444-4444-4444-444444444444"), null, false, "English", new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(7937), null, "Beginner", null, (byte)5, "tenses.jpg", "Tenses Made Easy", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null });

            migrationBuilder.InsertData(
                table: "StudentProfile",
                columns: new[] { "Id", "Address", "CreatedAt", "CreatedBy", "GradeLevel", "Institution", "LastUpdatedAt", "LastUpdatedBy", "ParentId", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("22222222-2222-2222-2222-000000000001"), "Hanoi", new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8093), null, "University", "FPT", new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8093), null, null, null },
                    { new Guid("22222222-2222-2222-2222-000000000002"), "Hanoi", new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8153), null, "University", "FPT", new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8153), null, null, null },
                    { new Guid("22222222-2222-2222-2222-000000000003"), "Hanoi", new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8170), null, "University", "FPT", new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8170), null, null, null },
                    { new Guid("22222222-2222-2222-2222-000000000004"), "Hanoi", new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8189), null, "University", "FPT", new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8189), null, null, null },
                    { new Guid("22222222-2222-2222-2222-000000000005"), "Hanoi", new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8216), null, "University", "FPT", new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8216), null, null, null },
                    { new Guid("22222222-2222-2222-2222-000000000006"), "Hanoi", new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8234), null, "University", "FPT", new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8235), null, null, null },
                    { new Guid("22222222-2222-2222-2222-000000000007"), "Hanoi", new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8253), null, "University", "FPT", new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8253), null, null, null },
                    { new Guid("22222222-2222-2222-2222-000000000008"), "Hanoi", new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8269), null, "University", "FPT", new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8269), null, null, null },
                    { new Guid("22222222-2222-2222-2222-000000000009"), "Hanoi", new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8297), null, "University", "FPT", new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8297), null, null, null },
                    { new Guid("22222222-2222-2222-2222-000000000010"), "Hanoi", new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8320), null, "University", "FPT", new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8321), null, null, null },
                    { new Guid("22222222-2222-2222-2222-000000000011"), "Hanoi", new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8336), null, "University", "FPT", new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8337), null, null, null },
                    { new Guid("22222222-2222-2222-2222-000000000012"), "Hanoi", new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8354), null, "University", "FPT", new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8354), null, null, null },
                    { new Guid("22222222-2222-2222-2222-000000000013"), "Hanoi", new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8370), null, "University", "FPT", new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8371), null, null, null },
                    { new Guid("22222222-2222-2222-2222-000000000014"), "Hanoi", new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8395), null, "University", "FPT", new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8396), null, null, null },
                    { new Guid("22222222-2222-2222-2222-000000000015"), "Hanoi", new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8414), null, "University", "FPT", new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8414), null, null, null },
                    { new Guid("22222222-2222-2222-2222-000000000016"), "Hanoi", new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8429), null, "University", "FPT", new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8430), null, null, null },
                    { new Guid("22222222-2222-2222-2222-000000000017"), "Hanoi", new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8447), null, "University", "FPT", new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8447), null, null, null },
                    { new Guid("22222222-2222-2222-2222-000000000018"), "Hanoi", new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8478), null, "University", "FPT", new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8478), null, null, null },
                    { new Guid("22222222-2222-2222-2222-000000000019"), "Hanoi", new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8494), null, "University", "FPT", new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8495), null, null, null },
                    { new Guid("22222222-2222-2222-2222-000000000020"), "Hanoi", new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8512), null, "University", "FPT", new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8513), null, null, null }
                });

            migrationBuilder.InsertData(
                table: "p_user_role",
                columns: new[] { "role_id", "user_id" },
                values: new object[,]
                {
                    { 2, new Guid("22222222-2222-2222-2222-000000000001") },
                    { 2, new Guid("22222222-2222-2222-2222-000000000002") },
                    { 2, new Guid("22222222-2222-2222-2222-000000000003") },
                    { 2, new Guid("22222222-2222-2222-2222-000000000004") },
                    { 2, new Guid("22222222-2222-2222-2222-000000000005") },
                    { 2, new Guid("22222222-2222-2222-2222-000000000006") },
                    { 2, new Guid("22222222-2222-2222-2222-000000000007") },
                    { 2, new Guid("22222222-2222-2222-2222-000000000008") },
                    { 2, new Guid("22222222-2222-2222-2222-000000000009") },
                    { 2, new Guid("22222222-2222-2222-2222-000000000010") },
                    { 2, new Guid("22222222-2222-2222-2222-000000000011") },
                    { 2, new Guid("22222222-2222-2222-2222-000000000012") },
                    { 2, new Guid("22222222-2222-2222-2222-000000000013") },
                    { 2, new Guid("22222222-2222-2222-2222-000000000014") },
                    { 2, new Guid("22222222-2222-2222-2222-000000000015") },
                    { 2, new Guid("22222222-2222-2222-2222-000000000016") },
                    { 2, new Guid("22222222-2222-2222-2222-000000000017") },
                    { 2, new Guid("22222222-2222-2222-2222-000000000018") },
                    { 2, new Guid("22222222-2222-2222-2222-000000000019") },
                    { 2, new Guid("22222222-2222-2222-2222-000000000020") }
                });

            migrationBuilder.InsertData(
                table: "Enrollments",
                columns: new[] { "Id", "CompletedAt", "CourseId", "EnrolledAt", "Status", "StudentId" },
                values: new object[,]
                {
                    { new Guid("99999999-9999-9999-9999-000000000001"), new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("88888888-8888-8888-8888-888888888888"), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), (byte)2, new Guid("22222222-2222-2222-2222-000000000001") },
                    { new Guid("99999999-9999-9999-9999-000000000002"), new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("88888888-8888-8888-8888-888888888888"), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), (byte)2, new Guid("22222222-2222-2222-2222-000000000002") },
                    { new Guid("99999999-9999-9999-9999-000000000003"), new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("88888888-8888-8888-8888-888888888888"), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), (byte)2, new Guid("22222222-2222-2222-2222-000000000003") },
                    { new Guid("99999999-9999-9999-9999-000000000004"), new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("88888888-8888-8888-8888-888888888888"), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), (byte)2, new Guid("22222222-2222-2222-2222-000000000004") },
                    { new Guid("99999999-9999-9999-9999-000000000005"), new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("88888888-8888-8888-8888-888888888888"), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), (byte)2, new Guid("22222222-2222-2222-2222-000000000005") },
                    { new Guid("99999999-9999-9999-9999-000000000006"), new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("88888888-8888-8888-8888-888888888888"), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), (byte)2, new Guid("22222222-2222-2222-2222-000000000006") },
                    { new Guid("99999999-9999-9999-9999-000000000007"), new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("88888888-8888-8888-8888-888888888888"), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), (byte)2, new Guid("22222222-2222-2222-2222-000000000007") },
                    { new Guid("99999999-9999-9999-9999-000000000008"), new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("88888888-8888-8888-8888-888888888888"), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), (byte)2, new Guid("22222222-2222-2222-2222-000000000008") },
                    { new Guid("99999999-9999-9999-9999-000000000009"), new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("88888888-8888-8888-8888-888888888888"), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), (byte)2, new Guid("22222222-2222-2222-2222-000000000009") },
                    { new Guid("99999999-9999-9999-9999-000000000010"), new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("88888888-8888-8888-8888-888888888888"), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), (byte)2, new Guid("22222222-2222-2222-2222-000000000010") },
                    { new Guid("99999999-9999-9999-9999-000000000011"), new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("88888888-8888-8888-8888-888888888888"), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), (byte)2, new Guid("22222222-2222-2222-2222-000000000011") },
                    { new Guid("99999999-9999-9999-9999-000000000012"), new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("88888888-8888-8888-8888-888888888888"), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), (byte)2, new Guid("22222222-2222-2222-2222-000000000012") },
                    { new Guid("99999999-9999-9999-9999-000000000013"), new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("88888888-8888-8888-8888-888888888888"), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), (byte)2, new Guid("22222222-2222-2222-2222-000000000013") },
                    { new Guid("99999999-9999-9999-9999-000000000014"), new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("88888888-8888-8888-8888-888888888888"), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), (byte)2, new Guid("22222222-2222-2222-2222-000000000014") },
                    { new Guid("99999999-9999-9999-9999-000000000015"), new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("88888888-8888-8888-8888-888888888888"), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), (byte)2, new Guid("22222222-2222-2222-2222-000000000015") },
                    { new Guid("99999999-9999-9999-9999-000000000016"), new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("88888888-8888-8888-8888-888888888888"), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), (byte)2, new Guid("22222222-2222-2222-2222-000000000016") },
                    { new Guid("99999999-9999-9999-9999-000000000017"), new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("88888888-8888-8888-8888-888888888888"), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), (byte)2, new Guid("22222222-2222-2222-2222-000000000017") },
                    { new Guid("99999999-9999-9999-9999-000000000018"), new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("88888888-8888-8888-8888-888888888888"), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), (byte)2, new Guid("22222222-2222-2222-2222-000000000018") },
                    { new Guid("99999999-9999-9999-9999-000000000019"), new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("88888888-8888-8888-8888-888888888888"), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), (byte)2, new Guid("22222222-2222-2222-2222-000000000019") },
                    { new Guid("99999999-9999-9999-9999-000000000020"), new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("88888888-8888-8888-8888-888888888888"), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), (byte)2, new Guid("22222222-2222-2222-2222-000000000020") }
                });

            migrationBuilder.InsertData(
                table: "Reviews",
                columns: new[] { "Id", "Comment", "CourseId", "CreatedAt", "CreatedBy", "LastUpdatedAt", "LastUpdatedBy", "Rating", "StudentId", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("10000000-0000-0000-0000-000000000001"), "Bài tập có độ khó tăng dần, tốc độ hợp lý, không bị nặng nề.", new Guid("88888888-8888-8888-8888-888888888888"), new DateTime(2024, 1, 15, 1, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8127), null, (byte)5, new Guid("22222222-2222-2222-2222-000000000001"), new DateTime(2024, 1, 15, 1, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("10000000-0000-0000-0000-000000000002"), "Mini-test cuối mỗi mục phản hồi rõ ràng để biết mình đang thiếu chỗ nào.", new Guid("88888888-8888-8888-8888-888888888888"), new DateTime(2024, 1, 15, 2, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8158), null, (byte)4, new Guid("22222222-2222-2222-2222-000000000002"), new DateTime(2024, 1, 15, 2, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("10000000-0000-0000-0000-000000000003"), "Cân bằng tốt giữa video, reading và drill; học không bị chán. Ước gì có thêm cheat sheet.", new Guid("88888888-8888-8888-8888-888888888888"), new DateTime(2024, 1, 15, 3, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8175), null, (byte)4, new Guid("22222222-2222-2222-2222-000000000003"), new DateTime(2024, 1, 15, 3, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("10000000-0000-0000-0000-000000000004"), "Trước đây mình hay rối Present Perfect, giờ đã hiểu logic since/for.", new Guid("88888888-8888-8888-8888-888888888888"), new DateTime(2024, 1, 15, 4, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8194), null, (byte)2, new Guid("22222222-2222-2222-2222-000000000004"), new DateTime(2024, 1, 15, 4, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("10000000-0000-0000-0000-000000000005"), "Rất hữu ích cho người mất gốc như mình.", new Guid("88888888-8888-8888-8888-888888888888"), new DateTime(2024, 1, 15, 5, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8222), null, (byte)2, new Guid("22222222-2222-2222-2222-000000000005"), new DateTime(2024, 1, 15, 5, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("10000000-0000-0000-0000-000000000006"), "Khóa học khá khó, giảng viên nói hơi nhanh.", new Guid("88888888-8888-8888-8888-888888888888"), new DateTime(2024, 1, 15, 6, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8239), null, (byte)5, new Guid("22222222-2222-2222-2222-000000000006"), new DateTime(2024, 1, 15, 6, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("10000000-0000-0000-0000-000000000007"), "Khóa học khá khó, giảng viên nói hơi nhanh.", new Guid("88888888-8888-8888-8888-888888888888"), new DateTime(2024, 1, 15, 7, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8258), null, (byte)2, new Guid("22222222-2222-2222-2222-000000000007"), new DateTime(2024, 1, 15, 7, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("10000000-0000-0000-0000-000000000008"), "Mini-test cuối mỗi mục phản hồi rõ ràng để biết mình đang thiếu chỗ nào.", new Guid("88888888-8888-8888-8888-888888888888"), new DateTime(2024, 1, 15, 8, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8274), null, (byte)2, new Guid("22222222-2222-2222-2222-000000000008"), new DateTime(2024, 1, 15, 8, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("10000000-0000-0000-0000-000000000009"), "Bài luyện thi rất thực tế, mình nắm rõ hơn cách dùng các thì.", new Guid("88888888-8888-8888-8888-888888888888"), new DateTime(2024, 1, 15, 9, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8305), null, (byte)4, new Guid("22222222-2222-2222-2222-000000000009"), new DateTime(2024, 1, 15, 9, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("10000000-0000-0000-0000-000000000010"), "Bài tập có độ khó tăng dần, tốc độ hợp lý, không bị nặng nề.", new Guid("88888888-8888-8888-8888-888888888888"), new DateTime(2024, 1, 15, 10, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8325), null, (byte)2, new Guid("22222222-2222-2222-2222-000000000010"), new DateTime(2024, 1, 15, 10, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("10000000-0000-0000-0000-000000000011"), "Cân bằng tốt giữa video, reading và drill; học không bị chán. Ước gì có thêm cheat sheet.", new Guid("88888888-8888-8888-8888-888888888888"), new DateTime(2024, 1, 15, 11, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8341), null, (byte)2, new Guid("22222222-2222-2222-2222-000000000011"), new DateTime(2024, 1, 15, 11, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("10000000-0000-0000-0000-000000000012"), "Cân bằng tốt giữa video, reading và drill; học không bị chán. Ước gì có thêm cheat sheet.", new Guid("88888888-8888-8888-8888-888888888888"), new DateTime(2024, 1, 15, 12, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8359), null, (byte)5, new Guid("22222222-2222-2222-2222-000000000012"), new DateTime(2024, 1, 15, 12, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("10000000-0000-0000-0000-000000000013"), "Rất hữu ích cho người mất gốc như mình.", new Guid("88888888-8888-8888-8888-888888888888"), new DateTime(2024, 1, 15, 13, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8375), null, (byte)5, new Guid("22222222-2222-2222-2222-000000000013"), new DateTime(2024, 1, 15, 13, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("10000000-0000-0000-0000-000000000014"), "Mini-test cuối mỗi mục phản hồi rõ ràng để biết mình đang thiếu chỗ nào.", new Guid("88888888-8888-8888-8888-888888888888"), new DateTime(2024, 1, 15, 14, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8400), null, (byte)4, new Guid("22222222-2222-2222-2222-000000000014"), new DateTime(2024, 1, 15, 14, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("10000000-0000-0000-0000-000000000015"), "Trước đây mình hay rối Present Perfect, giờ đã hiểu logic since/for.", new Guid("88888888-8888-8888-8888-888888888888"), new DateTime(2024, 1, 15, 15, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8418), null, (byte)4, new Guid("22222222-2222-2222-2222-000000000015"), new DateTime(2024, 1, 15, 15, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("10000000-0000-0000-0000-000000000016"), "Mini-test cuối mỗi mục phản hồi rõ ràng để biết mình đang thiếu chỗ nào.", new Guid("88888888-8888-8888-8888-888888888888"), new DateTime(2024, 1, 15, 16, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8434), null, (byte)4, new Guid("22222222-2222-2222-2222-000000000016"), new DateTime(2024, 1, 15, 16, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("10000000-0000-0000-0000-000000000017"), "Cân bằng tốt giữa video, reading và drill; học không bị chán. Ước gì có thêm cheat sheet.", new Guid("88888888-8888-8888-8888-888888888888"), new DateTime(2024, 1, 15, 17, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8455), null, (byte)5, new Guid("22222222-2222-2222-2222-000000000017"), new DateTime(2024, 1, 15, 17, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("10000000-0000-0000-0000-000000000018"), "Cân bằng tốt giữa video, reading và drill; học không bị chán. Ước gì có thêm cheat sheet.", new Guid("88888888-8888-8888-8888-888888888888"), new DateTime(2024, 1, 15, 18, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8483), null, (byte)4, new Guid("22222222-2222-2222-2222-000000000018"), new DateTime(2024, 1, 15, 18, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("10000000-0000-0000-0000-000000000019"), "Bài luyện thi rất thực tế, mình nắm rõ hơn cách dùng các thì.", new Guid("88888888-8888-8888-8888-888888888888"), new DateTime(2024, 1, 15, 19, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8499), null, (byte)5, new Guid("22222222-2222-2222-2222-000000000019"), new DateTime(2024, 1, 15, 19, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("10000000-0000-0000-0000-000000000020"), "Giáo viên vui tính, tài liệu đầy đủ.", new Guid("88888888-8888-8888-8888-888888888888"), new DateTime(2024, 1, 15, 20, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2026, 7, 17, 15, 11, 33, 220, DateTimeKind.Local).AddTicks(8517), null, (byte)3, new Guid("22222222-2222-2222-2222-000000000020"), new DateTime(2024, 1, 15, 20, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: new Guid("99999999-9999-9999-9999-000000000001"));

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: new Guid("99999999-9999-9999-9999-000000000002"));

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: new Guid("99999999-9999-9999-9999-000000000003"));

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: new Guid("99999999-9999-9999-9999-000000000004"));

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: new Guid("99999999-9999-9999-9999-000000000005"));

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: new Guid("99999999-9999-9999-9999-000000000006"));

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: new Guid("99999999-9999-9999-9999-000000000007"));

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: new Guid("99999999-9999-9999-9999-000000000008"));

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: new Guid("99999999-9999-9999-9999-000000000009"));

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: new Guid("99999999-9999-9999-9999-000000000010"));

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: new Guid("99999999-9999-9999-9999-000000000011"));

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: new Guid("99999999-9999-9999-9999-000000000012"));

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: new Guid("99999999-9999-9999-9999-000000000013"));

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: new Guid("99999999-9999-9999-9999-000000000014"));

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: new Guid("99999999-9999-9999-9999-000000000015"));

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: new Guid("99999999-9999-9999-9999-000000000016"));

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: new Guid("99999999-9999-9999-9999-000000000017"));

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: new Guid("99999999-9999-9999-9999-000000000018"));

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: new Guid("99999999-9999-9999-9999-000000000019"));

            migrationBuilder.DeleteData(
                table: "Enrollments",
                keyColumn: "Id",
                keyValue: new Guid("99999999-9999-9999-9999-000000000020"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000002"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000003"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000004"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000005"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000006"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000007"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000008"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000009"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000010"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000011"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000012"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000013"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000014"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000015"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000016"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000017"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000018"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000019"));

            migrationBuilder.DeleteData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000020"));

            migrationBuilder.DeleteData(
                table: "p_user_role",
                keyColumns: new[] { "role_id", "user_id" },
                keyValues: new object[] { 2, new Guid("22222222-2222-2222-2222-000000000001") });

            migrationBuilder.DeleteData(
                table: "p_user_role",
                keyColumns: new[] { "role_id", "user_id" },
                keyValues: new object[] { 2, new Guid("22222222-2222-2222-2222-000000000002") });

            migrationBuilder.DeleteData(
                table: "p_user_role",
                keyColumns: new[] { "role_id", "user_id" },
                keyValues: new object[] { 2, new Guid("22222222-2222-2222-2222-000000000003") });

            migrationBuilder.DeleteData(
                table: "p_user_role",
                keyColumns: new[] { "role_id", "user_id" },
                keyValues: new object[] { 2, new Guid("22222222-2222-2222-2222-000000000004") });

            migrationBuilder.DeleteData(
                table: "p_user_role",
                keyColumns: new[] { "role_id", "user_id" },
                keyValues: new object[] { 2, new Guid("22222222-2222-2222-2222-000000000005") });

            migrationBuilder.DeleteData(
                table: "p_user_role",
                keyColumns: new[] { "role_id", "user_id" },
                keyValues: new object[] { 2, new Guid("22222222-2222-2222-2222-000000000006") });

            migrationBuilder.DeleteData(
                table: "p_user_role",
                keyColumns: new[] { "role_id", "user_id" },
                keyValues: new object[] { 2, new Guid("22222222-2222-2222-2222-000000000007") });

            migrationBuilder.DeleteData(
                table: "p_user_role",
                keyColumns: new[] { "role_id", "user_id" },
                keyValues: new object[] { 2, new Guid("22222222-2222-2222-2222-000000000008") });

            migrationBuilder.DeleteData(
                table: "p_user_role",
                keyColumns: new[] { "role_id", "user_id" },
                keyValues: new object[] { 2, new Guid("22222222-2222-2222-2222-000000000009") });

            migrationBuilder.DeleteData(
                table: "p_user_role",
                keyColumns: new[] { "role_id", "user_id" },
                keyValues: new object[] { 2, new Guid("22222222-2222-2222-2222-000000000010") });

            migrationBuilder.DeleteData(
                table: "p_user_role",
                keyColumns: new[] { "role_id", "user_id" },
                keyValues: new object[] { 2, new Guid("22222222-2222-2222-2222-000000000011") });

            migrationBuilder.DeleteData(
                table: "p_user_role",
                keyColumns: new[] { "role_id", "user_id" },
                keyValues: new object[] { 2, new Guid("22222222-2222-2222-2222-000000000012") });

            migrationBuilder.DeleteData(
                table: "p_user_role",
                keyColumns: new[] { "role_id", "user_id" },
                keyValues: new object[] { 2, new Guid("22222222-2222-2222-2222-000000000013") });

            migrationBuilder.DeleteData(
                table: "p_user_role",
                keyColumns: new[] { "role_id", "user_id" },
                keyValues: new object[] { 2, new Guid("22222222-2222-2222-2222-000000000014") });

            migrationBuilder.DeleteData(
                table: "p_user_role",
                keyColumns: new[] { "role_id", "user_id" },
                keyValues: new object[] { 2, new Guid("22222222-2222-2222-2222-000000000015") });

            migrationBuilder.DeleteData(
                table: "p_user_role",
                keyColumns: new[] { "role_id", "user_id" },
                keyValues: new object[] { 2, new Guid("22222222-2222-2222-2222-000000000016") });

            migrationBuilder.DeleteData(
                table: "p_user_role",
                keyColumns: new[] { "role_id", "user_id" },
                keyValues: new object[] { 2, new Guid("22222222-2222-2222-2222-000000000017") });

            migrationBuilder.DeleteData(
                table: "p_user_role",
                keyColumns: new[] { "role_id", "user_id" },
                keyValues: new object[] { 2, new Guid("22222222-2222-2222-2222-000000000018") });

            migrationBuilder.DeleteData(
                table: "p_user_role",
                keyColumns: new[] { "role_id", "user_id" },
                keyValues: new object[] { 2, new Guid("22222222-2222-2222-2222-000000000019") });

            migrationBuilder.DeleteData(
                table: "p_user_role",
                keyColumns: new[] { "role_id", "user_id" },
                keyValues: new object[] { 2, new Guid("22222222-2222-2222-2222-000000000020") });

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("88888888-8888-8888-8888-888888888888"));

            migrationBuilder.DeleteData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000001"));

            migrationBuilder.DeleteData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000002"));

            migrationBuilder.DeleteData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000003"));

            migrationBuilder.DeleteData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000004"));

            migrationBuilder.DeleteData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000005"));

            migrationBuilder.DeleteData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000006"));

            migrationBuilder.DeleteData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000007"));

            migrationBuilder.DeleteData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000008"));

            migrationBuilder.DeleteData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000009"));

            migrationBuilder.DeleteData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000010"));

            migrationBuilder.DeleteData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000011"));

            migrationBuilder.DeleteData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000012"));

            migrationBuilder.DeleteData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000013"));

            migrationBuilder.DeleteData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000014"));

            migrationBuilder.DeleteData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000015"));

            migrationBuilder.DeleteData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000016"));

            migrationBuilder.DeleteData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000017"));

            migrationBuilder.DeleteData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000018"));

            migrationBuilder.DeleteData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000019"));

            migrationBuilder.DeleteData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000020"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 999);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000001"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000002"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000003"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000004"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000005"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000006"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000007"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000008"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000009"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000010"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000011"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000012"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000013"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000014"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000015"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000016"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000017"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000018"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000019"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000020"));

            migrationBuilder.UpdateData(
                table: "ParentProfile",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 15, 10, 42, 12, 398, DateTimeKind.Local).AddTicks(5629), new DateTime(2026, 7, 15, 10, 42, 12, 398, DateTimeKind.Local).AddTicks(5630) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 15, 10, 42, 12, 398, DateTimeKind.Local).AddTicks(5579), new DateTime(2026, 7, 15, 10, 42, 12, 398, DateTimeKind.Local).AddTicks(5580) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 15, 10, 42, 12, 398, DateTimeKind.Local).AddTicks(5299), new DateTime(2026, 7, 15, 10, 42, 12, 398, DateTimeKind.Local).AddTicks(5317) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 15, 10, 42, 12, 398, DateTimeKind.Local).AddTicks(5390), new DateTime(2026, 7, 15, 10, 42, 12, 398, DateTimeKind.Local).AddTicks(5390) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 15, 10, 42, 12, 398, DateTimeKind.Local).AddTicks(5396), new DateTime(2026, 7, 15, 10, 42, 12, 398, DateTimeKind.Local).AddTicks(5397) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 15, 10, 42, 12, 398, DateTimeKind.Local).AddTicks(5399), new DateTime(2026, 7, 15, 10, 42, 12, 398, DateTimeKind.Local).AddTicks(5400) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("55555555-5555-5555-5555-555555555555"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 15, 10, 42, 12, 398, DateTimeKind.Local).AddTicks(5403), new DateTime(2026, 7, 15, 10, 42, 12, 398, DateTimeKind.Local).AddTicks(5404) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666666"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 15, 10, 42, 12, 398, DateTimeKind.Local).AddTicks(5406), new DateTime(2026, 7, 15, 10, 42, 12, 398, DateTimeKind.Local).AddTicks(5407) });
        }
    }
}
