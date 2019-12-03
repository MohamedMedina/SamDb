
--------------------------------------------------------------------------------------------------------------------
-- Created By   : 
-- Created Date : 2019/11/19 04:32:45 م
--------------------Change History----------------------------------------------------------------------------------
-- Change No     Date		Time	Author					Descrition
--------------------Change History----------------------------------------------------------------------------------
-- Name       : [Lookups].[SelectRequestClass]
-- Description: Select Row From [Lookups].[RequestClass]
--------------------------------------------------------------------------------------------------------------------

CREATE PROCEDURE [Lookups].[SelectRequestClass]
(
	@Id AS INT,
	@name AS NVARCHAR(60),
	@nameAr AS NVARCHAR(60)
)
AS
BEGIN

SELECT 
	[RequestClass].[Id],
	[RequestClass].[name],
	[RequestClass].[nameAr]
FROM  [Lookups].[RequestClass]
WHERE	(@Id IS NULL OR [RequestClass].[Id] = @Id)
	AND (@name IS NULL OR [RequestClass].[name] = @name)
	AND (@nameAr IS NULL OR [RequestClass].[nameAr] = @nameAr)

END
