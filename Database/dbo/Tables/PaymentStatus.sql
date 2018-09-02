CREATE TABLE [dbo].[PaymentStatus] (
    [PaymentStatusId]   UNIQUEIDENTIFIER NOT NULL,
    [PaymentStatusName] NVARCHAR (500)   NOT NULL,
    [CreatedBy]         UNIQUEIDENTIFIER NOT NULL,
    [DatetimeCreated]   DATETIME         NOT NULL,
    [ModifiedBy]        UNIQUEIDENTIFIER NOT NULL,
    [DatetimeModified]  DATETIME         NOT NULL,
    [IsDeleted]         BIT              DEFAULT ((0)) NOT NULL,
    PRIMARY KEY CLUSTERED ([PaymentStatusId] ASC)
);

