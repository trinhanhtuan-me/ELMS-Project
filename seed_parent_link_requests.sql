-- SQL script to seed sample data for testing parent-student link requests
-- Target Database: ELMS_DB

USE [ELMS_DB];
GO

-- Set NOCOUNT ON to prevent extra result sets from interfering with SELECT statements
SET NOCOUNT ON;

-- 1. CLEAN UP existing test data to ensure clean, repeatable runs
PRINT 'Cleaning up existing test data...';

DELETE FROM [dbo].[ParentLinkRequests]
WHERE [StudentId] IN ('A1111111-A111-A111-A111-A11111111111', 'A2222222-A222-A222-A222-A22222222222', 'A3333333-A333-A333-A333-A33333333333')
   OR [ParentId] IN ('B1111111-B111-B111-B111-B11111111111', 'B2222222-B222-B222-B222-B22222222222');

DELETE FROM [dbo].[p_user_role]
WHERE [user_id] IN (
    'A1111111-A111-A111-A111-A11111111111', 
    'A2222222-A222-A222-A222-A22222222222', 
    'A3333333-A333-A333-A333-A33333333333', 
    'B1111111-B111-B111-B111-B11111111111', 
    'B2222222-B222-B222-B222-B22222222222'
);

DELETE FROM [dbo].[StudentProfile] WHERE [Id] IN ('A1111111-A111-A111-A111-A11111111111', 'A2222222-A222-A222-A222-A22222222222', 'A3333333-A333-A333-A333-A33333333333');
DELETE FROM [dbo].[ParentProfile] WHERE [Id] IN ('B1111111-B111-B111-B111-B11111111111', 'B2222222-B222-B222-B222-B22222222222');
DELETE FROM [dbo].[Users] WHERE [Id] IN (
    'A1111111-A111-A111-A111-A11111111111', 
    'A2222222-A222-A222-A222-A22222222222', 
    'A3333333-A333-A333-A333-A33333333333', 
    'B1111111-B111-B111-B111-B11111111111', 
    'B2222222-B222-B222-B222-B22222222222'
);

-- 2. INSERT TEST USERS into Users table (including LastUpdatedAt column)
PRINT 'Inserting test users...';
INSERT INTO [dbo].[Users] 
    ([Id], [Username], [Email], [FullName], [IsActive], [IsDeleted], [Password], [CreatedAt], [UpdatedAt], [LastUpdatedAt])
VALUES 
    ('A1111111-A111-A111-A111-A11111111111', 'test_student_1', 'student1@test.com', 'Test Student One', 1, 0, '$2a$11$3HXCJnYevNW8Awmlq9VfIengAG7omtmw85UBxJAAYLmNTjatfD6Zy', SYSDATETIME(), SYSDATETIME(), SYSDATETIME()),
    ('A2222222-A222-A222-A222-A22222222222', 'test_student_2', 'student2@test.com', 'Test Student Two', 1, 0, '$2a$11$3HXCJnYevNW8Awmlq9VfIengAG7omtmw85UBxJAAYLmNTjatfD6Zy', SYSDATETIME(), SYSDATETIME(), SYSDATETIME()),
    ('A3333333-A333-A333-A333-A33333333333', 'test_student_3', 'student3@test.com', 'Test Student Three', 1, 0, '$2a$11$3HXCJnYevNW8Awmlq9VfIengAG7omtmw85UBxJAAYLmNTjatfD6Zy', SYSDATETIME(), SYSDATETIME(), SYSDATETIME()),
    ('B1111111-B111-B111-B111-B11111111111', 'test_parent_1', 'parent1@test.com', 'Test Parent One', 1, 0, '$2a$11$3HXCJnYevNW8Awmlq9VfIengAG7omtmw85UBxJAAYLmNTjatfD6Zy', SYSDATETIME(), SYSDATETIME(), SYSDATETIME()),
    ('B2222222-B222-B222-B222-B22222222222', 'test_parent_2', 'parent2@test.com', 'Test Parent Two', 1, 0, '$2a$11$3HXCJnYevNW8Awmlq9VfIengAG7omtmw85UBxJAAYLmNTjatfD6Zy', SYSDATETIME(), SYSDATETIME(), SYSDATETIME());

-- 3. ASSIGN ROLES to test users (Role 2 = Student, Role 3 = Parent)
PRINT 'Assigning roles to test users...';
INSERT INTO [dbo].[p_user_role] ([user_id], [role_id])
VALUES 
    ('A1111111-A111-A111-A111-A11111111111', 2),
    ('A2222222-A222-A222-A222-A22222222222', 2),
    ('A3333333-A333-A333-A333-A33333333333', 2),
    ('B1111111-B111-B111-B111-B11111111111', 3),
    ('B2222222-B222-B222-B222-B22222222222', 3);

-- 4. INSERT PROFILES into ParentProfile and StudentProfile tables (including LastUpdatedAt column)
PRINT 'Inserting profiles...';
INSERT INTO [dbo].[ParentProfile] ([Id], [Address], [Occupation], [CreatedAt], [UpdatedAt], [LastUpdatedAt])
VALUES 
    ('B1111111-B111-B111-B111-B11111111111', N'123 Hanoi St, Vietnam', N'Software Engineer', SYSDATETIME(), SYSDATETIME(), SYSDATETIME()),
    ('B2222222-B222-B222-B222-B22222222222', N'456 HCM St, Vietnam', N'Doctor', SYSDATETIME(), SYSDATETIME(), SYSDATETIME());

INSERT INTO [dbo].[StudentProfile] ([Id], [Address], [GradeLevel], [Institution], [ParentId], [CreatedAt], [UpdatedAt], [LastUpdatedAt])
VALUES 
    ('A1111111-A111-A111-A111-A11111111111', N'Hoa Lac, Hanoi', N'Grade 10', N'High School A', NULL, SYSDATETIME(), SYSDATETIME(), SYSDATETIME()),
    ('A2222222-A222-A222-A222-A22222222222', N'Hoa Lac, Hanoi', N'Grade 11', N'High School B', 'B1111111-B111-B111-B111-B11111111111', SYSDATETIME(), SYSDATETIME(), SYSDATETIME()), -- Student 2 is linked to Parent 1
    ('A3333333-A333-A333-A333-A33333333333', N'Hoa Lac, Hanoi', N'Grade 12', N'High School C', NULL, SYSDATETIME(), SYSDATETIME(), SYSDATETIME());

-- 5. INSERT TEST PARENT-STUDENT LINK REQUESTS
-- Status Enum Mapping:
-- 1 = Pending, 2 = Approved, 3 = Rejected, 4 = Canceled, 5 = Unlink
PRINT 'Inserting ParentLinkRequests...';
INSERT INTO [dbo].[ParentLinkRequests] 
    ([Id], [StudentId], [ParentId], [Status], [Note], [DecidedAt], [CreatedAt], [CreatedBy], [LastUpdatedAt], [LastUpdatedBy])
VALUES
    -- Case 1: Pending Request (Parent 1 requests Student 1)
    ('C1111111-C111-C111-C111-C11111111111', 
     'A1111111-A111-A111-A111-A11111111111', 
     'B1111111-B111-B111-B111-B11111111111', 
     1, 
     N'Hello, I am Parent One. I want to link with my child Test Student One.', 
     NULL, 
     DATEADD(day, -5, SYSDATETIME()), 
     'test_parent_1', 
     DATEADD(day, -5, SYSDATETIME()), 
     'test_parent_1'),

    -- Case 2: Approved Request (Parent 1 requests Student 2 - linked)
    ('C2222222-C222-C222-C222-C22222222222', 
     'A2222222-A222-A222-A222-A22222222222', 
     'B1111111-B111-B111-B111-B11111111111', 
     2, 
     N'Please link with my child Test Student Two.', 
     DATEADD(day, -3, SYSDATETIME()), 
     DATEADD(day, -4, SYSDATETIME()), 
     'test_parent_1', 
     DATEADD(day, -3, SYSDATETIME()), 
     'test_student_2'),

    -- Case 3: Rejected Request (Parent 2 requests Student 2 - rejected by student)
    ('C3333333-C333-C333-C333-C33333333333', 
     'A2222222-A222-A222-A222-A22222222222', 
     'B2222222-B222-B222-B222-B22222222222', 
     3, 
     N'Parent Two trying to connect to Student Two.', 
     DATEADD(day, -1, SYSDATETIME()), 
     DATEADD(day, -2, SYSDATETIME()), 
     'test_parent_2', 
     DATEADD(day, -1, SYSDATETIME()), 
     'test_student_2'),

    -- Case 4: Canceled Request (Parent 2 requests Student 3 - canceled by parent)
    ('C4444444-C444-C444-C444-C44444444444', 
     'A3333333-A333-A333-A333-A33333333333', 
     'B2222222-B222-B222-B222-B22222222222', 
     4, 
     N'Canceled request due to incorrect student ID.', 
     DATEADD(minute, -30, SYSDATETIME()), 
     DATEADD(hour, -2, SYSDATETIME()), 
     'test_parent_2', 
     DATEADD(minute, -30, SYSDATETIME()), 
     'test_parent_2'),

    -- Case 5: Unlinked Request (Parent 1 was linked to Student 3, but now unlinked)
    ('C5555555-C555-C555-C555-C55555555555', 
     'A3333333-A333-A333-A333-A33333333333', 
     'B1111111-B111-B111-B111-B11111111111', 
     5, 
     N'Unlinking student profile.', 
     SYSDATETIME(), 
     DATEADD(month, -1, SYSDATETIME()), 
     'test_parent_1', 
     SYSDATETIME(), 
     'test_parent_1'),

    -- Case 6: Another Pending Request (Parent 2 requests Student 1)
    ('C6666666-C666-C666-C666-C66666666666', 
     'A1111111-A111-A111-A111-A11111111111', 
     'B2222222-B222-B222-B222-B22222222222', 
     1, 
     N'Hello, please link me with my child Test Student One.', 
     NULL, 
     SYSDATETIME(), 
     'test_parent_2', 
     SYSDATETIME(), 
     'test_parent_2');

PRINT 'Sample data seeding completed successfully.';
GO

-- Verify data
SELECT TOP (1000) [Id]
      ,[StudentId]
      ,[ParentId]
      ,[Status]
      ,[Note]
      ,[DecidedAt]
      ,[CreatedAt]
      ,[CreatedBy]
      ,[LastUpdatedAt]
      ,[LastUpdatedBy]
  FROM [ELMS_DB].[dbo].[ParentLinkRequests];
