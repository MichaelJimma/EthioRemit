CREATE TABLE [dbo].[PaymentMethods] (
    [PaymentMethodId]  UNIQUEIDENTIFIER NOT NULL,
    [Name]             NVARCHAR (250)   NOT NULL,
    [CreatedBy]        UNIQUEIDENTIFIER NOT NULL,
    [DatetimeCreated]  DATETIME         NOT NULL,
    [ModifiedBy]       UNIQUEIDENTIFIER NOT NULL,
    [DatetimeModified] DATETIME         NOT NULL,
    [IsDeleted]        BIT              DEFAULT ((0)) NOT NULL,
    PRIMARY KEY CLUSTERED ([PaymentMethodId] ASC)
);

