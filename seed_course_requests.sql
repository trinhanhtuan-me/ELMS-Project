-- SQL script to seed sample data for testing course requests
-- Target Database: ELMS_DB

USE [ELMS_DB];
GO

-- Set options required for tables with filtered indexes or computed columns
SET ANSI_NULLS ON;
SET QUOTED_IDENTIFIER ON;
SET ARITHABORT ON;
SET NOCOUNT ON;

-- 1. CLEAN UP existing test data to ensure clean, repeatable runs
PRINT 'Cleaning up existing course request test data...';

DELETE FROM [dbo].[CourseRequests]
WHERE [StudentId] = 'A1111111-A111-A111-A111-A11111111111'
   OR [ParentId] = 'B1111111-B111-B111-B111-B11111111111';

DELETE FROM [dbo].[Course]
WHERE [Id] IN ('E1111111-E111-E111-E111-E11111111111', 'E2222222-E222-E222-E222-E22222222222', 'E3333333-E333-E333-E333-E33333333333');

-- Temporarily enable identity insert for Categories if we want to force ID 1
IF EXISTS (SELECT * FROM [dbo].[Categories] WHERE [Id] = 1)
BEGIN
    -- If category 1 already exists, we will use it; otherwise we insert a new one
    PRINT 'Category with ID 1 already exists. Keeping it.';
END
ELSE
BEGIN
    PRINT 'Inserting test category...';
    SET IDENTITY_INSERT [dbo].[Categories] ON;
    INSERT INTO [dbo].[Categories] ([Id], [Name], [Description], [Picture])
    VALUES (1, N'General English', N'General English courses for all levels', NULL);
    SET IDENTITY_INSERT [dbo].[Categories] OFF;
END

-- 2. INSERT TEST COURSES
-- Status 5 = Publish
PRINT 'Inserting test courses...';
INSERT INTO [dbo].[Course]
    ([Id], [Title], [Description], [Language], [Level], [Thumbnail], [Status], [PublishAt], [CreatedBy], [CategoryId], [IsDeleted], [UpdatedAt], [UpdatedBy], [CreatedAt], [LastUpdatedAt], [LastUpdatedBy])
VALUES
    ('E1111111-E111-E111-E111-E11111111111', 
     N'Starter English Course', 
     N'Learn the basics of English communication, vocabulary, and elementary grammar.', 
     'English', 
     'Beginner', 
     'starter_english.png', 
     5, 
     SYSDATETIME(), 
     '44444444-4444-4444-4444-444444444444', 
     1, 
     0, 
     SYSDATETIME(), 
     NULL, 
     SYSDATETIME(), 
     SYSDATETIME(), 
     'admin'),

    ('E2222222-E222-E222-E222-E22222222222', 
     N'Intermediate English Writing', 
     N'Develop academic and professional writing skills, sentence structures, and essays.', 
     'English', 
     'Intermediate', 
     'intermediate_writing.png', 
     5, 
     SYSDATETIME(), 
     '44444444-4444-4444-4444-444444444444', 
     1, 
     0, 
     SYSDATETIME(), 
     NULL, 
     SYSDATETIME(), 
     SYSDATETIME(), 
     'admin'),

    ('E3333333-E333-E333-E333-E33333333333', 
     N'Advanced English Communication', 
     N'Master fluent conversation, expressions, idioms, and public speaking techniques.', 
     'English', 
     'Advanced', 
     'advanced_comm.png', 
     5, 
     SYSDATETIME(), 
     '44444444-4444-4444-4444-444444444444', 
     1, 
     0, 
     SYSDATETIME(), 
     NULL, 
     SYSDATETIME(), 
     SYSDATETIME(), 
     'admin');

-- 3. INSERT TEST COURSE REQUESTS
-- CourseRequestStatus Enum Mapping:
-- 1 = Saved, 2 = Pending, 3 = Approved, 4 = Unpaid, 5 = Rejected, 6 = Canceled
PRINT 'Inserting CourseRequests...';
INSERT INTO [dbo].[CourseRequests]
    ([Id], [StudentId], [CourseId], [ParentId], [Status], [Note], [DecidedAt], [CreatedAt], [CreatedBy], [LastUpdatedAt], [LastUpdatedBy])
VALUES
    -- Case 1: Pending Request (Parent 1 requests Course 1 for Student 1)
    ('D1111111-D111-D111-D111-D11111111111', 
     'A1111111-A111-A111-A111-A11111111111', 
     'E1111111-E111-E111-E111-E11111111111', 
     'B1111111-B111-B111-B111-B11111111111', 
     2, 
     N'I would like my child to join the Starter English Course.', 
     NULL, 
     DATEADD(day, -2, SYSDATETIME()), 
     'test_parent_1', 
     DATEADD(day, -2, SYSDATETIME()), 
     'test_parent_1'),

    -- Case 2: Approved Request (Parent 1 requests Course 2 for Student 1)
    ('D2222222-D222-D222-D222-D22222222222', 
     'A1111111-A111-A111-A111-A11111111111', 
     'E2222222-E222-E222-E222-E22222222222', 
     'B1111111-B111-B111-B111-B11111111111', 
     3, 
     N'Requesting Intermediate writing course.', 
     DATEADD(day, -1, SYSDATETIME()), 
     DATEADD(day, -3, SYSDATETIME()), 
     'test_parent_1', 
     DATEADD(day, -1, SYSDATETIME()), 
     'admin'),

    -- Case 3: Rejected Request (Parent 1 requests Course 3 for Student 1)
    ('D3333333-D333-D333-D333-D33333333333', 
     'A1111111-A111-A111-A111-A11111111111', 
     'E3333333-E333-E333-E333-E33333333333', 
     'B1111111-B111-B111-B111-B11111111111', 
     5, 
     N'Applying for Advanced communication course.', 
     DATEADD(hour, -5, SYSDATETIME()), 
     DATEADD(day, -1, SYSDATETIME()), 
     'test_parent_1', 
     DATEADD(hour, -5, SYSDATETIME()), 
     'admin');

PRINT 'Course requests sample data seeding completed successfully.';
GO

-- Verify data
SELECT [Id]
      ,[StudentId]
      ,[CourseId]
      ,[ParentId]
      ,[Status]
      ,[Note]
      ,[DecidedAt]
      ,[CreatedAt]
      ,[CreatedBy]
      ,[LastUpdatedAt]
      ,[LastUpdatedBy]
  FROM [ELMS_DB].[dbo].[CourseRequests]
  WHERE [StudentId] = 'A1111111-A111-A111-A111-A11111111111';
GO
