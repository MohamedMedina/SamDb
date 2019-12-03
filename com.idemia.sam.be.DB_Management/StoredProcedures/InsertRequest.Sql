
--------------------------------------------------------------------------------------------------------------------
-- Created By   : 
-- Created Date : 2019/11/19 04:32:47 م
--------------------Change History----------------------------------------------------------------------------------
-- Change No     Date		Time	Author					Descrition
--------------------Change History----------------------------------------------------------------------------------
-- Name       : [Transactions].[InsertRequest]
-- Description: Insert Row Into [Transactions].[Request]
--------------------------------------------------------------------------------------------------------------------

CREATE PROCEDURE [Transactions].[InsertRequest]
(
	@Id AS INT OUTPUT,
	@requestNumber AS NVARCHAR(20),
	@totalQuantity AS INT,
	@PDD AS DATETIME,
	@customerID AS INT,
	@creationDate AS DATETIME,
	@creationUserID AS INT,
	@approvalDate AS DATETIME,
	@approvalUserID AS INT,
	@receiveDate AS DATETIME,
	@receiveUserID AS INT,
	@rejectionDate AS DATETIME,
	@rejectionUserID AS INT,
	@rejectionReasonID AS INT,
	@requestTypeID AS INT,
	@requestStatusID AS INT,
	@requestCalssID AS INT,
	@requestPriorityID AS INT
)
 AS
BEGIN

INSERT INTO [Transactions].[Request]
(
	[requestNumber],
	[totalQuantity],
	[PDD],
	[customerID],
	[creationDate],
	[creationUserID],
	[approvalDate],
	[approvalUserID],
	[receiveDate],
	[receiveUserID],
	[rejectionDate],
	[rejectionUserID],
	[rejectionReasonID],
	[requestTypeID],
	[requestStatusID],
	[requestCalssID],
	[requestPriorityID]
)
VALUES
(
	@requestNumber,
	@totalQuantity,
	@PDD,
	@customerID,
	@creationDate,
	@creationUserID,
	@approvalDate,
	@approvalUserID,
	@receiveDate,
	@receiveUserID,
	@rejectionDate,
	@rejectionUserID,
	@rejectionReasonID,
	@requestTypeID,
	@requestStatusID,
	@requestCalssID,
	@requestPriorityID
)
SELECT @Id = SCOPE_IDENTITY()

END
