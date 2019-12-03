--------------------------------------------------------------------------------------------------------------------
-- Created By   : 
-- Created Date : 2019/11/19 04:32:48 م
--------------------Change History----------------------------------------------------------------------------------
-- Change No     Date		Time	Author					Descrition
--------------------Change History----------------------------------------------------------------------------------
-- Name       : [Transactions].[UpdateRequestDetail]
-- Description: Update Row Into [Transactions].[RequestDetail]
--------------------------------------------------------------------------------------------------------------------

CREATE PROCEDURE [Transactions].[UpdateRequestDetail]
(
	@Id AS INT,
	@quantity AS INT,
	@cardTypeID AS INT,
	@requestID AS INT
)
AS
BEGIN

UPDATE [Transactions].[RequestDetail]
SET 
	 [quantity] = @quantity,
	 [cardTypeID] = @cardTypeID,
	 [requestID] = @requestID
WHERE	(@Id IS NULL OR [RequestDetail].[Id] = @Id)

END

