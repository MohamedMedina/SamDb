CREATE TABLE [Transactions].[Customer]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [code] NVARCHAR(30) NULL, 
	[name] NVARCHAR(100) NULL, 
    [nameAr] NVARCHAR(100) NULL, 
	[address] NVARCHAR(100) NULL, 
    [phone] NVARCHAR(20) NULL,
    [email] NVARCHAR(100) NULL, 
    [workFieldId] INT,
	CONSTRAINT [FK_WorkFieldId_Customer] FOREIGN KEY ([workFieldId]) REFERENCES [Lookups].[WorkField]([Id]),
)


