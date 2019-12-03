--------------------------------------------------------------------------------------------------------------------
-- Created By   : 
-- Created Date : 2019/11/13 11:29:02 ص
--------------------Change History----------------------------------------------------------------------------------
-- Change No     Date		Time	Author					Descrition
--------------------Change History----------------------------------------------------------------------------------
-- Name       : [Lookups].[SelectGroupFunction]
-- Description: Select Row From [Lookups].[GroupFunction]
--------------------------------------------------------------------------------------------------------------------

CREATE PROCEDURE [Lookups].[SelectGroupFunction]
(
	@Id AS INT,
	@functionId AS INT,
	@groupId AS INT
)
AS
BEGIN

SELECT 
	[GroupFunction].[Id],
	[GroupFunction].[functionId],
	[GroupFunction].[groupId],
	[GroupFunction].[status]
FROM  [Lookups].[GroupFunction]
WHERE	(@Id IS NULL OR [GroupFunction].[Id] = @Id)
	AND (@functionId IS NULL OR [GroupFunction].[functionId] = @functionId)
	AND (@groupId IS NULL OR [GroupFunction].[groupId] = @groupId)

END
