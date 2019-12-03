--------------------------------------------------------------------------------------------------------------------
-- Created By   : 
-- Created Date : 2019/11/19 04:32:47 م
--------------------Change History----------------------------------------------------------------------------------
-- Change No     Date		Time	Author					Descrition
--------------------Change History----------------------------------------------------------------------------------
-- Name       : [Transactions].[DeleteCustomer]
-- Description: Delete Row From [Transactions].[Customer]
--------------------------------------------------------------------------------------------------------------------

CREATE PROCEDURE [Transactions].[DeleteCustomer]
(
	@Id AS INT
)
AS
BEGIN

DELETE [Transactions].[Customer]
WHERE	(@Id IS NULL OR [Customer].[Id] = @Id)

END

