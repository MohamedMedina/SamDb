--------------------------------------------------------------------------------------------------------------------
-- Created By   : 
-- Created Date : 2019/11/19 04:32:44 م
--------------------Change History----------------------------------------------------------------------------------
-- Change No     Date		Time	Author					Descrition
--------------------Change History----------------------------------------------------------------------------------
-- Name       : [Lookups].[DeleteCardType]
-- Description: Delete Row From [Lookups].[CardType]
--------------------------------------------------------------------------------------------------------------------

CREATE PROCEDURE [Lookups].[DeleteCardType]
(
	@Id AS INT
)
AS
BEGIN

DELETE [Lookups].[CardType]
WHERE	(@Id IS NULL OR [CardType].[Id] = @Id)

END
