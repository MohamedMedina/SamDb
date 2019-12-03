--------------------------------------------------------------------------------------------------------------------
-- Created By   : 
-- Created Date : 2019/11/19 04:32:46 م
--------------------Change History----------------------------------------------------------------------------------
-- Change No     Date		Time	Author					Descrition
--------------------Change History----------------------------------------------------------------------------------
-- Name       : [Lookups].[DeleteRequestType]
-- Description: Delete Row From [Lookups].[RequestType]
--------------------------------------------------------------------------------------------------------------------

CREATE PROCEDURE [Lookups].[DeleteRequestType]
(
	@Id AS INT
)
AS
BEGIN

DELETE [Lookups].[RequestType]
WHERE	(@Id IS NULL OR [RequestType].[Id] = @Id)

END
