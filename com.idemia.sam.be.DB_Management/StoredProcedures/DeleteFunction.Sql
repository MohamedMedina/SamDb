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

