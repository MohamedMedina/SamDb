
--------------------------------------------------------------------------------------------------------------------
-- Created By   : 
-- Created Date : 2019/11/19 04:32:45 م
--------------------Change History----------------------------------------------------------------------------------
-- Change No     Date		Time	Author					Descrition
--------------------Change History----------------------------------------------------------------------------------
-- Name       : [Lookups].[SelectRequestPriority]
-- Description: Select Row From [Lookups].[RequestPriority]
--------------------------------------------------------------------------------------------------------------------

CREATE PROCEDURE [Lookups].[SelectRequestPriority]
(
	@Id AS INT,
	@name AS NVARCHAR(60),
	@nameAr AS NVARCHAR(60)
)
 AS
BEGIN

SELECT 
	[RequestPriority].[Id],
	[RequestPriority].[name],
	[RequestPriority].[nameAr]
FROM  [Lookups].[RequestPriority]
WHERE	(@Id IS NULL OR [RequestPriority].[Id] = @Id)
	AND (@name IS NULL OR [RequestPriority].[name] = @name)
	AND (@nameAr IS NULL OR [RequestPriority].[nameAr] = @nameAr)

END

