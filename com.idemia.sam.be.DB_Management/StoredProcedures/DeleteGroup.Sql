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

