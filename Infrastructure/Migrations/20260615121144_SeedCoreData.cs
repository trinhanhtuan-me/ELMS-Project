using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedCoreData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "SystemKey",
                columns: new[] { "Id", "code_key", "code_value", "description", "is_deleted", "parent_id", "sort_order" },
                values: new object[,]
                {
                    { 1, "USER_GENDER", 0, "User Gender", false, null, 0 },
                    { 5, "PARENT_LINK_STATUS", 0, "Parent Link Status", false, null, 0 },
                    { 11, "COURSE_STATUS", 0, "Course Status", false, null, 0 },
                    { 18, "ENROLLMENT_STATUS", 0, "Enrollment Status", false, null, 0 },
                    { 21, "MODULE_ITEM_TYPE", 0, "Module Item Type", false, null, 0 },
                    { 26, "LESSON_CONTENT_TYPE", 0, "Lesson Content Type", false, null, 0 },
                    { 29, "QUIZ_ATTEMPT_STATUS", 0, "Quiz Attempt Status", false, null, 0 },
                    { 32, "ASSIGNMENT_SUBMISSION_TYPE", 0, "Assignment Submission Type", false, null, 0 },
                    { 35, "ASSIGNMENT_WORK_STATUS", 0, "Assignment Work Status", false, null, 0 },
                    { 40, "PROGRESS_STATUS", 0, "Progress Status", false, null, 0 },
                    { 43, "FLASHCARD_SET_STATUS", 0, "Flashcard Set Status", false, null, 0 },
                    { 47, "COURSE_REQUEST_STATUS", 0, "Course Request Status", false, null, 0 },
                    { 54, "ORDER_STATUS", 0, "Order Status", false, null, 0 },
                    { 58, "PAYMENT_METHOD", 0, "Payment Method", false, null, 0 },
                    { 63, "PAYMENT_STATUS", 0, "Payment Status", false, null, 0 }
                });

            migrationBuilder.InsertData(
                table: "p_role",
                columns: new[] { "Id", "description", "is_deleted", "name", "status" },
                values: new object[,]
                {
                    { 1, "Administrator Role", false, "Admin", (byte)1 },
                    { 2, "Student Role", false, "Student", (byte)1 },
                    { 3, "Parent Role", false, "Parent", (byte)1 },
                    { 4, "Teacher Role", false, "Teacher", (byte)1 },
                    { 5, "Manager Role", false, "Manager", (byte)1 }
                });

            migrationBuilder.InsertData(
                table: "SystemKey",
                columns: new[] { "Id", "code_key", "code_value", "description", "is_deleted", "parent_id", "sort_order" },
                values: new object[,]
                {
                    { 2, "USER_GENDER_MALE", 1, "Male", false, 1, 1 },
                    { 3, "USER_GENDER_FEMALE", 2, "Female", false, 1, 2 },
                    { 4, "USER_GENDER_OTHER", 3, "Other", false, 1, 3 },
                    { 6, "PARENT_LINK_STATUS_PENDING", 1, "Pending", false, 5, 1 },
                    { 7, "PARENT_LINK_STATUS_APPROVED", 2, "Approved", false, 5, 2 },
                    { 8, "PARENT_LINK_STATUS_REJECTED", 3, "Rejected", false, 5, 3 },
                    { 9, "PARENT_LINK_STATUS_CANCELED", 4, "Canceled", false, 5, 4 },
                    { 10, "PARENT_LINK_STATUS_UNLINK", 5, "Unlink", false, 5, 5 },
                    { 12, "COURSE_STATUS_DRAFT", 1, "Draft", false, 11, 1 },
                    { 13, "COURSE_STATUS_SUBMITTED", 2, "Submitted", false, 11, 2 },
                    { 14, "COURSE_STATUS_APPROVED", 3, "Approved", false, 11, 3 },
                    { 15, "COURSE_STATUS_REJECTED", 4, "Rejected", false, 11, 4 },
                    { 16, "COURSE_STATUS_PUBLISH", 5, "Publish", false, 11, 5 },
                    { 17, "COURSE_STATUS_UNPUBLISH", 6, "Unpublish", false, 11, 6 },
                    { 19, "ENROLLMENT_STATUS_ACTIVE", 1, "Active", false, 18, 1 },
                    { 20, "ENROLLMENT_STATUS_COMPLETED", 2, "Completed", false, 18, 2 },
                    { 22, "MODULE_ITEM_TYPE_LESSON", 1, "Lesson", false, 21, 1 },
                    { 23, "MODULE_ITEM_TYPE_QUIZ", 2, "Quiz", false, 21, 2 },
                    { 24, "MODULE_ITEM_TYPE_ASSIGNMENT", 3, "Assignment", false, 21, 3 },
                    { 25, "MODULE_ITEM_TYPE_DISCUSSION", 4, "Discussion", false, 21, 4 },
                    { 27, "LESSON_CONTENT_TYPE_VIDEO", 1, "Video", false, 26, 1 },
                    { 28, "LESSON_CONTENT_TYPE_READING", 2, "Reading", false, 26, 2 },
                    { 30, "QUIZ_ATTEMPT_STATUS_DRAFT", 1, "Draft", false, 29, 1 },
                    { 31, "QUIZ_ATTEMPT_STATUS_SUBMITTED", 2, "Submitted", false, 29, 2 },
                    { 33, "ASSIGNMENT_SUBMISSION_TYPE_TEXT", 1, "Text", false, 32, 1 },
                    { 34, "ASSIGNMENT_SUBMISSION_TYPE_FILE", 2, "File", false, 32, 2 },
                    { 36, "ASSIGNMENT_WORK_STATUS_DRAFT", 1, "Draft", false, 35, 1 },
                    { 37, "ASSIGNMENT_WORK_STATUS_SUBMITTED", 2, "Submitted", false, 35, 2 },
                    { 38, "ASSIGNMENT_WORK_STATUS_PASSED", 3, "Passed", false, 35, 3 },
                    { 39, "ASSIGNMENT_WORK_STATUS_RETURNED", 4, "Returned", false, 35, 4 },
                    { 41, "PROGRESS_STATUS_IN_PROGRESS", 1, "In Progress", false, 40, 1 },
                    { 42, "PROGRESS_STATUS_COMPLETED", 2, "Completed", false, 40, 2 },
                    { 44, "FLASHCARD_SET_STATUS_PRIVATE", 1, "Private", false, 43, 1 },
                    { 45, "FLASHCARD_SET_STATUS_PUBLIC", 2, "Public", false, 43, 2 },
                    { 46, "FLASHCARD_SET_STATUS_INACTIVE", 3, "Inactive", false, 43, 3 },
                    { 48, "COURSE_REQUEST_STATUS_SAVED", 1, "Saved", false, 47, 1 },
                    { 49, "COURSE_REQUEST_STATUS_PENDING", 2, "Pending", false, 47, 2 },
                    { 50, "COURSE_REQUEST_STATUS_APPROVED", 3, "Approved", false, 47, 3 },
                    { 51, "COURSE_REQUEST_STATUS_UNPAID", 4, "Unpaid", false, 47, 4 },
                    { 52, "COURSE_REQUEST_STATUS_REJECTED", 5, "Rejected", false, 47, 5 },
                    { 53, "COURSE_REQUEST_STATUS_CANCELED", 6, "Canceled", false, 47, 6 },
                    { 55, "ORDER_STATUS_PENDING", 1, "Pending", false, 54, 1 },
                    { 56, "ORDER_STATUS_PAID", 2, "Paid", false, 54, 2 },
                    { 57, "ORDER_STATUS_CANCELLED", 3, "Cancelled", false, 54, 3 },
                    { 59, "PAYMENT_METHOD_CARD", 1, "Card", false, 58, 1 },
                    { 60, "PAYMENT_METHOD_BANK_TRANSFER", 2, "Bank Transfer", false, 58, 2 },
                    { 61, "PAYMENT_METHOD_E_WALLET", 3, "E-Wallet", false, 58, 3 },
                    { 62, "PAYMENT_METHOD_CASH", 4, "Cash", false, 58, 4 },
                    { 64, "PAYMENT_STATUS_INITIATED", 1, "Initiated", false, 63, 1 },
                    { 65, "PAYMENT_STATUS_CAPTURED", 2, "Captured", false, 63, 2 },
                    { 66, "PAYMENT_STATUS_FAILED", 3, "Failed", false, 63, 3 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "SystemKey",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "SystemKey",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "SystemKey",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "SystemKey",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "SystemKey",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "SystemKey",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "SystemKey",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "SystemKey",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "SystemKey",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "SystemKey",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "SystemKey",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "SystemKey",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "SystemKey",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "SystemKey",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "SystemKey",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "SystemKey",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "SystemKey",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "SystemKey",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "SystemKey",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "SystemKey",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "SystemKey",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "SystemKey",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "SystemKey",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "SystemKey",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "SystemKey",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "SystemKey",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "SystemKey",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "SystemKey",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "SystemKey",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "SystemKey",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "SystemKey",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "SystemKey",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "SystemKey",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "SystemKey",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "SystemKey",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "SystemKey",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "SystemKey",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "SystemKey",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "SystemKey",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "SystemKey",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "SystemKey",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "SystemKey",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "SystemKey",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "SystemKey",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "SystemKey",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "SystemKey",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "SystemKey",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "SystemKey",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "SystemKey",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "SystemKey",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "SystemKey",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "p_role",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "p_role",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "p_role",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "p_role",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "p_role",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "SystemKey",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SystemKey",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "SystemKey",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "SystemKey",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "SystemKey",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "SystemKey",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "SystemKey",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "SystemKey",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "SystemKey",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "SystemKey",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "SystemKey",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "SystemKey",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "SystemKey",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "SystemKey",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "SystemKey",
                keyColumn: "Id",
                keyValue: 63);
        }
    }
}
