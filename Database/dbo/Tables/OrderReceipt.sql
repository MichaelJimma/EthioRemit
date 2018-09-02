CREATE TABLE [dbo].[OrderReceipt] (
    [OrderReceiptId]   UNIQUEIDENTIFIER NOT NULL,
    [OrderId]          UNIQUEIDENTIFIER NOT NULL,
    [Name]             NVARCHAR (250)   NULL,
    [FileName]         NVARCHAR (250)   NULL,
    [FileExtension]    NVARCHAR (20)    NULL,
    [Size]             INT              NULL,
    [CreatedBy]        UNIQUEIDENTIFIER NOT NULL,
    [DatetimeCreated]  DATETIME         NOT NULL,
    [ModifiedBy]       UNIQUEIDENTIFIER NOT NULL,
    [DatetimeModified] DATETIME         NOT NULL,
    [IsDeleted]        BIT              DEFAULT ((0)) NOT NULL,
    PRIMARY KEY CLUSTERED ([OrderReceiptId] ASC),
    CONSTRAINT [FK_OrderReceipt_Orders] FOREIGN KEY ([OrderId]) REFERENCES [dbo].[Orders] ([OrderId])
);

