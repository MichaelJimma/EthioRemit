CREATE TABLE [dbo].[CashOnHand] (
    [CashOnHandId] UNIQUEIDENTIFIER NOT NULL,
    [Date]         DATETIME         NOT NULL,
    [Amount]       DECIMAL (9, 2)   NOT NULL,
    PRIMARY KEY CLUSTERED ([CashOnHandId] ASC)
);

