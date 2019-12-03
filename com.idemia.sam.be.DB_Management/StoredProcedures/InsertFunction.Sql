--------------------------------------------------------------------------------------------------------------------
-- Created By   : 
-- Created Date : 2019/11/13 11:29:02 ص
--------------------Change History----------------------------------------------------------------------------------
-- Change No     Date		Time	Author					Descrition
--------------------Change History----------------------------------------------------------------------------------
-- Name       : [Lookups].[InsertFunction]
-- Description: Insert Row Into [Lookups].[Function]
--------------------------------------------------------------------------------------------------------------------

CREATE PROCEDURE [Lookups].[InsertFunction]
(
	@Id AS INT OUTPUT,
	@name AS NVARCHAR(60),
	@nameAr AS NVARCHAR(60),
	@route AS NVARCHAR(MAX),
	@status AS BIT
)
AS
BEGIN

INSERT INTO [Lookups].[Function]
(
	[name],
	[nameAr],
	[route],
	[status]
)
VALUES
(
	@name,
	@nameAr,
	@route,
	@status
)
SELECT @Id = SCOPE_IDENTITY()

END
