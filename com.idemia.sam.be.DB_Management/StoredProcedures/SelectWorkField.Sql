--------------------------------------------------------------------------------------------------------------------
-- Created By   : 
-- Created Date : 2019/11/19 04:32:47 م
--------------------Change History----------------------------------------------------------------------------------
-- Change No     Date		Time	Author					Descrition
--------------------Change History----------------------------------------------------------------------------------
-- Name       : [Lookups].[SelectWorkField]
-- Description: Select Row From [Lookups].[WorkField]
--------------------------------------------------------------------------------------------------------------------

CREATE PROCEDURE [Lookups].[SelectWorkField]
(
	@Id AS INT,
	@name AS NVARCHAR(60),
	@nameAr AS NVARCHAR(60)
)
AS
BEGIN

SELECT 
	[WorkField].[Id],
	[WorkField].[name],
	[WorkField].[nameAr]
FROM  [Lookups].[WorkField]
WHERE	(@Id IS NULL OR [WorkField].[Id] = @Id)
	AND (@name IS NULL OR [WorkField].[name] = @name)
	AND (@nameAr IS NULL OR [WorkField].[nameAr] = @nameAr)

END
