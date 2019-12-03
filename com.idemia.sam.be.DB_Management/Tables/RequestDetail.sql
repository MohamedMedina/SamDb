CREATE TABLE [Transactions].[RequestDetail]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
	[quantity] INT NULL,
    [cardTypeID] INT NULL,  
    [requestID] INT NULL,

	CONSTRAINT [FK_CardTypeID_RequestDetail] FOREIGN KEY ([cardTypeID]) REFERENCES [Lookups].[CardType]([Id]),
	CONSTRAINT [FK_RequestID_RequestDetail] FOREIGN KEY ([requestID]) REFERENCES [Transactions].[Request]([Id]),
)
