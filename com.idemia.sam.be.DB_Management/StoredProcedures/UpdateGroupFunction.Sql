--------------------------------------------------------------------------------------------------------------------
-- Created By   : 
-- Created Date : 2019/11/13 11:29:02 ص
--------------------Change History----------------------------------------------------------------------------------
-- Change No     Date		Time	Author					Descrition
--------------------Change History----------------------------------------------------------------------------------
-- Name       : [Lookups].[UpdateGroupFunction]
-- Description: Update Row Into [Lookups].[GroupFunction]
--------------------------------------------------------------------------------------------------------------------

CREATE PROCEDURE [Lookups].[UpdateGroupFunction]
(
	@Id AS INT,
	@functionId AS INT,
	@groupId AS INT,
	@status AS BIT
)
AS
BEGIN

UPDATE [Lookups].[GroupFunction]
SET 
	 [functionId] = @functionId,
	 [groupId] = @groupId,
	 [status] = @status
WHERE	(@Id IS NULL OR [GroupFunction].[Id] = @Id)

END

