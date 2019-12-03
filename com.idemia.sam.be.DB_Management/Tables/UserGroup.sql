CREATE TABLE [Lookups].[UserGroup]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [userId] INT NOT NULL, 
    [groupId] INT NOT NULL,
	CONSTRAINT [FK_UserID_UserGroup] FOREIGN KEY ([userId]) REFERENCES [Lookups].[User]([Id]),
	CONSTRAINT [FK_GroupID_UserGroup] FOREIGN KEY ([groupId]) REFERENCES [Lookups].[Group]([Id])
)
