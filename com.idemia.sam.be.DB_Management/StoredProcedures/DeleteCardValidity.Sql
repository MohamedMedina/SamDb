--------------------------------------------------------------------------------------------------------------------
-- Created By   : 
-- Created Date : 2019/11/19 04:32:44 م
--------------------Change History----------------------------------------------------------------------------------
-- Change No     Date		Time	Author					Descrition
--------------------Change History----------------------------------------------------------------------------------
-- Name       : [Lookups].[DeleteCardValidity]
-- Description: Delete Row From [Lookups].[CardValidity]
--------------------------------------------------------------------------------------------------------------------

CREATE PROCEDURE [Lookups].[DeleteCardValidity]
(
	@Id AS INT
)
AS
BEGIN

DELETE [Lookups].[CardValidity]
WHERE	(@Id IS NULL OR [CardValidity].[Id] = @Id)

END
