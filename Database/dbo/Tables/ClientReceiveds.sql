CREATE TABLE [dbo].[ClientReceiveds] (
    [ClientReceivedId] UNIQUEIDENTIFIER NOT NULL,
    [ClientId]         UNIQUEIDENTIFIER NOT NULL,
    [ReceivedBirr]     DECIMAL (9, 2)   NOT NULL,
    [Rate]             DECIMAL (6, 2)   NOT NULL,
    [ExchangeAmount]   DECIMAL (9, 2)   NOT NULL,
    [CreatedBy]        UNIQUEIDENTIFIER NOT NULL,
    [DatetimeCreated]  DATETIME         NOT NULL,
    [ModifiedBy]       UNIQUEIDENTIFIER NOT NULL,
    [DatetimeModified] DATETIME         NOT NULL,
    [IsDeleted]        BIT              DEFAULT ((0)) NOT NULL,
    PRIMARY KEY CLUSTERED ([ClientReceivedId] ASC),
    CONSTRAINT [FK_ClientReceiveds_Clients] FOREIGN KEY ([ClientId]) REFERENCES [dbo].[Clients] ([ClientId])
);

