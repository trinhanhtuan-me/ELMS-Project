using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Picture = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Categori__3214EC07993CDB00", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Otp",
                columns: table => new
                {
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExpiryDate = table.Column<DateTime>(type: "datetime", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Otp__A9D10535055C2095", x => x.Email);
                });

            migrationBuilder.CreateTable(
                name: "p_category",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    identity = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__p_catego__3214EC0795538515", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "p_role",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    status = table.Column<byte>(type: "tinyint", nullable: false, defaultValue: (byte)1),
                    is_deleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__p_role__3214EC07B368DDB1", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SystemKey",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    parent_id = table.Column<int>(type: "int", nullable: true),
                    code_key = table.Column<string>(type: "varchar(128)", unicode: false, maxLength: 128, nullable: false),
                    code_value = table.Column<int>(type: "int", nullable: false),
                    description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    sort_order = table.Column<int>(type: "int", nullable: true, defaultValue: 0),
                    is_deleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__SystemKe__3214EC074AF795E4", x => x.Id);
                    table.ForeignKey(
                        name: "FK__SystemKey__paren__7EF6D905",
                        column: x => x.parent_id,
                        principalTable: "SystemKey",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newsequentialid())"),
                    Username = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    Avatar = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    FullName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Password = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    DateOfBirth = table.Column<DateOnly>(type: "date", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Gender = table.Column<byte>(type: "tinyint", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "(sysdatetime())"),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "(sysdatetime())"),
                    LastUpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Users__3214EC07E0D93620", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "p_function",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    category_id = table.Column<int>(type: "int", nullable: false),
                    permission_key = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    is_deleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__p_functi__3214EC07D19C8E01", x => x.Id);
                    table.ForeignKey(
                        name: "FK__p_functio__categ__6DCC4D03",
                        column: x => x.category_id,
                        principalTable: "p_category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InstructorProfile",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Bio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Expertise = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Qualifications = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "(sysdatetime())"),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "(sysdatetime())"),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Instruct__3214EC0746B47B69", x => x.Id);
                    table.ForeignKey(
                        name: "FK__InstructorPr__Id__11158940",
                        column: x => x.Id,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ManagerProfile",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Position = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Specialization = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "(sysdatetime())"),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "(sysdatetime())"),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__ManagerP__3214EC07690C9E3E", x => x.Id);
                    table.ForeignKey(
                        name: "FK__ManagerProfi__Id__15DA3E5D",
                        column: x => x.Id,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OAuthAccounts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newsequentialid())"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Provider = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    ProviderUserId = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__OAuthAcc__3214EC07C50EB307", x => x.Id);
                    table.ForeignKey(
                        name: "FK__OAuthAcco__UserI__2EA5EC27",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "p_user_role",
                columns: table => new
                {
                    user_id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    role_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__p_user_r__6EDEA1538933C941", x => new { x.user_id, x.role_id });
                    table.ForeignKey(
                        name: "FK__p_user_ro__role___7B264821",
                        column: x => x.role_id,
                        principalTable: "p_role",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK__p_user_ro__user___7A3223E8",
                        column: x => x.user_id,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ParentProfile",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Occupation = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "(sysdatetime())"),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "(sysdatetime())"),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__ParentPr__3214EC0761A9CA55", x => x.Id);
                    table.ForeignKey(
                        name: "FK__ParentProfil__Id__0697FACD",
                        column: x => x.Id,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PasswordResetTokens",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newsequentialid())"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Token = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: false),
                    ExpiresAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UsedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "(sysdatetime())"),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
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

            migrationBuilder.CreateTable(
                name: "p_role_function",
                columns: table => new
                {
                    role_id = table.Column<int>(type: "int", nullable: false),
                    function_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__p_role_f__29C13F1CC669E777", x => new { x.role_id, x.function_id });
                    table.ForeignKey(
                        name: "FK__p_role_fu__funct__7755B73D",
                        column: x => x.function_id,
                        principalTable: "p_function",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK__p_role_fu__role___76619304",
                        column: x => x.role_id,
                        principalTable: "p_role",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Course",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newsequentialid())"),
                    Title = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Language = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Level = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Thumbnail = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Status = table.Column<byte>(type: "tinyint", nullable: false, defaultValue: (byte)1),
                    PublishAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "(sysdatetime())"),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "(sysdatetime())"),
                    LastUpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Course__3214EC073A17DE83", x => x.Id);
                    table.ForeignKey(
                        name: "FK__Course__Category__373B3228",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK__Course__CreatedB__36470DEF",
                        column: x => x.CreatedBy,
                        principalTable: "InstructorProfile",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newsequentialid())"),
                    ParentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Status = table.Column<byte>(type: "tinyint", nullable: false, defaultValue: (byte)1),
                    PaymentMethod = table.Column<byte>(type: "tinyint", nullable: true),
                    PaidAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "(sysdatetime())"),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Orders__3214EC07E3CDB0A4", x => x.Id);
                    table.ForeignKey(
                        name: "FK__Orders__ParentId__408F9238",
                        column: x => x.ParentId,
                        principalTable: "ParentProfile",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "StudentProfile",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GradeLevel = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Institution = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ParentId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "(sysdatetime())"),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "(sysdatetime())"),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__StudentP__3214EC07A84EDAD7", x => x.Id);
                    table.ForeignKey(
                        name: "FK__StudentPr__Paren__0C50D423",
                        column: x => x.ParentId,
                        principalTable: "ParentProfile",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK__StudentProfi__Id__0B5CAFEA",
                        column: x => x.Id,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CourseManagers",
                columns: table => new
                {
                    CourseId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RejectReason = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseManagers", x => new { x.CourseId, x.UserId });
                    table.ForeignKey(
                        name: "FK__CourseMan__Cours__44952D46",
                        column: x => x.CourseId,
                        principalTable: "Course",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK__CourseMan__UserI__4589517F",
                        column: x => x.UserId,
                        principalTable: "ManagerProfile",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "CoursePrice",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newsequentialid())"),
                    CourseId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PriceAmount = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    EffectiveDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "(sysdatetime())"),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "(sysdatetime())"),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "(sysdatetime())"),
                    LastUpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__CoursePr__3214EC07B99E2D14", x => x.Id);
                    table.ForeignKey(
                        name: "FK__CoursePri__Cours__3DE82FB7",
                        column: x => x.CourseId,
                        principalTable: "Course",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Module",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newsequentialid())"),
                    CourseId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    OrderIndex = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "(sysdatetime())"),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "(sysdatetime())"),
                    LastUpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Module__3214EC071960FC2D", x => x.Id);
                    table.ForeignKey(
                        name: "FK__Module__CourseId__50FB042B",
                        column: x => x.CourseId,
                        principalTable: "Course",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newsequentialid())"),
                    OrderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AmountVnd = table.Column<decimal>(type: "decimal(12,2)", nullable: false),
                    PaymentMethod = table.Column<byte>(type: "tinyint", nullable: false),
                    Status = table.Column<byte>(type: "tinyint", nullable: false),
                    TxnRef = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    CapturedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "(sysdatetime())"),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Payments__3214EC07BECFF7B9", x => x.Id);
                    table.ForeignKey(
                        name: "FK__Payments__OrderI__4EDDB18F",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CourseRequests",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newsequentialid())"),
                    StudentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CourseId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ParentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Status = table.Column<byte>(type: "tinyint", nullable: false, defaultValue: (byte)1),
                    Note = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DecidedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "(sysdatetime())"),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__CourseRe__3214EC07E863B1BB", x => x.Id);
                    table.ForeignKey(
                        name: "FK__CourseReq__Cours__39E294A9",
                        column: x => x.CourseId,
                        principalTable: "Course",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK__CourseReq__Paren__3AD6B8E2",
                        column: x => x.ParentId,
                        principalTable: "ParentProfile",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK__CourseReq__Stude__38EE7070",
                        column: x => x.StudentId,
                        principalTable: "StudentProfile",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Enrollments",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newsequentialid())"),
                    CourseId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StudentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Status = table.Column<byte>(type: "tinyint", nullable: false, defaultValue: (byte)1),
                    EnrolledAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "(sysdatetime())"),
                    CompletedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Enrollme__3214EC0779269BF9", x => x.Id);
                    table.ForeignKey(
                        name: "FK__Enrollmen__Cours__4959E263",
                        column: x => x.CourseId,
                        principalTable: "Course",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK__Enrollmen__Stude__4A4E069C",
                        column: x => x.StudentId,
                        principalTable: "StudentProfile",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "FlashcardSets",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newsequentialid())"),
                    StudentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Status = table.Column<byte>(type: "tinyint", nullable: false, defaultValue: (byte)1),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "(sysdatetime())"),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "(sysdatetime())"),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Flashcar__3214EC079963F2DD", x => x.Id);
                    table.ForeignKey(
                        name: "FK__Flashcard__Stude__22FF2F51",
                        column: x => x.StudentId,
                        principalTable: "StudentProfile",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ParentLinkRequests",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newsequentialid())"),
                    StudentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ParentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Status = table.Column<byte>(type: "tinyint", nullable: false, defaultValue: (byte)1),
                    Note = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    DecidedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "(sysdatetime())"),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__ParentLi__3214EC0720C12F86", x => x.Id);
                    table.ForeignKey(
                        name: "FK__ParentLin__Paren__22401542",
                        column: x => x.ParentId,
                        principalTable: "ParentProfile",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK__ParentLin__Stude__214BF109",
                        column: x => x.StudentId,
                        principalTable: "StudentProfile",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newsequentialid())"),
                    CourseId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StudentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Rating = table.Column<byte>(type: "tinyint", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "(sysdatetime())"),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "(sysdatetime())"),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Reviews__3214EC07C19495F3", x => x.Id);
                    table.ForeignKey(
                        name: "FK__Reviews__CourseI__30592A6F",
                        column: x => x.CourseId,
                        principalTable: "Course",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK__Reviews__Student__314D4EA8",
                        column: x => x.StudentId,
                        principalTable: "StudentProfile",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "StudentVocabulary",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newsequentialid())"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Word = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Phonetic = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    AudioUrl = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    PartOfSpeech = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Definition = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    Example = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    Synonyms = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    Antonyms = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "(sysdatetime())"),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "(sysdatetime())"),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__StudentV__3214EC074EFB6526", x => x.Id);
                    table.ForeignKey(
                        name: "FK__StudentVo__UserI__1B9317B3",
                        column: x => x.UserId,
                        principalTable: "StudentProfile",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ModuleItem",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newsequentialid())"),
                    ModuleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ItemType = table.Column<byte>(type: "tinyint", nullable: false),
                    OrderIndex = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "(sysdatetime())"),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "(sysdatetime())"),
                    LastUpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__ModuleIt__3214EC0798DF46D0", x => x.Id);
                    table.ForeignKey(
                        name: "FK__ModuleIte__Modul__57A801BA",
                        column: x => x.ModuleId,
                        principalTable: "Module",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderItems",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newsequentialid())"),
                    OrderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RequestId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CourseId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StudentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PriceVnd = table.Column<decimal>(type: "decimal(12,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__OrderIte__3214EC0700B32BF3", x => x.Id);
                    table.ForeignKey(
                        name: "FK__OrderItem__Cours__4924D839",
                        column: x => x.CourseId,
                        principalTable: "Course",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK__OrderItem__Order__473C8FC7",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK__OrderItem__Reque__4830B400",
                        column: x => x.RequestId,
                        principalTable: "CourseRequests",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK__OrderItem__Stude__4A18FC72",
                        column: x => x.StudentId,
                        principalTable: "StudentProfile",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Flashcards",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newsequentialid())"),
                    SetId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FrontText = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    BackText = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "(sysdatetime())"),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "(sysdatetime())"),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Flashcar__3214EC0737C6A2F3", x => x.Id);
                    table.ForeignKey(
                        name: "FK__Flashcard__SetId__29AC2CE0",
                        column: x => x.SetId,
                        principalTable: "FlashcardSets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Assignment",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Instructions = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SubmissionType = table.Column<byte>(type: "tinyint", nullable: false),
                    AttachmentUrl = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    MaxScore = table.Column<decimal>(type: "decimal(6,2)", nullable: false, defaultValue: 100m),
                    PassingScorePct = table.Column<decimal>(type: "decimal(5,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Assignme__3214EC07D9839F64", x => x.Id);
                    table.ForeignKey(
                        name: "FK__Assignment__Id__084B3915",
                        column: x => x.Id,
                        principalTable: "ModuleItem",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Discussion",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Discussi__3214EC07F06DF961", x => x.Id);
                    table.ForeignKey(
                        name: "FK__Discussion__Id__11D4A34F",
                        column: x => x.Id,
                        principalTable: "ModuleItem",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Lesson",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    ContentType = table.Column<byte>(type: "tinyint", nullable: false),
                    VideoUrl = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    DurationSec = table.Column<int>(type: "int", nullable: true),
                    TextContent = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Lesson__3214EC071AA94531", x => x.Id);
                    table.ForeignKey(
                        name: "FK__Lesson__Id__5C6CB6D7",
                        column: x => x.Id,
                        principalTable: "ModuleItem",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Progress",
                columns: table => new
                {
                    StudentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ModuleItemId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Status = table.Column<byte>(type: "tinyint", nullable: false, defaultValue: (byte)1),
                    PercentDone = table.Column<decimal>(type: "decimal(5,2)", nullable: false),
                    ScorePct = table.Column<decimal>(type: "decimal(5,2)", nullable: true),
                    StartedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CompletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "(sysdatetime())")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Progress__9CEE653A05D9D328", x => new { x.StudentId, x.ModuleItemId });
                    table.ForeignKey(
                        name: "FK__Progress__Module__1C5231C2",
                        column: x => x.ModuleItemId,
                        principalTable: "ModuleItem",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK__Progress__Studen__1B5E0D89",
                        column: x => x.StudentId,
                        principalTable: "StudentProfile",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Quiz",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    PassingScorePct = table.Column<decimal>(type: "decimal(5,2)", nullable: false, defaultValue: 50.00m),
                    PickCount = table.Column<int>(type: "int", nullable: true),
                    TimeLimitMin = table.Column<int>(type: "int", nullable: true),
                    MaxAttempts = table.Column<int>(type: "int", nullable: false, defaultValue: 3)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Quiz__3214EC07423BF1CC", x => x.Id);
                    table.ForeignKey(
                        name: "FK__Quiz__Id__67DE6983",
                        column: x => x.Id,
                        principalTable: "ModuleItem",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AssignmentWork",
                columns: table => new
                {
                    AssignmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StudentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TextAnswer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FileUrl = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    Status = table.Column<byte>(type: "tinyint", nullable: false, defaultValue: (byte)1),
                    Score = table.Column<decimal>(type: "decimal(6,2)", nullable: true),
                    GraderId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    FeedbackText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DraftSavedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SubmittedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GradedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Assignme__B165CCCE4390C321", x => new { x.AssignmentId, x.StudentId });
                    table.ForeignKey(
                        name: "FK__Assignmen__Assig__0C1BC9F9",
                        column: x => x.AssignmentId,
                        principalTable: "Assignment",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK__Assignmen__Grade__0EF836A4",
                        column: x => x.GraderId,
                        principalTable: "InstructorProfile",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK__Assignmen__Stude__0D0FEE32",
                        column: x => x.StudentId,
                        principalTable: "StudentProfile",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "DiscussionReplies",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newsequentialid())"),
                    DiscussionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ParentReplyId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    AuthorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "(sysdatetime())"),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastUpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastUpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Discussi__3214EC075CA3EA89", x => x.Id);
                    table.ForeignKey(
                        name: "FK__Discussio__Autho__178D7CA5",
                        column: x => x.AuthorId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK__Discussio__Discu__15A53433",
                        column: x => x.DiscussionId,
                        principalTable: "Discussion",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK__Discussio__Paren__1699586C",
                        column: x => x.ParentReplyId,
                        principalTable: "DiscussionReplies",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "LessonQuestion",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newsequentialid())"),
                    LessonId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Explanation = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__LessonQu__3214EC07DC88D140", x => x.Id);
                    table.ForeignKey(
                        name: "FK__LessonQue__Lesso__603D47BB",
                        column: x => x.LessonId,
                        principalTable: "Lesson",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "QuizAttempt",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newsequentialid())"),
                    QuizId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StudentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AttemptNo = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<byte>(type: "tinyint", nullable: false, defaultValue: (byte)1),
                    ScorePct = table.Column<decimal>(type: "decimal(5,2)", nullable: true),
                    IsPassed = table.Column<bool>(type: "bit", nullable: false),
                    StartedAt = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "(sysdatetime())"),
                    DeadlineAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SubmittedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__QuizAtte__3214EC070E7C79F7", x => x.Id);
                    table.ForeignKey(
                        name: "FK__QuizAttem__QuizI__7814D14C",
                        column: x => x.QuizId,
                        principalTable: "Quiz",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK__QuizAttem__Stude__7908F585",
                        column: x => x.StudentId,
                        principalTable: "StudentProfile",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "QuizQuestion",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newsequentialid())"),
                    QuizId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MediaUrl = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    Explanation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__QuizQues__3214EC0706B6327D", x => x.Id);
                    table.ForeignKey(
                        name: "FK__QuizQuest__QuizI__6D9742D9",
                        column: x => x.QuizId,
                        principalTable: "Quiz",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LessonOption",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newsequentialid())"),
                    QuestionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsCorrect = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__LessonOp__3214EC072E73BC5F", x => x.Id);
                    table.ForeignKey(
                        name: "FK__LessonOpt__Quest__640DD89F",
                        column: x => x.QuestionId,
                        principalTable: "LessonQuestion",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "QuizAttemptQuestion",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newsequentialid())"),
                    AttemptId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    QuestionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DisplayOrder = table.Column<byte>(type: "tinyint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__QuizAtte__3214EC0793843CCD", x => x.Id);
                    table.ForeignKey(
                        name: "FK__QuizAttem__Attem__00AA174D",
                        column: x => x.AttemptId,
                        principalTable: "QuizAttempt",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK__QuizAttem__Quest__019E3B86",
                        column: x => x.QuestionId,
                        principalTable: "QuizQuestion",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "QuizOption",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false, defaultValueSql: "(newsequentialid())"),
                    QuestionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsCorrect = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__QuizOpti__3214EC07D2B00FB3", x => x.Id);
                    table.ForeignKey(
                        name: "FK__QuizOptio__Quest__725BF7F6",
                        column: x => x.QuestionId,
                        principalTable: "QuizQuestion",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AttemptAnswer",
                columns: table => new
                {
                    AttemptId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ChosenOptionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsCorrect = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__AttemptA__93BFE65D20CC1582", x => new { x.AttemptId, x.ChosenOptionId });
                    table.ForeignKey(
                        name: "FK__AttemptAn__Attem__047AA831",
                        column: x => x.AttemptId,
                        principalTable: "QuizAttempt",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK__AttemptAn__Chose__056ECC6A",
                        column: x => x.ChosenOptionId,
                        principalTable: "QuizOption",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_AssignmentWork_GraderId",
                table: "AssignmentWork",
                column: "GraderId");

            migrationBuilder.CreateIndex(
                name: "IX_AssignmentWork_StudentId",
                table: "AssignmentWork",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_AttemptAnswer_ChosenOptionId",
                table: "AttemptAnswer",
                column: "ChosenOptionId");

            migrationBuilder.CreateIndex(
                name: "UQ__Categori__737584F64FC3C943",
                table: "Categories",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Course_CategoryId",
                table: "Course",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Course_CreatedBy",
                table: "Course",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_CourseManagers_UserId",
                table: "CourseManagers",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "UQ_CoursePrice_Active_OnePriceOnly",
                table: "CoursePrice",
                column: "CourseId",
                unique: true,
                filter: "([IsActive]=(1))");

            migrationBuilder.CreateIndex(
                name: "IX_CourseRequests_CourseId",
                table: "CourseRequests",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseRequests_ParentId",
                table: "CourseRequests",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "UQ_CourseRequests_StudentCourse",
                table: "CourseRequests",
                columns: new[] { "StudentId", "CourseId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_DiscussionReplies_AuthorId",
                table: "DiscussionReplies",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_DiscussionReplies_DiscussionId",
                table: "DiscussionReplies",
                column: "DiscussionId");

            migrationBuilder.CreateIndex(
                name: "IX_DiscussionReplies_ParentReplyId",
                table: "DiscussionReplies",
                column: "ParentReplyId");

            migrationBuilder.CreateIndex(
                name: "IX_Enrollments_CourseId",
                table: "Enrollments",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Enrollments_StudentId",
                table: "Enrollments",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_Flashcards_SetId",
                table: "Flashcards",
                column: "SetId");

            migrationBuilder.CreateIndex(
                name: "IX_FlashcardSets_StudentId",
                table: "FlashcardSets",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_LessonOption_QuestionId",
                table: "LessonOption",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_LessonQuestion_LessonId",
                table: "LessonQuestion",
                column: "LessonId");

            migrationBuilder.CreateIndex(
                name: "UQ_Module_CourseOrder",
                table: "Module",
                columns: new[] { "CourseId", "OrderIndex" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UQ_ModuleItem_ModuleOrder",
                table: "ModuleItem",
                columns: new[] { "ModuleId", "OrderIndex" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_OAuthAccounts_UserId",
                table: "OAuthAccounts",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "UQ_OAuth_provider_uid",
                table: "OAuthAccounts",
                columns: new[] { "Provider", "ProviderUserId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_CourseId",
                table: "OrderItems",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_RequestId",
                table: "OrderItems",
                column: "RequestId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_StudentId",
                table: "OrderItems",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "UQ_OrderItems",
                table: "OrderItems",
                columns: new[] { "OrderId", "CourseId", "StudentId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Orders_ParentId",
                table: "Orders",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_p_function_category_id",
                table: "p_function",
                column: "category_id");

            migrationBuilder.CreateIndex(
                name: "UQ__p_functi__9E2779BD01846E20",
                table: "p_function",
                column: "permission_key",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UQ__p_role__72E12F1BBF2AD974",
                table: "p_role",
                column: "name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_p_role_function_function_id",
                table: "p_role_function",
                column: "function_id");

            migrationBuilder.CreateIndex(
                name: "IX_p_user_role_role_id",
                table: "p_user_role",
                column: "role_id");

            migrationBuilder.CreateIndex(
                name: "IX_ParentLinkRequests_ParentId",
                table: "ParentLinkRequests",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_ParentLinkRequests_StudentId",
                table: "ParentLinkRequests",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "IX_PasswordResetTokens_UserId",
                table: "PasswordResetTokens",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "UQ__Password__1EB4F8175944EB96",
                table: "PasswordResetTokens",
                column: "Token",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Payments_OrderId",
                table: "Payments",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "UQ__Payments__DE7ABA53BF5879A5",
                table: "Payments",
                column: "TxnRef",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Progress_ModuleItemId",
                table: "Progress",
                column: "ModuleItemId");

            migrationBuilder.CreateIndex(
                name: "IX_QuizAttempt_StudentId",
                table: "QuizAttempt",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "UQ_QuizAttempt",
                table: "QuizAttempt",
                columns: new[] { "QuizId", "StudentId", "AttemptNo" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_QuizAttemptQuestion_AttemptId",
                table: "QuizAttemptQuestion",
                column: "AttemptId");

            migrationBuilder.CreateIndex(
                name: "IX_QuizAttemptQuestion_QuestionId",
                table: "QuizAttemptQuestion",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_QuizOption_QuestionId",
                table: "QuizOption",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_QuizQuestion_QuizId",
                table: "QuizQuestion",
                column: "QuizId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_StudentId",
                table: "Reviews",
                column: "StudentId");

            migrationBuilder.CreateIndex(
                name: "UQ_Review",
                table: "Reviews",
                columns: new[] { "CourseId", "StudentId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_StudentProfile_ParentId",
                table: "StudentProfile",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentVocabulary_UserId",
                table: "StudentVocabulary",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_SystemKey_parent_id",
                table: "SystemKey",
                column: "parent_id");

            migrationBuilder.CreateIndex(
                name: "UQ_SystemKey_Code",
                table: "SystemKey",
                columns: new[] { "code_key", "code_value" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UQ__Users__536C85E490C1A94A",
                table: "Users",
                column: "Username",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UQ__Users__A9D10534AF3DCAB6",
                table: "Users",
                column: "Email",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AssignmentWork");

            migrationBuilder.DropTable(
                name: "AttemptAnswer");

            migrationBuilder.DropTable(
                name: "CourseManagers");

            migrationBuilder.DropTable(
                name: "CoursePrice");

            migrationBuilder.DropTable(
                name: "DiscussionReplies");

            migrationBuilder.DropTable(
                name: "Enrollments");

            migrationBuilder.DropTable(
                name: "Flashcards");

            migrationBuilder.DropTable(
                name: "LessonOption");

            migrationBuilder.DropTable(
                name: "OAuthAccounts");

            migrationBuilder.DropTable(
                name: "OrderItems");

            migrationBuilder.DropTable(
                name: "Otp");

            migrationBuilder.DropTable(
                name: "p_role_function");

            migrationBuilder.DropTable(
                name: "p_user_role");

            migrationBuilder.DropTable(
                name: "ParentLinkRequests");

            migrationBuilder.DropTable(
                name: "PasswordResetTokens");

            migrationBuilder.DropTable(
                name: "Payments");

            migrationBuilder.DropTable(
                name: "Progress");

            migrationBuilder.DropTable(
                name: "QuizAttemptQuestion");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "StudentVocabulary");

            migrationBuilder.DropTable(
                name: "SystemKey");

            migrationBuilder.DropTable(
                name: "Assignment");

            migrationBuilder.DropTable(
                name: "QuizOption");

            migrationBuilder.DropTable(
                name: "ManagerProfile");

            migrationBuilder.DropTable(
                name: "Discussion");

            migrationBuilder.DropTable(
                name: "FlashcardSets");

            migrationBuilder.DropTable(
                name: "LessonQuestion");

            migrationBuilder.DropTable(
                name: "CourseRequests");

            migrationBuilder.DropTable(
                name: "p_function");

            migrationBuilder.DropTable(
                name: "p_role");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "QuizAttempt");

            migrationBuilder.DropTable(
                name: "QuizQuestion");

            migrationBuilder.DropTable(
                name: "Lesson");

            migrationBuilder.DropTable(
                name: "p_category");

            migrationBuilder.DropTable(
                name: "StudentProfile");

            migrationBuilder.DropTable(
                name: "Quiz");

            migrationBuilder.DropTable(
                name: "ParentProfile");

            migrationBuilder.DropTable(
                name: "ModuleItem");

            migrationBuilder.DropTable(
                name: "Module");

            migrationBuilder.DropTable(
                name: "Course");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "InstructorProfile");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
