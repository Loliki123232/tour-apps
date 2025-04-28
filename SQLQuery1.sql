CREATE TABLE [dbo].[AirPlaneFlights] (
    [AirPlaneFlightId] INT             IDENTITY (1, 1) NOT NULL,
    [FromCity]         NVARCHAR (100)  NOT NULL,
    [ToCity]           NVARCHAR (100)  NOT NULL,
    [Price]            DECIMAL (10, 2) NOT NULL,
    [DepartureTime]    DATETIME        NULL,
    PRIMARY KEY CLUSTERED ([AirPlaneFlightId] ASC)
);