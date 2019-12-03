
--------------------------------------------------------------------------------------------------------------------
-- Created By   : 
-- Created Date : 2019/11/19 04:32:44 م
--------------------Change History----------------------------------------------------------------------------------
-- Change No     Date		Time	Author					Descrition
--------------------Change History----------------------------------------------------------------------------------
-- Name       : [Lookups].[SelectCardType]
-- Description: Select Row From [Lookups].[CardType]
--------------------------------------------------------------------------------------------------------------------

CREATE PROCEDURE [Lookups].[SelectCardType]
(
	@Id AS INT,
	@name AS NVARCHAR(60),
	@nameAr AS NVARCHAR(60)
)
 AS
BEGIN

SELECT 
	[CardType].[Id],
	[CardType].[name],
	[CardType].[nameAr]
FROM  [Lookups].[CardType]
WHERE	(@Id IS NULL OR [CardType].[Id] = @Id)
	AND (@name IS NULL OR [CardType].[name] = @name)
	AND (@nameAr IS NULL OR [CardType].[nameAr] = @nameAr)

END
