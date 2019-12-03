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