using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedStudentFunctions_Full : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            // DELETE OLD SEED DATA
            migrationBuilder.DeleteData(table: "p_function", keyColumn: "Id", keyValue: 100);
            migrationBuilder.DeleteData(table: "p_function", keyColumn: "Id", keyValue: 101);
            migrationBuilder.DeleteData(table: "p_function", keyColumn: "Id", keyValue: 102);
            migrationBuilder.DeleteData(table: "p_category", keyColumn: "Id", keyValue: 100);
            migrationBuilder.DeleteData(table: "p_category", keyColumn: "Id", keyValue: 101);

            // INSERT CATEGORIES
            migrationBuilder.InsertData(
                table: "p_category",
                columns: new[] { "Id", "description", "identity" },
                values: new object[,]
                {
                    { 1, "Không gian Học tập", "Learning" },
                    { 2, "Kiểm tra & Đánh giá", "Testing" },
                    { 3, "Kết nối Phụ huynh", "Family" },
                    { 4, "Hồ sơ & Bảo mật", "Profile" },
                    { 5, "Hệ thống Quản trị", "System" }
                });

            // INSERT FUNCTIONS
            migrationBuilder.InsertData(
                table: "p_function",
                columns: new[] { "Id", "category_id", "description", "is_deleted", "permission_key" },
                values: new object[,]
                {
                    { 1, 1, "Truy cập lớp học", false, "/Learning" },
                    { 2, 1, "Đọc nội dung bài học", false, "/Learning/GetItemContent" },
                    { 3, 1, "Đánh dấu hoàn thành bài", false, "/Learning/MarkReadingCompleted" },
                    { 4, 1, "Xem biểu đồ tiến độ học tập", false, "/MyProgress" },
                    
                    { 5, 2, "Bắt đầu làm Trắc nghiệm", false, "/Learning/StartQuizAttempt" },
                    { 6, 2, "Nộp bài Trắc nghiệm", false, "/Learning/TakeQuiz" },
                    { 7, 2, "Nộp bài Tự luận", false, "/Learning/SubmitAssignment" },
                    { 8, 2, "Trả lời câu hỏi trong bài", false, "/Learning/SubmitLessonQuestion" },
                    { 9, 2, "Viết đánh giá khóa học mới", false, "/CourseReview/Create" },
                    { 10, 2, "Chỉnh sửa đánh giá khóa học", false, "/CourseReview/Update" },
                    
                    { 11, 3, "Xem danh sách Phụ huynh liên kết", false, "/StudentFamily" },
                    { 12, 3, "Gửi lời mời liên kết cho Phụ huynh", false, "/StudentFamily/SendRequest" },
                    { 13, 3, "Hủy lời mời liên kết", false, "/StudentFamily/CancelRequest" },
                    { 14, 3, "Hủy liên kết với Phụ huynh hiện tại", false, "/StudentFamily/Unlink" },
                    { 15, 3, "Gửi yêu cầu xin mua khóa học", false, "/StudentFamily/SendCourseRequest" },
                    { 16, 3, "Hủy yêu cầu xin mua khóa học", false, "/StudentFamily/CancelCourseRequest" },
                    
                    { 17, 4, "Xem hồ sơ cá nhân", false, "/StudentProfile" },
                    { 18, 4, "Cập nhật hồ sơ cá nhân", false, "/StudentProfile/Update" },
                    { 19, 4, "Truy cập cài đặt bảo mật", false, "/SecurityManagement" },
                    { 20, 4, "Đổi mật khẩu", false, "/SecurityManagement/ChangePassword" },
                    
                    { 21, 5, "Quản lý Vai trò & Phân quyền", false, "/Role" }
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            // REMOVE NEW SEED DATA
            for (int i = 1; i <= 21; i++)
            {
                migrationBuilder.DeleteData(table: "p_function", keyColumn: "Id", keyValue: i);
            }
            for (int i = 1; i <= 5; i++)
            {
                migrationBuilder.DeleteData(table: "p_category", keyColumn: "Id", keyValue: i);
            }

            // RESTORE OLD SEED DATA
            migrationBuilder.InsertData(
                table: "p_category",
                columns: new[] { "Id", "description", "identity" },
                values: new object[,]
                {
                    { 100, "Hệ thống", "System" },
                    { 101, "Người dùng", "User" }
                });

            migrationBuilder.InsertData(
                table: "p_function",
                columns: new[] { "Id", "category_id", "description", "is_deleted", "permission_key" },
                values: new object[,]
                {
                    { 100, 100, "Cài đặt hệ thống", false, "System/Setting" },
                    { 101, 101, "Xem người dùng", false, "User/View" },
                    { 102, 101, "Tạo người dùng", false, "User/Create" }
                });

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
    }
}
