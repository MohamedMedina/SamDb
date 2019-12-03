
--------------------------------------------------------------------------------------------------------------------
-- Created By   : 
-- Created Date : 2019/11/19 04:32:45 م
--------------------Change History----------------------------------------------------------------------------------
-- Change No     Date		Time	Author					Descrition
--------------------Change History----------------------------------------------------------------------------------
-- Name       : [Lookups].[InsertRequestClass]
-- Description: Insert Row Into [Lookups].[RequestClass]
--------------------------------------------------------------------------------------------------------------------

CREATE PROCEDURE [Lookups].[InsertRequestClass]
(
	@Id AS INT OUTPUT,
	@name AS NVARCHAR(60),
	@nameAr AS NVARCHAR(60)
)
 AS
BEGIN

INSERT INTO [Lookups].[RequestClass]
(
	[name],
	[nameAr]
)
VALUES
(
	@name,
	@nameAr
)
SELECT @Id = SCOPE_IDENTITY()

END
