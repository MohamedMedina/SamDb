--------------------------------------------------------------------------------------------------------------------
-- Created By   : 
-- Created Date : 2019/11/19 04:32:47 م
--------------------Change History----------------------------------------------------------------------------------
-- Change No     Date		Time	Author					Descrition
--------------------Change History----------------------------------------------------------------------------------
-- Name       : [Transactions].[DeleteRequest]
-- Description: Delete Row From [Transactions].[Request]
--------------------------------------------------------------------------------------------------------------------

CREATE PROCEDURE [Transactions].[DeleteRequest]
(
	@Id AS INT
)
AS
BEGIN

DELETE [Transactions].[Request]
WHERE	(@Id IS NULL OR [Request].[Id] = @Id)

END
