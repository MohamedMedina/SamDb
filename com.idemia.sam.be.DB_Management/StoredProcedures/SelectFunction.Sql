--------------------------------------------------------------------------------------------------------------------
-- Created By   : 
-- Created Date : 2019/11/13 11:29:02 ص
--------------------Change History----------------------------------------------------------------------------------
-- Change No     Date		Time	Author					Descrition
--------------------Change History----------------------------------------------------------------------------------
-- Name       : [Lookups].[SelectFunction]
-- Description: Select Row From [Lookups].[Function]
--------------------------------------------------------------------------------------------------------------------

CREATE PROCEDURE [Lookups].[SelectFunction]
(
	@Id AS INT,
	@name AS NVARCHAR(60),
	@nameAr AS NVARCHAR(60)
)
AS
BEGIN

SELECT 
	[Function].[Id],
	[Function].[name],
	[Function].[nameAr],
	[Function].[route],
	[Function].[status]
FROM  [Lookups].[Function]
WHERE	(@Id IS NULL OR [Function].[Id] = @Id)
	AND (@name IS NULL OR [Function].[name] = @name)
	AND (@nameAr IS NULL OR [Function].[nameAr] = @nameAr)

END

