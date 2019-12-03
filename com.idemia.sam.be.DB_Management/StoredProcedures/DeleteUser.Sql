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
