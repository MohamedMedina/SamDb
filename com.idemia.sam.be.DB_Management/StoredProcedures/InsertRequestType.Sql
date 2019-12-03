
--------------------------------------------------------------------------------------------------------------------
-- Created By   : 
-- Created Date : 2019/11/19 04:32:46 م
--------------------Change History----------------------------------------------------------------------------------
-- Change No     Date		Time	Author					Descrition
--------------------Change History----------------------------------------------------------------------------------
-- Name       : [Lookups].[InsertRequestType]
-- Description: Insert Row Into [Lookups].[RequestType]
--------------------------------------------------------------------------------------------------------------------

CREATE PROCEDURE [Lookups].[InsertRequestType]
(
	@Id AS INT OUTPUT,
	@name AS NVARCHAR(60),
	@nameAr AS NVARCHAR(60)
)
 AS
BEGIN

INSERT INTO [Lookups].[RequestType]
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

