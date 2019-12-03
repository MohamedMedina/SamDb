--------------------------------------------------------------------------------------------------------------------
-- Created By   : 
-- Created Date : 2019/11/19 04:32:46 م
--------------------Change History----------------------------------------------------------------------------------
-- Change No     Date		Time	Author					Descrition
--------------------Change History----------------------------------------------------------------------------------
-- Name       : [Lookups].[SelectRequestType]
-- Description: Select Row From [Lookups].[RequestType]
--------------------------------------------------------------------------------------------------------------------

CREATE PROCEDURE [Lookups].[SelectRequestType]
(
	@Id AS INT,
	@name AS NVARCHAR(60),
	@nameAr AS NVARCHAR(60)
)
AS
BEGIN

SELECT 
	[RequestType].[Id],
	[RequestType].[name],
	[RequestType].[nameAr]
FROM  [Lookups].[RequestType]
WHERE	(@Id IS NULL OR [RequestType].[Id] = @Id)
	AND (@name IS NULL OR [RequestType].[name] = @name)
	AND (@nameAr IS NULL OR [RequestType].[nameAr] = @nameAr)

END

