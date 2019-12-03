--------------------------------------------------------------------------------------------------------------------
-- Created By   : 
-- Created Date : 2019/11/19 04:32:45 م
--------------------Change History----------------------------------------------------------------------------------
-- Change No     Date		Time	Author					Descrition
--------------------Change History----------------------------------------------------------------------------------
-- Name       : [Lookups].[DeleteRequestClass]
-- Description: Delete Row From [Lookups].[RequestClass]
--------------------------------------------------------------------------------------------------------------------

CREATE PROCEDURE [Lookups].[DeleteRequestClass]
(
	@Id AS INT
)
AS
BEGIN

DELETE [Lookups].[RequestClass]
WHERE	(@Id IS NULL OR [RequestClass].[Id] = @Id)

END

