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

