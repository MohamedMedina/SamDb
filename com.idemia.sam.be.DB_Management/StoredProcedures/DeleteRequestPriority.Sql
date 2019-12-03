--------------------------------------------------------------------------------------------------------------------
-- Created By   : 
-- Created Date : 2019/11/19 04:32:45 م
--------------------Change History----------------------------------------------------------------------------------
-- Change No     Date		Time	Author					Descrition
--------------------Change History----------------------------------------------------------------------------------
-- Name       : [Lookups].[DeleteRequestPriority]
-- Description: Delete Row From [Lookups].[RequestPriority]
--------------------------------------------------------------------------------------------------------------------

CREATE PROCEDURE [Lookups].[DeleteRequestPriority]
(
	@Id AS INT
)
AS
BEGIN

DELETE [Lookups].[RequestPriority]
WHERE	(@Id IS NULL OR [RequestPriority].[Id] = @Id)

END
