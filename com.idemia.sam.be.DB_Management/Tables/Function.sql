CREATE TABLE [Lookups].[Function]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [name] NVARCHAR(30) NULL, 
    [nameAr] NVARCHAR(30) NULL, 
    [route] NVARCHAR(MAX) NULL, 
    [status] BIT NULL
)
