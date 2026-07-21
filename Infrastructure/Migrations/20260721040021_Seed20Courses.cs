using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Seed20Courses : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("88888888-8888-8888-8888-888888888888"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 21, 11, 0, 19, 754, DateTimeKind.Local).AddTicks(6730));

            migrationBuilder.InsertData(
                table: "Course",
                columns: new[] { "Id", "CategoryId", "CreatedAt", "CreatedBy", "Description", "IsDeleted", "Language", "LastUpdatedAt", "LastUpdatedBy", "Level", "PublishAt", "Status", "Thumbnail", "Title", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("0561ab29-2eba-49bb-b81e-79253986dcba"), 999, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("44444444-4444-4444-4444-444444444444"), null, false, "English", new DateTime(2026, 7, 21, 11, 0, 19, 754, DateTimeKind.Local).AddTicks(6665), null, "Beginner", null, (byte)5, "https://res.cloudinary.com/pewx8g7u/image/upload/v1784531406/thumbnail/course/OIP_qtnva8.webp", "English Course 12", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("09a0e922-ab13-48c6-9905-65ff3d1368db"), 999, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("44444444-4444-4444-4444-444444444444"), null, false, "English", new DateTime(2026, 7, 21, 11, 0, 19, 754, DateTimeKind.Local).AddTicks(6725), null, "Beginner", null, (byte)5, "https://res.cloudinary.com/pewx8g7u/image/upload/v1784565597/thumbnail/course/khoa-hoc-tieng-anh-online-1-1024x734_dopaw0.png", "English Course 19", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("266dd46e-3986-4349-badc-cdd9f93d4ff3"), 999, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("44444444-4444-4444-4444-444444444444"), null, false, "English", new DateTime(2026, 7, 21, 11, 0, 19, 754, DateTimeKind.Local).AddTicks(6680), null, "Beginner", null, (byte)5, "https://res.cloudinary.com/pewx8g7u/image/upload/v1784565597/thumbnail/course/khoa-hoc-tieng-anh-online-1-1024x734_dopaw0.png", "English Course 17", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("2f07f110-d481-4e4e-ad06-7304dbd03bc4"), 999, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("44444444-4444-4444-4444-444444444444"), null, false, "English", new DateTime(2026, 7, 21, 11, 0, 19, 754, DateTimeKind.Local).AddTicks(6660), null, "Beginner", null, (byte)5, "https://res.cloudinary.com/pewx8g7u/image/upload/v1784531406/thumbnail/course/OIP_qtnva8.webp", "English Course 10", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("41aa5211-41d9-4588-b3e3-93be5a795493"), 999, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("44444444-4444-4444-4444-444444444444"), null, false, "English", new DateTime(2026, 7, 21, 11, 0, 19, 754, DateTimeKind.Local).AddTicks(6721), null, "Beginner", null, (byte)5, "https://res.cloudinary.com/pewx8g7u/image/upload/v1784531406/thumbnail/course/OIP_qtnva8.webp", "English Course 18", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("41e09acd-a45c-452a-b160-e35d0937961b"), 999, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("44444444-4444-4444-4444-444444444444"), null, false, "English", new DateTime(2026, 7, 21, 11, 0, 19, 754, DateTimeKind.Local).AddTicks(6672), null, "Beginner", null, (byte)5, "https://res.cloudinary.com/pewx8g7u/image/upload/v1784531406/thumbnail/course/OIP_qtnva8.webp", "English Course 14", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("468a7aa7-f96a-434a-adb9-55ff4417e9fc"), 999, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("44444444-4444-4444-4444-444444444444"), null, false, "English", new DateTime(2026, 7, 21, 11, 0, 19, 754, DateTimeKind.Local).AddTicks(6728), null, "Beginner", null, (byte)5, "https://res.cloudinary.com/pewx8g7u/image/upload/v1784531406/thumbnail/course/OIP_qtnva8.webp", "English Course 20", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("5f515dfb-afdd-494b-8962-7cba76e2cef2"), 999, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("44444444-4444-4444-4444-444444444444"), null, false, "English", new DateTime(2026, 7, 21, 11, 0, 19, 754, DateTimeKind.Local).AddTicks(6677), null, "Beginner", null, (byte)5, "https://res.cloudinary.com/pewx8g7u/image/upload/v1784531406/thumbnail/course/OIP_qtnva8.webp", "English Course 16", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("604089d4-4678-47c3-9a13-1f9ef2369c6c"), 999, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("44444444-4444-4444-4444-444444444444"), null, false, "English", new DateTime(2026, 7, 21, 11, 0, 19, 754, DateTimeKind.Local).AddTicks(6655), null, "Beginner", null, (byte)5, "https://res.cloudinary.com/pewx8g7u/image/upload/v1784531406/thumbnail/course/OIP_qtnva8.webp", "English Course 8", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("61cbb7d3-3c29-44d5-8fb4-ad5cfaf353d9"), 999, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("44444444-4444-4444-4444-444444444444"), null, false, "English", new DateTime(2026, 7, 21, 11, 0, 19, 754, DateTimeKind.Local).AddTicks(6675), null, "Beginner", null, (byte)5, "https://res.cloudinary.com/pewx8g7u/image/upload/v1784565597/thumbnail/course/khoa-hoc-tieng-anh-online-1-1024x734_dopaw0.png", "English Course 15", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("6b44ae4b-e537-492c-a2c3-3a6c6910ab0c"), 999, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("44444444-4444-4444-4444-444444444444"), null, false, "English", new DateTime(2026, 7, 21, 11, 0, 19, 754, DateTimeKind.Local).AddTicks(6652), null, "Beginner", null, (byte)5, "https://res.cloudinary.com/pewx8g7u/image/upload/v1784565597/thumbnail/course/khoa-hoc-tieng-anh-online-1-1024x734_dopaw0.png", "English Course 7", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("6ca511a0-87e2-41f5-85eb-62b0148c2372"), 999, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("44444444-4444-4444-4444-444444444444"), null, false, "English", new DateTime(2026, 7, 21, 11, 0, 19, 754, DateTimeKind.Local).AddTicks(6645), null, "Beginner", null, (byte)5, "https://res.cloudinary.com/pewx8g7u/image/upload/v1784565597/thumbnail/course/khoa-hoc-tieng-anh-online-1-1024x734_dopaw0.png", "English Course 5", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("797b695d-3ff0-4c3e-b808-c6cbb860d0db"), 999, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("44444444-4444-4444-4444-444444444444"), null, false, "English", new DateTime(2026, 7, 21, 11, 0, 19, 754, DateTimeKind.Local).AddTicks(6642), null, "Beginner", null, (byte)5, "https://res.cloudinary.com/pewx8g7u/image/upload/v1784531406/thumbnail/course/OIP_qtnva8.webp", "English Course 4", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("8642f332-26c4-49b3-9e9a-717eb5635c1c"), 999, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("44444444-4444-4444-4444-444444444444"), null, false, "English", new DateTime(2026, 7, 21, 11, 0, 19, 754, DateTimeKind.Local).AddTicks(6637), null, "Beginner", null, (byte)5, "https://res.cloudinary.com/pewx8g7u/image/upload/v1784565597/thumbnail/course/khoa-hoc-tieng-anh-online-1-1024x734_dopaw0.png", "English Course 3", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("a19630ec-36a4-4636-ad75-9b2e43673e60"), 999, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("44444444-4444-4444-4444-444444444444"), null, false, "English", new DateTime(2026, 7, 21, 11, 0, 19, 754, DateTimeKind.Local).AddTicks(6658), null, "Beginner", null, (byte)5, "https://res.cloudinary.com/pewx8g7u/image/upload/v1784565597/thumbnail/course/khoa-hoc-tieng-anh-online-1-1024x734_dopaw0.png", "English Course 9", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("a534574a-c17a-4753-a006-15c1f08dada8"), 999, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("44444444-4444-4444-4444-444444444444"), null, false, "English", new DateTime(2026, 7, 21, 11, 0, 19, 754, DateTimeKind.Local).AddTicks(6663), null, "Beginner", null, (byte)5, "https://res.cloudinary.com/pewx8g7u/image/upload/v1784565597/thumbnail/course/khoa-hoc-tieng-anh-online-1-1024x734_dopaw0.png", "English Course 11", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("a7fac760-5150-49ef-8c4c-45dfdec000e9"), 999, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("44444444-4444-4444-4444-444444444444"), null, false, "English", new DateTime(2026, 7, 21, 11, 0, 19, 754, DateTimeKind.Local).AddTicks(6623), null, "Beginner", null, (byte)5, "https://res.cloudinary.com/pewx8g7u/image/upload/v1784565597/thumbnail/course/khoa-hoc-tieng-anh-online-1-1024x734_dopaw0.png", "English Course 1", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("ba40e913-e8b4-442d-a51b-7d00ed101f54"), 999, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("44444444-4444-4444-4444-444444444444"), null, false, "English", new DateTime(2026, 7, 21, 11, 0, 19, 754, DateTimeKind.Local).AddTicks(6649), null, "Beginner", null, (byte)5, "https://res.cloudinary.com/pewx8g7u/image/upload/v1784531406/thumbnail/course/OIP_qtnva8.webp", "English Course 6", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("c3f6c320-2104-49a5-a03e-a8e2f28d17f9"), 999, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("44444444-4444-4444-4444-444444444444"), null, false, "English", new DateTime(2026, 7, 21, 11, 0, 19, 754, DateTimeKind.Local).AddTicks(6633), null, "Beginner", null, (byte)5, "https://res.cloudinary.com/pewx8g7u/image/upload/v1784531406/thumbnail/course/OIP_qtnva8.webp", "English Course 2", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("deb669bf-a38e-407c-a327-ddf5b7632e02"), 999, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("44444444-4444-4444-4444-444444444444"), null, false, "English", new DateTime(2026, 7, 21, 11, 0, 19, 754, DateTimeKind.Local).AddTicks(6668), null, "Beginner", null, (byte)5, "https://res.cloudinary.com/pewx8g7u/image/upload/v1784565597/thumbnail/course/khoa-hoc-tieng-anh-online-1-1024x734_dopaw0.png", "English Course 13", new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null }
                });

            migrationBuilder.UpdateData(
                table: "Module",
                keyColumn: "Id",
                keyValue: new Guid("77777777-7777-7777-7777-777777777777"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 21, 11, 0, 19, 754, DateTimeKind.Local).AddTicks(6758), new DateTime(2026, 7, 21, 11, 0, 19, 754, DateTimeKind.Local).AddTicks(6758) });

            migrationBuilder.UpdateData(
                table: "ModuleItem",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666601"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 21, 11, 0, 19, 754, DateTimeKind.Local).AddTicks(6784), new DateTime(2026, 7, 21, 11, 0, 19, 754, DateTimeKind.Local).AddTicks(6785) });

            migrationBuilder.UpdateData(
                table: "ModuleItem",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666602"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 21, 11, 0, 19, 754, DateTimeKind.Local).AddTicks(6787), new DateTime(2026, 7, 21, 11, 0, 19, 754, DateTimeKind.Local).AddTicks(6788) });

            migrationBuilder.UpdateData(
                table: "ModuleItem",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666603"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 21, 11, 0, 19, 754, DateTimeKind.Local).AddTicks(6789), new DateTime(2026, 7, 21, 11, 0, 19, 754, DateTimeKind.Local).AddTicks(6789) });

            migrationBuilder.UpdateData(
                table: "ModuleItem",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666604"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 21, 11, 0, 19, 754, DateTimeKind.Local).AddTicks(6790), new DateTime(2026, 7, 21, 11, 0, 19, 754, DateTimeKind.Local).AddTicks(6791) });

            migrationBuilder.UpdateData(
                table: "ParentProfile",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 21, 11, 0, 19, 754, DateTimeKind.Local).AddTicks(6401), new DateTime(2026, 7, 21, 11, 0, 19, 754, DateTimeKind.Local).AddTicks(6402) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000001"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 21, 11, 0, 19, 754, DateTimeKind.Local).AddTicks(7044));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000002"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 21, 11, 0, 19, 754, DateTimeKind.Local).AddTicks(7071));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000003"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 21, 11, 0, 19, 754, DateTimeKind.Local).AddTicks(7083));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000004"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 21, 11, 0, 19, 754, DateTimeKind.Local).AddTicks(7135));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000005"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 21, 11, 0, 19, 754, DateTimeKind.Local).AddTicks(7148));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000006"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 21, 11, 0, 19, 754, DateTimeKind.Local).AddTicks(7160));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000007"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 21, 11, 0, 19, 754, DateTimeKind.Local).AddTicks(7170));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000008"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 21, 11, 0, 19, 754, DateTimeKind.Local).AddTicks(7201));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000009"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 21, 11, 0, 19, 754, DateTimeKind.Local).AddTicks(7213));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000010"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 21, 11, 0, 19, 754, DateTimeKind.Local).AddTicks(7226));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000011"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 21, 11, 0, 19, 754, DateTimeKind.Local).AddTicks(7255));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000012"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 21, 11, 0, 19, 754, DateTimeKind.Local).AddTicks(7265));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000013"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 21, 11, 0, 19, 754, DateTimeKind.Local).AddTicks(7275));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000014"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 21, 11, 0, 19, 754, DateTimeKind.Local).AddTicks(7305));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000015"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 21, 11, 0, 19, 754, DateTimeKind.Local).AddTicks(7316));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000016"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 21, 11, 0, 19, 754, DateTimeKind.Local).AddTicks(7326));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000017"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 21, 11, 0, 19, 754, DateTimeKind.Local).AddTicks(7356));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000018"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 21, 11, 0, 19, 754, DateTimeKind.Local).AddTicks(7368));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000019"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 21, 11, 0, 19, 754, DateTimeKind.Local).AddTicks(7379));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000020"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 21, 11, 0, 19, 754, DateTimeKind.Local).AddTicks(7425));

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000001"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 21, 11, 0, 19, 754, DateTimeKind.Local).AddTicks(7022), new DateTime(2026, 7, 21, 11, 0, 19, 754, DateTimeKind.Local).AddTicks(7022) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000002"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 21, 11, 0, 19, 754, DateTimeKind.Local).AddTicks(7068), new DateTime(2026, 7, 21, 11, 0, 19, 754, DateTimeKind.Local).AddTicks(7069) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000003"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 21, 11, 0, 19, 754, DateTimeKind.Local).AddTicks(7080), new DateTime(2026, 7, 21, 11, 0, 19, 754, DateTimeKind.Local).AddTicks(7080) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000004"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 21, 11, 0, 19, 754, DateTimeKind.Local).AddTicks(7091), new DateTime(2026, 7, 21, 11, 0, 19, 754, DateTimeKind.Local).AddTicks(7091) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000005"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 21, 11, 0, 19, 754, DateTimeKind.Local).AddTicks(7144), new DateTime(2026, 7, 21, 11, 0, 19, 754, DateTimeKind.Local).AddTicks(7144) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000006"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 21, 11, 0, 19, 754, DateTimeKind.Local).AddTicks(7157), new DateTime(2026, 7, 21, 11, 0, 19, 754, DateTimeKind.Local).AddTicks(7157) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000007"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 21, 11, 0, 19, 754, DateTimeKind.Local).AddTicks(7167), new DateTime(2026, 7, 21, 11, 0, 19, 754, DateTimeKind.Local).AddTicks(7168) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000008"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 21, 11, 0, 19, 754, DateTimeKind.Local).AddTicks(7197), new DateTime(2026, 7, 21, 11, 0, 19, 754, DateTimeKind.Local).AddTicks(7197) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000009"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 21, 11, 0, 19, 754, DateTimeKind.Local).AddTicks(7209), new DateTime(2026, 7, 21, 11, 0, 19, 754, DateTimeKind.Local).AddTicks(7209) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000010"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 21, 11, 0, 19, 754, DateTimeKind.Local).AddTicks(7223), new DateTime(2026, 7, 21, 11, 0, 19, 754, DateTimeKind.Local).AddTicks(7223) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000011"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 21, 11, 0, 19, 754, DateTimeKind.Local).AddTicks(7253), new DateTime(2026, 7, 21, 11, 0, 19, 754, DateTimeKind.Local).AddTicks(7253) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000012"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 21, 11, 0, 19, 754, DateTimeKind.Local).AddTicks(7263), new DateTime(2026, 7, 21, 11, 0, 19, 754, DateTimeKind.Local).AddTicks(7263) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000013"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 21, 11, 0, 19, 754, DateTimeKind.Local).AddTicks(7273), new DateTime(2026, 7, 21, 11, 0, 19, 754, DateTimeKind.Local).AddTicks(7273) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000014"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 21, 11, 0, 19, 754, DateTimeKind.Local).AddTicks(7302), new DateTime(2026, 7, 21, 11, 0, 19, 754, DateTimeKind.Local).AddTicks(7302) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000015"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 21, 11, 0, 19, 754, DateTimeKind.Local).AddTicks(7313), new DateTime(2026, 7, 21, 11, 0, 19, 754, DateTimeKind.Local).AddTicks(7313) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000016"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 21, 11, 0, 19, 754, DateTimeKind.Local).AddTicks(7323), new DateTime(2026, 7, 21, 11, 0, 19, 754, DateTimeKind.Local).AddTicks(7323) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000017"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 21, 11, 0, 19, 754, DateTimeKind.Local).AddTicks(7334), new DateTime(2026, 7, 21, 11, 0, 19, 754, DateTimeKind.Local).AddTicks(7334) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000018"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 21, 11, 0, 19, 754, DateTimeKind.Local).AddTicks(7365), new DateTime(2026, 7, 21, 11, 0, 19, 754, DateTimeKind.Local).AddTicks(7365) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000019"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 21, 11, 0, 19, 754, DateTimeKind.Local).AddTicks(7376), new DateTime(2026, 7, 21, 11, 0, 19, 754, DateTimeKind.Local).AddTicks(7376) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000020"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 21, 11, 0, 19, 754, DateTimeKind.Local).AddTicks(7386), new DateTime(2026, 7, 21, 11, 0, 19, 754, DateTimeKind.Local).AddTicks(7386) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 21, 11, 0, 19, 754, DateTimeKind.Local).AddTicks(6380), new DateTime(2026, 7, 21, 11, 0, 19, 754, DateTimeKind.Local).AddTicks(6380) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 21, 11, 0, 19, 754, DateTimeKind.Local).AddTicks(6276), new DateTime(2026, 7, 21, 11, 0, 19, 754, DateTimeKind.Local).AddTicks(6291) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000001"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 21, 11, 0, 19, 754, DateTimeKind.Local).AddTicks(6986), new DateTime(2026, 7, 21, 11, 0, 19, 754, DateTimeKind.Local).AddTicks(6987) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000002"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 21, 11, 0, 19, 754, DateTimeKind.Local).AddTicks(7064), new DateTime(2026, 7, 21, 11, 0, 19, 754, DateTimeKind.Local).AddTicks(7065) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000003"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 21, 11, 0, 19, 754, DateTimeKind.Local).AddTicks(7076), new DateTime(2026, 7, 21, 11, 0, 19, 754, DateTimeKind.Local).AddTicks(7076) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000004"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 21, 11, 0, 19, 754, DateTimeKind.Local).AddTicks(7087), new DateTime(2026, 7, 21, 11, 0, 19, 754, DateTimeKind.Local).AddTicks(7087) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000005"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 21, 11, 0, 19, 754, DateTimeKind.Local).AddTicks(7140), new DateTime(2026, 7, 21, 11, 0, 19, 754, DateTimeKind.Local).AddTicks(7140) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000006"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 21, 11, 0, 19, 754, DateTimeKind.Local).AddTicks(7153), new DateTime(2026, 7, 21, 11, 0, 19, 754, DateTimeKind.Local).AddTicks(7154) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000007"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 21, 11, 0, 19, 754, DateTimeKind.Local).AddTicks(7164), new DateTime(2026, 7, 21, 11, 0, 19, 754, DateTimeKind.Local).AddTicks(7164) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000008"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 21, 11, 0, 19, 754, DateTimeKind.Local).AddTicks(7193), new DateTime(2026, 7, 21, 11, 0, 19, 754, DateTimeKind.Local).AddTicks(7193) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000009"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 21, 11, 0, 19, 754, DateTimeKind.Local).AddTicks(7204), new DateTime(2026, 7, 21, 11, 0, 19, 754, DateTimeKind.Local).AddTicks(7205) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000010"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 21, 11, 0, 19, 754, DateTimeKind.Local).AddTicks(7219), new DateTime(2026, 7, 21, 11, 0, 19, 754, DateTimeKind.Local).AddTicks(7219) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000011"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 21, 11, 0, 19, 754, DateTimeKind.Local).AddTicks(7248), new DateTime(2026, 7, 21, 11, 0, 19, 754, DateTimeKind.Local).AddTicks(7248) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000012"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 21, 11, 0, 19, 754, DateTimeKind.Local).AddTicks(7259), new DateTime(2026, 7, 21, 11, 0, 19, 754, DateTimeKind.Local).AddTicks(7260) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000013"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 21, 11, 0, 19, 754, DateTimeKind.Local).AddTicks(7269), new DateTime(2026, 7, 21, 11, 0, 19, 754, DateTimeKind.Local).AddTicks(7269) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000014"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 21, 11, 0, 19, 754, DateTimeKind.Local).AddTicks(7280), new DateTime(2026, 7, 21, 11, 0, 19, 754, DateTimeKind.Local).AddTicks(7280) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000015"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 21, 11, 0, 19, 754, DateTimeKind.Local).AddTicks(7309), new DateTime(2026, 7, 21, 11, 0, 19, 754, DateTimeKind.Local).AddTicks(7309) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000016"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 21, 11, 0, 19, 754, DateTimeKind.Local).AddTicks(7319), new DateTime(2026, 7, 21, 11, 0, 19, 754, DateTimeKind.Local).AddTicks(7319) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000017"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 21, 11, 0, 19, 754, DateTimeKind.Local).AddTicks(7330), new DateTime(2026, 7, 21, 11, 0, 19, 754, DateTimeKind.Local).AddTicks(7330) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000018"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 21, 11, 0, 19, 754, DateTimeKind.Local).AddTicks(7361), new DateTime(2026, 7, 21, 11, 0, 19, 754, DateTimeKind.Local).AddTicks(7361) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000019"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 21, 11, 0, 19, 754, DateTimeKind.Local).AddTicks(7371), new DateTime(2026, 7, 21, 11, 0, 19, 754, DateTimeKind.Local).AddTicks(7371) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000020"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 21, 11, 0, 19, 754, DateTimeKind.Local).AddTicks(7382), new DateTime(2026, 7, 21, 11, 0, 19, 754, DateTimeKind.Local).AddTicks(7383) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 21, 11, 0, 19, 754, DateTimeKind.Local).AddTicks(6305), new DateTime(2026, 7, 21, 11, 0, 19, 754, DateTimeKind.Local).AddTicks(6305) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 21, 11, 0, 19, 754, DateTimeKind.Local).AddTicks(6307), new DateTime(2026, 7, 21, 11, 0, 19, 754, DateTimeKind.Local).AddTicks(6308) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 21, 11, 0, 19, 754, DateTimeKind.Local).AddTicks(6313), new DateTime(2026, 7, 21, 11, 0, 19, 754, DateTimeKind.Local).AddTicks(6313) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("55555555-5555-5555-5555-555555555555"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 21, 11, 0, 19, 754, DateTimeKind.Local).AddTicks(6315), new DateTime(2026, 7, 21, 11, 0, 19, 754, DateTimeKind.Local).AddTicks(6316) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666666"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 21, 11, 0, 19, 754, DateTimeKind.Local).AddTicks(6317), new DateTime(2026, 7, 21, 11, 0, 19, 754, DateTimeKind.Local).AddTicks(6318) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("0561ab29-2eba-49bb-b81e-79253986dcba"));

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("09a0e922-ab13-48c6-9905-65ff3d1368db"));

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("266dd46e-3986-4349-badc-cdd9f93d4ff3"));

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("2f07f110-d481-4e4e-ad06-7304dbd03bc4"));

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("41aa5211-41d9-4588-b3e3-93be5a795493"));

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("41e09acd-a45c-452a-b160-e35d0937961b"));

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("468a7aa7-f96a-434a-adb9-55ff4417e9fc"));

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("5f515dfb-afdd-494b-8962-7cba76e2cef2"));

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("604089d4-4678-47c3-9a13-1f9ef2369c6c"));

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("61cbb7d3-3c29-44d5-8fb4-ad5cfaf353d9"));

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("6b44ae4b-e537-492c-a2c3-3a6c6910ab0c"));

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("6ca511a0-87e2-41f5-85eb-62b0148c2372"));

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("797b695d-3ff0-4c3e-b808-c6cbb860d0db"));

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("8642f332-26c4-49b3-9e9a-717eb5635c1c"));

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("a19630ec-36a4-4636-ad75-9b2e43673e60"));

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("a534574a-c17a-4753-a006-15c1f08dada8"));

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("a7fac760-5150-49ef-8c4c-45dfdec000e9"));

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("ba40e913-e8b4-442d-a51b-7d00ed101f54"));

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("c3f6c320-2104-49a5-a03e-a8e2f28d17f9"));

            migrationBuilder.DeleteData(
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("deb669bf-a38e-407c-a327-ddf5b7632e02"));

            migrationBuilder.UpdateData(
                table: "Course",
                keyColumn: "Id",
                keyValue: new Guid("88888888-8888-8888-8888-888888888888"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(908));

            migrationBuilder.UpdateData(
                table: "Module",
                keyColumn: "Id",
                keyValue: new Guid("77777777-7777-7777-7777-777777777777"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(1483), new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(1485) });

            migrationBuilder.UpdateData(
                table: "ModuleItem",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666601"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(1658), new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(1659) });

            migrationBuilder.UpdateData(
                table: "ModuleItem",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666602"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(1671), new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(1672) });

            migrationBuilder.UpdateData(
                table: "ModuleItem",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666603"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(1677), new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(1703) });

            migrationBuilder.UpdateData(
                table: "ModuleItem",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666604"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(1735), new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(1736) });

            migrationBuilder.UpdateData(
                table: "ParentProfile",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 23, 15, 51, 465, DateTimeKind.Local).AddTicks(8826), new DateTime(2026, 7, 20, 23, 15, 51, 465, DateTimeKind.Local).AddTicks(8827) });

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000001"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(4850));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000002"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(5318));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000003"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(5831));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000004"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(6018));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000005"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(6552));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000006"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(6653));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000007"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(6698));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000008"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(6746));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000009"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(7002));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000010"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(7102));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000011"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(7215));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000012"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(7484));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000013"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(7528));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000014"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(7574));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000015"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(7815));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000016"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(7972));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000017"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(8061));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000018"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(8382));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000019"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(8434));

            migrationBuilder.UpdateData(
                table: "Reviews",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000020"),
                column: "LastUpdatedAt",
                value: new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(8472));

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000001"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(4662), new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(4663) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000002"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(5297), new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(5298) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000003"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(5585), new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(5595) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000004"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(6005), new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(6006) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000005"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(6070), new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(6071) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000006"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(6633), new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(6634) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000007"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(6687), new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(6688) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000008"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(6735), new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(6736) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000009"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(6983), new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(6985) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000010"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(7053), new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(7054) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000011"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(7193), new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(7194) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000012"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(7464), new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(7465) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000013"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(7516), new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(7517) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000014"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(7562), new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(7564) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000015"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(7611), new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(7612) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000016"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(7957), new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(7958) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000017"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(8041), new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(8042) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000018"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(8364), new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(8365) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000019"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(8416), new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(8417) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000020"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(8462), new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(8463) });

            migrationBuilder.UpdateData(
                table: "StudentProfile",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 23, 15, 51, 465, DateTimeKind.Local).AddTicks(8653), new DateTime(2026, 7, 20, 23, 15, 51, 465, DateTimeKind.Local).AddTicks(8657) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("11111111-1111-1111-1111-111111111111"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 23, 15, 51, 465, DateTimeKind.Local).AddTicks(7656), new DateTime(2026, 7, 20, 23, 15, 51, 465, DateTimeKind.Local).AddTicks(7745) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000001"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(4407), new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(4415) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000002"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(5005), new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(5006) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000003"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(5372), new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(5373) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000004"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(5950), new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(5951) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000005"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(6038), new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(6039) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000006"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(6599), new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(6600) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000007"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(6671), new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(6672) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000008"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(6716), new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(6717) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000009"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(6958), new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(6959) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000010"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(7033), new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(7033) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000011"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(7174), new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(7176) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000012"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(7442), new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(7442) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000013"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(7502), new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(7503) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000014"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(7543), new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(7544) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000015"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(7592), new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(7593) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000016"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(7940), new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(7941) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000017"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(8001), new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(8002) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000018"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(8339), new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(8341) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000019"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(8399), new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(8400) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-000000000020"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(8448), new DateTime(2026, 7, 20, 23, 15, 51, 466, DateTimeKind.Local).AddTicks(8449) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 23, 15, 51, 465, DateTimeKind.Local).AddTicks(7917), new DateTime(2026, 7, 20, 23, 15, 51, 465, DateTimeKind.Local).AddTicks(7918) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("33333333-3333-3333-3333-333333333333"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 23, 15, 51, 465, DateTimeKind.Local).AddTicks(8106), new DateTime(2026, 7, 20, 23, 15, 51, 465, DateTimeKind.Local).AddTicks(8108) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 23, 15, 51, 465, DateTimeKind.Local).AddTicks(8115), new DateTime(2026, 7, 20, 23, 15, 51, 465, DateTimeKind.Local).AddTicks(8116) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("55555555-5555-5555-5555-555555555555"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 23, 15, 51, 465, DateTimeKind.Local).AddTicks(8121), new DateTime(2026, 7, 20, 23, 15, 51, 465, DateTimeKind.Local).AddTicks(8121) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666666"),
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 7, 20, 23, 15, 51, 465, DateTimeKind.Local).AddTicks(8129), new DateTime(2026, 7, 20, 23, 15, 51, 465, DateTimeKind.Local).AddTicks(8130) });
        }
    }
}
