--------------------------------------------------------------------------------------------------------------------
-- Created By   : 
-- Created Date : 2019/11/19 04:32:47 م
--------------------Change History----------------------------------------------------------------------------------
-- Change No     Date		Time	Author					Descrition
--------------------Change History----------------------------------------------------------------------------------
-- Name       : [Lookups].[UpdateWorkField]
-- Description: Update Row Into [Lookups].[WorkField]
--------------------------------------------------------------------------------------------------------------------

CREATE PROCEDURE [Lookups].[UpdateWorkField]
(
	@Id AS INT,
	@name AS NVARCHAR(60),
	@nameAr AS NVARCHAR(60)
)
AS
BEGIN

UPDATE [Lookups].[WorkField]
SET 
	 [name] = @name,
	 [nameAr] = @nameAr
WHERE	(@Id IS NULL OR [WorkField].[Id] = @Id)

END

