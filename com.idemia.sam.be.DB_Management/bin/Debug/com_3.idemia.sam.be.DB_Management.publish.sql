﻿/*
Deployment script for SAM_DB

This code was generated by a tool.
Changes to this file may cause incorrect behavior and will be lost if
the code is regenerated.
*/

GO
SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, CONCAT_NULL_YIELDS_NULL, QUOTED_IDENTIFIER ON;

SET NUMERIC_ROUNDABORT OFF;


GO
:setvar DatabaseName "SAM_DB"
:setvar DefaultFilePrefix "SAM_DB"
:setvar DefaultDataPath "C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\"
:setvar DefaultLogPath "C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\"

GO
:on error exit
GO
/*
Detect SQLCMD mode and disable script execution if SQLCMD mode is not supported.
To re-enable the script after enabling SQLCMD mode, execute the following:
SET NOEXEC OFF; 
*/
:setvar __IsSqlCmdEnabled "True"
GO
IF N'$(__IsSqlCmdEnabled)' NOT LIKE N'True'
    BEGIN
        PRINT N'SQLCMD mode must be enabled to successfully execute this script.';
        SET NOEXEC ON;
    END


GO
USE [$(DatabaseName)];


GO
PRINT N'Creating [Lookups].[DeleteFunction]...';


GO
--------------------------------------------------------------------------------------------------------------------
-- Created By   : 
-- Created Date : 2019/11/13 11:29:02 ص
--------------------Change History----------------------------------------------------------------------------------
-- Change No     Date		Time	Author					Descrition
--------------------Change History----------------------------------------------------------------------------------
-- Name       : [Lookups].[DeleteFunction]
-- Description: Delete Row From [Lookups].[Function]
--------------------------------------------------------------------------------------------------------------------

CREATE PROCEDURE [Lookups].[DeleteFunction]
(
	@Id AS INT
)
AS
BEGIN

DELETE [Lookups].[Function]
WHERE	(@Id IS NULL OR [Function].[Id] = @Id)

END
GO
PRINT N'Creating [Lookups].[DeleteGroup]...';


GO
--------------------------------------------------------------------------------------------------------------------
-- Created By   : 
-- Created Date : 2019/11/13 11:29:02 ص
--------------------Change History----------------------------------------------------------------------------------
-- Change No     Date		Time	Author					Descrition
--------------------Change History----------------------------------------------------------------------------------
-- Name       : [Lookups].[DeleteGroup]
-- Description: Delete Row From [Lookups].[Group]
--------------------------------------------------------------------------------------------------------------------

CREATE PROCEDURE [Lookups].[DeleteGroup]
(
	@Id AS INT
)
AS
BEGIN

DELETE [Lookups].[Group]
WHERE	(@Id IS NULL OR [Group].[Id] = @Id)

END
GO
PRINT N'Creating [Lookups].[DeleteGroupFunction]...';


GO
--------------------------------------------------------------------------------------------------------------------
-- Created By   : 
-- Created Date : 2019/11/13 11:29:02 ص
--------------------Change History----------------------------------------------------------------------------------
-- Change No     Date		Time	Author					Descrition
--------------------Change History----------------------------------------------------------------------------------
-- Name       : [Lookups].[DeleteGroupFunction]
-- Description: Delete Row From [Lookups].[GroupFunction]
--------------------------------------------------------------------------------------------------------------------

CREATE PROCEDURE [Lookups].[DeleteGroupFunction]
(
	@Id AS INT
)
AS
BEGIN

DELETE [Lookups].[GroupFunction]
WHERE	(@Id IS NULL OR [GroupFunction].[Id] = @Id)

END
GO
PRINT N'Creating [Lookups].[DeleteUser]...';


GO
--------------------------------------------------------------------------------------------------------------------
-- Created By   : 
-- Created Date : 2019/11/13 11:29:03 ص
--------------------Change History----------------------------------------------------------------------------------
-- Change No     Date		Time	Author					Descrition
--------------------Change History----------------------------------------------------------------------------------
-- Name       : [Lookups].[DeleteUser]
-- Description: Delete Row From [Lookups].[User]
--------------------------------------------------------------------------------------------------------------------

CREATE PROCEDURE [Lookups].[DeleteUser]
(
	@Id AS INT
)
AS
BEGIN

DELETE [Lookups].[User]
WHERE	(@Id IS NULL OR [User].[Id] = @Id)

END
GO
PRINT N'Creating [Lookups].[DeleteUserGroup]...';


GO
--------------------------------------------------------------------------------------------------------------------
-- Created By   : 
-- Created Date : 2019/11/13 11:29:03 ص
--------------------Change History----------------------------------------------------------------------------------
-- Change No     Date		Time	Author					Descrition
--------------------Change History----------------------------------------------------------------------------------
-- Name       : [Lookups].[DeleteUserGroup]
-- Description: Delete Row From [Lookups].[UserGroup]
--------------------------------------------------------------------------------------------------------------------

CREATE PROCEDURE [Lookups].[DeleteUserGroup]
(
	@Id AS INT
)
AS
BEGIN

DELETE [Lookups].[UserGroup]
WHERE	(@Id IS NULL OR [UserGroup].[Id] = @Id)

END
GO
PRINT N'Creating [Lookups].[InsertFunction]...';


GO
--------------------------------------------------------------------------------------------------------------------
-- Created By   : 
-- Created Date : 2019/11/13 11:29:02 ص
--------------------Change History----------------------------------------------------------------------------------
-- Change No     Date		Time	Author					Descrition
--------------------Change History----------------------------------------------------------------------------------
-- Name       : [Lookups].[InsertFunction]
-- Description: Insert Row Into [Lookups].[Function]
--------------------------------------------------------------------------------------------------------------------

CREATE PROCEDURE [Lookups].[InsertFunction]
(
	@Id AS INT OUTPUT,
	@name AS NVARCHAR(60),
	@nameAr AS NVARCHAR(60),
	@route AS NVARCHAR(MAX),
	@status AS BIT
)
AS
BEGIN

INSERT INTO [Lookups].[Function]
(
	[name],
	[nameAr],
	[route],
	[status]
)
VALUES
(
	@name,
	@nameAr,
	@route,
	@status
)
SELECT @Id = SCOPE_IDENTITY()

END
GO
PRINT N'Creating [Lookups].[InsertGroup]...';


GO
--------------------------------------------------------------------------------------------------------------------
-- Created By   : 
-- Created Date : 2019/11/13 11:29:02 ص
--------------------Change History----------------------------------------------------------------------------------
-- Change No     Date		Time	Author					Descrition
--------------------Change History----------------------------------------------------------------------------------
-- Name       : [Lookups].[InsertGroup]
-- Description: Insert Row Into [Lookups].[Group]
--------------------------------------------------------------------------------------------------------------------

CREATE PROCEDURE [Lookups].[InsertGroup]
(
	@Id AS INT OUTPUT,
	@name AS NVARCHAR(100),
	@status AS BIT
)
AS
BEGIN

INSERT INTO [Lookups].[Group]
(
	[name],
	[status]
)
VALUES
(
	@name,
	@status
)
SELECT @Id = SCOPE_IDENTITY()

END
GO
PRINT N'Creating [Lookups].[InsertGroupFunction]...';


GO
--------------------------------------------------------------------------------------------------------------------
-- Created By   : 
-- Created Date : 2019/11/13 11:29:02 ص
--------------------Change History----------------------------------------------------------------------------------
-- Change No     Date		Time	Author					Descrition
--------------------Change History----------------------------------------------------------------------------------
-- Name       : [Lookups].[InsertGroupFunction]
-- Description: Insert Row Into [Lookups].[GroupFunction]
--------------------------------------------------------------------------------------------------------------------

CREATE PROCEDURE [Lookups].[InsertGroupFunction]
(
	@Id AS INT OUTPUT,
	@functionId AS INT,
	@groupId AS INT,
	@status AS BIT
)
AS
BEGIN

INSERT INTO [Lookups].[GroupFunction]
(
	[functionId],
	[groupId],
	[status]
)
VALUES
(
	@functionId,
	@groupId,
	@status
)
SELECT @Id = SCOPE_IDENTITY()

END
GO
PRINT N'Creating [Lookups].[InsertUser]...';


GO
--------------------------------------------------------------------------------------------------------------------
-- Created By   : 
-- Created Date : 2019/11/13 11:29:02 ص
--------------------Change History----------------------------------------------------------------------------------
-- Change No     Date		Time	Author					Descrition
--------------------Change History----------------------------------------------------------------------------------
-- Name       : [Lookups].[InsertUser]
-- Description: Insert Row Into [Lookups].[User]
--------------------------------------------------------------------------------------------------------------------

CREATE PROCEDURE [Lookups].[InsertUser]
(
	@Id AS INT OUTPUT,
	@userName AS NVARCHAR(60),
	@fullName AS NVARCHAR(100),
	@Password AS NVARCHAR(60),
	@status AS BIT,
	@createDate AS DATETIME
)
AS
BEGIN

INSERT INTO [Lookups].[User]
(
	[userName],
	[fullName],
	[Password],
	[status],
	[createDate]
)
VALUES
(
	@userName,
	@fullName,
	@Password,
	@status,
	@createDate
)
SELECT @Id = SCOPE_IDENTITY()

END
GO
PRINT N'Creating [Lookups].[InsertUserGroup]...';


GO
--------------------------------------------------------------------------------------------------------------------
-- Created By   : 
-- Created Date : 2019/11/13 11:29:03 ص
--------------------Change History----------------------------------------------------------------------------------
-- Change No     Date		Time	Author					Descrition
--------------------Change History----------------------------------------------------------------------------------
-- Name       : [Lookups].[InsertUserGroup]
-- Description: Insert Row Into [Lookups].[UserGroup]
--------------------------------------------------------------------------------------------------------------------

CREATE PROCEDURE [Lookups].[InsertUserGroup]
(
	@Id AS INT OUTPUT,
	@userId AS INT,
	@groupId AS INT
)
AS
BEGIN

INSERT INTO [Lookups].[UserGroup]
(
	[userId],
	[groupId]
)
VALUES
(
	@userId,
	@groupId
)
SELECT @Id = SCOPE_IDENTITY()

END
GO
PRINT N'Creating [Lookups].[SelectFunction]...';


GO
--------------------------------------------------------------------------------------------------------------------
-- Created By   : 
-- Created Date : 2019/11/13 11:29:02 ص
--------------------Change History----------------------------------------------------------------------------------
-- Change No     Date		Time	Author					Descrition
--------------------Change History----------------------------------------------------------------------------------
-- Name       : [Lookups].[SelectFunction]
-- Description: Select Row From [Lookups].[Function]
--------------------------------------------------------------------------------------------------------------------

CREATE PROCEDURE [Lookups].[SelectFunction]
(
	@Id AS INT,
	@name AS NVARCHAR(60),
	@nameAr AS NVARCHAR(60)
)
AS
BEGIN

SELECT 
	[Function].[Id],
	[Function].[name],
	[Function].[nameAr],
	[Function].[route],
	[Function].[status]
FROM  [Lookups].[Function]
WHERE	(@Id IS NULL OR [Function].[Id] = @Id)
	AND (@name IS NULL OR [Function].[name] = @name)
	AND (@nameAr IS NULL OR [Function].[nameAr] = @nameAr)

END
GO
PRINT N'Creating [Lookups].[SelectGroup]...';


GO
--------------------------------------------------------------------------------------------------------------------
-- Created By   : 
-- Created Date : 2019/11/13 11:29:02 ص
--------------------Change History----------------------------------------------------------------------------------
-- Change No     Date		Time	Author					Descrition
--------------------Change History----------------------------------------------------------------------------------
-- Name       : [Lookups].[SelectGroup]
-- Description: Select Row From [Lookups].[Group]
--------------------------------------------------------------------------------------------------------------------

CREATE PROCEDURE [Lookups].[SelectGroup]
(
	@Id AS INT,
	@name AS NVARCHAR(100)
)
AS
BEGIN

SELECT 
	[Group].[Id],
	[Group].[name],
	[Group].[status]
FROM  [Lookups].[Group]
WHERE	(@Id IS NULL OR [Group].[Id] = @Id)
	AND (@name IS NULL OR [Group].[name] = @name)

END
GO
PRINT N'Creating [Lookups].[SelectGroupFunction]...';


GO
--------------------------------------------------------------------------------------------------------------------
-- Created By   : 
-- Created Date : 2019/11/13 11:29:02 ص
--------------------Change History----------------------------------------------------------------------------------
-- Change No     Date		Time	Author					Descrition
--------------------Change History----------------------------------------------------------------------------------
-- Name       : [Lookups].[SelectGroupFunction]
-- Description: Select Row From [Lookups].[GroupFunction]
--------------------------------------------------------------------------------------------------------------------

CREATE PROCEDURE [Lookups].[SelectGroupFunction]
(
	@Id AS INT,
	@functionId AS INT,
	@groupId AS INT
)
AS
BEGIN

SELECT 
	[GroupFunction].[Id],
	[GroupFunction].[functionId],
	[GroupFunction].[groupId],
	[GroupFunction].[status]
FROM  [Lookups].[GroupFunction]
WHERE	(@Id IS NULL OR [GroupFunction].[Id] = @Id)
	AND (@functionId IS NULL OR [GroupFunction].[functionId] = @functionId)
	AND (@groupId IS NULL OR [GroupFunction].[groupId] = @groupId)

END
GO
PRINT N'Creating [Lookups].[SelectUser]...';


GO
--------------------------------------------------------------------------------------------------------------------
-- Created By   : 
-- Created Date : 2019/11/13 11:29:03 ص
--------------------Change History----------------------------------------------------------------------------------
-- Change No     Date		Time	Author					Descrition
--------------------Change History----------------------------------------------------------------------------------
-- Name       : [Lookups].[SelectUser]
-- Description: Select Row From [Lookups].[User]
--------------------------------------------------------------------------------------------------------------------

CREATE PROCEDURE [Lookups].[SelectUser]
(
	@Id AS INT,
	@userName AS NVARCHAR(60),
	@fullName AS NVARCHAR(100),
	@createDate AS DATETIME
)
AS
BEGIN

SELECT 
	[User].[Id],
	[User].[userName],
	[User].[fullName],
	[User].[Password],
	[User].[status],
	[User].[createDate]
FROM  [Lookups].[User]
WHERE	(@Id IS NULL OR [User].[Id] = @Id)
	AND (@userName IS NULL OR [User].[userName] = @userName)
	AND (@fullName IS NULL OR [User].[fullName] = @fullName)
	AND (@createDate IS NULL OR [User].[createDate] = @createDate)

END
GO
PRINT N'Creating [Lookups].[SelectUserGroup]...';


GO
--------------------------------------------------------------------------------------------------------------------
-- Created By   : 
-- Created Date : 2019/11/13 11:29:03 ص
--------------------Change History----------------------------------------------------------------------------------
-- Change No     Date		Time	Author					Descrition
--------------------Change History----------------------------------------------------------------------------------
-- Name       : [Lookups].[SelectUserGroup]
-- Description: Select Row From [Lookups].[UserGroup]
--------------------------------------------------------------------------------------------------------------------

CREATE PROCEDURE [Lookups].[SelectUserGroup]
(
	@Id AS INT,
	@userId AS INT,
	@groupId AS INT
)
AS
BEGIN

SELECT 
	[UserGroup].[Id],
	[UserGroup].[userId],
	[UserGroup].[groupId]
FROM  [Lookups].[UserGroup]
WHERE	(@Id IS NULL OR [UserGroup].[Id] = @Id)
	AND (@userId IS NULL OR [UserGroup].[userId] = @userId)
	AND (@groupId IS NULL OR [UserGroup].[groupId] = @groupId)

END
GO
PRINT N'Creating [Lookups].[UpdateFunction]...';


GO
--------------------------------------------------------------------------------------------------------------------
-- Created By   : 
-- Created Date : 2019/11/13 11:29:02 ص
--------------------Change History----------------------------------------------------------------------------------
-- Change No     Date		Time	Author					Descrition
--------------------Change History----------------------------------------------------------------------------------
-- Name       : [Lookups].[UpdateFunction]
-- Description: Update Row Into [Lookups].[Function]
--------------------------------------------------------------------------------------------------------------------

CREATE PROCEDURE [Lookups].[UpdateFunction]
(
	@Id AS INT,
	@name AS NVARCHAR(60),
	@nameAr AS NVARCHAR(60),
	@route AS NVARCHAR(MAX),
	@status AS BIT
)
AS
BEGIN

UPDATE [Lookups].[Function]
SET 
	 [name] = @name,
	 [nameAr] = @nameAr,
	 [route] = @route,
	 [status] = @status
WHERE	(@Id IS NULL OR [Function].[Id] = @Id)

END
GO
PRINT N'Creating [Lookups].[UpdateGroup]...';


GO
--------------------------------------------------------------------------------------------------------------------
-- Created By   : 
-- Created Date : 2019/11/13 11:29:02 ص
--------------------Change History----------------------------------------------------------------------------------
-- Change No     Date		Time	Author					Descrition
--------------------Change History----------------------------------------------------------------------------------
-- Name       : [Lookups].[UpdateGroup]
-- Description: Update Row Into [Lookups].[Group]
--------------------------------------------------------------------------------------------------------------------

CREATE PROCEDURE [Lookups].[UpdateGroup]
(
	@Id AS INT,
	@name AS NVARCHAR(100),
	@status AS BIT
)
AS
BEGIN

UPDATE [Lookups].[Group]
SET 
	 [name] = @name,
	 [status] = @status
WHERE	(@Id IS NULL OR [Group].[Id] = @Id)

END
GO
PRINT N'Creating [Lookups].[UpdateGroupFunction]...';


GO
--------------------------------------------------------------------------------------------------------------------
-- Created By   : 
-- Created Date : 2019/11/13 11:29:02 ص
--------------------Change History----------------------------------------------------------------------------------
-- Change No     Date		Time	Author					Descrition
--------------------Change History----------------------------------------------------------------------------------
-- Name       : [Lookups].[UpdateGroupFunction]
-- Description: Update Row Into [Lookups].[GroupFunction]
--------------------------------------------------------------------------------------------------------------------

CREATE PROCEDURE [Lookups].[UpdateGroupFunction]
(
	@Id AS INT,
	@functionId AS INT,
	@groupId AS INT,
	@status AS BIT
)
AS
BEGIN

UPDATE [Lookups].[GroupFunction]
SET 
	 [functionId] = @functionId,
	 [groupId] = @groupId,
	 [status] = @status
WHERE	(@Id IS NULL OR [GroupFunction].[Id] = @Id)

END
GO
PRINT N'Creating [Lookups].[UpdateUser]...';


GO
--------------------------------------------------------------------------------------------------------------------
-- Created By   : 
-- Created Date : 2019/11/13 11:29:02 ص
--------------------Change History----------------------------------------------------------------------------------
-- Change No     Date		Time	Author					Descrition
--------------------Change History----------------------------------------------------------------------------------
-- Name       : [Lookups].[UpdateUser]
-- Description: Update Row Into [Lookups].[User]
--------------------------------------------------------------------------------------------------------------------

CREATE PROCEDURE [Lookups].[UpdateUser]
(
	@Id AS INT,
	@userName AS NVARCHAR(60),
	@fullName AS NVARCHAR(100),
	@Password AS NVARCHAR(60),
	@status AS BIT,
	@createDate AS DATETIME
)
AS
BEGIN

UPDATE [Lookups].[User]
SET 
	 [userName] = @userName,
	 [fullName] = @fullName,
	 [Password] = @Password,
	 [status] = @status,
	 [createDate] = @createDate
WHERE	(@Id IS NULL OR [User].[Id] = @Id)

END
GO
PRINT N'Creating [Lookups].[UpdateUserGroup]...';


GO
--------------------------------------------------------------------------------------------------------------------
-- Created By   : 
-- Created Date : 2019/11/13 11:29:03 ص
--------------------Change History----------------------------------------------------------------------------------
-- Change No     Date		Time	Author					Descrition
--------------------Change History----------------------------------------------------------------------------------
-- Name       : [Lookups].[UpdateUserGroup]
-- Description: Update Row Into [Lookups].[UserGroup]
--------------------------------------------------------------------------------------------------------------------

CREATE PROCEDURE [Lookups].[UpdateUserGroup]
(
	@Id AS INT,
	@userId AS INT,
	@groupId AS INT
)
AS
BEGIN

UPDATE [Lookups].[UserGroup]
SET 
	 [userId] = @userId,
	 [groupId] = @groupId
WHERE	(@Id IS NULL OR [UserGroup].[Id] = @Id)

END
GO
PRINT N'Update complete.';


GO
