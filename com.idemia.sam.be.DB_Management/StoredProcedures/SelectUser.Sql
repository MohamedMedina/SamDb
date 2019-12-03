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
