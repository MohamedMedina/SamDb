--------------------------------------------------------------------------------------------------------------------
-- Created By   : 
-- Created Date : 2019/11/13 11:29:02 ص
--------------------Change History----------------------------------------------------------------------------------
-- Change No     Date		Time	Author					Descrition
--------------------Change History----------------------------------------------------------------------------------
-- Name       : [Lookups].[UpdateUser]
-- Description: Update Row Into [Lookups].[User]
--------------------------------------------------------------------------------------------------------------------

CREATE PROCEDURE [Lookups].[UpdateUser]
(
	@Id AS INT,
	@userName AS NVARCHAR(60),
	@fullName AS NVARCHAR(100),
	@Password AS NVARCHAR(60),
	@status AS BIT,
	@createDate AS DATETIME
)
AS
BEGIN

UPDATE [Lookups].[User]
SET 
	 [userName] = @userName,
	 [fullName] = @fullName,
	 [Password] = @Password,
	 [status] = @status,
	 [createDate] = @createDate
WHERE	(@Id IS NULL OR [User].[Id] = @Id)

END
