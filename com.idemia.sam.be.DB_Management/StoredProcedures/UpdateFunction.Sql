--------------------------------------------------------------------------------------------------------------------
-- Created By   : 
-- Created Date : 2019/11/13 11:29:02 ص
--------------------Change History----------------------------------------------------------------------------------
-- Change No     Date		Time	Author					Descrition
--------------------Change History----------------------------------------------------------------------------------
-- Name       : [Lookups].[UpdateFunction]
-- Description: Update Row Into [Lookups].[Function]
--------------------------------------------------------------------------------------------------------------------

CREATE PROCEDURE [Lookups].[UpdateFunction]
(
	@Id AS INT,
	@name AS NVARCHAR(60),
	@nameAr AS NVARCHAR(60),
	@route AS NVARCHAR(MAX),
	@status AS BIT
)
AS
BEGIN

UPDATE [Lookups].[Function]
SET 
	 [name] = @name,
	 [nameAr] = @nameAr,
	 [route] = @route,
	 [status] = @status
WHERE	(@Id IS NULL OR [Function].[Id] = @Id)

END
