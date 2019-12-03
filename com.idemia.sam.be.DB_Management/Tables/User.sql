CREATE TABLE [Lookups].[User]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [userName] NVARCHAR(30) NOT NULL, 
    [fullName] NVARCHAR(50) NULL, 
    [Password] NVARCHAR(30) NOT NULL, 
    [status] BIT NULL, 
    [createDate] DATETIME NULL
)
