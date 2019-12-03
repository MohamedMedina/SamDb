--------------------------------------------------------------------------------------------------------------------
-- Created By   : 
-- Created Date : 2019/11/19 04:32:46 م
--------------------Change History----------------------------------------------------------------------------------
-- Change No     Date		Time	Author					Descrition
--------------------Change History----------------------------------------------------------------------------------
-- Name       : [Lookups].[UpdateRequestStatus]
-- Description: Update Row Into [Lookups].[RequestStatus]
--------------------------------------------------------------------------------------------------------------------

CREATE PROCEDURE [Lookups].[UpdateRequestStatus]
(
	@Id AS INT,
	@name AS NVARCHAR(60),
	@nameAr AS NVARCHAR(60)
)
AS
BEGIN

UPDATE [Lookups].[RequestStatus]
SET 
	 [name] = @name,
	 [nameAr] = @nameAr
WHERE	(@Id IS NULL OR [RequestStatus].[Id] = @Id)

END
