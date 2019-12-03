--------------------------------------------------------------------------------------------------------------------
-- Created By   : 
-- Created Date : 2019/11/19 04:32:45 م
--------------------Change History----------------------------------------------------------------------------------
-- Change No     Date		Time	Author					Descrition
--------------------Change History----------------------------------------------------------------------------------
-- Name       : [Lookups].[UpdateRequestPriority]
-- Description: Update Row Into [Lookups].[RequestPriority]
--------------------------------------------------------------------------------------------------------------------

CREATE PROCEDURE [Lookups].[UpdateRequestPriority]
(
	@Id AS INT,
	@name AS NVARCHAR(60),
	@nameAr AS NVARCHAR(60)
)
AS
BEGIN

UPDATE [Lookups].[RequestPriority]
SET 
	 [name] = @name,
	 [nameAr] = @nameAr
WHERE	(@Id IS NULL OR [RequestPriority].[Id] = @Id)

END
