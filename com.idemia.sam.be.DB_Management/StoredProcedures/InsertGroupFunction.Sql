--------------------------------------------------------------------------------------------------------------------
-- Created By   : 
-- Created Date : 2019/11/13 11:29:02 ص
--------------------Change History----------------------------------------------------------------------------------
-- Change No     Date		Time	Author					Descrition
--------------------Change History----------------------------------------------------------------------------------
-- Name       : [Lookups].[InsertGroupFunction]
-- Description: Insert Row Into [Lookups].[GroupFunction]
--------------------------------------------------------------------------------------------------------------------

CREATE PROCEDURE [Lookups].[InsertGroupFunction]
(
	@Id AS INT OUTPUT,
	@functionId AS INT,
	@groupId AS INT,
	@status AS BIT
)
AS
BEGIN

INSERT INTO [Lookups].[GroupFunction]
(
	[functionId],
	[groupId],
	[status]
)
VALUES
(
	@functionId,
	@groupId,
	@status
)
SELECT @Id = SCOPE_IDENTITY()

END

