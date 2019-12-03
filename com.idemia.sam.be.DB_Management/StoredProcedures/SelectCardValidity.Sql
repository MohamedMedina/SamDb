
--------------------------------------------------------------------------------------------------------------------
-- Created By   : 
-- Created Date : 2019/11/19 04:32:44 م
--------------------Change History----------------------------------------------------------------------------------
-- Change No     Date		Time	Author					Descrition
--------------------Change History----------------------------------------------------------------------------------
-- Name       : [Lookups].[SelectCardValidity]
-- Description: Select Row From [Lookups].[CardValidity]
--------------------------------------------------------------------------------------------------------------------

CREATE PROCEDURE [Lookups].[SelectCardValidity]
(
	@Id AS INT,
	@name AS NVARCHAR(60),
	@nameAr AS NVARCHAR(60)
)
AS
BEGIN

SELECT 
	[CardValidity].[Id],
	[CardValidity].[name],
	[CardValidity].[nameAr]
FROM  [Lookups].[CardValidity]
WHERE	(@Id IS NULL OR [CardValidity].[Id] = @Id)
	AND (@name IS NULL OR [CardValidity].[name] = @name)
	AND (@nameAr IS NULL OR [CardValidity].[nameAr] = @nameAr)

END
