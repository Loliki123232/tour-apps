CREATE TABLE [dbo].[AirPlaneFlights] (
    [AirPlaneFlightId] INT             IDENTITY (1, 1) NOT NULL,
    [FromCity]         NVARCHAR (100)  NOT NULL,
    [ToCity]           NVARCHAR (100)  NOT NULL,
    [Price]            INT NOT NULL,
    [DepartureTime]    DATETIME2        NOT NULL,
    PRIMARY KEY CLUSTERED ([AirPlaneFlightId] ASC)
);

