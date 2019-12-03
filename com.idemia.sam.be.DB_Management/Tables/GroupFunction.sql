CREATE TABLE [Lookups].[GroupFunction]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [functionId] INT NULL, 
    [groupId] INT NULL, 
    [status] BIT NULL, 
    CONSTRAINT [FK_FunctionID_GroupFunction] FOREIGN KEY ([functionId]) REFERENCES [Lookups].[Function]([Id]),
	CONSTRAINT [FK_GroupID_GroupFunction] FOREIGN KEY ([groupId]) REFERENCES [Lookups].[Group]([Id])
)

