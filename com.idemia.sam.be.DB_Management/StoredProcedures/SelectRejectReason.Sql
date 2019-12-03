
--------------------------------------------------------------------------------------------------------------------
-- Created By   : 
-- Created Date : 2019/11/19 04:32:45 م
--------------------Change History----------------------------------------------------------------------------------
-- Change No     Date		Time	Author					Descrition
--------------------Change History----------------------------------------------------------------------------------
-- Name       : [Lookups].[SelectRejectReason]
-- Description: Select Row From [Lookups].[RejectReason]
--------------------------------------------------------------------------------------------------------------------

CREATE PROCEDURE [Lookups].[SelectRejectReason]
(
	@Id AS INT,
	@name AS NVARCHAR(60),
	@nameAr AS NVARCHAR(60)
)
 AS
BEGIN

SELECT 
	[RejectReason].[Id],
	[RejectReason].[name],
	[RejectReason].[nameAr]
FROM  [Lookups].[RejectReason]
WHERE	(@Id IS NULL OR [RejectReason].[Id] = @Id)
	AND (@name IS NULL OR [RejectReason].[name] = @name)
	AND (@nameAr IS NULL OR [RejectReason].[nameAr] = @nameAr)

END
