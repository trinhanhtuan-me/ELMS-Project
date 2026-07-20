using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedAssignmentData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Assignment",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666604"),
                columns: new[] { "Content", "Instructions", "SubmissionType", "Title" },
                values: new object[] { "<strong>Task:</strong> Write a 120-150-word paragraph describing your daily routine using the Present Simple.<br><ul><li>Include frequency markers (always/usually/often...)</li><li>Use 3 sequence words (first, then, finally...)</li><li>Highlight 3 typical verbs of your day</li></ul><p><em>Tip: draft &rarr; revise &rarr; finalize. Check S-V agreement (he/she/it + s/es).</em></p>", "1) Viết 120-150 từ về thói quen hằng ngày (Present Simple).<br>2) Dùng từ chỉ tần suất: always/usually/often/sometimes/never.<br>3) Thêm từ nối trình tự: first/then/after that/finally.<br>4) Gạch chân 3 động từ tiêu biểu (get up, have breakfast, do homework).<br>5) Kiểm tra chia động từ đúng với he/she/it (+s/es).<br>6) Soát lỗi chính tả & dấu câu trước khi nộp.<br>7) Đọc to để rà nhịp điệu và mạch lạc.", (byte)1, "Daily Routine Paragraph (Present Simple)" });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("88888888-8888-8888-8888-888888888888"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 19, 13, 46, 38, 102, DateTimeKind.Local).AddTicks(6886));

            migrationBuilder.UpdateData(
                table: "Module",
                keyColumn: "Id",
                keyValue: new Guid("77777777-7777-7777-7777-777777777777"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 13, 46, 38, 102, DateTimeKind.Local).AddTicks(6942), new DateTime(2026, 7, 19, 13, 46, 38, 102, DateTimeKind.Local).AddTicks(6942) });

            migrationBuilder.UpdateData(
                table: "ModuleItem",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666601"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 13, 46, 38, 102, DateTimeKind.Local).AddTicks(6999), new DateTime(2026, 7, 19, 13, 46, 38, 102, DateTimeKind.Local).AddTicks(6999) });

            migrationBuilder.UpdateData(
                table: "ModuleItem",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666602"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 13, 46, 38, 102, DateTimeKind.Local).AddTicks(7007), new DateTime(2026, 7, 19, 13, 46, 38, 102, DateTimeKind.Local).AddTicks(7008) });

            migrationBuilder.UpdateData(
                table: "ModuleItem",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666603"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 13, 46, 38, 102, DateTimeKind.Local).AddTicks(7011), new DateTime(2026, 7, 19, 13, 46, 38, 102, DateTimeKind.Local).AddTicks(7011) });

            migrationBuilder.UpdateData(
                table: "ModuleItem",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666604"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 13, 46, 38, 102, DateTimeKind.Local).AddTicks(7014), new DateTime(2026, 7, 19, 13, 46, 38, 102, DateTimeKind.Local).AddTicks(7014) });

            migrationBuilder.UpdateData(
                table: "ParentProfile",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 13, 46, 38, 102, DateTimeKind.Local).AddTicks(6423), new DateTime(2026, 7, 19, 13, 46, 38, 102, DateTimeKind.Local).AddTicks(6423) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000001"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 19, 13, 46, 38, 102, DateTimeKind.Local).AddTicks(7499));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000002"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 19, 13, 46, 38, 102, DateTimeKind.Local).AddTicks(7542));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000003"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 19, 13, 46, 38, 102, DateTimeKind.Local).AddTicks(7560));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000004"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 19, 13, 46, 38, 102, DateTimeKind.Local).AddTicks(7577));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000005"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 19, 13, 46, 38, 102, DateTimeKind.Local).AddTicks(7621));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000006"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 19, 13, 46, 38, 102, DateTimeKind.Local).AddTicks(7641));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000007"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 19, 13, 46, 38, 102, DateTimeKind.Local).AddTicks(7656));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000008"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 19, 13, 46, 38, 102, DateTimeKind.Local).AddTicks(7742));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000009"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 19, 13, 46, 38, 102, DateTimeKind.Local).AddTicks(7763));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000010"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 19, 13, 46, 38, 102, DateTimeKind.Local).AddTicks(7803));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000011"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 19, 13, 46, 38, 102, DateTimeKind.Local).AddTicks(7874));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000012"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 19, 13, 46, 38, 102, DateTimeKind.Local).AddTicks(7892));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000013"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 19, 13, 46, 38, 102, DateTimeKind.Local).AddTicks(7907));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000014"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 19, 13, 46, 38, 102, DateTimeKind.Local).AddTicks(7924));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000015"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 19, 13, 46, 38, 102, DateTimeKind.Local).AddTicks(7978));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000016"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 19, 13, 46, 38, 102, DateTimeKind.Local).AddTicks(7994));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000017"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 19, 13, 46, 38, 102, DateTimeKind.Local).AddTicks(8014));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000018"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 19, 13, 46, 38, 102, DateTimeKind.Local).AddTicks(8069));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000019"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 19, 13, 46, 38, 102, DateTimeKind.Local).AddTicks(8084));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000020"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 19, 13, 46, 38, 102, DateTimeKind.Local).AddTicks(8101));

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000001"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 13, 46, 38, 102, DateTimeKind.Local).AddTicks(7464), new DateTime(2026, 7, 19, 13, 46, 38, 102, DateTimeKind.Local).AddTicks(7465) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000002"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 13, 46, 38, 102, DateTimeKind.Local).AddTicks(7536), new DateTime(2026, 7, 19, 13, 46, 38, 102, DateTimeKind.Local).AddTicks(7537) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000003"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 13, 46, 38, 102, DateTimeKind.Local).AddTicks(7555), new DateTime(2026, 7, 19, 13, 46, 38, 102, DateTimeKind.Local).AddTicks(7556) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000004"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 13, 46, 38, 102, DateTimeKind.Local).AddTicks(7573), new DateTime(2026, 7, 19, 13, 46, 38, 102, DateTimeKind.Local).AddTicks(7573) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000005"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 13, 46, 38, 102, DateTimeKind.Local).AddTicks(7616), new DateTime(2026, 7, 19, 13, 46, 38, 102, DateTimeKind.Local).AddTicks(7616) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000006"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 13, 46, 38, 102, DateTimeKind.Local).AddTicks(7634), new DateTime(2026, 7, 19, 13, 46, 38, 102, DateTimeKind.Local).AddTicks(7635) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000007"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 13, 46, 38, 102, DateTimeKind.Local).AddTicks(7652), new DateTime(2026, 7, 19, 13, 46, 38, 102, DateTimeKind.Local).AddTicks(7652) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000008"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 13, 46, 38, 102, DateTimeKind.Local).AddTicks(7738), new DateTime(2026, 7, 19, 13, 46, 38, 102, DateTimeKind.Local).AddTicks(7738) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000009"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 13, 46, 38, 102, DateTimeKind.Local).AddTicks(7757), new DateTime(2026, 7, 19, 13, 46, 38, 102, DateTimeKind.Local).AddTicks(7757) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000010"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 13, 46, 38, 102, DateTimeKind.Local).AddTicks(7780), new DateTime(2026, 7, 19, 13, 46, 38, 102, DateTimeKind.Local).AddTicks(7780) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000011"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 13, 46, 38, 102, DateTimeKind.Local).AddTicks(7870), new DateTime(2026, 7, 19, 13, 46, 38, 102, DateTimeKind.Local).AddTicks(7870) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000012"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 13, 46, 38, 102, DateTimeKind.Local).AddTicks(7888), new DateTime(2026, 7, 19, 13, 46, 38, 102, DateTimeKind.Local).AddTicks(7888) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000013"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 13, 46, 38, 102, DateTimeKind.Local).AddTicks(7903), new DateTime(2026, 7, 19, 13, 46, 38, 102, DateTimeKind.Local).AddTicks(7904) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000014"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 13, 46, 38, 102, DateTimeKind.Local).AddTicks(7918), new DateTime(2026, 7, 19, 13, 46, 38, 102, DateTimeKind.Local).AddTicks(7918) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000015"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 13, 46, 38, 102, DateTimeKind.Local).AddTicks(7974), new DateTime(2026, 7, 19, 13, 46, 38, 102, DateTimeKind.Local).AddTicks(7974) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000016"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 13, 46, 38, 102, DateTimeKind.Local).AddTicks(7989), new DateTime(2026, 7, 19, 13, 46, 38, 102, DateTimeKind.Local).AddTicks(7990) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000017"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 13, 46, 38, 102, DateTimeKind.Local).AddTicks(8008), new DateTime(2026, 7, 19, 13, 46, 38, 102, DateTimeKind.Local).AddTicks(8008) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000018"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 13, 46, 38, 102, DateTimeKind.Local).AddTicks(8065), new DateTime(2026, 7, 19, 13, 46, 38, 102, DateTimeKind.Local).AddTicks(8065) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000019"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 13, 46, 38, 102, DateTimeKind.Local).AddTicks(8080), new DateTime(2026, 7, 19, 13, 46, 38, 102, DateTimeKind.Local).AddTicks(8080) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000020"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 13, 46, 38, 102, DateTimeKind.Local).AddTicks(8097), new DateTime(2026, 7, 19, 13, 46, 38, 102, DateTimeKind.Local).AddTicks(8097) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 13, 46, 38, 102, DateTimeKind.Local).AddTicks(6364), new DateTime(2026, 7, 19, 13, 46, 38, 102, DateTimeKind.Local).AddTicks(6364) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 13, 46, 38, 102, DateTimeKind.Local).AddTicks(6150), new DateTime(2026, 7, 19, 13, 46, 38, 102, DateTimeKind.Local).AddTicks(6164) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000001"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 13, 46, 38, 102, DateTimeKind.Local).AddTicks(7407), new DateTime(2026, 7, 19, 13, 46, 38, 102, DateTimeKind.Local).AddTicks(7407) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000002"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 13, 46, 38, 102, DateTimeKind.Local).AddTicks(7529), new DateTime(2026, 7, 19, 13, 46, 38, 102, DateTimeKind.Local).AddTicks(7529) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000003"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 13, 46, 38, 102, DateTimeKind.Local).AddTicks(7550), new DateTime(2026, 7, 19, 13, 46, 38, 102, DateTimeKind.Local).AddTicks(7550) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000004"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 13, 46, 38, 102, DateTimeKind.Local).AddTicks(7568), new DateTime(2026, 7, 19, 13, 46, 38, 102, DateTimeKind.Local).AddTicks(7568) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000005"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 13, 46, 38, 102, DateTimeKind.Local).AddTicks(7609), new DateTime(2026, 7, 19, 13, 46, 38, 102, DateTimeKind.Local).AddTicks(7609) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000006"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 13, 46, 38, 102, DateTimeKind.Local).AddTicks(7629), new DateTime(2026, 7, 19, 13, 46, 38, 102, DateTimeKind.Local).AddTicks(7629) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000007"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 13, 46, 38, 102, DateTimeKind.Local).AddTicks(7647), new DateTime(2026, 7, 19, 13, 46, 38, 102, DateTimeKind.Local).AddTicks(7647) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000008"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 13, 46, 38, 102, DateTimeKind.Local).AddTicks(7731), new DateTime(2026, 7, 19, 13, 46, 38, 102, DateTimeKind.Local).AddTicks(7732) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000009"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 13, 46, 38, 102, DateTimeKind.Local).AddTicks(7748), new DateTime(2026, 7, 19, 13, 46, 38, 102, DateTimeKind.Local).AddTicks(7749) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000010"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 13, 46, 38, 102, DateTimeKind.Local).AddTicks(7773), new DateTime(2026, 7, 19, 13, 46, 38, 102, DateTimeKind.Local).AddTicks(7774) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000011"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 13, 46, 38, 102, DateTimeKind.Local).AddTicks(7863), new DateTime(2026, 7, 19, 13, 46, 38, 102, DateTimeKind.Local).AddTicks(7864) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000012"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 13, 46, 38, 102, DateTimeKind.Local).AddTicks(7882), new DateTime(2026, 7, 19, 13, 46, 38, 102, DateTimeKind.Local).AddTicks(7883) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000013"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 13, 46, 38, 102, DateTimeKind.Local).AddTicks(7898), new DateTime(2026, 7, 19, 13, 46, 38, 102, DateTimeKind.Local).AddTicks(7899) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000014"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 13, 46, 38, 102, DateTimeKind.Local).AddTicks(7913), new DateTime(2026, 7, 19, 13, 46, 38, 102, DateTimeKind.Local).AddTicks(7913) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000015"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 13, 46, 38, 102, DateTimeKind.Local).AddTicks(7968), new DateTime(2026, 7, 19, 13, 46, 38, 102, DateTimeKind.Local).AddTicks(7968) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000016"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 13, 46, 38, 102, DateTimeKind.Local).AddTicks(7984), new DateTime(2026, 7, 19, 13, 46, 38, 102, DateTimeKind.Local).AddTicks(7984) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000017"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 13, 46, 38, 102, DateTimeKind.Local).AddTicks(7999), new DateTime(2026, 7, 19, 13, 46, 38, 102, DateTimeKind.Local).AddTicks(8000) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000018"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 13, 46, 38, 102, DateTimeKind.Local).AddTicks(8058), new DateTime(2026, 7, 19, 13, 46, 38, 102, DateTimeKind.Local).AddTicks(8059) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000019"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 13, 46, 38, 102, DateTimeKind.Local).AddTicks(8075), new DateTime(2026, 7, 19, 13, 46, 38, 102, DateTimeKind.Local).AddTicks(8075) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000020"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 13, 46, 38, 102, DateTimeKind.Local).AddTicks(8092), new DateTime(2026, 7, 19, 13, 46, 38, 102, DateTimeKind.Local).AddTicks(8092) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 13, 46, 38, 102, DateTimeKind.Local).AddTicks(6229), new DateTime(2026, 7, 19, 13, 46, 38, 102, DateTimeKind.Local).AddTicks(6229) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 13, 46, 38, 102, DateTimeKind.Local).AddTicks(6233), new DateTime(2026, 7, 19, 13, 46, 38, 102, DateTimeKind.Local).AddTicks(6234) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 13, 46, 38, 102, DateTimeKind.Local).AddTicks(6238), new DateTime(2026, 7, 19, 13, 46, 38, 102, DateTimeKind.Local).AddTicks(6238) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("55555555-5555-5555-5555-555555555555"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 13, 46, 38, 102, DateTimeKind.Local).AddTicks(6241), new DateTime(2026, 7, 19, 13, 46, 38, 102, DateTimeKind.Local).AddTicks(6241) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666666"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 13, 46, 38, 102, DateTimeKind.Local).AddTicks(6245), new DateTime(2026, 7, 19, 13, 46, 38, 102, DateTimeKind.Local).AddTicks(6245) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Assignment",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666604"),
                columns: new[] { "Content", "Instructions", "SubmissionType", "Title" },
                values: new object[] { "Mô tả thói quen", "Write a paragraph...", (byte)0, "Daily Routine Paragraph" });

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("88888888-8888-8888-8888-888888888888"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(7950));

            migrationBuilder.UpdateData(
                table: "Module",
                keyColumn: "Id",
                keyValue: new Guid("77777777-7777-7777-7777-777777777777"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(8026), new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(8027) });

            migrationBuilder.UpdateData(
                table: "ModuleItem",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666601"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(8094), new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(8094) });

            migrationBuilder.UpdateData(
                table: "ModuleItem",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666602"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(8099), new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(8100) });

            migrationBuilder.UpdateData(
                table: "ModuleItem",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666603"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(8103), new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(8120) });

            migrationBuilder.UpdateData(
                table: "ModuleItem",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666604"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(8143), new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(8143) });

            migrationBuilder.UpdateData(
                table: "ParentProfile",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(7344), new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(7345) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000001"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(8725));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000002"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(8769));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000003"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(8937));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000004"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(8982));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000005"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(9019));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000006"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(9111));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000007"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(9133));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000008"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(9153));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000009"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(9174));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000010"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(9233));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000011"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(9281));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000012"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(9298));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000013"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(9352));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000014"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(9371));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000015"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(9393));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000016"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(9423));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000017"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(9478));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000018"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(9498));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000019"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(9549));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000020"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(9567));

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000001"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(8688), new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(8688) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000002"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(8763), new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(8764) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000003"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(8922), new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(8923) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000004"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(8972), new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(8973) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000005"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(9007), new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(9008) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000006"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(9101), new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(9102) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000007"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(9128), new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(9129) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000008"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(9146), new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(9147) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000009"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(9168), new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(9168) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000010"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(9228), new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(9229) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000011"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(9276), new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(9276) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000012"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(9294), new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(9294) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000013"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(9347), new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(9347) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000014"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(9366), new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(9367) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000015"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(9385), new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(9385) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000016"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(9416), new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(9416) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000017"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(9472), new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(9472) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000018"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(9493), new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(9494) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000019"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(9544), new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(9545) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000020"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(9562), new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(9563) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(7286), new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(7287) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(6993), new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(7036) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000001"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(8664), new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(8665) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000002"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(8756), new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(8756) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000003"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(8778), new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(8778) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000004"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(8961), new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(8962) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000005"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(8995), new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(8995) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000006"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(9038), new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(9039) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000007"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(9121), new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(9122) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000008"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(9140), new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(9141) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000009"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(9160), new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(9160) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000010"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(9221), new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(9222) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000011"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(9267), new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(9268) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000012"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(9287), new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(9288) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000013"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(9340), new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(9340) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000014"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(9361), new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(9361) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000015"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(9378), new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(9378) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000016"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(9410), new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(9410) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000017"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(9464), new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(9464) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000018"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(9487), new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(9488) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000019"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(9505), new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(9506) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000020"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(9556), new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(9557) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(7085), new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(7086) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(7091), new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(7091) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(7098), new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(7098) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("55555555-5555-5555-5555-555555555555"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(7102), new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(7102) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666666"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(7106), new DateTime(2026, 7, 19, 1, 35, 54, 204, DateTimeKind.Local).AddTicks(7106) });
        }
    }
}
