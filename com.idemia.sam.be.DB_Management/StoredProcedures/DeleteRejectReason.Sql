--------------------------------------------------------------------------------------------------------------------
-- Created By   : 
-- Created Date : 2019/11/19 04:32:45 م
--------------------Change History----------------------------------------------------------------------------------
-- Change No     Date		Time	Author					Descrition
--------------------Change History----------------------------------------------------------------------------------
-- Name       : [Lookups].[DeleteRejectReason]
-- Description: Delete Row From [Lookups].[RejectReason]
--------------------------------------------------------------------------------------------------------------------

CREATE PROCEDURE [Lookups].[DeleteRejectReason]
(
	@Id AS INT
)
AS
BEGIN

DELETE [Lookups].[RejectReason]
WHERE	(@Id IS NULL OR [RejectReason].[Id] = @Id)

END
