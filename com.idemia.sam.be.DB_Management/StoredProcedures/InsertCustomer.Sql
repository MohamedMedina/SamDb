
--------------------------------------------------------------------------------------------------------------------
-- Created By   : 
-- Created Date : 2019/11/19 04:32:47 م
--------------------Change History----------------------------------------------------------------------------------
-- Change No     Date		Time	Author					Descrition
--------------------Change History----------------------------------------------------------------------------------
-- Name       : [Transactions].[InsertCustomer]
-- Description: Insert Row Into [Transactions].[Customer]
--------------------------------------------------------------------------------------------------------------------

CREATE PROCEDURE [Transactions].[InsertCustomer]
(
	@Id AS INT OUTPUT,
	@code AS NVARCHAR(60),
	@name AS NVARCHAR(200),
	@nameAr AS NVARCHAR(200),
	@address AS NVARCHAR(200),
	@phone AS NVARCHAR(40),
	@email AS NVARCHAR(200),
	@workFieldId AS INT
)
 AS
BEGIN

INSERT INTO [Transactions].[Customer]
(
	[code],
	[name],
	[nameAr],
	[address],
	[phone],
	[email],
	[workFieldId]
)
VALUES
(
	@code,
	@name,
	@nameAr,
	@address,
	@phone,
	@email,
	@workFieldId
)
SELECT @Id = SCOPE_IDENTITY()

END
