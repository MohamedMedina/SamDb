--------------------------------------------------------------------------------------------------------------------
-- Created By   : 
-- Created Date : 2019/11/19 04:32:46 م
--------------------Change History----------------------------------------------------------------------------------
-- Change No     Date		Time	Author					Descrition
--------------------Change History----------------------------------------------------------------------------------
-- Name       : [Lookups].[SelectRequestStatus]
-- Description: Select Row From [Lookups].[RequestStatus]
--------------------------------------------------------------------------------------------------------------------

CREATE PROCEDURE [Lookups].[SelectRequestStatus]
(
	@Id AS INT,
	@name AS NVARCHAR(60),
	@nameAr AS NVARCHAR(60)
)
AS
BEGIN

SELECT 
	[RequestStatus].[Id],
	[RequestStatus].[name],
	[RequestStatus].[nameAr]
FROM  [Lookups].[RequestStatus]
WHERE	(@Id IS NULL OR [RequestStatus].[Id] = @Id)
	AND (@name IS NULL OR [RequestStatus].[name] = @name)
	AND (@nameAr IS NULL OR [RequestStatus].[nameAr] = @nameAr)

END
