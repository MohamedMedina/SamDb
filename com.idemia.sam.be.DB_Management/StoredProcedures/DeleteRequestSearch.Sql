

CREATE PROCEDURE [Transactions].[DeleteRequestSearch]
(
	@Id AS INT
)
 AS
BEGIN

DELETE [Transactions].[RequestSearch]
WHERE	(@Id IS NULL OR [RequestSearch].[Id] = @Id)

END
