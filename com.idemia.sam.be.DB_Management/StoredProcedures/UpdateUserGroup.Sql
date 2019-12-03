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
