using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UpdateReadingLessonSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("88888888-8888-8888-8888-888888888888"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 18, 4, 49, 114, DateTimeKind.Local).AddTicks(9830));

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666602"),
                column: "TextContent",
                value: "\r\n<div class='reading-lesson'>\r\n    <h2 class='text-primary mb-4'>Mastering English Tenses: A Timeline Approach</h2>\r\n    \r\n    <p class='lead'>Understanding English tenses can be challenging, but visualizing them on a timeline makes it much easier to grasp when to use which tense.</p>\r\n    \r\n    <hr class='my-4' />\r\n\r\n    <h4 class='text-success'>1. The Past Tenses</h4>\r\n    <p>The past tenses deal with actions that have already concluded.</p>\r\n    <ul>\r\n        <li><b>Past Simple:</b> Actions that started and finished in the past. \r\n            <br/><span class='text-muted'>Example: \"I visited Paris last year.\"</span></li>\r\n        <li><b>Past Continuous:</b> Actions that were ongoing at a specific moment in the past.\r\n            <br/><span class='text-muted'>Example: \"I was watching TV when the phone rang.\"</span></li>\r\n    </ul>\r\n\r\n    <h4 class='text-primary mt-4'>2. The Present Tenses</h4>\r\n    <p>Present tenses connect the past to the present or describe current facts and routines.</p>\r\n    <ul>\r\n        <li><b>Present Simple:</b> Habits, routines, and universal truths.\r\n            <br/><span class='text-muted'>Example: \"The sun rises in the east.\"</span></li>\r\n        <li><b>Present Continuous:</b> Actions happening right now, at the moment of speaking.\r\n            <br/><span class='text-muted'>Example: \"I am studying English right now.\"</span></li>\r\n        <li><b>Present Perfect:</b> Actions that happened at an unspecified time in the past but have a result in the present.\r\n            <br/><span class='text-muted'>Example: \"I have lost my keys.\"</span></li>\r\n    </ul>\r\n\r\n    <h4 class='text-info mt-4'>3. The Future Tenses</h4>\r\n    <p>Future tenses look ahead to actions that have not yet occurred.</p>\r\n    <ul>\r\n        <li><b>Future Simple (Will):</b> Predictions, promises, or spontaneous decisions.\r\n            <br/><span class='text-muted'>Example: \"I think it will rain tomorrow.\"</span></li>\r\n        <li><b>Future Intentions (Going to):</b> Planned actions or predictions based on current evidence.\r\n            <br/><span class='text-muted'>Example: \"Look at those dark clouds! It is going to rain.\"</span></li>\r\n    </ul>\r\n\r\n    <div class='alert alert-warning mt-4'>\r\n        <strong>Pro Tip:</strong> Don't try to translate tenses word-for-word from your native language. Instead, try to understand the <em>concept</em> and the <em>timeframe</em> each English tense represents!\r\n    </div>\r\n</div>");

            migrationBuilder.UpdateData(
                table: "Module",
                keyColumn: "Id",
                keyValue: new Guid("77777777-7777-7777-7777-777777777777"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 18, 4, 49, 114, DateTimeKind.Local).AddTicks(9888), new DateTime(2026, 7, 18, 18, 4, 49, 114, DateTimeKind.Local).AddTicks(9888) });

            migrationBuilder.UpdateData(
                table: "ModuleItem",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666601"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 18, 4, 49, 114, DateTimeKind.Local).AddTicks(9947), new DateTime(2026, 7, 18, 18, 4, 49, 114, DateTimeKind.Local).AddTicks(9947) });

            migrationBuilder.UpdateData(
                table: "ModuleItem",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666602"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 18, 4, 49, 114, DateTimeKind.Local).AddTicks(9953), new DateTime(2026, 7, 18, 18, 4, 49, 114, DateTimeKind.Local).AddTicks(9953) });

            migrationBuilder.UpdateData(
                table: "ModuleItem",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666603"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 18, 4, 49, 114, DateTimeKind.Local).AddTicks(9956), new DateTime(2026, 7, 18, 18, 4, 49, 114, DateTimeKind.Local).AddTicks(9962) });

            migrationBuilder.UpdateData(
                table: "ModuleItem",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666604"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 18, 4, 49, 114, DateTimeKind.Local).AddTicks(9982), new DateTime(2026, 7, 18, 18, 4, 49, 114, DateTimeKind.Local).AddTicks(9982) });

            migrationBuilder.UpdateData(
                table: "ParentProfile",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 18, 4, 49, 114, DateTimeKind.Local).AddTicks(9359), new DateTime(2026, 7, 18, 18, 4, 49, 114, DateTimeKind.Local).AddTicks(9360) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000001"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(448));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000002"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(489));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000003"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(506));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000004"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(541));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000005"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(624));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000006"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(641));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000007"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(655));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000008"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(719));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000009"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(736));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000010"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(767));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000011"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(829));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000012"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(845));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000013"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(861));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000014"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(876));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000015"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(926));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000016"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(952));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000017"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(970));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000018"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(1026));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000019"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(1041));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000020"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(1057));

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000001"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(389), new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(389) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000002"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(481), new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(482) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000003"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(501), new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(502) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000004"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(536), new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(537) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000005"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(619), new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(620) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000006"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(636), new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(637) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000007"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(651), new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(652) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000008"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(715), new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(716) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000009"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(732), new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(732) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000010"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(752), new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(752) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000011"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(825), new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(825) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000012"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(841), new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(842) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000013"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(858), new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(858) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000014"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(872), new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(873) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000015"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(922), new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(923) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000016"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(948), new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(949) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000017"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(965), new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(965) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000018"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(1020), new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(1021) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000019"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(1037), new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(1038) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000020"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(1053), new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(1054) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 18, 4, 49, 114, DateTimeKind.Local).AddTicks(9305), new DateTime(2026, 7, 18, 18, 4, 49, 114, DateTimeKind.Local).AddTicks(9306) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 18, 4, 49, 114, DateTimeKind.Local).AddTicks(9087), new DateTime(2026, 7, 18, 18, 4, 49, 114, DateTimeKind.Local).AddTicks(9107) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000001"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(369), new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(370) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000002"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(475), new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(475) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000003"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(496), new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(496) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000004"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(531), new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(531) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000005"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(610), new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(611) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000006"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(631), new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(632) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000007"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(646), new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(646) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000008"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(709), new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(710) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000009"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(726), new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(726) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000010"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(747), new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(747) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000011"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(785), new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(785) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000012"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(836), new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(836) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000013"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(851), new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(851) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000014"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(867), new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(868) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000015"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(917), new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(918) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000016"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(943), new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(944) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000017"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(958), new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(959) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000018"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(1014), new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(1015) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000019"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(1032), new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(1033) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000020"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(1048), new DateTime(2026, 7, 18, 18, 4, 49, 115, DateTimeKind.Local).AddTicks(1048) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 18, 4, 49, 114, DateTimeKind.Local).AddTicks(9158), new DateTime(2026, 7, 18, 18, 4, 49, 114, DateTimeKind.Local).AddTicks(9158) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 18, 4, 49, 114, DateTimeKind.Local).AddTicks(9163), new DateTime(2026, 7, 18, 18, 4, 49, 114, DateTimeKind.Local).AddTicks(9164) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 18, 4, 49, 114, DateTimeKind.Local).AddTicks(9166), new DateTime(2026, 7, 18, 18, 4, 49, 114, DateTimeKind.Local).AddTicks(9167) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("55555555-5555-5555-5555-555555555555"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 18, 4, 49, 114, DateTimeKind.Local).AddTicks(9172), new DateTime(2026, 7, 18, 18, 4, 49, 114, DateTimeKind.Local).AddTicks(9173) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666666"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 18, 4, 49, 114, DateTimeKind.Local).AddTicks(9185), new DateTime(2026, 7, 18, 18, 4, 49, 114, DateTimeKind.Local).AddTicks(9185) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("88888888-8888-8888-8888-888888888888"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 17, 33, 38, 29, DateTimeKind.Local).AddTicks(9105));

            migrationBuilder.UpdateData(
                table: "Lesson",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666602"),
                column: "TextContent",
                value: "Tense Timelines content");

            migrationBuilder.UpdateData(
                table: "Module",
                keyColumn: "Id",
                keyValue: new Guid("77777777-7777-7777-7777-777777777777"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 17, 33, 38, 29, DateTimeKind.Local).AddTicks(9156), new DateTime(2026, 7, 18, 17, 33, 38, 29, DateTimeKind.Local).AddTicks(9157) });

            migrationBuilder.UpdateData(
                table: "ModuleItem",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666601"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 17, 33, 38, 29, DateTimeKind.Local).AddTicks(9223), new DateTime(2026, 7, 18, 17, 33, 38, 29, DateTimeKind.Local).AddTicks(9223) });

            migrationBuilder.UpdateData(
                table: "ModuleItem",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666602"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 17, 33, 38, 29, DateTimeKind.Local).AddTicks(9228), new DateTime(2026, 7, 18, 17, 33, 38, 29, DateTimeKind.Local).AddTicks(9228) });

            migrationBuilder.UpdateData(
                table: "ModuleItem",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666603"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 17, 33, 38, 29, DateTimeKind.Local).AddTicks(9230), new DateTime(2026, 7, 18, 17, 33, 38, 29, DateTimeKind.Local).AddTicks(9230) });

            migrationBuilder.UpdateData(
                table: "ModuleItem",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666604"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 17, 33, 38, 29, DateTimeKind.Local).AddTicks(9232), new DateTime(2026, 7, 18, 17, 33, 38, 29, DateTimeKind.Local).AddTicks(9232) });

            migrationBuilder.UpdateData(
                table: "ParentProfile",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 17, 33, 38, 29, DateTimeKind.Local).AddTicks(8738), new DateTime(2026, 7, 18, 17, 33, 38, 29, DateTimeKind.Local).AddTicks(8739) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000001"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 17, 33, 38, 29, DateTimeKind.Local).AddTicks(9677));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000002"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 17, 33, 38, 29, DateTimeKind.Local).AddTicks(9712));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000003"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 17, 33, 38, 29, DateTimeKind.Local).AddTicks(9766));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000004"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 17, 33, 38, 29, DateTimeKind.Local).AddTicks(9782));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000005"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 17, 33, 38, 29, DateTimeKind.Local).AddTicks(9799));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000006"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 17, 33, 38, 29, DateTimeKind.Local).AddTicks(9840));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000007"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 17, 33, 38, 29, DateTimeKind.Local).AddTicks(9854));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000008"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 17, 33, 38, 29, DateTimeKind.Local).AddTicks(9867));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000009"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 17, 33, 38, 29, DateTimeKind.Local).AddTicks(9940));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000010"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 17, 33, 38, 29, DateTimeKind.Local).AddTicks(9960));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000011"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 17, 33, 38, 29, DateTimeKind.Local).AddTicks(9977));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000012"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 17, 33, 38, 30, DateTimeKind.Local).AddTicks(33));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000013"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 17, 33, 38, 30, DateTimeKind.Local).AddTicks(49));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000014"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 17, 33, 38, 30, DateTimeKind.Local).AddTicks(66));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000015"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 17, 33, 38, 30, DateTimeKind.Local).AddTicks(80));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000016"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 17, 33, 38, 30, DateTimeKind.Local).AddTicks(126));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000017"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 17, 33, 38, 30, DateTimeKind.Local).AddTicks(145));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000018"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 17, 33, 38, 30, DateTimeKind.Local).AddTicks(160));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000019"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 17, 33, 38, 30, DateTimeKind.Local).AddTicks(209));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000020"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 18, 17, 33, 38, 30, DateTimeKind.Local).AddTicks(224));

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000001"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 17, 33, 38, 29, DateTimeKind.Local).AddTicks(9651), new DateTime(2026, 7, 18, 17, 33, 38, 29, DateTimeKind.Local).AddTicks(9651) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000002"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 17, 33, 38, 29, DateTimeKind.Local).AddTicks(9707), new DateTime(2026, 7, 18, 17, 33, 38, 29, DateTimeKind.Local).AddTicks(9708) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000003"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 17, 33, 38, 29, DateTimeKind.Local).AddTicks(9760), new DateTime(2026, 7, 18, 17, 33, 38, 29, DateTimeKind.Local).AddTicks(9760) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000004"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 17, 33, 38, 29, DateTimeKind.Local).AddTicks(9777), new DateTime(2026, 7, 18, 17, 33, 38, 29, DateTimeKind.Local).AddTicks(9778) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000005"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 17, 33, 38, 29, DateTimeKind.Local).AddTicks(9794), new DateTime(2026, 7, 18, 17, 33, 38, 29, DateTimeKind.Local).AddTicks(9795) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000006"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 17, 33, 38, 29, DateTimeKind.Local).AddTicks(9836), new DateTime(2026, 7, 18, 17, 33, 38, 29, DateTimeKind.Local).AddTicks(9836) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000007"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 17, 33, 38, 29, DateTimeKind.Local).AddTicks(9850), new DateTime(2026, 7, 18, 17, 33, 38, 29, DateTimeKind.Local).AddTicks(9850) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000008"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 17, 33, 38, 29, DateTimeKind.Local).AddTicks(9863), new DateTime(2026, 7, 18, 17, 33, 38, 29, DateTimeKind.Local).AddTicks(9864) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000009"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 17, 33, 38, 29, DateTimeKind.Local).AddTicks(9934), new DateTime(2026, 7, 18, 17, 33, 38, 29, DateTimeKind.Local).AddTicks(9935) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000010"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 17, 33, 38, 29, DateTimeKind.Local).AddTicks(9956), new DateTime(2026, 7, 18, 17, 33, 38, 29, DateTimeKind.Local).AddTicks(9956) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000011"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 17, 33, 38, 29, DateTimeKind.Local).AddTicks(9971), new DateTime(2026, 7, 18, 17, 33, 38, 29, DateTimeKind.Local).AddTicks(9971) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000012"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 17, 33, 38, 29, DateTimeKind.Local).AddTicks(9986), new DateTime(2026, 7, 18, 17, 33, 38, 29, DateTimeKind.Local).AddTicks(9987) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000013"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 17, 33, 38, 30, DateTimeKind.Local).AddTicks(45), new DateTime(2026, 7, 18, 17, 33, 38, 30, DateTimeKind.Local).AddTicks(45) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000014"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 17, 33, 38, 30, DateTimeKind.Local).AddTicks(62), new DateTime(2026, 7, 18, 17, 33, 38, 30, DateTimeKind.Local).AddTicks(62) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000015"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 17, 33, 38, 30, DateTimeKind.Local).AddTicks(76), new DateTime(2026, 7, 18, 17, 33, 38, 30, DateTimeKind.Local).AddTicks(77) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000016"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 17, 33, 38, 30, DateTimeKind.Local).AddTicks(122), new DateTime(2026, 7, 18, 17, 33, 38, 30, DateTimeKind.Local).AddTicks(122) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000017"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 17, 33, 38, 30, DateTimeKind.Local).AddTicks(140), new DateTime(2026, 7, 18, 17, 33, 38, 30, DateTimeKind.Local).AddTicks(140) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000018"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 17, 33, 38, 30, DateTimeKind.Local).AddTicks(157), new DateTime(2026, 7, 18, 17, 33, 38, 30, DateTimeKind.Local).AddTicks(157) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000019"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 17, 33, 38, 30, DateTimeKind.Local).AddTicks(203), new DateTime(2026, 7, 18, 17, 33, 38, 30, DateTimeKind.Local).AddTicks(204) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000020"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 17, 33, 38, 30, DateTimeKind.Local).AddTicks(220), new DateTime(2026, 7, 18, 17, 33, 38, 30, DateTimeKind.Local).AddTicks(221) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 17, 33, 38, 29, DateTimeKind.Local).AddTicks(8689), new DateTime(2026, 7, 18, 17, 33, 38, 29, DateTimeKind.Local).AddTicks(8690) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 17, 33, 38, 29, DateTimeKind.Local).AddTicks(8446), new DateTime(2026, 7, 18, 17, 33, 38, 29, DateTimeKind.Local).AddTicks(8457) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000001"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 17, 33, 38, 29, DateTimeKind.Local).AddTicks(9631), new DateTime(2026, 7, 18, 17, 33, 38, 29, DateTimeKind.Local).AddTicks(9632) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000002"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 17, 33, 38, 29, DateTimeKind.Local).AddTicks(9701), new DateTime(2026, 7, 18, 17, 33, 38, 29, DateTimeKind.Local).AddTicks(9702) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000003"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 17, 33, 38, 29, DateTimeKind.Local).AddTicks(9755), new DateTime(2026, 7, 18, 17, 33, 38, 29, DateTimeKind.Local).AddTicks(9755) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000004"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 17, 33, 38, 29, DateTimeKind.Local).AddTicks(9772), new DateTime(2026, 7, 18, 17, 33, 38, 29, DateTimeKind.Local).AddTicks(9773) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000005"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 17, 33, 38, 29, DateTimeKind.Local).AddTicks(9787), new DateTime(2026, 7, 18, 17, 33, 38, 29, DateTimeKind.Local).AddTicks(9788) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000006"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 17, 33, 38, 29, DateTimeKind.Local).AddTicks(9829), new DateTime(2026, 7, 18, 17, 33, 38, 29, DateTimeKind.Local).AddTicks(9829) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000007"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 17, 33, 38, 29, DateTimeKind.Local).AddTicks(9845), new DateTime(2026, 7, 18, 17, 33, 38, 29, DateTimeKind.Local).AddTicks(9845) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000008"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 17, 33, 38, 29, DateTimeKind.Local).AddTicks(9859), new DateTime(2026, 7, 18, 17, 33, 38, 29, DateTimeKind.Local).AddTicks(9859) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000009"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 17, 33, 38, 29, DateTimeKind.Local).AddTicks(9874), new DateTime(2026, 7, 18, 17, 33, 38, 29, DateTimeKind.Local).AddTicks(9874) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000010"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 17, 33, 38, 29, DateTimeKind.Local).AddTicks(9949), new DateTime(2026, 7, 18, 17, 33, 38, 29, DateTimeKind.Local).AddTicks(9950) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000011"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 17, 33, 38, 29, DateTimeKind.Local).AddTicks(9966), new DateTime(2026, 7, 18, 17, 33, 38, 29, DateTimeKind.Local).AddTicks(9966) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000012"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 17, 33, 38, 29, DateTimeKind.Local).AddTicks(9982), new DateTime(2026, 7, 18, 17, 33, 38, 29, DateTimeKind.Local).AddTicks(9982) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000013"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 17, 33, 38, 30, DateTimeKind.Local).AddTicks(39), new DateTime(2026, 7, 18, 17, 33, 38, 30, DateTimeKind.Local).AddTicks(39) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000014"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 17, 33, 38, 30, DateTimeKind.Local).AddTicks(55), new DateTime(2026, 7, 18, 17, 33, 38, 30, DateTimeKind.Local).AddTicks(56) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000015"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 17, 33, 38, 30, DateTimeKind.Local).AddTicks(71), new DateTime(2026, 7, 18, 17, 33, 38, 30, DateTimeKind.Local).AddTicks(71) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000016"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 17, 33, 38, 30, DateTimeKind.Local).AddTicks(86), new DateTime(2026, 7, 18, 17, 33, 38, 30, DateTimeKind.Local).AddTicks(86) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000017"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 17, 33, 38, 30, DateTimeKind.Local).AddTicks(133), new DateTime(2026, 7, 18, 17, 33, 38, 30, DateTimeKind.Local).AddTicks(133) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000018"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 17, 33, 38, 30, DateTimeKind.Local).AddTicks(151), new DateTime(2026, 7, 18, 17, 33, 38, 30, DateTimeKind.Local).AddTicks(152) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000019"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 17, 33, 38, 30, DateTimeKind.Local).AddTicks(198), new DateTime(2026, 7, 18, 17, 33, 38, 30, DateTimeKind.Local).AddTicks(199) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000020"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 17, 33, 38, 30, DateTimeKind.Local).AddTicks(215), new DateTime(2026, 7, 18, 17, 33, 38, 30, DateTimeKind.Local).AddTicks(216) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 17, 33, 38, 29, DateTimeKind.Local).AddTicks(8518), new DateTime(2026, 7, 18, 17, 33, 38, 29, DateTimeKind.Local).AddTicks(8518) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 17, 33, 38, 29, DateTimeKind.Local).AddTicks(8521), new DateTime(2026, 7, 18, 17, 33, 38, 29, DateTimeKind.Local).AddTicks(8522) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 17, 33, 38, 29, DateTimeKind.Local).AddTicks(8524), new DateTime(2026, 7, 18, 17, 33, 38, 29, DateTimeKind.Local).AddTicks(8525) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("55555555-5555-5555-5555-555555555555"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 17, 33, 38, 29, DateTimeKind.Local).AddTicks(8528), new DateTime(2026, 7, 18, 17, 33, 38, 29, DateTimeKind.Local).AddTicks(8528) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666666"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 18, 17, 33, 38, 29, DateTimeKind.Local).AddTicks(8531), new DateTime(2026, 7, 18, 17, 33, 38, 29, DateTimeKind.Local).AddTicks(8531) });
        }
    }
}
