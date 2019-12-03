
--------------------------------------------------------------------------------------------------------------------
-- Created By   : 
-- Created Date : 2019/11/19 04:32:48 م
--------------------Change History----------------------------------------------------------------------------------
-- Change No     Date		Time	Author					Descrition
--------------------Change History----------------------------------------------------------------------------------
-- Name       : [Transactions].[SelectRequestDetail]
-- Description: Select Row From [Transactions].[RequestDetail]
--------------------------------------------------------------------------------------------------------------------

CREATE PROCEDURE [Transactions].[SelectRequestDetail]
(
	@Id AS INT,
	@cardTypeID AS INT,
	@requestID AS INT
)
AS
BEGIN

SELECT 
	[RequestDetail].[Id],
	[RequestDetail].[quantity],
	[RequestDetail].[cardTypeID],
	[RequestDetail].[requestID]
FROM  [Transactions].[RequestDetail]
WHERE	(@Id IS NULL OR [RequestDetail].[Id] = @Id)
	AND (@cardTypeID IS NULL OR [RequestDetail].[cardTypeID] = @cardTypeID)
	AND (@requestID IS NULL OR [RequestDetail].[requestID] = @requestID)

END
