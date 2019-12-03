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
