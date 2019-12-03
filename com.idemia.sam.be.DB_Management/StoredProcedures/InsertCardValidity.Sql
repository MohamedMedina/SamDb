--------------------------------------------------------------------------------------------------------------------
-- Created By   : 
-- Created Date : 2019/11/19 04:32:44 م
--------------------Change History----------------------------------------------------------------------------------
-- Change No     Date		Time	Author					Descrition
--------------------Change History----------------------------------------------------------------------------------
-- Name       : [Lookups].[InsertCardValidity]
-- Description: Insert Row Into [Lookups].[CardValidity]
--------------------------------------------------------------------------------------------------------------------

CREATE PROCEDURE [Lookups].[InsertCardValidity]
(
	@Id AS INT OUTPUT,
	@name AS NVARCHAR(60),
	@nameAr AS NVARCHAR(60)
)
AS
BEGIN

INSERT INTO [Lookups].[CardValidity]
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
