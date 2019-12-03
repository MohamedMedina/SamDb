--------------------------------------------------------------------------------------------------------------------
-- Created By   : 
-- Created Date : 2019/11/13 11:29:02 ص
--------------------Change History----------------------------------------------------------------------------------
-- Change No     Date		Time	Author					Descrition
--------------------Change History----------------------------------------------------------------------------------
-- Name       : [Lookups].[SelectGroup]
-- Description: Select Row From [Lookups].[Group]
--------------------------------------------------------------------------------------------------------------------

CREATE PROCEDURE [Lookups].[SelectGroup]
(
	@Id AS INT,
	@name AS NVARCHAR(100)
)
AS
BEGIN

SELECT 
	[Group].[Id],
	[Group].[name],
	[Group].[status]
FROM  [Lookups].[Group]
WHERE	(@Id IS NULL OR [Group].[Id] = @Id)
	AND (@name IS NULL OR [Group].[name] = @name)

END
