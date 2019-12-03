--------------------------------------------------------------------------------------------------------------------
-- Created By   : 
-- Created Date : 2019/11/13 11:29:02 ص
--------------------Change History----------------------------------------------------------------------------------
-- Change No     Date		Time	Author					Descrition
--------------------Change History----------------------------------------------------------------------------------
-- Name       : [Lookups].[InsertUser]
-- Description: Insert Row Into [Lookups].[User]
--------------------------------------------------------------------------------------------------------------------

CREATE PROCEDURE [Lookups].[InsertUser]
(
	@Id AS INT OUTPUT,
	@userName AS NVARCHAR(60),
	@fullName AS NVARCHAR(100),
	@Password AS NVARCHAR(60),
	@status AS BIT,
	@createDate AS DATETIME
)
AS
BEGIN

INSERT INTO [Lookups].[User]
(
	[userName],
	[fullName],
	[Password],
	[status],
	[createDate]
)
VALUES
(
	@userName,
	@fullName,
	@Password,
	@status,
	@createDate
)
SELECT @Id = SCOPE_IDENTITY()

END
