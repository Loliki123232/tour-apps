CREATE TABLE [dbo].[Clients] (
    [IdClient]        INT           IDENTITY (1, 1) NOT NULL,
    [FirstName] NVARCHAR (50) NOT NULL,
    [LastName]  NVARCHAR (50) NOT NULL,
	[MiddleName]  NVARCHAR (50) NULL,
	[Number]    INT           NOT NULL,
	[NumberCard]  int NOT NULL,
	[ValidUntil]  NVARCHAR (10) NOT NULL,
	[CCVCod]  int NOT NULL,
    PRIMARY KEY CLUSTERED ([IdClient] ASC),
);