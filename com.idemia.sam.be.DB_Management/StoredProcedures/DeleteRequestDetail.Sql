--------------------------------------------------------------------------------------------------------------------
-- Created By   : 
-- Created Date : 2019/11/19 04:32:48 م
--------------------Change History----------------------------------------------------------------------------------
-- Change No     Date		Time	Author					Descrition
--------------------Change History----------------------------------------------------------------------------------
-- Name       : [Transactions].[DeleteRequestDetail]
-- Description: Delete Row From [Transactions].[RequestDetail]
--------------------------------------------------------------------------------------------------------------------

CREATE PROCEDURE [Transactions].[DeleteRequestDetail]
(
	@Id AS INT
)
AS
BEGIN

DELETE [Transactions].[RequestDetail]
WHERE	(@Id IS NULL OR [RequestDetail].[Id] = @Id)

END

