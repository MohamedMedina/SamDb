--------------------------------------------------------------------------------------------------------------------
-- Created By   : 
-- Created Date : 2019/11/19 04:32:47 م
--------------------Change History----------------------------------------------------------------------------------
-- Change No     Date		Time	Author					Descrition
--------------------Change History----------------------------------------------------------------------------------
-- Name       : [Lookups].[DeleteWorkField]
-- Description: Delete Row From [Lookups].[WorkField]
--------------------------------------------------------------------------------------------------------------------

CREATE PROCEDURE [Lookups].[DeleteWorkField]
(
	@Id AS INT
)
AS
BEGIN

DELETE [Lookups].[WorkField]
WHERE	(@Id IS NULL OR [WorkField].[Id] = @Id)

END
