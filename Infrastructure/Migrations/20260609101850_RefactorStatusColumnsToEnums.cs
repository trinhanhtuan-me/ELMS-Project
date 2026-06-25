using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class RefactorStatusColumnsToEnums : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Gender",
                table: "Users",
                type: "int",
                nullable: true,
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Status",
                table: "QuizAttempt",
                type: "int",
                nullable: false,
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldDefaultValue: (byte)1);

            migrationBuilder.AlterColumn<int>(
                name: "Status",
                table: "Progress",
                type: "int",
                nullable: false,
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldDefaultValue: (byte)1);

            migrationBuilder.AlterColumn<int>(
                name: "Status",
                table: "Payments",
                type: "int",
                nullable: false,
                oldClrType: typeof(byte),
                oldType: "tinyint");

            migrationBuilder.AlterColumn<int>(
                name: "PaymentMethod",
                table: "Payments",
                type: "int",
                nullable: false,
                oldClrType: typeof(byte),
                oldType: "tinyint");

            migrationBuilder.AlterColumn<int>(
                name: "Status",
                table: "ParentLinkRequests",
                type: "int",
                nullable: false,
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldDefaultValue: (byte)1);

            migrationBuilder.AlterColumn<byte>(
                name: "status",
                table: "p_role",
                type: "tinyint",
                nullable: false,
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldDefaultValue: (byte)1);

            migrationBuilder.AlterColumn<int>(
                name: "Status",
                table: "Orders",
                type: "int",
                nullable: false,
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldDefaultValue: (byte)1);

            migrationBuilder.AlterColumn<int>(
                name: "PaymentMethod",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ItemType",
                table: "ModuleItem",
                type: "int",
                nullable: false,
                oldClrType: typeof(byte),
                oldType: "tinyint");

            migrationBuilder.AlterColumn<int>(
                name: "ContentType",
                table: "Lesson",
                type: "int",
                nullable: false,
                oldClrType: typeof(byte),
                oldType: "tinyint");

            migrationBuilder.AlterColumn<int>(
                name: "Status",
                table: "FlashcardSets",
                type: "int",
                nullable: false,
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldDefaultValue: (byte)1);

            migrationBuilder.AlterColumn<int>(
                name: "Status",
                table: "Enrollments",
                type: "int",
                nullable: false,
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldDefaultValue: (byte)1);

            migrationBuilder.AlterColumn<int>(
                name: "Status",
                table: "CourseRequests",
                type: "int",
                nullable: false,
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldDefaultValue: (byte)1);

            migrationBuilder.AlterColumn<int>(
                name: "Status",
                table: "Course",
                type: "int",
                nullable: false,
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldDefaultValue: (byte)1);

            migrationBuilder.AlterColumn<int>(
                name: "Status",
                table: "AssignmentWork",
                type: "int",
                nullable: false,
                oldClrType: typeof(byte),
                oldType: "tinyint",
                oldDefaultValue: (byte)1);

            migrationBuilder.AlterColumn<int>(
                name: "SubmissionType",
                table: "Assignment",
                type: "int",
                nullable: false,
                oldClrType: typeof(byte),
                oldType: "tinyint");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<byte>(
                name: "Gender",
                table: "Users",
                type: "tinyint",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<byte>(
                name: "Status",
                table: "QuizAttempt",
                type: "tinyint",
                nullable: false,
                defaultValue: (byte)1,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<byte>(
                name: "Status",
                table: "Progress",
                type: "tinyint",
                nullable: false,
                defaultValue: (byte)1,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<byte>(
                name: "Status",
                table: "Payments",
                type: "tinyint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<byte>(
                name: "PaymentMethod",
                table: "Payments",
                type: "tinyint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<byte>(
                name: "Status",
                table: "ParentLinkRequests",
                type: "tinyint",
                nullable: false,
                defaultValue: (byte)1,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<byte>(
                name: "status",
                table: "p_role",
                type: "tinyint",
                nullable: false,
                defaultValue: (byte)1,
                oldClrType: typeof(byte),
                oldType: "tinyint");

            migrationBuilder.AlterColumn<byte>(
                name: "Status",
                table: "Orders",
                type: "tinyint",
                nullable: false,
                defaultValue: (byte)1,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<byte>(
                name: "PaymentMethod",
                table: "Orders",
                type: "tinyint",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<byte>(
                name: "ItemType",
                table: "ModuleItem",
                type: "tinyint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<byte>(
                name: "ContentType",
                table: "Lesson",
                type: "tinyint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<byte>(
                name: "Status",
                table: "FlashcardSets",
                type: "tinyint",
                nullable: false,
                defaultValue: (byte)1,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<byte>(
                name: "Status",
                table: "Enrollments",
                type: "tinyint",
                nullable: false,
                defaultValue: (byte)1,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<byte>(
                name: "Status",
                table: "CourseRequests",
                type: "tinyint",
                nullable: false,
                defaultValue: (byte)1,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<byte>(
                name: "Status",
                table: "Course",
                type: "tinyint",
                nullable: false,
                defaultValue: (byte)1,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<byte>(
                name: "Status",
                table: "AssignmentWork",
                type: "tinyint",
                nullable: false,
                defaultValue: (byte)1,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<byte>(
                name: "SubmissionType",
                table: "Assignment",
                type: "tinyint",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }
    }
}
