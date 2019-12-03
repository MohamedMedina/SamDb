CREATE PROCEDURE [Transactions].[SelectRequestSearch]
(
	@Id AS INT,
	@requestNumber AS NVARCHAR(20),
	@creationDateFrom AS DATETIME,
	@creationDateTo AS DATETIME,
	@approvalDateFrom AS DATETIME,
	@approvalDateTo AS DATETIME,
	@receiveDateFrom AS DATETIME,
	@receiveDateTo AS DATETIME,
	@rejectionDateFrom AS DATETIME,
	@rejectionDateTo AS DATETIME
)
 AS
BEGIN

SELECT 
	[RequestSearch].[Id],
	[RequestSearch].[requestNumber],
	[RequestSearch].[totalQuantity],
	[RequestSearch].[PDDFrom],
	[RequestSearch].[PDDTo],
	[RequestSearch].[customerID],
	[RequestSearch].[creationDateFrom],
	[RequestSearch].[creationDateTo],
	[RequestSearch].[creationUserID],
	[RequestSearch].[approvalDateFrom],
	[RequestSearch].[approvalDateTo],
	[RequestSearch].[approvalUserID],
	[RequestSearch].[receiveDateFrom],
	[RequestSearch].[receiveDateTo],
	[RequestSearch].[receiveUserID],
	[RequestSearch].[rejectionDateFrom],
	[RequestSearch].[rejectionDateTo],
	[RequestSearch].[rejectionUserID],
	[RequestSearch].[rejectionReasonID],
	[RequestSearch].[requestTypeID],
	[RequestSearch].[requestStatusID],
	[RequestSearch].[requestCalssID],
	[RequestSearch].[requestPriorityID],
	[RequestSearch].[cardTypeID]
FROM  [Transactions].[RequestSearch]
WHERE	(@Id IS NULL OR [RequestSearch].[Id] = @Id)
	AND (@requestNumber IS NULL OR [RequestSearch].[requestNumber] = @requestNumber)
	AND (@creationDateFrom IS NULL OR [RequestSearch].[creationDateFrom] = @creationDateFrom)
	AND (@creationDateTo IS NULL OR [RequestSearch].[creationDateTo] = @creationDateTo)
	AND (@approvalDateFrom IS NULL OR [RequestSearch].[approvalDateFrom] = @approvalDateFrom)
	AND (@approvalDateTo IS NULL OR [RequestSearch].[approvalDateTo] = @approvalDateTo)
	AND (@receiveDateFrom IS NULL OR [RequestSearch].[receiveDateFrom] = @receiveDateFrom)
	AND (@receiveDateTo IS NULL OR [RequestSearch].[receiveDateTo] = @receiveDateTo)
	AND (@rejectionDateFrom IS NULL OR [RequestSearch].[rejectionDateFrom] = @rejectionDateFrom)
	AND (@rejectionDateTo IS NULL OR [RequestSearch].[rejectionDateTo] = @rejectionDateTo)

END
