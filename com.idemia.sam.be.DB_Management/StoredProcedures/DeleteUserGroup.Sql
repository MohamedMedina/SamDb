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
