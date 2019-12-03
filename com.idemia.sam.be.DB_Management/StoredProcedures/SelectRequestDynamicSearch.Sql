
--------------------------------------------------------------------------------------------------------------------
-- Created By   : 
-- Created Date : 2019/11/19 04:32:47 م
--------------------Change History----------------------------------------------------------------------------------
-- Change No     Date		Time	Author					Descrition
--------------------Change History----------------------------------------------------------------------------------
-- Name       : [Transactions].[SelectRequest]
-- Description: Select Row From [Transactions].[SelectRequestDynamicSearch]
--------------------------------------------------------------------------------------------------------------------

CREATE PROCEDURE [Transactions].[SelectRequestDynamicSearch]
(
	@Id AS INT,
	@requestNumber AS NVARCHAR(20),
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
	@cardTypeID AS INT -- To be used later in our search criteria
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
	AND (@PDDFrom IS NULL OR CONVERT(DATE, [Request].[PDD]) >= @PDDFrom)
	AND (@PDDTo IS NULL OR CONVERT(DATE, [Request].[PDD]) <= @PDDTo) 
	AND (@customerID IS NULL OR [Request].[customerID] = @customerID)
	--AND (@creationDateFrom IS NULL OR [Request].[creationDate] = @creationDateFrom)
	AND (@creationDateFrom IS NULL OR CONVERT(DATE, [Request].[creationDate]) <= @creationDateFrom)
	--AND (@creationDate IS NULL OR [Request].[creationDate] = @creationDate)
	AND (@creationDateTo IS NULL OR CONVERT(DATE, [Request].[creationDate]) <= @creationDateTo) 
	AND (@creationUserID IS NULL OR [Request].[creationUserID] = @creationUserID)
	--AND (@approvalDate IS NULL OR [Request].[approvalDate] = @approvalDate)
	AND (@approvalDateFrom IS NULL OR CONVERT(DATE, [Request].[approvalDate]) >= @approvalDateFrom)
	AND (@approvalDateTo IS NULL OR CONVERT(DATE, [Request].[approvalDate]) <= @approvalDateTo) 
	AND (@approvalUserID IS NULL OR [Request].[approvalUserID] = @approvalUserID)
	--AND (@receiveDate IS NULL OR [Request].[receiveDate] = @receiveDate)
	AND (@receiveDateFrom IS NULL OR CONVERT(DATE, [Request].[receiveDate]) >= @PDDFrom)
	AND (@receiveDateTo IS NULL OR CONVERT(DATE, [Request].[receiveDate]) <= @receiveDateTo) 
	AND (@receiveUserID IS NULL OR [Request].[receiveUserID] = @receiveUserID)
	--AND (@rejectionDate IS NULL OR [Request].[rejectionDate] = @rejectionDate)
	AND (@rejectionDateFrom IS NULL OR CONVERT(DATE, [Request].[rejectionDate]) >= @rejectionDateFrom)
	AND (@rejectionDateTo IS NULL OR CONVERT(DATE, [Request].[rejectionDate]) <= @rejectionDateTo) 
	AND (@rejectionUserID IS NULL OR [Request].[rejectionUserID] = @rejectionUserID)
	AND (@rejectionReasonID IS NULL OR [Request].[rejectionReasonID] = @rejectionReasonID)
	AND (@requestTypeID IS NULL OR [Request].[requestTypeID] = @requestTypeID)
	AND (@requestStatusID IS NULL OR [Request].[requestStatusID] = @requestStatusID)
	AND (@requestCalssID IS NULL OR [Request].[requestCalssID] = @requestCalssID)
	AND (@requestPriorityID IS NULL OR [Request].[requestPriorityID] = @requestPriorityID)

END
