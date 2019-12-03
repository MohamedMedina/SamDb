
--------------------------------------------------------------------------------------------------------------------
-- Created By   : 
-- Created Date : 2019/11/19 04:32:47 م
--------------------Change History----------------------------------------------------------------------------------
-- Change No     Date		Time	Author					Descrition
--------------------Change History----------------------------------------------------------------------------------
-- Name       : [Transactions].[InsertRequestDetail]
-- Description: Insert Row Into [Transactions].[RequestDetail]
--------------------------------------------------------------------------------------------------------------------

CREATE PROCEDURE [Transactions].[InsertRequestDetail]
(
	@Id AS INT OUTPUT,
	@quantity AS INT,
	@cardTypeID AS INT,
	@requestID AS INT
)
 AS
BEGIN

INSERT INTO [Transactions].[RequestDetail]
(
	[quantity],
	[cardTypeID],
	[requestID]
)
VALUES
(
	@quantity,
	@cardTypeID,
	@requestID
)
SELECT @Id = SCOPE_IDENTITY()

END
