--------------------------------------------------------------------------------------------------------------------
-- Created By   : 
-- Created Date : 2019/11/19 04:32:46 م
--------------------Change History----------------------------------------------------------------------------------
-- Change No     Date		Time	Author					Descrition
--------------------Change History----------------------------------------------------------------------------------
-- Name       : [Lookups].[DeleteRequestStatus]
-- Description: Delete Row From [Lookups].[RequestStatus]
--------------------------------------------------------------------------------------------------------------------

CREATE PROCEDURE [Lookups].[DeleteRequestStatus]
(
	@Id AS INT
)
AS
BEGIN

DELETE [Lookups].[RequestStatus]
WHERE	(@Id IS NULL OR [RequestStatus].[Id] = @Id)

END
