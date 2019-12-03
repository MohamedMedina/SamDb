--------------------------------------------------------------------------------------------------------------------
-- Created By   : 
-- Created Date : 2019/11/19 04:32:47 م
--------------------Change History----------------------------------------------------------------------------------
-- Change No     Date		Time	Author					Descrition
--------------------Change History----------------------------------------------------------------------------------
-- Name       : [Transactions].[UpdateCustomer]
-- Description: Update Row Into [Transactions].[Customer]
--------------------------------------------------------------------------------------------------------------------

CREATE PROCEDURE [Transactions].[UpdateCustomer]
(
	@Id AS INT,
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

UPDATE [Transactions].[Customer]
SET 
	 [code] = @code,
	 [name] = @name,
	 [nameAr] = @nameAr,
	 [address] = @address,
	 [phone] = @phone,
	 [email] = @email,
	 [workFieldId] = @workFieldId
WHERE	(@Id IS NULL OR [Customer].[Id] = @Id)

END
