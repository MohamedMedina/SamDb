
CREATE PROCEDURE [Transactions].[UpdateRequestSearch]
(
	@Id AS INT,
	@requestNumber AS NVARCHAR(20),
	@totalQuantity AS INT,
	@PDDFrom AS DATETIME,
	@PDDTo AS DATETIME,
	@customerID AS INT,
	@creationDateFrom AS DATETIME,
	@creationDateTo AS DATETIME,
	@creationUserID AS INT,
	@approvalDateFrom AS DATETIME,
	@approvalDateTo AS DATETIME,
	@approvalUserID AS INT,
	@receiveDateFrom AS DATETIME,
	@receiveDateTo AS DATETIME,
	@receiveUserID AS INT,
	@rejectionDateFrom AS DATETIME,
	@rejectionDateTo AS DATETIME,
	@rejectionUserID AS INT,
	@rejectionReasonID AS INT,
	@requestTypeID AS INT,
	@requestStatusID AS INT,
	@requestCalssID AS INT,
	@requestPriorityID AS INT,
	@cardTypeID AS INT
)
 AS
BEGIN

UPDATE [Transactions].[RequestSearch]
SET 
	 [requestNumber] = @requestNumber,
	 [totalQuantity] = @totalQuantity,
	 [PDDFrom] = @PDDFrom,
	 [PDDTo] = @PDDTo,
	 [customerID] = @customerID,
	 [creationDateFrom] = @creationDateFrom,
	 [creationDateTo] = @creationDateTo,
	 [creationUserID] = @creationUserID,
	 [approvalDateFrom] = @approvalDateFrom,
	 [approvalDateTo] = @approvalDateTo,
	 [approvalUserID] = @approvalUserID,
	 [receiveDateFrom] = @receiveDateFrom,
	 [receiveDateTo] = @receiveDateTo,
	 [receiveUserID] = @receiveUserID,
	 [rejectionDateFrom] = @rejectionDateFrom,
	 [rejectionDateTo] = @rejectionDateTo,
	 [rejectionUserID] = @rejectionUserID,
	 [rejectionReasonID] = @rejectionReasonID,
	 [requestTypeID] = @requestTypeID,
	 [requestStatusID] = @requestStatusID,
	 [requestCalssID] = @requestCalssID,
	 [requestPriorityID] = @requestPriorityID,
	 [cardTypeID] = @cardTypeID
WHERE	(@Id IS NULL OR [RequestSearch].[Id] = @Id)

END
