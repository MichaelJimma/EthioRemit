CREATE TABLE [dbo].[Accounts] (
    [AccountId]        UNIQUEIDENTIFIER NOT NULL,
    [ClientId]         UNIQUEIDENTIFIER NOT NULL,
    [AccountName]      NVARCHAR (300)   NULL,
    [CurrentBalance]   DECIMAL (9, 2)   DEFAULT ((0.00)) NULL,
    [CreatedBy]        UNIQUEIDENTIFIER NOT NULL,
    [DatetimeCreated]  DATETIME         NOT NULL,
    [ModifiedBy]       UNIQUEIDENTIFIER NOT NULL,
    [DatetimeModified] DATETIME         NOT NULL,
    [IsDeleted]        BIT              DEFAULT ((0)) NOT NULL,
    PRIMARY KEY CLUSTERED ([AccountId] ASC),
    CONSTRAINT [FK_Accounts_Clients] FOREIGN KEY ([ClientId]) REFERENCES [dbo].[Clients] ([ClientId])
);

