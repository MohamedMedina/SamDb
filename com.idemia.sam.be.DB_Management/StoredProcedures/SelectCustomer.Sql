
--------------------------------------------------------------------------------------------------------------------
-- Created By   : 
-- Created Date : 2019/11/19 04:32:47 م
--------------------Change History----------------------------------------------------------------------------------
-- Change No     Date		Time	Author					Descrition
--------------------Change History----------------------------------------------------------------------------------
-- Name       : [Transactions].[SelectCustomer]
-- Description: Select Row From [Transactions].[Customer]
--------------------------------------------------------------------------------------------------------------------

CREATE PROCEDURE [Transactions].[SelectCustomer]
(
	@Id AS INT,
	@code AS NVARCHAR(60),
	@name AS NVARCHAR(200),
	@nameAr AS NVARCHAR(200),
	@workFieldId AS INT
)
AS
BEGIN

SELECT 
	[Customer].[Id],
	[Customer].[code],
	[Customer].[name],
	[Customer].[nameAr],
	[Customer].[address],
	[Customer].[phone],
	[Customer].[email],
	[Customer].[workFieldId]
FROM  [Transactions].[Customer]
WHERE	(@Id IS NULL OR [Customer].[Id] = @Id)
	AND (@code IS NULL OR [Customer].[code] = @code)
	AND (@name IS NULL OR [Customer].[name] = @name)
	AND (@nameAr IS NULL OR [Customer].[nameAr] = @nameAr)
	AND (@workFieldId IS NULL OR [Customer].[workFieldId] = @workFieldId)

END
