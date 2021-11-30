CREATE TABLE [dbo].[Book]
(
	[BookId] INT IDENTITY (1,1) NOT NULL,
	[Title]	NVARCHAR(70)	NOT NULL,
	[PublisherID]	INT NOT NULL,
	[AuthorID]	INT	NOT NULL,
	[DatePublished]	DATETIME NOT NULL,
	PRIMARY KEY CLUSTERED ([BookID] ASC), 
    CONSTRAINT [FKPublisherID] FOREIGN KEY ([PublisherID]) REFERENCES Publisher([PublisherID]),
	CONSTRAINT [FKAuthorID] FOREIGN KEY ([AuthorID]) REFERENCES Author([AuthorID]),


	)
