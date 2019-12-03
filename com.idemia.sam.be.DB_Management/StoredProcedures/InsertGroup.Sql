--------------------------------------------------------------------------------------------------------------------
-- Created By   : 
-- Created Date : 2019/11/13 11:29:02 ص
--------------------Change History----------------------------------------------------------------------------------
-- Change No     Date		Time	Author					Descrition
--------------------Change History----------------------------------------------------------------------------------
-- Name       : [Lookups].[InsertGroup]
-- Description: Insert Row Into [Lookups].[Group]
--------------------------------------------------------------------------------------------------------------------

CREATE PROCEDURE [Lookups].[InsertGroup]
(
	@Id AS INT OUTPUT,
	@name AS NVARCHAR(100),
	@status AS BIT
)
AS
BEGIN

INSERT INTO [Lookups].[Group]
(
	[name],
	[status]
)
VALUES
(
	@name,
	@status
)
SELECT @Id = SCOPE_IDENTITY()

END
