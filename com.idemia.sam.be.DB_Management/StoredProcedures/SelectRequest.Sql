
--------------------------------------------------------------------------------------------------------------------
-- Created By   : 
-- Created Date : 2019/11/19 04:32:47 م
--------------------Change History----------------------------------------------------------------------------------
-- Change No     Date		Time	Author					Descrition
--------------------Change History----------------------------------------------------------------------------------
-- Name       : [Transactions].[SelectRequest]
-- Description: Select Row From [Transactions].[Request]
--------------------------------------------------------------------------------------------------------------------

CREATE PROCEDURE [Transactions].[SelectRequest]
(
	@Id AS INT,
	@requestNumber AS NVARCHAR(20),
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

SELECT 
	[Request].[Id],
	[Request].[requestNumber],
	[Request].[totalQuantity],
	[Request].[PDD],
	[Request].[customerID],
	[Request].[creationDate],
	[Request].[creationUserID],
	[Request].[approvalDate],
	[Request].[approvalUserID],
	[Request].[receiveDate],
	[Request].[receiveUserID],
	[Request].[rejectionDate],
	[Request].[rejectionUserID],
	[Request].[rejectionReasonID],
	[Request].[requestTypeID],
	[Request].[requestStatusID],
	[Request].[requestCalssID],
	[Request].[requestPriorityID]
FROM  [Transactions].[Request]
WHERE	(@Id IS NULL OR [Request].[Id] = @Id)
	AND (@requestNumber IS NULL OR [Request].[requestNumber] = @requestNumber)
	AND (@customerID IS NULL OR [Request].[customerID] = @customerID)
	AND (@creationDate IS NULL OR [Request].[creationDate] = @creationDate)
	AND (@creationUserID IS NULL OR [Request].[creationUserID] = @creationUserID)
	AND (@approvalDate IS NULL OR [Request].[approvalDate] = @approvalDate)
	AND (@approvalUserID IS NULL OR [Request].[approvalUserID] = @approvalUserID)
	AND (@receiveDate IS NULL OR [Request].[receiveDate] = @receiveDate)
	AND (@receiveUserID IS NULL OR [Request].[receiveUserID] = @receiveUserID)
	AND (@rejectionDate IS NULL OR [Request].[rejectionDate] = @rejectionDate)
	AND (@rejectionUserID IS NULL OR [Request].[rejectionUserID] = @rejectionUserID)
	AND (@rejectionReasonID IS NULL OR [Request].[rejectionReasonID] = @rejectionReasonID)
	AND (@requestTypeID IS NULL OR [Request].[requestTypeID] = @requestTypeID)
	AND (@requestStatusID IS NULL OR [Request].[requestStatusID] = @requestStatusID)
	AND (@requestCalssID IS NULL OR [Request].[requestCalssID] = @requestCalssID)
	AND (@requestPriorityID IS NULL OR [Request].[requestPriorityID] = @requestPriorityID)

END
