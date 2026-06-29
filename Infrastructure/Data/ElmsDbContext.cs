using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Domain.Entities;
namespace Infrastructure.Data;

public partial class ElmsDbContext : DbContext
{
    public ElmsDbContext()
    {
    }

    public ElmsDbContext(DbContextOptions<ElmsDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Assignment> Assignments { get; set; }

    public virtual DbSet<AssignmentWork> AssignmentWorks { get; set; }

    public virtual DbSet<AttemptAnswer> AttemptAnswers { get; set; }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<Course> Courses { get; set; }

    public virtual DbSet<CourseManager> CourseManagers { get; set; }

    public virtual DbSet<CoursePrice> CoursePrices { get; set; }

    public virtual DbSet<CourseRequest> CourseRequests { get; set; }

    public virtual DbSet<Discussion> Discussions { get; set; }

    public virtual DbSet<DiscussionReply> DiscussionReplies { get; set; }

    public virtual DbSet<Enrollment> Enrollments { get; set; }

    public virtual DbSet<Flashcard> Flashcards { get; set; }

    public virtual DbSet<FlashcardSet> FlashcardSets { get; set; }

    public virtual DbSet<InstructorProfile> InstructorProfiles { get; set; }

    public virtual DbSet<Lesson> Lessons { get; set; }

    public virtual DbSet<LessonOption> LessonOptions { get; set; }

    public virtual DbSet<LessonQuestion> LessonQuestions { get; set; }

    public virtual DbSet<ManagerProfile> ManagerProfiles { get; set; }

    public virtual DbSet<Module> Modules { get; set; }

    public virtual DbSet<ModuleItem> ModuleItems { get; set; }

    public virtual DbSet<OauthAccount> OauthAccounts { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<OrderItem> OrderItems { get; set; }

    public virtual DbSet<Otp> Otps { get; set; }

    public virtual DbSet<PCategory> PCategories { get; set; }

    public virtual DbSet<PFunction> PFunctions { get; set; }

    public virtual DbSet<PRole> PRoles { get; set; }

    public virtual DbSet<ParentLinkRequest> ParentLinkRequests { get; set; }

    public virtual DbSet<ParentProfile> ParentProfiles { get; set; }

    public virtual DbSet<PasswordResetToken> PasswordResetTokens { get; set; }

    public virtual DbSet<Payment> Payments { get; set; }

    public virtual DbSet<Progress> Progresses { get; set; }

    public virtual DbSet<Quiz> Quizzes { get; set; }

    public virtual DbSet<QuizAttempt> QuizAttempts { get; set; }

    public virtual DbSet<QuizAttemptQuestion> QuizAttemptQuestions { get; set; }

    public virtual DbSet<QuizOption> QuizOptions { get; set; }

    public virtual DbSet<QuizQuestion> QuizQuestions { get; set; }

    public virtual DbSet<Review> Reviews { get; set; }

    public virtual DbSet<StudentProfile> StudentProfiles { get; set; }

    public virtual DbSet<StudentVocabulary> StudentVocabularies { get; set; }

    public virtual DbSet<SystemKey> SystemKeys { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<Mail> Mails { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Assignment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Assignme__3214EC07D9839F64");

            entity.ToTable("Assignment");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.AttachmentUrl).HasMaxLength(1000);
            entity.Property(e => e.MaxScore)
                .HasDefaultValue(100m)
                .HasColumnType("decimal(6, 2)");
            entity.Property(e => e.PassingScorePct).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.Title).HasMaxLength(255);

            entity.HasOne(d => d.IdNavigation).WithOne(p => p.Assignment)
                .HasForeignKey<Assignment>(d => d.Id)
                .HasConstraintName("FK__Assignment__Id__084B3915");
        });

        modelBuilder.Entity<AssignmentWork>(entity =>
        {
            entity.HasKey(e => new { e.AssignmentId, e.StudentId }).HasName("PK__Assignme__B165CCCE4390C321");

            entity.ToTable("AssignmentWork");

            entity.Property(e => e.FileUrl).HasMaxLength(1000);
            entity.Property(e => e.Score).HasColumnType("decimal(6, 2)");
            entity.Property(e => e.Status);

            entity.HasOne(d => d.Assignment).WithMany(p => p.AssignmentWorks)
                .HasForeignKey(d => d.AssignmentId)
                .HasConstraintName("FK__Assignmen__Assig__0C1BC9F9");

            entity.HasOne(d => d.Grader).WithMany(p => p.AssignmentWorks)
                .HasForeignKey(d => d.GraderId)
                .HasConstraintName("FK__Assignmen__Grade__0EF836A4");

            entity.HasOne(d => d.Student).WithMany(p => p.AssignmentWorks)
                .HasForeignKey(d => d.StudentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Assignmen__Stude__0D0FEE32");
        });

        modelBuilder.Entity<AttemptAnswer>(entity =>
        {
            entity.HasKey(e => new { e.AttemptId, e.ChosenOptionId }).HasName("PK__AttemptA__93BFE65D20CC1582");

            entity.ToTable("AttemptAnswer");

            entity.HasOne(d => d.Attempt).WithMany(p => p.AttemptAnswers)
                .HasForeignKey(d => d.AttemptId)
                .HasConstraintName("FK__AttemptAn__Attem__047AA831");

            entity.HasOne(d => d.ChosenOption).WithMany(p => p.AttemptAnswers)
                .HasForeignKey(d => d.ChosenOptionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__AttemptAn__Chose__056ECC6A");
        });

        modelBuilder.Entity<Category>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Categori__3214EC07993CDB00");

            entity.HasIndex(e => e.Name, "UQ__Categori__737584F64FC3C943").IsUnique();

            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.Name).HasMaxLength(100);
            entity.Property(e => e.Picture).HasMaxLength(255);
        });

        modelBuilder.Entity<Course>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Course__3214EC073A17DE83");

            entity.ToTable("Course");

            entity.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");
            entity.Property(e => e.CreatedAt).HasDefaultValueSql("(sysdatetime())");
            entity.Property(e => e.Language)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Level)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Status);
            entity.Property(e => e.Thumbnail).HasMaxLength(255);
            entity.Property(e => e.Title).HasMaxLength(255);
            entity.Property(e => e.UpdatedAt).HasDefaultValueSql("(sysdatetime())");

            entity.HasOne(d => d.Category).WithMany(p => p.Courses)
                .HasForeignKey(d => d.CategoryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Course__Category__373B3228");

            entity.HasOne(d => d.CreatedByNavigation).WithMany(p => p.Courses)
                .HasForeignKey(d => d.CreatedBy)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Course__CreatedB__36470DEF");
        });

        modelBuilder.Entity<CourseManager>(entity =>
        {
            entity.HasKey(e => new { e.CourseId, e.UserId });

            entity.Property(e => e.RejectReason).HasMaxLength(500);

            entity.HasOne(d => d.Course).WithMany(p => p.CourseManagers)
                .HasForeignKey(d => d.CourseId)
                .HasConstraintName("FK__CourseMan__Cours__44952D46");

            entity.HasOne(d => d.User).WithMany(p => p.CourseManagers)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__CourseMan__UserI__4589517F");
        });

        modelBuilder.Entity<CoursePrice>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CoursePr__3214EC07B99E2D14");

            entity.ToTable("CoursePrice");

            entity.HasIndex(e => e.CourseId, "UQ_CoursePrice_Active_OnePriceOnly")
                .IsUnique()
                .HasFilter("([IsActive]=(1))");

            entity.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");
            entity.Property(e => e.CreatedAt).HasDefaultValueSql("(sysdatetime())");
            entity.Property(e => e.EffectiveDate).HasDefaultValueSql("(sysdatetime())");
            entity.Property(e => e.IsActive).HasDefaultValue(true);
            entity.Property(e => e.PriceAmount).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.UpdatedAt).HasDefaultValueSql("(sysdatetime())");

            entity.HasOne(d => d.Course).WithOne(p => p.CoursePrice)
                .HasForeignKey<CoursePrice>(d => d.CourseId)
                .HasConstraintName("FK__CoursePri__Cours__3DE82FB7");
        });

        modelBuilder.Entity<CourseRequest>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CourseRe__3214EC07E863B1BB");

            entity.HasIndex(e => new { e.StudentId, e.CourseId }, "UQ_CourseRequests_StudentCourse").IsUnique();

            entity.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");
            entity.Property(e => e.CreatedAt).HasDefaultValueSql("(sysdatetime())");
            entity.Property(e => e.Note).HasMaxLength(255);
            entity.Property(e => e.Status);

            entity.HasOne(d => d.Course).WithMany(p => p.CourseRequests)
                .HasForeignKey(d => d.CourseId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__CourseReq__Cours__39E294A9");

            entity.HasOne(d => d.Parent).WithMany(p => p.CourseRequests)
                .HasForeignKey(d => d.ParentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__CourseReq__Paren__3AD6B8E2");

            entity.HasOne(d => d.Student).WithMany(p => p.CourseRequests)
                .HasForeignKey(d => d.StudentId)
                .HasConstraintName("FK__CourseReq__Stude__38EE7070");
        });

        modelBuilder.Entity<Discussion>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Discussi__3214EC07F06DF961");

            entity.ToTable("Discussion");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Title).HasMaxLength(255);

            entity.HasOne(d => d.IdNavigation).WithOne(p => p.Discussion)
                .HasForeignKey<Discussion>(d => d.Id)
                .HasConstraintName("FK__Discussion__Id__11D4A34F");
        });

        modelBuilder.Entity<DiscussionReply>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Discussi__3214EC075CA3EA89");

            entity.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");
            entity.Property(e => e.CreatedAt).HasDefaultValueSql("(sysdatetime())");

            entity.HasOne(d => d.Author).WithMany(p => p.DiscussionReplies)
                .HasForeignKey(d => d.AuthorId)
                .OnDelete(DeleteBehavior.SetNull)
                .HasConstraintName("FK__Discussio__Autho__178D7CA5");

            entity.HasOne(d => d.Discussion).WithMany(p => p.DiscussionReplies)
                .HasForeignKey(d => d.DiscussionId)
                .HasConstraintName("FK__Discussio__Discu__15A53433");

            entity.HasOne(d => d.ParentReply).WithMany(p => p.InverseParentReply)
                .HasForeignKey(d => d.ParentReplyId)
                .HasConstraintName("FK__Discussio__Paren__1699586C");
        });

        modelBuilder.Entity<Enrollment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Enrollme__3214EC0779269BF9");

            entity.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");
            entity.Property(e => e.EnrolledAt).HasDefaultValueSql("(sysdatetime())");
            entity.Property(e => e.Status);

            entity.HasOne(d => d.Course).WithMany(p => p.Enrollments)
                .HasForeignKey(d => d.CourseId)
                .HasConstraintName("FK__Enrollmen__Cours__4959E263");

            entity.HasOne(d => d.Student).WithMany(p => p.Enrollments)
                .HasForeignKey(d => d.StudentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Enrollmen__Stude__4A4E069C");
        });

        modelBuilder.Entity<Flashcard>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Flashcar__3214EC0737C6A2F3");

            entity.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");
            entity.Property(e => e.BackText).HasMaxLength(255);
            entity.Property(e => e.CreatedAt).HasDefaultValueSql("(sysdatetime())");
            entity.Property(e => e.FrontText).HasMaxLength(255);
            entity.Property(e => e.UpdatedAt).HasDefaultValueSql("(sysdatetime())");

            entity.HasOne(d => d.Set).WithMany(p => p.Flashcards)
                .HasForeignKey(d => d.SetId)
                .HasConstraintName("FK__Flashcard__SetId__29AC2CE0");
        });

        modelBuilder.Entity<FlashcardSet>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Flashcar__3214EC079963F2DD");

            entity.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");
            entity.Property(e => e.CreatedAt).HasDefaultValueSql("(sysdatetime())");
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.Status);
            entity.Property(e => e.Title).HasMaxLength(255);
            entity.Property(e => e.UpdatedAt).HasDefaultValueSql("(sysdatetime())");

            entity.HasOne(d => d.Student).WithMany(p => p.FlashcardSets)
                .HasForeignKey(d => d.StudentId)
                .HasConstraintName("FK__Flashcard__Stude__22FF2F51");
        });

        modelBuilder.Entity<InstructorProfile>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Instruct__3214EC0746B47B69");

            entity.ToTable("InstructorProfile");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreatedAt).HasDefaultValueSql("(sysdatetime())");
            entity.Property(e => e.Expertise).HasMaxLength(255);
            entity.Property(e => e.Qualifications).HasMaxLength(255);
            entity.Property(e => e.UpdatedAt).HasDefaultValueSql("(sysdatetime())");

            entity.HasOne(d => d.IdNavigation).WithOne(p => p.InstructorProfile)
                .HasForeignKey<InstructorProfile>(d => d.Id)
                .HasConstraintName("FK__InstructorPr__Id__11158940");
        });

        modelBuilder.Entity<Lesson>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Lesson__3214EC071AA94531");

            entity.ToTable("Lesson");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Title).HasMaxLength(255);
            entity.Property(e => e.VideoUrl).HasMaxLength(1000);

            entity.HasOne(d => d.IdNavigation).WithOne(p => p.Lesson)
                .HasForeignKey<Lesson>(d => d.Id)
                .HasConstraintName("FK__Lesson__Id__5C6CB6D7");
        });

        modelBuilder.Entity<LessonOption>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__LessonOp__3214EC072E73BC5F");

            entity.ToTable("LessonOption");

            entity.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");

            entity.HasOne(d => d.Question).WithMany(p => p.LessonOptions)
                .HasForeignKey(d => d.QuestionId)
                .HasConstraintName("FK__LessonOpt__Quest__640DD89F");
        });

        modelBuilder.Entity<LessonQuestion>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__LessonQu__3214EC07DC88D140");

            entity.ToTable("LessonQuestion");

            entity.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");

            entity.HasOne(d => d.Lesson).WithMany(p => p.LessonQuestions)
                .HasForeignKey(d => d.LessonId)
                .HasConstraintName("FK__LessonQue__Lesso__603D47BB");
        });

        modelBuilder.Entity<ManagerProfile>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ManagerP__3214EC07690C9E3E");

            entity.ToTable("ManagerProfile");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.CreatedAt).HasDefaultValueSql("(sysdatetime())");
            entity.Property(e => e.Position).HasMaxLength(100);
            entity.Property(e => e.Specialization).HasMaxLength(255);
            entity.Property(e => e.UpdatedAt).HasDefaultValueSql("(sysdatetime())");

            entity.HasOne(d => d.IdNavigation).WithOne(p => p.ManagerProfile)
                .HasForeignKey<ManagerProfile>(d => d.Id)
                .HasConstraintName("FK__ManagerProfi__Id__15DA3E5D");
        });

        modelBuilder.Entity<Module>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Module__3214EC071960FC2D");

            entity.ToTable("Module");

            entity.HasIndex(e => new { e.CourseId, e.OrderIndex }, "UQ_Module_CourseOrder").IsUnique();

            entity.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");
            entity.Property(e => e.CreatedAt).HasDefaultValueSql("(sysdatetime())");
            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.Title).HasMaxLength(255);
            entity.Property(e => e.UpdatedAt).HasDefaultValueSql("(sysdatetime())");

            entity.HasOne(d => d.Course).WithMany(p => p.Modules)
                .HasForeignKey(d => d.CourseId)
                .HasConstraintName("FK__Module__CourseId__50FB042B");
        });

        modelBuilder.Entity<ModuleItem>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ModuleIt__3214EC0798DF46D0");

            entity.ToTable("ModuleItem");

            entity.HasIndex(e => new { e.ModuleId, e.OrderIndex }, "UQ_ModuleItem_ModuleOrder").IsUnique();

            entity.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");
            entity.Property(e => e.CreatedAt).HasDefaultValueSql("(sysdatetime())");
            entity.Property(e => e.UpdatedAt).HasDefaultValueSql("(sysdatetime())");

            entity.HasOne(d => d.Module).WithMany(p => p.ModuleItems)
                .HasForeignKey(d => d.ModuleId)
                .HasConstraintName("FK__ModuleIte__Modul__57A801BA");
        });

        modelBuilder.Entity<OauthAccount>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__OAuthAcc__3214EC07C50EB307");

            entity.ToTable("OAuthAccounts");

            entity.HasIndex(e => new { e.Provider, e.ProviderUserId }, "UQ_OAuth_provider_uid").IsUnique();

            entity.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");
            entity.Property(e => e.Provider)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ProviderUserId)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.HasOne(d => d.User).WithMany(p => p.OauthAccounts)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK__OAuthAcco__UserI__2EA5EC27");
        });

        modelBuilder.Entity<Order>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Orders__3214EC07E3CDB0A4");

            entity.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");
            entity.Property(e => e.CreatedAt).HasDefaultValueSql("(sysdatetime())");
            entity.Property(e => e.Status);

            entity.HasOne(d => d.Parent).WithMany(p => p.Orders)
                .HasForeignKey(d => d.ParentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Orders__ParentId__408F9238");
        });

        modelBuilder.Entity<OrderItem>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__OrderIte__3214EC0700B32BF3");

            entity.HasIndex(e => new { e.OrderId, e.CourseId, e.StudentId }, "UQ_OrderItems").IsUnique();

            entity.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");
            entity.Property(e => e.PriceVnd).HasColumnType("decimal(12, 2)");

            entity.HasOne(d => d.Course).WithMany(p => p.OrderItems)
                .HasForeignKey(d => d.CourseId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__OrderItem__Cours__4924D839");

            entity.HasOne(d => d.Order).WithMany(p => p.OrderItems)
                .HasForeignKey(d => d.OrderId)
                .HasConstraintName("FK__OrderItem__Order__473C8FC7");

            entity.HasOne(d => d.Request).WithMany(p => p.OrderItems)
                .HasForeignKey(d => d.RequestId)
                .HasConstraintName("FK__OrderItem__Reque__4830B400");

            entity.HasOne(d => d.Student).WithMany(p => p.OrderItems)
                .HasForeignKey(d => d.StudentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__OrderItem__Stude__4A18FC72");
        });

        modelBuilder.Entity<Otp>(entity =>
        {
            entity.HasKey(e => new { e.Email, e.Type }).HasName("PK__Otp__A9D10535055C2095");

            entity.ToTable("Otp");

            entity.Property(e => e.Email).HasMaxLength(256);
            entity.Property(e => e.ExpiryDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<PCategory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__p_catego__3214EC0795538515");

            entity.ToTable("p_category");

            entity.Property(e => e.Description)
                .HasMaxLength(250)
                .HasColumnName("description");
            entity.Property(e => e.Identity)
                .HasMaxLength(250)
                .IsUnicode(false)
                .HasColumnName("identity");

            entity.HasData(
                new PCategory { Id = 100, Identity = "System", Description = "Hệ thống" },
                new PCategory { Id = 101, Identity = "User", Description = "Người dùng" }
            );
        });

        modelBuilder.Entity<PFunction>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__p_functi__3214EC07D19C8E01");

            entity.ToTable("p_function");

            entity.HasIndex(e => e.PermissionKey, "UQ__p_functi__9E2779BD01846E20").IsUnique();

            entity.Property(e => e.CategoryId).HasColumnName("category_id");
            entity.Property(e => e.Description)
                .HasMaxLength(250)
                .HasColumnName("description");
            entity.Property(e => e.IsDeleted).HasColumnName("is_deleted");
            entity.Property(e => e.PermissionKey)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("permission_key");

            entity.HasOne(d => d.Category).WithMany(p => p.PFunctions)
                .HasForeignKey(d => d.CategoryId)
                .HasConstraintName("FK__p_functio__categ__6DCC4D03");

            entity.HasData(
                new PFunction { Id = 100, CategoryId = 100, PermissionKey = "System/Setting", Description = "Cài đặt hệ thống", IsDeleted = false },
                new PFunction { Id = 101, CategoryId = 101, PermissionKey = "User/View", Description = "Xem người dùng", IsDeleted = false },
                new PFunction { Id = 102, CategoryId = 101, PermissionKey = "User/Create", Description = "Tạo người dùng", IsDeleted = false }
            );
        });

        modelBuilder.Entity<PRole>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__p_role__3214EC07B368DDB1");

            entity.ToTable("p_role");

            entity.HasIndex(e => e.Name, "UQ__p_role__72E12F1BBF2AD974").IsUnique();

            entity.Property(e => e.Description)
                .HasMaxLength(250)
                .HasColumnName("description");
            entity.Property(e => e.IsDeleted).HasColumnName("is_deleted");
            entity.Property(e => e.Name)
                .HasMaxLength(100)
                .HasColumnName("name");
            entity.Property(e => e.Status)

                .HasColumnName("status");

            entity.HasMany(d => d.Functions).WithMany(p => p.Roles)
                .UsingEntity<Dictionary<string, object>>(
                    "PRoleFunction",
                    r => r.HasOne<PFunction>().WithMany()
                        .HasForeignKey("FunctionId")
                        .HasConstraintName("FK__p_role_fu__funct__7755B73D"),
                    l => l.HasOne<PRole>().WithMany()
                        .HasForeignKey("RoleId")
                        .HasConstraintName("FK__p_role_fu__role___76619304"),
                    j =>
                    {
                        j.HasKey("RoleId", "FunctionId").HasName("PK__p_role_f__29C13F1CC669E777");
                        j.ToTable("p_role_function");
                        j.IndexerProperty<int>("RoleId").HasColumnName("role_id");
                        j.IndexerProperty<int>("FunctionId").HasColumnName("function_id");
                    });
        });

        modelBuilder.Entity<ParentLinkRequest>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ParentLi__3214EC0720C12F86");

            entity.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");
            entity.Property(e => e.CreatedAt).HasDefaultValueSql("(sysdatetime())");
            entity.Property(e => e.Note).HasMaxLength(255);
            entity.Property(e => e.Status);

            entity.HasOne(d => d.Parent).WithMany(p => p.ParentLinkRequests)
                .HasForeignKey(d => d.ParentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ParentLin__Paren__22401542");

            entity.HasOne(d => d.Student).WithMany(p => p.ParentLinkRequests)
                .HasForeignKey(d => d.StudentId)
                .HasConstraintName("FK__ParentLin__Stude__214BF109");
        });

        modelBuilder.Entity<ParentProfile>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ParentPr__3214EC0761A9CA55");

            entity.ToTable("ParentProfile");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Address).HasMaxLength(255);
            entity.Property(e => e.CreatedAt).HasDefaultValueSql("(sysdatetime())");
            entity.Property(e => e.Occupation).HasMaxLength(100);
            entity.Property(e => e.UpdatedAt).HasDefaultValueSql("(sysdatetime())");

            entity.HasOne(d => d.IdNavigation).WithOne(p => p.ParentProfile)
                .HasForeignKey<ParentProfile>(d => d.Id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ParentProfil__Id__0697FACD");
        });

        modelBuilder.Entity<PasswordResetToken>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Password__3214EC07BFB33313");

            entity.HasIndex(e => e.Token, "UQ__Password__1EB4F8175944EB96").IsUnique();

            entity.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");
            entity.Property(e => e.CreatedAt).HasDefaultValueSql("(sysdatetime())");
            entity.Property(e => e.Token)
                .HasMaxLength(255)
                .IsUnicode(false);

            entity.HasOne(d => d.User).WithMany(p => p.PasswordResetTokens)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK__PasswordR__UserI__28ED12D1");
        });

        modelBuilder.Entity<Payment>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Payments__3214EC07BECFF7B9");

            entity.HasIndex(e => e.TxnRef, "UQ__Payments__DE7ABA53BF5879A5").IsUnique();

            entity.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");
            entity.Property(e => e.AmountVnd).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.CreatedAt).HasDefaultValueSql("(sysdatetime())");
            entity.Property(e => e.TxnRef).HasMaxLength(64);

            entity.HasOne(d => d.Order).WithMany(p => p.Payments)
                .HasForeignKey(d => d.OrderId)
                .HasConstraintName("FK__Payments__OrderI__4EDDB18F");
        });

        modelBuilder.Entity<Progress>(entity =>
        {
            entity.HasKey(e => new { e.StudentId, e.ModuleItemId }).HasName("PK__Progress__9CEE653A05D9D328");

            entity.ToTable("Progress");

            entity.Property(e => e.PercentDone).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.ScorePct).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.Status);
            entity.Property(e => e.UpdatedAt).HasDefaultValueSql("(sysdatetime())");

            entity.HasOne(d => d.ModuleItem).WithMany(p => p.Progresses)
                .HasForeignKey(d => d.ModuleItemId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Progress__Module__1C5231C2");

            entity.HasOne(d => d.Student).WithMany(p => p.Progresses)
                .HasForeignKey(d => d.StudentId)
                .HasConstraintName("FK__Progress__Studen__1B5E0D89");
        });

        modelBuilder.Entity<Quiz>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Quiz__3214EC07423BF1CC");

            entity.ToTable("Quiz");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.MaxAttempts).HasDefaultValue(3);
            entity.Property(e => e.PassingScorePct)
                .HasDefaultValue(50.00m)
                .HasColumnType("decimal(5, 2)");
            entity.Property(e => e.Title).HasMaxLength(255);

            entity.HasOne(d => d.IdNavigation).WithOne(p => p.Quiz)
                .HasForeignKey<Quiz>(d => d.Id)
                .HasConstraintName("FK__Quiz__Id__67DE6983");
        });

        modelBuilder.Entity<QuizAttempt>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__QuizAtte__3214EC070E7C79F7");

            entity.ToTable("QuizAttempt");

            entity.HasIndex(e => new { e.QuizId, e.StudentId, e.AttemptNo }, "UQ_QuizAttempt").IsUnique();

            entity.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");
            entity.Property(e => e.ScorePct).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.StartedAt).HasDefaultValueSql("(sysdatetime())");
            entity.Property(e => e.Status);

            entity.HasOne(d => d.Quiz).WithMany(p => p.QuizAttempts)
                .HasForeignKey(d => d.QuizId)
                .HasConstraintName("FK__QuizAttem__QuizI__7814D14C");

            entity.HasOne(d => d.Student).WithMany(p => p.QuizAttempts)
                .HasForeignKey(d => d.StudentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__QuizAttem__Stude__7908F585");
        });

        modelBuilder.Entity<QuizAttemptQuestion>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__QuizAtte__3214EC0793843CCD");

            entity.ToTable("QuizAttemptQuestion");

            entity.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");

            entity.HasOne(d => d.Attempt).WithMany(p => p.QuizAttemptQuestions)
                .HasForeignKey(d => d.AttemptId)
                .HasConstraintName("FK__QuizAttem__Attem__00AA174D");

            entity.HasOne(d => d.Question).WithMany(p => p.QuizAttemptQuestions)
                .HasForeignKey(d => d.QuestionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__QuizAttem__Quest__019E3B86");
        });

        modelBuilder.Entity<QuizOption>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__QuizOpti__3214EC07D2B00FB3");

            entity.ToTable("QuizOption");

            entity.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");

            entity.HasOne(d => d.Question).WithMany(p => p.QuizOptions)
                .HasForeignKey(d => d.QuestionId)
                .HasConstraintName("FK__QuizOptio__Quest__725BF7F6");
        });

        modelBuilder.Entity<QuizQuestion>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__QuizQues__3214EC0706B6327D");

            entity.ToTable("QuizQuestion");

            entity.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");
            entity.Property(e => e.MediaUrl).HasMaxLength(1000);

            entity.HasOne(d => d.Quiz).WithMany(p => p.QuizQuestions)
                .HasForeignKey(d => d.QuizId)
                .HasConstraintName("FK__QuizQuest__QuizI__6D9742D9");
        });

        modelBuilder.Entity<Review>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Reviews__3214EC07C19495F3");

            entity.HasIndex(e => new { e.CourseId, e.StudentId }, "UQ_Review").IsUnique();

            entity.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");
            entity.Property(e => e.Comment).HasMaxLength(500);
            entity.Property(e => e.CreatedAt).HasDefaultValueSql("(sysdatetime())");
            entity.Property(e => e.UpdatedAt).HasDefaultValueSql("(sysdatetime())");

            entity.HasOne(d => d.Course).WithMany(p => p.Reviews)
                .HasForeignKey(d => d.CourseId)
                .HasConstraintName("FK__Reviews__CourseI__30592A6F");

            entity.HasOne(d => d.Student).WithMany(p => p.Reviews)
                .HasForeignKey(d => d.StudentId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Reviews__Student__314D4EA8");
        });

        modelBuilder.Entity<StudentProfile>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__StudentP__3214EC07A84EDAD7");

            entity.ToTable("StudentProfile");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Address).HasMaxLength(255);
            entity.Property(e => e.CreatedAt).HasDefaultValueSql("(sysdatetime())");
            entity.Property(e => e.GradeLevel).HasMaxLength(50);
            entity.Property(e => e.Institution).HasMaxLength(255);
            entity.Property(e => e.UpdatedAt).HasDefaultValueSql("(sysdatetime())");

            entity.HasOne(d => d.IdNavigation).WithOne(p => p.StudentProfile)
                .HasForeignKey<StudentProfile>(d => d.Id)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__StudentProfi__Id__0B5CAFEA");

            entity.HasOne(d => d.Parent).WithMany(p => p.StudentProfiles)
                .HasForeignKey(d => d.ParentId)
                .HasConstraintName("FK__StudentPr__Paren__0C50D423");
        });

        modelBuilder.Entity<StudentVocabulary>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__StudentV__3214EC074EFB6526");

            entity.ToTable("StudentVocabulary");

            entity.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");
            entity.Property(e => e.Antonyms).HasMaxLength(1000);
            entity.Property(e => e.AudioUrl).HasMaxLength(200);
            entity.Property(e => e.CreatedAt).HasDefaultValueSql("(sysdatetime())");
            entity.Property(e => e.Definition).HasMaxLength(1000);
            entity.Property(e => e.Example).HasMaxLength(1000);
            entity.Property(e => e.PartOfSpeech).HasMaxLength(50);
            entity.Property(e => e.Phonetic).HasMaxLength(100);
            entity.Property(e => e.Synonyms).HasMaxLength(1000);
            entity.Property(e => e.UpdatedAt).HasDefaultValueSql("(sysdatetime())");
            entity.Property(e => e.Word).HasMaxLength(255);

            entity.HasOne(d => d.User).WithMany(p => p.StudentVocabularies)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK__StudentVo__UserI__1B9317B3");
        });

        modelBuilder.Entity<SystemKey>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__SystemKe__3214EC074AF795E4");

            entity.ToTable("SystemKey");

            entity.HasIndex(e => new { e.CodeKey, e.CodeValue }, "UQ_SystemKey_Code").IsUnique();

            entity.Property(e => e.CodeKey)
                .HasMaxLength(128)
                .IsUnicode(false)
                .HasColumnName("code_key");
            entity.Property(e => e.CodeValue).HasColumnName("code_value");
            entity.Property(e => e.Description)
                .HasMaxLength(255)
                .HasColumnName("description");
            entity.Property(e => e.IsDeleted).HasColumnName("is_deleted");
            entity.Property(e => e.ParentId).HasColumnName("parent_id");
            entity.Property(e => e.SortOrder)
                .HasDefaultValue(0)
                .HasColumnName("sort_order");

            entity.HasOne(d => d.Parent).WithMany(p => p.InverseParent)
                .HasForeignKey(d => d.ParentId)
                .HasConstraintName("FK__SystemKey__paren__7EF6D905");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Users__3214EC07E0D93620");

            entity.HasIndex(e => e.Username, "UQ__Users__536C85E490C1A94A").IsUnique();

            entity.HasIndex(e => e.Email, "UQ__Users__A9D10534AF3DCAB6").IsUnique();

            entity.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");
            entity.Property(e => e.Avatar).HasMaxLength(255);
            entity.Property(e => e.CreatedAt).HasDefaultValueSql("(sysdatetime())");
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.FullName).HasMaxLength(255);
            entity.Property(e => e.Password)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Phone).HasMaxLength(20);
            entity.Property(e => e.UpdatedAt).HasDefaultValueSql("(sysdatetime())");
            entity.Property(e => e.Username)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasMany(d => d.Roles).WithMany(p => p.Users)
                .UsingEntity<Dictionary<string, object>>(
                    "PUserRole",
                    r => r.HasOne<PRole>().WithMany()
                        .HasForeignKey("RoleId")
                        .HasConstraintName("FK__p_user_ro__role___7B264821"),
                    l => l.HasOne<User>().WithMany()
                        .HasForeignKey("UserId")
                        .HasConstraintName("FK__p_user_ro__user___7A3223E8"),
                    j =>
                    {
                        j.HasKey("UserId", "RoleId").HasName("PK__p_user_r__6EDEA1538933C941");
                        j.ToTable("p_user_role");
                        j.IndexerProperty<Guid>("UserId").HasColumnName("user_id");
                        j.IndexerProperty<int>("RoleId").HasColumnName("role_id");
                    });
        });

        modelBuilder.Entity<Mail>(entity =>
        {
            entity.HasKey(e => e.Id);

            entity.Property(e => e.To)
                .IsRequired()
                .HasMaxLength(150);
            entity.Property(e => e.Subject)
                .IsRequired()
                .HasMaxLength(255);

            entity.Property(e => e.Body)
                .IsRequired();

            entity.Property(e => e.Status)
                .IsRequired();
        });


        // Data Seeding for 5 core roles
        modelBuilder.Entity<PRole>().HasData(
            new PRole { Id = 1, Name = "Admin", Status = Domain.Enums.RoleStatus.Active, IsDeleted = false, Description = "Administrator Role" },
            new PRole { Id = 2, Name = "Student", Status = Domain.Enums.RoleStatus.Active, IsDeleted = false, Description = "Student Role" },
            new PRole { Id = 3, Name = "Parent", Status = Domain.Enums.RoleStatus.Active, IsDeleted = false, Description = "Parent Role" },
            new PRole { Id = 4, Name = "Teacher", Status = Domain.Enums.RoleStatus.Active, IsDeleted = false, Description = "Teacher Role" },
            new PRole { Id = 5, Name = "Manager", Status = Domain.Enums.RoleStatus.Active, IsDeleted = false, Description = "Manager Role" }
        );

        // Data Seeding for Users
        var adminId = Guid.Parse("11111111-1111-1111-1111-111111111111");
        var studentId = Guid.Parse("22222222-2222-2222-2222-222222222222");
        var parentId = Guid.Parse("33333333-3333-3333-3333-333333333333");
        var teacherId = Guid.Parse("44444444-4444-4444-4444-444444444444");
        var managerId = Guid.Parse("55555555-5555-5555-5555-555555555555");
        var defaultPasswordHash = "$2a$11$3HXCJnYevNW8Awmlq9VfIengAG7omtmw85UBxJAAYLmNTjatfD6Zy"; // 123456aA@

        modelBuilder.Entity<User>().HasData(
            new User { Id = adminId, Username = "admin", Email = "admin@elms.com", FullName = "System Admin", Password = defaultPasswordHash, IsActive = true, IsDeleted = false },
            new User { Id = studentId, Username = "student", Email = "student@elms.com", FullName = "Sample Student", Password = defaultPasswordHash, IsActive = true, IsDeleted = false },
            new User { Id = parentId, Username = "parent", Email = "parent@elms.com", FullName = "Sample Parent", Password = defaultPasswordHash, IsActive = true, IsDeleted = false },
            new User { Id = teacherId, Username = "teacher", Email = "teacher@elms.com", FullName = "Sample Teacher", Password = defaultPasswordHash, IsActive = true, IsDeleted = false },
            new User { Id = managerId, Username = "manager", Email = "manager@elms.com", FullName = "Sample Manager", Password = defaultPasswordHash, IsActive = true, IsDeleted = false }
        );

        // Data Seeding for Many-to-Many PUserRole Join Table
        modelBuilder.Entity("PUserRole").HasData(
            new { UserId = adminId, RoleId = 1 },
            new { UserId = studentId, RoleId = 2 },
            new { UserId = parentId, RoleId = 3 },
            new { UserId = teacherId, RoleId = 4 },
            new { UserId = managerId, RoleId = 5 }
        );

        // Data Seeding for User Profiles
        modelBuilder.Entity<StudentProfile>().HasData(
            new StudentProfile { Id = studentId, Institution = "FPT University", GradeLevel = "University", Address = "Hoa Lac" }
        );
        modelBuilder.Entity<ParentProfile>().HasData(
            new ParentProfile { Id = parentId, Occupation = "Engineer", Address = "Hanoi" }
        );
        modelBuilder.Entity<InstructorProfile>().HasData(
            new InstructorProfile { Id = teacherId, Bio = "Experienced Teacher", Expertise = "Software Engineering", Qualifications = "PhD" }
        );
        modelBuilder.Entity<ManagerProfile>().HasData(
            new ManagerProfile { Id = managerId, Position = "Academic Head", Specialization = "Operations" }
        );

        // Data Seeding for SystemKey
        modelBuilder.Entity<SystemKey>().HasData(
            new SystemKey { Id = 1, ParentId = null, CodeKey = "USER_GENDER", CodeValue = 0, Description = "User Gender", SortOrder = 0, IsDeleted = false },
            new SystemKey { Id = 2, ParentId = 1, CodeKey = "USER_GENDER_MALE", CodeValue = 1, Description = "Male", SortOrder = 1, IsDeleted = false },
            new SystemKey { Id = 3, ParentId = 1, CodeKey = "USER_GENDER_FEMALE", CodeValue = 2, Description = "Female", SortOrder = 2, IsDeleted = false },
            new SystemKey { Id = 4, ParentId = 1, CodeKey = "USER_GENDER_OTHER", CodeValue = 3, Description = "Other", SortOrder = 3, IsDeleted = false },
            new SystemKey { Id = 5, ParentId = null, CodeKey = "PARENT_LINK_STATUS", CodeValue = 0, Description = "Parent Link Status", SortOrder = 0, IsDeleted = false },
            new SystemKey { Id = 6, ParentId = 5, CodeKey = "PARENT_LINK_STATUS_PENDING", CodeValue = 1, Description = "Pending", SortOrder = 1, IsDeleted = false },
            new SystemKey { Id = 7, ParentId = 5, CodeKey = "PARENT_LINK_STATUS_APPROVED", CodeValue = 2, Description = "Approved", SortOrder = 2, IsDeleted = false },
            new SystemKey { Id = 8, ParentId = 5, CodeKey = "PARENT_LINK_STATUS_REJECTED", CodeValue = 3, Description = "Rejected", SortOrder = 3, IsDeleted = false },
            new SystemKey { Id = 9, ParentId = 5, CodeKey = "PARENT_LINK_STATUS_CANCELED", CodeValue = 4, Description = "Canceled", SortOrder = 4, IsDeleted = false },
            new SystemKey { Id = 10, ParentId = 5, CodeKey = "PARENT_LINK_STATUS_UNLINK", CodeValue = 5, Description = "Unlink", SortOrder = 5, IsDeleted = false },
            new SystemKey { Id = 11, ParentId = null, CodeKey = "COURSE_STATUS", CodeValue = 0, Description = "Course Status", SortOrder = 0, IsDeleted = false },
            new SystemKey { Id = 12, ParentId = 11, CodeKey = "COURSE_STATUS_DRAFT", CodeValue = 1, Description = "Draft", SortOrder = 1, IsDeleted = false },
            new SystemKey { Id = 13, ParentId = 11, CodeKey = "COURSE_STATUS_SUBMITTED", CodeValue = 2, Description = "Submitted", SortOrder = 2, IsDeleted = false },
            new SystemKey { Id = 14, ParentId = 11, CodeKey = "COURSE_STATUS_APPROVED", CodeValue = 3, Description = "Approved", SortOrder = 3, IsDeleted = false },
            new SystemKey { Id = 15, ParentId = 11, CodeKey = "COURSE_STATUS_REJECTED", CodeValue = 4, Description = "Rejected", SortOrder = 4, IsDeleted = false },
            new SystemKey { Id = 16, ParentId = 11, CodeKey = "COURSE_STATUS_PUBLISH", CodeValue = 5, Description = "Publish", SortOrder = 5, IsDeleted = false },
            new SystemKey { Id = 17, ParentId = 11, CodeKey = "COURSE_STATUS_UNPUBLISH", CodeValue = 6, Description = "Unpublish", SortOrder = 6, IsDeleted = false },
            new SystemKey { Id = 18, ParentId = null, CodeKey = "ENROLLMENT_STATUS", CodeValue = 0, Description = "Enrollment Status", SortOrder = 0, IsDeleted = false },
            new SystemKey { Id = 19, ParentId = 18, CodeKey = "ENROLLMENT_STATUS_ACTIVE", CodeValue = 1, Description = "Active", SortOrder = 1, IsDeleted = false },
            new SystemKey { Id = 20, ParentId = 18, CodeKey = "ENROLLMENT_STATUS_COMPLETED", CodeValue = 2, Description = "Completed", SortOrder = 2, IsDeleted = false },
            new SystemKey { Id = 21, ParentId = null, CodeKey = "MODULE_ITEM_TYPE", CodeValue = 0, Description = "Module Item Type", SortOrder = 0, IsDeleted = false },
            new SystemKey { Id = 22, ParentId = 21, CodeKey = "MODULE_ITEM_TYPE_LESSON", CodeValue = 1, Description = "Lesson", SortOrder = 1, IsDeleted = false },
            new SystemKey { Id = 23, ParentId = 21, CodeKey = "MODULE_ITEM_TYPE_QUIZ", CodeValue = 2, Description = "Quiz", SortOrder = 2, IsDeleted = false },
            new SystemKey { Id = 24, ParentId = 21, CodeKey = "MODULE_ITEM_TYPE_ASSIGNMENT", CodeValue = 3, Description = "Assignment", SortOrder = 3, IsDeleted = false },
            new SystemKey { Id = 25, ParentId = 21, CodeKey = "MODULE_ITEM_TYPE_DISCUSSION", CodeValue = 4, Description = "Discussion", SortOrder = 4, IsDeleted = false },
            new SystemKey { Id = 26, ParentId = null, CodeKey = "LESSON_CONTENT_TYPE", CodeValue = 0, Description = "Lesson Content Type", SortOrder = 0, IsDeleted = false },
            new SystemKey { Id = 27, ParentId = 26, CodeKey = "LESSON_CONTENT_TYPE_VIDEO", CodeValue = 1, Description = "Video", SortOrder = 1, IsDeleted = false },
            new SystemKey { Id = 28, ParentId = 26, CodeKey = "LESSON_CONTENT_TYPE_READING", CodeValue = 2, Description = "Reading", SortOrder = 2, IsDeleted = false },
            new SystemKey { Id = 29, ParentId = null, CodeKey = "QUIZ_ATTEMPT_STATUS", CodeValue = 0, Description = "Quiz Attempt Status", SortOrder = 0, IsDeleted = false },
            new SystemKey { Id = 30, ParentId = 29, CodeKey = "QUIZ_ATTEMPT_STATUS_DRAFT", CodeValue = 1, Description = "Draft", SortOrder = 1, IsDeleted = false },
            new SystemKey { Id = 31, ParentId = 29, CodeKey = "QUIZ_ATTEMPT_STATUS_SUBMITTED", CodeValue = 2, Description = "Submitted", SortOrder = 2, IsDeleted = false },
            new SystemKey { Id = 32, ParentId = null, CodeKey = "ASSIGNMENT_SUBMISSION_TYPE", CodeValue = 0, Description = "Assignment Submission Type", SortOrder = 0, IsDeleted = false },
            new SystemKey { Id = 33, ParentId = 32, CodeKey = "ASSIGNMENT_SUBMISSION_TYPE_TEXT", CodeValue = 1, Description = "Text", SortOrder = 1, IsDeleted = false },
            new SystemKey { Id = 34, ParentId = 32, CodeKey = "ASSIGNMENT_SUBMISSION_TYPE_FILE", CodeValue = 2, Description = "File", SortOrder = 2, IsDeleted = false },
            new SystemKey { Id = 35, ParentId = null, CodeKey = "ASSIGNMENT_WORK_STATUS", CodeValue = 0, Description = "Assignment Work Status", SortOrder = 0, IsDeleted = false },
            new SystemKey { Id = 36, ParentId = 35, CodeKey = "ASSIGNMENT_WORK_STATUS_DRAFT", CodeValue = 1, Description = "Draft", SortOrder = 1, IsDeleted = false },
            new SystemKey { Id = 37, ParentId = 35, CodeKey = "ASSIGNMENT_WORK_STATUS_SUBMITTED", CodeValue = 2, Description = "Submitted", SortOrder = 2, IsDeleted = false },
            new SystemKey { Id = 38, ParentId = 35, CodeKey = "ASSIGNMENT_WORK_STATUS_PASSED", CodeValue = 3, Description = "Passed", SortOrder = 3, IsDeleted = false },
            new SystemKey { Id = 39, ParentId = 35, CodeKey = "ASSIGNMENT_WORK_STATUS_RETURNED", CodeValue = 4, Description = "Returned", SortOrder = 4, IsDeleted = false },
            new SystemKey { Id = 40, ParentId = null, CodeKey = "PROGRESS_STATUS", CodeValue = 0, Description = "Progress Status", SortOrder = 0, IsDeleted = false },
            new SystemKey { Id = 41, ParentId = 40, CodeKey = "PROGRESS_STATUS_IN_PROGRESS", CodeValue = 1, Description = "In Progress", SortOrder = 1, IsDeleted = false },
            new SystemKey { Id = 42, ParentId = 40, CodeKey = "PROGRESS_STATUS_COMPLETED", CodeValue = 2, Description = "Completed", SortOrder = 2, IsDeleted = false },
            new SystemKey { Id = 43, ParentId = null, CodeKey = "FLASHCARD_SET_STATUS", CodeValue = 0, Description = "Flashcard Set Status", SortOrder = 0, IsDeleted = false },
            new SystemKey { Id = 44, ParentId = 43, CodeKey = "FLASHCARD_SET_STATUS_PRIVATE", CodeValue = 1, Description = "Private", SortOrder = 1, IsDeleted = false },
            new SystemKey { Id = 45, ParentId = 43, CodeKey = "FLASHCARD_SET_STATUS_PUBLIC", CodeValue = 2, Description = "Public", SortOrder = 2, IsDeleted = false },
            new SystemKey { Id = 46, ParentId = 43, CodeKey = "FLASHCARD_SET_STATUS_INACTIVE", CodeValue = 3, Description = "Inactive", SortOrder = 3, IsDeleted = false },
            new SystemKey { Id = 47, ParentId = null, CodeKey = "COURSE_REQUEST_STATUS", CodeValue = 0, Description = "Course Request Status", SortOrder = 0, IsDeleted = false },
            new SystemKey { Id = 48, ParentId = 47, CodeKey = "COURSE_REQUEST_STATUS_SAVED", CodeValue = 1, Description = "Saved", SortOrder = 1, IsDeleted = false },
            new SystemKey { Id = 49, ParentId = 47, CodeKey = "COURSE_REQUEST_STATUS_PENDING", CodeValue = 2, Description = "Pending", SortOrder = 2, IsDeleted = false },
            new SystemKey { Id = 50, ParentId = 47, CodeKey = "COURSE_REQUEST_STATUS_APPROVED", CodeValue = 3, Description = "Approved", SortOrder = 3, IsDeleted = false },
            new SystemKey { Id = 51, ParentId = 47, CodeKey = "COURSE_REQUEST_STATUS_UNPAID", CodeValue = 4, Description = "Unpaid", SortOrder = 4, IsDeleted = false },
            new SystemKey { Id = 52, ParentId = 47, CodeKey = "COURSE_REQUEST_STATUS_REJECTED", CodeValue = 5, Description = "Rejected", SortOrder = 5, IsDeleted = false },
            new SystemKey { Id = 53, ParentId = 47, CodeKey = "COURSE_REQUEST_STATUS_CANCELED", CodeValue = 6, Description = "Canceled", SortOrder = 6, IsDeleted = false },
            new SystemKey { Id = 54, ParentId = null, CodeKey = "ORDER_STATUS", CodeValue = 0, Description = "Order Status", SortOrder = 0, IsDeleted = false },
            new SystemKey { Id = 55, ParentId = 54, CodeKey = "ORDER_STATUS_PENDING", CodeValue = 1, Description = "Pending", SortOrder = 1, IsDeleted = false },
            new SystemKey { Id = 56, ParentId = 54, CodeKey = "ORDER_STATUS_PAID", CodeValue = 2, Description = "Paid", SortOrder = 2, IsDeleted = false },
            new SystemKey { Id = 57, ParentId = 54, CodeKey = "ORDER_STATUS_CANCELLED", CodeValue = 3, Description = "Cancelled", SortOrder = 3, IsDeleted = false },
            new SystemKey { Id = 58, ParentId = null, CodeKey = "PAYMENT_METHOD", CodeValue = 0, Description = "Payment Method", SortOrder = 0, IsDeleted = false },
            new SystemKey { Id = 59, ParentId = 58, CodeKey = "PAYMENT_METHOD_CARD", CodeValue = 1, Description = "Card", SortOrder = 1, IsDeleted = false },
            new SystemKey { Id = 60, ParentId = 58, CodeKey = "PAYMENT_METHOD_BANK_TRANSFER", CodeValue = 2, Description = "Bank Transfer", SortOrder = 2, IsDeleted = false },
            new SystemKey { Id = 61, ParentId = 58, CodeKey = "PAYMENT_METHOD_E_WALLET", CodeValue = 3, Description = "E-Wallet", SortOrder = 3, IsDeleted = false },
            new SystemKey { Id = 62, ParentId = 58, CodeKey = "PAYMENT_METHOD_CASH", CodeValue = 4, Description = "Cash", SortOrder = 4, IsDeleted = false },
            new SystemKey { Id = 63, ParentId = null, CodeKey = "PAYMENT_STATUS", CodeValue = 0, Description = "Payment Status", SortOrder = 0, IsDeleted = false },
            new SystemKey { Id = 64, ParentId = 63, CodeKey = "PAYMENT_STATUS_INITIATED", CodeValue = 1, Description = "Initiated", SortOrder = 1, IsDeleted = false },
            new SystemKey { Id = 65, ParentId = 63, CodeKey = "PAYMENT_STATUS_CAPTURED", CodeValue = 2, Description = "Captured", SortOrder = 2, IsDeleted = false },
            new SystemKey { Id = 66, ParentId = 63, CodeKey = "PAYMENT_STATUS_FAILED", CodeValue = 3, Description = "Failed", SortOrder = 3, IsDeleted = false }
        );

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

