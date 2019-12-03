-----------------------------------------------------------------------------------------------------------

CREATE PROCEDURE [Transactions].[InsertRequestSearch]
(
	@Id AS INT OUTPUT,
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

INSERT INTO [Transactions].[RequestSearch]
(
	[requestNumber],
	[totalQuantity],
	[PDDFrom],
	[PDDTo],
	[customerID],
	[creationDateFrom],
	[creationDateTo],
	[creationUserID],
	[approvalDateFrom],
	[approvalDateTo],
	[approvalUserID],
	[receiveDateFrom],
	[receiveDateTo],
	[receiveUserID],
	[rejectionDateFrom],
	[rejectionDateTo],
	[rejectionUserID],
	[rejectionReasonID],
	[requestTypeID],
	[requestStatusID],
	[requestCalssID],
	[requestPriorityID],
	[cardTypeID]
)
VALUES
(
	@requestNumber,
	@totalQuantity,
	@PDDFrom,
	@PDDTo,
	@customerID,
	@creationDateFrom,
	@creationDateTo,
	@creationUserID,
	@approvalDateFrom,
	@approvalDateTo,
	@approvalUserID,
	@receiveDateFrom,
	@receiveDateTo,
	@receiveUserID,
	@rejectionDateFrom,
	@rejectionDateTo,
	@rejectionUserID,
	@rejectionReasonID,
	@requestTypeID,
	@requestStatusID,
	@requestCalssID,
	@requestPriorityID,
	@cardTypeID
)
SELECT @Id = SCOPE_IDENTITY()

END
