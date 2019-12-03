--------------------------------------------------------------------------------------------------------------------
-- Created By   : 
-- Created Date : 2019/11/13 11:29:02 ص
--------------------Change History----------------------------------------------------------------------------------
-- Change No     Date		Time	Author					Descrition
--------------------Change History----------------------------------------------------------------------------------
-- Name       : [Lookups].[UpdateGroup]
-- Description: Update Row Into [Lookups].[Group]
--------------------------------------------------------------------------------------------------------------------

CREATE PROCEDURE [Lookups].[UpdateGroup]
(
	@Id AS INT,
	@name AS NVARCHAR(100),
	@status AS BIT
)
AS
BEGIN

UPDATE [Lookups].[Group]
SET 
	 [name] = @name,
	 [status] = @status
WHERE	(@Id IS NULL OR [Group].[Id] = @Id)

END
