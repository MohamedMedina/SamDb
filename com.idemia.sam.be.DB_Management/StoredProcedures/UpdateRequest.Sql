--------------------------------------------------------------------------------------------------------------------
-- Created By   : 
-- Created Date : 2019/11/19 04:32:47 م
--------------------Change History----------------------------------------------------------------------------------
-- Change No     Date		Time	Author					Descrition
--------------------Change History----------------------------------------------------------------------------------
-- Name       : [Transactions].[UpdateRequest]
-- Description: Update Row Into [Transactions].[Request]
--------------------------------------------------------------------------------------------------------------------

CREATE PROCEDURE [Transactions].[UpdateRequest]
(
	@Id AS INT,
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

UPDATE [Transactions].[Request]
SET 
	 [requestNumber] = @requestNumber,
	 [totalQuantity] = @totalQuantity,
	 [PDD] = @PDD,
	 [customerID] = @customerID,
	 [creationDate] = @creationDate,
	 [creationUserID] = @creationUserID,
	 [approvalDate] = @approvalDate,
	 [approvalUserID] = @approvalUserID,
	 [receiveDate] = @receiveDate,
	 [receiveUserID] = @receiveUserID,
	 [rejectionDate] = @rejectionDate,
	 [rejectionUserID] = @rejectionUserID,
	 [rejectionReasonID] = @rejectionReasonID,
	 [requestTypeID] = @requestTypeID,
	 [requestStatusID] = @requestStatusID,
	 [requestCalssID] = @requestCalssID,
	 [requestPriorityID] = @requestPriorityID
WHERE	(@Id IS NULL OR [Request].[Id] = @Id)

END

