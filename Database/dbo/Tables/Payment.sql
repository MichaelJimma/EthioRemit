CREATE TABLE [dbo].[Payment] (
    [PaymentId]        UNIQUEIDENTIFIER NOT NULL,
    [AccountId]        UNIQUEIDENTIFIER NOT NULL,
    [ClientId]         UNIQUEIDENTIFIER NOT NULL,
    [PaymentMethodId]  UNIQUEIDENTIFIER NOT NULL,
    [PaymentStatusId]  UNIQUEIDENTIFIER NOT NULL,
    [PaymentAmount]    DECIMAL (9, 2)   NOT NULL,
    [CreatedBy]        UNIQUEIDENTIFIER NOT NULL,
    [DatetimeCreated]  DATETIME         NOT NULL,
    [ModifiedBy]       UNIQUEIDENTIFIER NOT NULL,
    [DatetimeModified] DATETIME         NOT NULL,
    [IsDeleted]        BIT              DEFAULT ((0)) NOT NULL,
    PRIMARY KEY CLUSTERED ([PaymentId] ASC),
    CONSTRAINT [FK_Payments_Accounts] FOREIGN KEY ([AccountId]) REFERENCES [dbo].[Accounts] ([AccountId]),
    CONSTRAINT [FK_Payments_Clients] FOREIGN KEY ([ClientId]) REFERENCES [dbo].[Clients] ([ClientId]),
    CONSTRAINT [FK_Payments_PaymentMethods] FOREIGN KEY ([PaymentMethodId]) REFERENCES [dbo].[PaymentMethods] ([PaymentMethodId]),
    CONSTRAINT [FK_Payments_PaymentStatus] FOREIGN KEY ([PaymentStatusId]) REFERENCES [dbo].[PaymentStatus] ([PaymentStatusId])
);

